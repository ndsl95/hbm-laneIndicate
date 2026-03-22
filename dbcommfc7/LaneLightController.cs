﻿﻿﻿﻿﻿﻿﻿﻿using System;
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

        public LaneLightController()
        {
            InitializeComponent();
        }

        private void LaneLightController_Load(object sender, EventArgs e)
        {
            LoadEquipmentDatabase();
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
