using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SQLite;

namespace dbcommfc7
{
    public partial class LaneLightController : Form
    {
        private SQLiteHelper sqliteHelper;
        private string currentDbPath;
        
        // 存储选中的按钮Name数组
        private List<string> selectedButtons = new List<string>();
        
        // 存储按钮的原始颜色
        private Dictionary<string, Color> buttonOriginalColors = new Dictionary<string, Color>();
        
        // 框选相关变量
        private bool isSelecting = false;
        private Point selectionStart;
        private Point selectionEnd;
        private PictureBox selectionBox;
        
        // 右键菜单
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem menuItemStraight;
        private ToolStripMenuItem menuItemProhibit;
        private ToolStripMenuItem menuItemReverse;
        private ToolStripMenuItem menuItemLeft;

        public LaneLightController()
        {
            InitializeComponent();
        }

        private void LaneLightController_Load(object sender, EventArgs e)
        {
           // this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // 禁用最大化按钮
            this.MaximizeBox = false;
            
            // 设置窗体初始大小以适应所有内容
            // ClientSize 2475x1276 是设计时的大小
            this.ClientSize = new System.Drawing.Size(1360, 760);
            
            // 配置日志文本框
            InitializeLogTextBox();
            
            LoadEquipmentDatabase();
            
            // 初始化框选框
            InitializeSelectionBox();
            
            // 为所有车道指示器按钮注册鼠标事件
            RegisterButtonMouseEvents();
            
            // 为窗体注册鼠标事件用于框选
            this.MouseDown += LaneLightController_MouseDown;
            this.MouseMove += LaneLightController_MouseMove;
            this.MouseUp += LaneLightController_MouseUp;
            
            // 为 Background PictureBox 注册鼠标事件，使其支持框选
            if (this.Background != null)
            {
                this.Background.MouseDown += Background_MouseDown;
                this.Background.MouseMove += Background_MouseMove;
                this.Background.MouseUp += Background_MouseUp;
            }
            
            // 初始化右键菜单
            InitializeContextMenu();
        }
        
        private void InitializeContextMenu()
        {
            contextMenu = new ContextMenuStrip();
            
            // 创建菜单项
            menuItemStraight = new ToolStripMenuItem("直行");
            menuItemProhibit = new ToolStripMenuItem("禁止");
            menuItemReverse = new ToolStripMenuItem("逆行");
            menuItemLeft = new ToolStripMenuItem("左转");
            
            // 添加点击事件
            menuItemStraight.Click += MenuItem_Click;
            menuItemProhibit.Click += MenuItem_Click;
            menuItemReverse.Click += MenuItem_Click;
            menuItemLeft.Click += MenuItem_Click;
            
            // 添加到菜单
            contextMenu.Items.Add(menuItemStraight);
            contextMenu.Items.Add(menuItemProhibit);
            contextMenu.Items.Add(menuItemReverse);
            contextMenu.Items.Add(menuItemLeft);
            
            // 为窗体和 Background 添加右键菜单
            this.ContextMenuStrip = contextMenu;
            if (this.Background != null)
            {
                this.Background.ContextMenuStrip = contextMenu;
            }
        }
        
        private void MenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem != null && selectedButtons.Count > 0)
            {
                string action = menuItem.Text;
                logTextBox.AppendText($"\r\n对选中的 {selectedButtons.Count} 个按钮执行操作: {action}\r\n");
                logTextBox.AppendText($"目标按钮: {string.Join(", ", selectedButtons)}\r\n");
                
                // 这里可以添加具体的业务逻辑
                // 例如：根据 action 更新按钮图片或状态
                foreach (string buttonName in selectedButtons)
                {
                    Control[] controls = this.Controls.Find(buttonName, false);
                    if (controls.Length > 0 && controls[0] is Button btn)
                    {
                        // 示例：在按钮上显示操作标记
                        logTextBox.AppendText($"  - 设置 {buttonName} 为 {action} 状态\r\n");
                    }
                }
            }
            else if (selectedButtons.Count == 0)
            {
                logTextBox.AppendText($"\r\n请先框选或选择按钮，再执行操作\r\n");
            }
        }
        
        private void Background_MouseDown(object sender, MouseEventArgs e)
        {
            // 将 PictureBox 的鼠标坐标转换为窗体坐标，然后调用窗体的鼠标按下事件
            Point formPoint = this.Background.PointToScreen(e.Location);
            formPoint = this.PointToClient(formPoint);
            
            // 手动触发框选开始
            if (e.Button == MouseButtons.Left)
            {
                // 检查是否按住Ctrl键
                if (Control.ModifierKeys != Keys.Control)
                {
                    ClearSelection();
                }
                
                isSelecting = true;
                selectionStart = formPoint;
                selectionEnd = formPoint;
                UpdateSelectionBox();
                selectionBox.Visible = true;
            }
        }
        
        private void Background_MouseMove(object sender, MouseEventArgs e)
        {
            if (isSelecting)
            {
                Point formPoint = this.Background.PointToScreen(e.Location);
                formPoint = this.PointToClient(formPoint);
                selectionEnd = formPoint;
                UpdateSelectionBox();
            }
        }
        
        private void Background_MouseUp(object sender, MouseEventArgs e)
        {
            if (isSelecting && e.Button == MouseButtons.Left)
            {
                isSelecting = false;
                selectionBox.Visible = false;
                
                Rectangle selectionRect = GetSelectionRectangle();
                SelectButtonsInRectangle(selectionRect);
                OutputSelectedButtons();
            }
        }
        
        private void InitializeLogTextBox()
        {
            // 启用自动换行
            logTextBox.WordWrap = true;
            // 文本变化时自动滚动到最新内容
            logTextBox.TextChanged += LogTextBox_TextChanged;
        }
        
        private void LogTextBox_TextChanged(object sender, EventArgs e)
        {
            // 限制行数不超过500行
            LimitLogLines(500);
            
            // 滚动到最新内容
            logTextBox.SelectionStart = logTextBox.Text.Length;
            logTextBox.ScrollToCaret();
        }
        
        private void LimitLogLines(int maxLines)
        {
            string[] lines = logTextBox.Lines;
            if (lines.Length > maxLines)
            {
                // 保留最后 maxLines 行
                string[] newLines = new string[maxLines];
                Array.Copy(lines, lines.Length - maxLines, newLines, 0, maxLines);
                logTextBox.Lines = newLines;
            }
        }
        
        private void InitializeSelectionBox()
        {
            selectionBox = new PictureBox();
            // 设置完全透明背景
            selectionBox.BackColor = Color.Transparent;
            // 不设置边框样式，使用 Paint 事件手动绘制黑色边框
            selectionBox.BorderStyle = BorderStyle.None;
            // 绘制黑色边框
            selectionBox.Paint += SelectionBox_Paint;
            selectionBox.Visible = false;
            this.Controls.Add(selectionBox);
            selectionBox.BringToFront();
        }
        
        private void SelectionBox_Paint(object sender, PaintEventArgs e)
        {
            // 绘制黑色边框，内部完全透明
            using (Pen pen = new Pen(Color.Black, 2))
            {
                // 绘制矩形边框，-1 是为了避免边框被裁剪
                e.Graphics.DrawRectangle(pen, 0, 0, selectionBox.Width - 1, selectionBox.Height - 1);
            }
        }
        
        private void RegisterButtonMouseEvents()
        {
            // 为所有车道指示器按钮注册鼠标事件
            string[] buttonPrefixes = { "左洞慢车道指示器", "左洞行车道指示器", "左洞超车道指示器",
                                        "右洞慢车道指示器", "右洞行车道指示器", "右洞超车道指示器" };
            
            foreach (string prefix in buttonPrefixes)
            {
                for (int i = 1; i <= 9; i++)
                {
                    string buttonName = prefix + i;
                    Control[] controls = this.Controls.Find(buttonName, false);
                    if (controls.Length > 0 && controls[0] is Button btn)
                    {
                        btn.MouseDown += LaneButton_MouseDown;
                    }
                }
            }
        }
        
        private void LaneButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button btn = sender as Button;
                if (btn != null)
                {
                    // 如果按住Ctrl键，则切换选择状态
                    if (Control.ModifierKeys == Keys.Control)
                    {
                        ToggleButtonSelection(btn);
                    }
                    else if (!selectedButtons.Contains(btn.Name))
                    {
                        // 如果没有按住Ctrl键且按钮未被选中，清除其他选择并选中当前按钮
                        ClearSelection();
                        SelectButton(btn);
                    }
                    
                    // 输出选中的按钮到logTextBox
                    OutputSelectedButtons();
                }
            }
        }
        
        private void SelectButton(Button btn)
        {
            if (!selectedButtons.Contains(btn.Name))
            {
                // 保存原始颜色（如果还没保存）
                if (!buttonOriginalColors.ContainsKey(btn.Name))
                {
                    buttonOriginalColors[btn.Name] = btn.BackColor;
                }
                selectedButtons.Add(btn.Name);
                btn.BackColor = Color.LightBlue;
            }
        }
        
        private void DeselectButton(Button btn)
        {
            if (selectedButtons.Contains(btn.Name))
            {
                selectedButtons.Remove(btn.Name);
                // 恢复原始颜色
                if (buttonOriginalColors.ContainsKey(btn.Name))
                {
                    btn.BackColor = buttonOriginalColors[btn.Name];
                }
            }
        }
        
        private void ToggleButtonSelection(Button btn)
        {
            if (selectedButtons.Contains(btn.Name))
            {
                DeselectButton(btn);
            }
            else
            {
                SelectButton(btn);
            }
        }
        
        private void ClearSelection()
        {
            foreach (string buttonName in selectedButtons)
            {
                Control[] controls = this.Controls.Find(buttonName, false);
                if (controls.Length > 0 && controls[0] is Button btn)
                {
                    // 恢复原始颜色
                    if (buttonOriginalColors.ContainsKey(btn.Name))
                    {
                        btn.BackColor = buttonOriginalColors[btn.Name];
                    }
                }
            }
            selectedButtons.Clear();
        }
        
        private void OutputSelectedButtons()
        {
            logTextBox.AppendText($"\r\n当前选中按钮 ({selectedButtons.Count}个): ");
            if (selectedButtons.Count > 0)
            {
                logTextBox.AppendText(string.Join(", ", selectedButtons));
            }
            else
            {
                logTextBox.AppendText("无");
            }
            logTextBox.AppendText("\r\n");
        }
        
        private void LaneLightController_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // 检查是否点击在按钮上
                Control clickedControl = this.GetChildAtPoint(e.Location);
                if (clickedControl == null || !(clickedControl is Button))
                {
                    // 如果没有按住Ctrl键，清除之前的选择
                    if (Control.ModifierKeys != Keys.Control)
                    {
                        ClearSelection();
                    }
                    
                    // 开始框选
                    isSelecting = true;
                    selectionStart = e.Location;
                    selectionEnd = e.Location;
                    UpdateSelectionBox();
                    selectionBox.Visible = true;
                }
            }
        }
        
        private void LaneLightController_MouseMove(object sender, MouseEventArgs e)
        {
            if (isSelecting)
            {
                selectionEnd = e.Location;
                UpdateSelectionBox();
            }
        }
        
        private void LaneLightController_MouseUp(object sender, MouseEventArgs e)
        {
            if (isSelecting && e.Button == MouseButtons.Left)
            {
                isSelecting = false;
                selectionBox.Visible = false;
                
                // 计算框选区域
                Rectangle selectionRect = GetSelectionRectangle();
                
                // 选择框选区域内的按钮
                SelectButtonsInRectangle(selectionRect);
                
                // 输出选中的按钮到logTextBox
                OutputSelectedButtons();
            }
        }
        
        private void UpdateSelectionBox()
        {
            Rectangle rect = GetSelectionRectangle();
            selectionBox.Location = rect.Location;
            selectionBox.Size = rect.Size;
        }
        
        private Rectangle GetSelectionRectangle()
        {
            int x = Math.Min(selectionStart.X, selectionEnd.X);
            int y = Math.Min(selectionStart.Y, selectionEnd.Y);
            int width = Math.Abs(selectionEnd.X - selectionStart.X);
            int height = Math.Abs(selectionEnd.Y - selectionStart.Y);
            return new Rectangle(x, y, width, height);
        }
        
        private void SelectButtonsInRectangle(Rectangle rect)
        {
            string[] buttonPrefixes = { "左洞慢车道指示器", "左洞行车道指示器", "左洞超车道指示器",
                                        "右洞慢车道指示器", "右洞行车道指示器", "右洞超车道指示器" };
            
            foreach (string prefix in buttonPrefixes)
            {
                for (int i = 1; i <= 9; i++)
                {
                    string buttonName = prefix + i;
                    Control[] controls = this.Controls.Find(buttonName, false);
                    if (controls.Length > 0 && controls[0] is Button btn)
                    {
                        // 检查按钮中心点是否在框选区域内
                        Point buttonCenter = new Point(
                            btn.Location.X + btn.Width / 2,
                            btn.Location.Y + btn.Height / 2
                        );
                        
                        if (rect.Contains(buttonCenter))
                        {
                            SelectButton(btn);
                        }
                    }
                }
            }
        }

        private void LoadEquipmentDatabase()
        {
            try
            {
                string dbPath = "D:\\Equipment.db";
                
                logTextBox.AppendText("=== 开始加载数据库 ===\r\n");
                logTextBox.AppendText($"程序路径：{Application.ExecutablePath}\r\n");
                logTextBox.AppendText($"工作目录：{Environment.CurrentDirectory}\r\n");
                logTextBox.AppendText($"基目录：{AppDomain.CurrentDomain.BaseDirectory}\r\n");
                
                string interopPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SQLite.Interop.dll");
                if (File.Exists(interopPath))
                {
                    logTextBox.AppendText($"✓ SQLite.Interop.dll 存在：{interopPath}\r\n");
                }
                else
                {
                    logTextBox.AppendText($"✗ SQLite.Interop.dll 不存在：{interopPath}\r\n");
                }
                
                if (!File.Exists(dbPath))
                {
                    logTextBox.AppendText("\r\n警告：未找到 D:\\Equipment.db 数据库文件\r\n");
                    return;
                }
                
                logTextBox.AppendText($"\r\n数据库文件存在：{dbPath}\r\n");
                currentDbPath = dbPath;
                
                logTextBox.AppendText("\r\n正在创建 SQLiteHelper...\r\n");
                sqliteHelper = new SQLiteHelper(currentDbPath);
                
                logTextBox.AppendText("正在测试连接...\r\n");
                if (sqliteHelper.TestConnection())
                {
                    logTextBox.AppendText("✓ 连接成功！\r\n");
                    
                    try
                    {
                        string sql = "SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;";
                        DataTable dt = sqliteHelper.ExecuteQuery(sql);
                        
                        logTextBox.AppendText($"\r\n共找到 {dt.Rows.Count} 个表\r\n");
                        
                        foreach (DataRow row in dt.Rows)
                        {
                            logTextBox.AppendText($"  - {row[0].ToString()}\r\n");
                        }
                        
                        if (dt.Rows.Count > 0)
                        {
                            string equipmentSql = "SELECT * FROM LineIndicate LIMIT 10;";
                            DataTable equipmentData = sqliteHelper.ExecuteQuery(equipmentSql);
                            
                            logTextBox.AppendText($"\r\n加载表 LineIndicate 数据，共 {equipmentData.Rows.Count} 行（显示前 10 行）\r\n");
                            
                            foreach (DataRow row in equipmentData.Rows)
                            {
                                logTextBox.AppendText("  ");
                                for (int i = 0; i < equipmentData.Columns.Count; i++)
                                {
                                    logTextBox.AppendText($"{row[i].ToString()} | ");
                                }
                                logTextBox.AppendText("\r\n");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        logTextBox.AppendText($"\r\n查询数据失败：{ex.Message}\r\n");
                    }
                    
                    logTextBox.AppendText($"\r\n数据库路径：{dbPath}\r\n");
                    logTextBox.AppendText("\r\n自动加载 Equipment 数据库成功！\r\n");
                }
                else
                {
                    logTextBox.AppendText("\r\n无法连接到 Equipment 数据库！\r\n");
                }
            }
            catch (Exception ex)
            {
                logTextBox.AppendText($"\r\n加载 Equipment 数据库失败：{ex.Message}\r\n");
                logTextBox.AppendText($"\r\n详细错误：{ex.ToString()}\r\n");
                if (ex.InnerException != null)
                {
                    logTextBox.AppendText($"\r\n内部错误：{ex.InnerException.ToString()}\r\n");
                }
            }
        }

        private void axDbCommOcxFC71_DataChange(object sender, AxDBCOMMOCXLibFC7._DDbCommOcxEventsFC7_DataChangeEvent e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void 左洞慢车道指示器6_Click(object sender, EventArgs e)
        {

        }

        private void 左洞行车道指示器6_Click(object sender, EventArgs e)
        {

        }

        private void 左洞超车道指示器6_Click(object sender, EventArgs e)
        {

        }

        private void 左洞慢车道指示器5_Click(object sender, EventArgs e)
        {

        }

        private void 左洞行车道指示器5_Click(object sender, EventArgs e)
        {

        }

        private void 左洞超车道指示器5_Click(object sender, EventArgs e)
        {

        }
    }
}
