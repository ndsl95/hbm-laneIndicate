
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace dbcommfc7
{
    partial class LaneLightController
    {
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaneLightController));
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.车道指示器按钮图片集 = new System.Windows.Forms.ImageList(this.components);
            this.右洞超车道指示器9 = new System.Windows.Forms.Button();
            this.右洞超车道指示器8 = new System.Windows.Forms.Button();
            this.右洞超车道指示器7 = new System.Windows.Forms.Button();
            this.右洞超车道指示器6 = new System.Windows.Forms.Button();
            this.右洞超车道指示器5 = new System.Windows.Forms.Button();
            this.右洞超车道指示器4 = new System.Windows.Forms.Button();
            this.右洞超车道指示器3 = new System.Windows.Forms.Button();
            this.右洞超车道指示器2 = new System.Windows.Forms.Button();
            this.右洞超车道指示器1 = new System.Windows.Forms.Button();
            this.右洞行车道指示器9 = new System.Windows.Forms.Button();
            this.右洞行车道指示器8 = new System.Windows.Forms.Button();
            this.右洞行车道指示器7 = new System.Windows.Forms.Button();
            this.右洞行车道指示器6 = new System.Windows.Forms.Button();
            this.右洞行车道指示器5 = new System.Windows.Forms.Button();
            this.右洞行车道指示器4 = new System.Windows.Forms.Button();
            this.右洞行车道指示器3 = new System.Windows.Forms.Button();
            this.右洞行车道指示器2 = new System.Windows.Forms.Button();
            this.右洞行车道指示器1 = new System.Windows.Forms.Button();
            this.右洞慢车道指示器9 = new System.Windows.Forms.Button();
            this.右洞慢车道指示器8 = new System.Windows.Forms.Button();
            this.右洞慢车道指示器7 = new System.Windows.Forms.Button();
            this.右洞慢车道指示器6 = new System.Windows.Forms.Button();
            this.右洞慢车道指示器5 = new System.Windows.Forms.Button();
            this.右洞慢车道指示器4 = new System.Windows.Forms.Button();
            this.右洞慢车道指示器3 = new System.Windows.Forms.Button();
            this.右洞慢车道指示器2 = new System.Windows.Forms.Button();
            this.右洞慢车道指示器1 = new System.Windows.Forms.Button();
            this.左洞超车道指示器9 = new System.Windows.Forms.Button();
            this.左洞超车道指示器8 = new System.Windows.Forms.Button();
            this.左洞超车道指示器7 = new System.Windows.Forms.Button();
            this.左洞超车道指示器6 = new System.Windows.Forms.Button();
            this.左洞超车道指示器5 = new System.Windows.Forms.Button();
            this.左洞超车道指示器4 = new System.Windows.Forms.Button();
            this.左洞超车道指示器3 = new System.Windows.Forms.Button();
            this.左洞超车道指示器2 = new System.Windows.Forms.Button();
            this.左洞超车道指示器1 = new System.Windows.Forms.Button();
            this.左洞行车道指示器9 = new System.Windows.Forms.Button();
            this.左洞行车道指示器8 = new System.Windows.Forms.Button();
            this.左洞行车道指示器7 = new System.Windows.Forms.Button();
            this.左洞行车道指示器6 = new System.Windows.Forms.Button();
            this.左洞行车道指示器5 = new System.Windows.Forms.Button();
            this.左洞行车道指示器4 = new System.Windows.Forms.Button();
            this.左洞行车道指示器3 = new System.Windows.Forms.Button();
            this.左洞行车道指示器2 = new System.Windows.Forms.Button();
            this.左洞行车道指示器1 = new System.Windows.Forms.Button();
            this.左洞慢车道指示器9 = new System.Windows.Forms.Button();
            this.左洞慢车道指示器8 = new System.Windows.Forms.Button();
            this.左洞慢车道指示器7 = new System.Windows.Forms.Button();
            this.左洞慢车道指示器6 = new System.Windows.Forms.Button();
            this.左洞慢车道指示器5 = new System.Windows.Forms.Button();
            this.左洞慢车道指示器4 = new System.Windows.Forms.Button();
            this.左洞慢车道指示器3 = new System.Windows.Forms.Button();
            this.左洞慢车道指示器2 = new System.Windows.Forms.Button();
            this.左洞慢车道指示器1 = new System.Windows.Forms.Button();
            this.Background = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.SuspendLayout();
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(526, 910);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.logTextBox.Size = new System.Drawing.Size(1933, 345);
            this.logTextBox.TabIndex = 0;
            this.logTextBox.Text = "";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(22, 1237);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(115, 21);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "状态：就绪";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 40);
            this.label1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.richTextBox1.Location = new System.Drawing.Point(26, 21);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(318, 84);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "左洞出口";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBox2.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox2.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox2.Location = new System.Drawing.Point(2132, 21);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(318, 84);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "左洞入口";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBox3.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.richTextBox3.Location = new System.Drawing.Point(2134, 810);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(318, 84);
            this.richTextBox3.TabIndex = 8;
            this.richTextBox3.Text = "右洞出口";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBox4.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox4.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox4.Location = new System.Drawing.Point(26, 803);
            this.richTextBox4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(318, 84);
            this.richTextBox4.TabIndex = 7;
            this.richTextBox4.Text = "右洞入口";
            // 
            // 车道指示器按钮图片集
            // 
            this.车道指示器按钮图片集.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("车道指示器按钮图片集.ImageStream")));
            this.车道指示器按钮图片集.TransparentColor = System.Drawing.Color.Transparent;
            this.车道指示器按钮图片集.Images.SetKeyName(0, "红灯.png");
            this.车道指示器按钮图片集.Images.SetKeyName(1, "逆行.png");
            this.车道指示器按钮图片集.Images.SetKeyName(2, "右指示灯.png");
            this.车道指示器按钮图片集.Images.SetKeyName(3, "直行.png");
            this.车道指示器按钮图片集.Images.SetKeyName(4, "左指示灯.png");
            // 
            // 右洞超车道指示器9
            // 
            this.右洞超车道指示器9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞超车道指示器9.FlatAppearance.BorderSize = 0;
            this.右洞超车道指示器9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞超车道指示器9.ImageKey = "右指示灯.png";
            this.右洞超车道指示器9.ImageList = this.车道指示器按钮图片集;
            this.右洞超车道指示器9.Location = new System.Drawing.Point(183, 458);
            this.右洞超车道指示器9.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞超车道指示器9.Name = "右洞超车道指示器9";
            this.右洞超车道指示器9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞超车道指示器9.Size = new System.Drawing.Size(51, 49);
            this.右洞超车道指示器9.TabIndex = 50;
            this.右洞超车道指示器9.UseVisualStyleBackColor = false;
            // 
            // 右洞超车道指示器8
            // 
            this.右洞超车道指示器8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞超车道指示器8.FlatAppearance.BorderSize = 0;
            this.右洞超车道指示器8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞超车道指示器8.ImageKey = "右指示灯.png";
            this.右洞超车道指示器8.ImageList = this.车道指示器按钮图片集;
            this.右洞超车道指示器8.Location = new System.Drawing.Point(413, 458);
            this.右洞超车道指示器8.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞超车道指示器8.Name = "右洞超车道指示器8";
            this.右洞超车道指示器8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞超车道指示器8.Size = new System.Drawing.Size(51, 49);
            this.右洞超车道指示器8.TabIndex = 49;
            this.右洞超车道指示器8.UseVisualStyleBackColor = false;
            // 
            // 右洞超车道指示器7
            // 
            this.右洞超车道指示器7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞超车道指示器7.FlatAppearance.BorderSize = 0;
            this.右洞超车道指示器7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞超车道指示器7.ImageKey = "右指示灯.png";
            this.右洞超车道指示器7.ImageList = this.车道指示器按钮图片集;
            this.右洞超车道指示器7.Location = new System.Drawing.Point(689, 458);
            this.右洞超车道指示器7.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞超车道指示器7.Name = "右洞超车道指示器7";
            this.右洞超车道指示器7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞超车道指示器7.Size = new System.Drawing.Size(51, 49);
            this.右洞超车道指示器7.TabIndex = 48;
            this.右洞超车道指示器7.UseVisualStyleBackColor = false;
            // 
            // 右洞超车道指示器6
            // 
            this.右洞超车道指示器6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞超车道指示器6.FlatAppearance.BorderSize = 0;
            this.右洞超车道指示器6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞超车道指示器6.ImageKey = "右指示灯.png";
            this.右洞超车道指示器6.ImageList = this.车道指示器按钮图片集;
            this.右洞超车道指示器6.Location = new System.Drawing.Point(942, 458);
            this.右洞超车道指示器6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞超车道指示器6.Name = "右洞超车道指示器6";
            this.右洞超车道指示器6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞超车道指示器6.Size = new System.Drawing.Size(51, 49);
            this.右洞超车道指示器6.TabIndex = 47;
            this.右洞超车道指示器6.UseVisualStyleBackColor = false;
            // 
            // 右洞超车道指示器5
            // 
            this.右洞超车道指示器5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞超车道指示器5.FlatAppearance.BorderSize = 0;
            this.右洞超车道指示器5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞超车道指示器5.ImageKey = "右指示灯.png";
            this.右洞超车道指示器5.ImageList = this.车道指示器按钮图片集;
            this.右洞超车道指示器5.Location = new System.Drawing.Point(1381, 458);
            this.右洞超车道指示器5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞超车道指示器5.Name = "右洞超车道指示器5";
            this.右洞超车道指示器5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞超车道指示器5.Size = new System.Drawing.Size(51, 49);
            this.右洞超车道指示器5.TabIndex = 46;
            this.右洞超车道指示器5.UseVisualStyleBackColor = false;
            // 
            // 右洞超车道指示器4
            // 
            this.右洞超车道指示器4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞超车道指示器4.FlatAppearance.BorderSize = 0;
            this.右洞超车道指示器4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞超车道指示器4.ImageKey = "右指示灯.png";
            this.右洞超车道指示器4.ImageList = this.车道指示器按钮图片集;
            this.右洞超车道指示器4.Location = new System.Drawing.Point(1637, 458);
            this.右洞超车道指示器4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞超车道指示器4.Name = "右洞超车道指示器4";
            this.右洞超车道指示器4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞超车道指示器4.Size = new System.Drawing.Size(51, 49);
            this.右洞超车道指示器4.TabIndex = 45;
            this.右洞超车道指示器4.UseVisualStyleBackColor = false;
            // 
            // 右洞超车道指示器3
            // 
            this.右洞超车道指示器3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞超车道指示器3.FlatAppearance.BorderSize = 0;
            this.右洞超车道指示器3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞超车道指示器3.ImageKey = "右指示灯.png";
            this.右洞超车道指示器3.ImageList = this.车道指示器按钮图片集;
            this.右洞超车道指示器3.Location = new System.Drawing.Point(1958, 458);
            this.右洞超车道指示器3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞超车道指示器3.Name = "右洞超车道指示器3";
            this.右洞超车道指示器3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞超车道指示器3.Size = new System.Drawing.Size(51, 49);
            this.右洞超车道指示器3.TabIndex = 44;
            this.右洞超车道指示器3.UseVisualStyleBackColor = false;
            // 
            // 右洞超车道指示器2
            // 
            this.右洞超车道指示器2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞超车道指示器2.FlatAppearance.BorderSize = 0;
            this.右洞超车道指示器2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞超车道指示器2.ImageKey = "右指示灯.png";
            this.右洞超车道指示器2.ImageList = this.车道指示器按钮图片集;
            this.右洞超车道指示器2.Location = new System.Drawing.Point(2185, 458);
            this.右洞超车道指示器2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞超车道指示器2.Name = "右洞超车道指示器2";
            this.右洞超车道指示器2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞超车道指示器2.Size = new System.Drawing.Size(51, 49);
            this.右洞超车道指示器2.TabIndex = 43;
            this.右洞超车道指示器2.UseVisualStyleBackColor = false;
            // 
            // 右洞超车道指示器1
            // 
            this.右洞超车道指示器1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞超车道指示器1.FlatAppearance.BorderSize = 0;
            this.右洞超车道指示器1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞超车道指示器1.ImageKey = "右指示灯.png";
            this.右洞超车道指示器1.ImageList = this.车道指示器按钮图片集;
            this.右洞超车道指示器1.Location = new System.Drawing.Point(2365, 458);
            this.右洞超车道指示器1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞超车道指示器1.Name = "右洞超车道指示器1";
            this.右洞超车道指示器1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞超车道指示器1.Size = new System.Drawing.Size(51, 61);
            this.右洞超车道指示器1.TabIndex = 42;
            this.右洞超车道指示器1.UseVisualStyleBackColor = false;
            // 
            // 右洞行车道指示器9
            // 
            this.右洞行车道指示器9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞行车道指示器9.FlatAppearance.BorderSize = 0;
            this.右洞行车道指示器9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞行车道指示器9.ImageKey = "右指示灯.png";
            this.右洞行车道指示器9.ImageList = this.车道指示器按钮图片集;
            this.右洞行车道指示器9.Location = new System.Drawing.Point(183, 537);
            this.右洞行车道指示器9.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞行车道指示器9.Name = "右洞行车道指示器9";
            this.右洞行车道指示器9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞行车道指示器9.Size = new System.Drawing.Size(51, 49);
            this.右洞行车道指示器9.TabIndex = 49;
            this.右洞行车道指示器9.UseVisualStyleBackColor = false;
            // 
            // 右洞行车道指示器8
            // 
            this.右洞行车道指示器8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞行车道指示器8.FlatAppearance.BorderSize = 0;
            this.右洞行车道指示器8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞行车道指示器8.ImageKey = "右指示灯.png";
            this.右洞行车道指示器8.ImageList = this.车道指示器按钮图片集;
            this.右洞行车道指示器8.Location = new System.Drawing.Point(413, 537);
            this.右洞行车道指示器8.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞行车道指示器8.Name = "右洞行车道指示器8";
            this.右洞行车道指示器8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞行车道指示器8.Size = new System.Drawing.Size(51, 49);
            this.右洞行车道指示器8.TabIndex = 48;
            this.右洞行车道指示器8.UseVisualStyleBackColor = false;
            // 
            // 右洞行车道指示器7
            // 
            this.右洞行车道指示器7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞行车道指示器7.FlatAppearance.BorderSize = 0;
            this.右洞行车道指示器7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞行车道指示器7.ImageKey = "右指示灯.png";
            this.右洞行车道指示器7.ImageList = this.车道指示器按钮图片集;
            this.右洞行车道指示器7.Location = new System.Drawing.Point(689, 537);
            this.右洞行车道指示器7.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞行车道指示器7.Name = "右洞行车道指示器7";
            this.右洞行车道指示器7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞行车道指示器7.Size = new System.Drawing.Size(51, 49);
            this.右洞行车道指示器7.TabIndex = 47;
            this.右洞行车道指示器7.UseVisualStyleBackColor = false;
            // 
            // 右洞行车道指示器6
            // 
            this.右洞行车道指示器6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞行车道指示器6.FlatAppearance.BorderSize = 0;
            this.右洞行车道指示器6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞行车道指示器6.ImageKey = "右指示灯.png";
            this.右洞行车道指示器6.ImageList = this.车道指示器按钮图片集;
            this.右洞行车道指示器6.Location = new System.Drawing.Point(942, 537);
            this.右洞行车道指示器6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞行车道指示器6.Name = "右洞行车道指示器6";
            this.右洞行车道指示器6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞行车道指示器6.Size = new System.Drawing.Size(51, 49);
            this.右洞行车道指示器6.TabIndex = 46;
            this.右洞行车道指示器6.UseVisualStyleBackColor = false;
            // 
            // 右洞行车道指示器5
            // 
            this.右洞行车道指示器5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞行车道指示器5.FlatAppearance.BorderSize = 0;
            this.右洞行车道指示器5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞行车道指示器5.ImageKey = "右指示灯.png";
            this.右洞行车道指示器5.ImageList = this.车道指示器按钮图片集;
            this.右洞行车道指示器5.Location = new System.Drawing.Point(1381, 537);
            this.右洞行车道指示器5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞行车道指示器5.Name = "右洞行车道指示器5";
            this.右洞行车道指示器5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞行车道指示器5.Size = new System.Drawing.Size(51, 49);
            this.右洞行车道指示器5.TabIndex = 45;
            this.右洞行车道指示器5.UseVisualStyleBackColor = false;
            // 
            // 右洞行车道指示器4
            // 
            this.右洞行车道指示器4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞行车道指示器4.FlatAppearance.BorderSize = 0;
            this.右洞行车道指示器4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞行车道指示器4.ImageKey = "右指示灯.png";
            this.右洞行车道指示器4.ImageList = this.车道指示器按钮图片集;
            this.右洞行车道指示器4.Location = new System.Drawing.Point(1637, 537);
            this.右洞行车道指示器4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞行车道指示器4.Name = "右洞行车道指示器4";
            this.右洞行车道指示器4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞行车道指示器4.Size = new System.Drawing.Size(51, 49);
            this.右洞行车道指示器4.TabIndex = 44;
            this.右洞行车道指示器4.UseVisualStyleBackColor = false;
            // 
            // 右洞行车道指示器3
            // 
            this.右洞行车道指示器3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞行车道指示器3.FlatAppearance.BorderSize = 0;
            this.右洞行车道指示器3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞行车道指示器3.ImageKey = "右指示灯.png";
            this.右洞行车道指示器3.ImageList = this.车道指示器按钮图片集;
            this.右洞行车道指示器3.Location = new System.Drawing.Point(1958, 537);
            this.右洞行车道指示器3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞行车道指示器3.Name = "右洞行车道指示器3";
            this.右洞行车道指示器3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞行车道指示器3.Size = new System.Drawing.Size(51, 49);
            this.右洞行车道指示器3.TabIndex = 43;
            this.右洞行车道指示器3.UseVisualStyleBackColor = false;
            // 
            // 右洞行车道指示器2
            // 
            this.右洞行车道指示器2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞行车道指示器2.FlatAppearance.BorderSize = 0;
            this.右洞行车道指示器2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞行车道指示器2.ImageKey = "右指示灯.png";
            this.右洞行车道指示器2.ImageList = this.车道指示器按钮图片集;
            this.右洞行车道指示器2.Location = new System.Drawing.Point(2185, 537);
            this.右洞行车道指示器2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞行车道指示器2.Name = "右洞行车道指示器2";
            this.右洞行车道指示器2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞行车道指示器2.Size = new System.Drawing.Size(51, 49);
            this.右洞行车道指示器2.TabIndex = 42;
            this.右洞行车道指示器2.UseVisualStyleBackColor = false;
            // 
            // 右洞行车道指示器1
            // 
            this.右洞行车道指示器1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞行车道指示器1.FlatAppearance.BorderSize = 0;
            this.右洞行车道指示器1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞行车道指示器1.ImageKey = "右指示灯.png";
            this.右洞行车道指示器1.ImageList = this.车道指示器按钮图片集;
            this.右洞行车道指示器1.Location = new System.Drawing.Point(2365, 537);
            this.右洞行车道指示器1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞行车道指示器1.Name = "右洞行车道指示器1";
            this.右洞行车道指示器1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞行车道指示器1.Size = new System.Drawing.Size(51, 49);
            this.右洞行车道指示器1.TabIndex = 43;
            this.右洞行车道指示器1.UseVisualStyleBackColor = false;
            // 
            // 右洞慢车道指示器9
            // 
            this.右洞慢车道指示器9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞慢车道指示器9.FlatAppearance.BorderSize = 0;
            this.右洞慢车道指示器9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞慢车道指示器9.ImageKey = "右指示灯.png";
            this.右洞慢车道指示器9.ImageList = this.车道指示器按钮图片集;
            this.右洞慢车道指示器9.Location = new System.Drawing.Point(183, 612);
            this.右洞慢车道指示器9.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞慢车道指示器9.Name = "右洞慢车道指示器9";
            this.右洞慢车道指示器9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞慢车道指示器9.Size = new System.Drawing.Size(51, 49);
            this.右洞慢车道指示器9.TabIndex = 48;
            this.右洞慢车道指示器9.UseVisualStyleBackColor = false;
            // 
            // 右洞慢车道指示器8
            // 
            this.右洞慢车道指示器8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞慢车道指示器8.FlatAppearance.BorderSize = 0;
            this.右洞慢车道指示器8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞慢车道指示器8.ImageKey = "右指示灯.png";
            this.右洞慢车道指示器8.ImageList = this.车道指示器按钮图片集;
            this.右洞慢车道指示器8.Location = new System.Drawing.Point(413, 612);
            this.右洞慢车道指示器8.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞慢车道指示器8.Name = "右洞慢车道指示器8";
            this.右洞慢车道指示器8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞慢车道指示器8.Size = new System.Drawing.Size(51, 49);
            this.右洞慢车道指示器8.TabIndex = 47;
            this.右洞慢车道指示器8.UseVisualStyleBackColor = false;
            // 
            // 右洞慢车道指示器7
            // 
            this.右洞慢车道指示器7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞慢车道指示器7.FlatAppearance.BorderSize = 0;
            this.右洞慢车道指示器7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞慢车道指示器7.ImageKey = "右指示灯.png";
            this.右洞慢车道指示器7.ImageList = this.车道指示器按钮图片集;
            this.右洞慢车道指示器7.Location = new System.Drawing.Point(689, 612);
            this.右洞慢车道指示器7.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞慢车道指示器7.Name = "右洞慢车道指示器7";
            this.右洞慢车道指示器7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞慢车道指示器7.Size = new System.Drawing.Size(51, 49);
            this.右洞慢车道指示器7.TabIndex = 46;
            this.右洞慢车道指示器7.UseVisualStyleBackColor = false;
            // 
            // 右洞慢车道指示器6
            // 
            this.右洞慢车道指示器6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞慢车道指示器6.FlatAppearance.BorderSize = 0;
            this.右洞慢车道指示器6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞慢车道指示器6.ImageKey = "右指示灯.png";
            this.右洞慢车道指示器6.ImageList = this.车道指示器按钮图片集;
            this.右洞慢车道指示器6.Location = new System.Drawing.Point(942, 612);
            this.右洞慢车道指示器6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞慢车道指示器6.Name = "右洞慢车道指示器6";
            this.右洞慢车道指示器6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞慢车道指示器6.Size = new System.Drawing.Size(51, 49);
            this.右洞慢车道指示器6.TabIndex = 45;
            this.右洞慢车道指示器6.UseVisualStyleBackColor = false;
            // 
            // 右洞慢车道指示器5
            // 
            this.右洞慢车道指示器5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞慢车道指示器5.FlatAppearance.BorderSize = 0;
            this.右洞慢车道指示器5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞慢车道指示器5.ImageKey = "右指示灯.png";
            this.右洞慢车道指示器5.ImageList = this.车道指示器按钮图片集;
            this.右洞慢车道指示器5.Location = new System.Drawing.Point(1381, 612);
            this.右洞慢车道指示器5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞慢车道指示器5.Name = "右洞慢车道指示器5";
            this.右洞慢车道指示器5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞慢车道指示器5.Size = new System.Drawing.Size(51, 49);
            this.右洞慢车道指示器5.TabIndex = 44;
            this.右洞慢车道指示器5.UseVisualStyleBackColor = false;
            // 
            // 右洞慢车道指示器4
            // 
            this.右洞慢车道指示器4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞慢车道指示器4.FlatAppearance.BorderSize = 0;
            this.右洞慢车道指示器4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞慢车道指示器4.ImageKey = "右指示灯.png";
            this.右洞慢车道指示器4.ImageList = this.车道指示器按钮图片集;
            this.右洞慢车道指示器4.Location = new System.Drawing.Point(1637, 612);
            this.右洞慢车道指示器4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞慢车道指示器4.Name = "右洞慢车道指示器4";
            this.右洞慢车道指示器4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞慢车道指示器4.Size = new System.Drawing.Size(51, 49);
            this.右洞慢车道指示器4.TabIndex = 43;
            this.右洞慢车道指示器4.UseVisualStyleBackColor = false;
            // 
            // 右洞慢车道指示器3
            // 
            this.右洞慢车道指示器3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞慢车道指示器3.FlatAppearance.BorderSize = 0;
            this.右洞慢车道指示器3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞慢车道指示器3.ImageKey = "右指示灯.png";
            this.右洞慢车道指示器3.ImageList = this.车道指示器按钮图片集;
            this.右洞慢车道指示器3.Location = new System.Drawing.Point(1958, 612);
            this.右洞慢车道指示器3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞慢车道指示器3.Name = "右洞慢车道指示器3";
            this.右洞慢车道指示器3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞慢车道指示器3.Size = new System.Drawing.Size(51, 49);
            this.右洞慢车道指示器3.TabIndex = 42;
            this.右洞慢车道指示器3.UseVisualStyleBackColor = false;
            // 
            // 右洞慢车道指示器2
            // 
            this.右洞慢车道指示器2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞慢车道指示器2.FlatAppearance.BorderSize = 0;
            this.右洞慢车道指示器2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞慢车道指示器2.ImageKey = "右指示灯.png";
            this.右洞慢车道指示器2.ImageList = this.车道指示器按钮图片集;
            this.右洞慢车道指示器2.Location = new System.Drawing.Point(2185, 612);
            this.右洞慢车道指示器2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞慢车道指示器2.Name = "右洞慢车道指示器2";
            this.右洞慢车道指示器2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞慢车道指示器2.Size = new System.Drawing.Size(51, 49);
            this.右洞慢车道指示器2.TabIndex = 41;
            this.右洞慢车道指示器2.UseVisualStyleBackColor = false;
            // 
            // 右洞慢车道指示器1
            // 
            this.右洞慢车道指示器1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.右洞慢车道指示器1.FlatAppearance.BorderSize = 0;
            this.右洞慢车道指示器1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.右洞慢车道指示器1.ImageKey = "右指示灯.png";
            this.右洞慢车道指示器1.ImageList = this.车道指示器按钮图片集;
            this.右洞慢车道指示器1.Location = new System.Drawing.Point(2365, 612);
            this.右洞慢车道指示器1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.右洞慢车道指示器1.Name = "右洞慢车道指示器1";
            this.右洞慢车道指示器1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞慢车道指示器1.Size = new System.Drawing.Size(51, 49);
            this.右洞慢车道指示器1.TabIndex = 44;
            this.右洞慢车道指示器1.UseVisualStyleBackColor = false;
            // 
            // 左洞超车道指示器9
            // 
            this.左洞超车道指示器9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞超车道指示器9.FlatAppearance.BorderSize = 0;
            this.左洞超车道指示器9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞超车道指示器9.ImageKey = "左指示灯.png";
            this.左洞超车道指示器9.ImageList = this.车道指示器按钮图片集;
            this.左洞超车道指示器9.Location = new System.Drawing.Point(183, 332);
            this.左洞超车道指示器9.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞超车道指示器9.Name = "左洞超车道指示器9";
            this.左洞超车道指示器9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞超车道指示器9.Size = new System.Drawing.Size(51, 49);
            this.左洞超车道指示器9.TabIndex = 19;
            this.左洞超车道指示器9.UseVisualStyleBackColor = false;
            // 
            // 左洞超车道指示器8
            // 
            this.左洞超车道指示器8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞超车道指示器8.FlatAppearance.BorderSize = 0;
            this.左洞超车道指示器8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞超车道指示器8.ImageKey = "左指示灯.png";
            this.左洞超车道指示器8.ImageList = this.车道指示器按钮图片集;
            this.左洞超车道指示器8.Location = new System.Drawing.Point(413, 332);
            this.左洞超车道指示器8.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞超车道指示器8.Name = "左洞超车道指示器8";
            this.左洞超车道指示器8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞超车道指示器8.Size = new System.Drawing.Size(51, 49);
            this.左洞超车道指示器8.TabIndex = 18;
            this.左洞超车道指示器8.UseVisualStyleBackColor = false;
            // 
            // 左洞超车道指示器7
            // 
            this.左洞超车道指示器7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞超车道指示器7.FlatAppearance.BorderSize = 0;
            this.左洞超车道指示器7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞超车道指示器7.ImageKey = "左指示灯.png";
            this.左洞超车道指示器7.ImageList = this.车道指示器按钮图片集;
            this.左洞超车道指示器7.Location = new System.Drawing.Point(689, 332);
            this.左洞超车道指示器7.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞超车道指示器7.Name = "左洞超车道指示器7";
            this.左洞超车道指示器7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞超车道指示器7.Size = new System.Drawing.Size(51, 49);
            this.左洞超车道指示器7.TabIndex = 17;
            this.左洞超车道指示器7.UseVisualStyleBackColor = false;
            // 
            // 左洞超车道指示器6
            // 
            this.左洞超车道指示器6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞超车道指示器6.FlatAppearance.BorderSize = 0;
            this.左洞超车道指示器6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞超车道指示器6.ImageKey = "左指示灯.png";
            this.左洞超车道指示器6.ImageList = this.车道指示器按钮图片集;
            this.左洞超车道指示器6.Location = new System.Drawing.Point(942, 332);
            this.左洞超车道指示器6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞超车道指示器6.Name = "左洞超车道指示器6";
            this.左洞超车道指示器6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞超车道指示器6.Size = new System.Drawing.Size(51, 49);
            this.左洞超车道指示器6.TabIndex = 16;
            this.左洞超车道指示器6.UseVisualStyleBackColor = false;
            this.左洞超车道指示器6.Click += new System.EventHandler(this.左洞超车道指示器6_Click);
            // 
            // 左洞超车道指示器5
            // 
            this.左洞超车道指示器5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞超车道指示器5.FlatAppearance.BorderSize = 0;
            this.左洞超车道指示器5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞超车道指示器5.ImageKey = "左指示灯.png";
            this.左洞超车道指示器5.ImageList = this.车道指示器按钮图片集;
            this.左洞超车道指示器5.Location = new System.Drawing.Point(1381, 332);
            this.左洞超车道指示器5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞超车道指示器5.Name = "左洞超车道指示器5";
            this.左洞超车道指示器5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞超车道指示器5.Size = new System.Drawing.Size(51, 49);
            this.左洞超车道指示器5.TabIndex = 15;
            this.左洞超车道指示器5.UseVisualStyleBackColor = false;
            this.左洞超车道指示器5.Click += new System.EventHandler(this.左洞超车道指示器5_Click);
            // 
            // 左洞超车道指示器4
            // 
            this.左洞超车道指示器4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞超车道指示器4.FlatAppearance.BorderSize = 0;
            this.左洞超车道指示器4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞超车道指示器4.ImageKey = "左指示灯.png";
            this.左洞超车道指示器4.ImageList = this.车道指示器按钮图片集;
            this.左洞超车道指示器4.Location = new System.Drawing.Point(1637, 332);
            this.左洞超车道指示器4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞超车道指示器4.Name = "左洞超车道指示器4";
            this.左洞超车道指示器4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞超车道指示器4.Size = new System.Drawing.Size(51, 49);
            this.左洞超车道指示器4.TabIndex = 14;
            this.左洞超车道指示器4.UseVisualStyleBackColor = false;
            // 
            // 左洞超车道指示器3
            // 
            this.左洞超车道指示器3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞超车道指示器3.FlatAppearance.BorderSize = 0;
            this.左洞超车道指示器3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞超车道指示器3.ImageKey = "左指示灯.png";
            this.左洞超车道指示器3.ImageList = this.车道指示器按钮图片集;
            this.左洞超车道指示器3.Location = new System.Drawing.Point(1962, 332);
            this.左洞超车道指示器3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞超车道指示器3.Name = "左洞超车道指示器3";
            this.左洞超车道指示器3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞超车道指示器3.Size = new System.Drawing.Size(51, 49);
            this.左洞超车道指示器3.TabIndex = 13;
            this.左洞超车道指示器3.UseVisualStyleBackColor = false;
            // 
            // 左洞超车道指示器2
            // 
            this.左洞超车道指示器2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞超车道指示器2.FlatAppearance.BorderSize = 0;
            this.左洞超车道指示器2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞超车道指示器2.ImageKey = "左指示灯.png";
            this.左洞超车道指示器2.ImageList = this.车道指示器按钮图片集;
            this.左洞超车道指示器2.Location = new System.Drawing.Point(2185, 332);
            this.左洞超车道指示器2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞超车道指示器2.Name = "左洞超车道指示器2";
            this.左洞超车道指示器2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞超车道指示器2.Size = new System.Drawing.Size(51, 49);
            this.左洞超车道指示器2.TabIndex = 12;
            this.左洞超车道指示器2.UseVisualStyleBackColor = false;
            // 
            // 左洞超车道指示器1
            // 
            this.左洞超车道指示器1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞超车道指示器1.FlatAppearance.BorderSize = 0;
            this.左洞超车道指示器1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞超车道指示器1.ImageKey = "左指示灯.png";
            this.左洞超车道指示器1.ImageList = this.车道指示器按钮图片集;
            this.左洞超车道指示器1.Location = new System.Drawing.Point(2365, 332);
            this.左洞超车道指示器1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞超车道指示器1.Name = "左洞超车道指示器1";
            this.左洞超车道指示器1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞超车道指示器1.Size = new System.Drawing.Size(51, 49);
            this.左洞超车道指示器1.TabIndex = 11;
            this.左洞超车道指示器1.UseVisualStyleBackColor = false;
            // 
            // 左洞行车道指示器9
            // 
            this.左洞行车道指示器9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞行车道指示器9.FlatAppearance.BorderSize = 0;
            this.左洞行车道指示器9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞行车道指示器9.ImageKey = "左指示灯.png";
            this.左洞行车道指示器9.ImageList = this.车道指示器按钮图片集;
            this.左洞行车道指示器9.Location = new System.Drawing.Point(183, 259);
            this.左洞行车道指示器9.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞行车道指示器9.Name = "左洞行车道指示器9";
            this.左洞行车道指示器9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞行车道指示器9.Size = new System.Drawing.Size(51, 49);
            this.左洞行车道指示器9.TabIndex = 27;
            this.左洞行车道指示器9.UseVisualStyleBackColor = false;
            // 
            // 左洞行车道指示器8
            // 
            this.左洞行车道指示器8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞行车道指示器8.FlatAppearance.BorderSize = 0;
            this.左洞行车道指示器8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞行车道指示器8.ImageKey = "左指示灯.png";
            this.左洞行车道指示器8.ImageList = this.车道指示器按钮图片集;
            this.左洞行车道指示器8.Location = new System.Drawing.Point(413, 259);
            this.左洞行车道指示器8.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞行车道指示器8.Name = "左洞行车道指示器8";
            this.左洞行车道指示器8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞行车道指示器8.Size = new System.Drawing.Size(51, 49);
            this.左洞行车道指示器8.TabIndex = 26;
            this.左洞行车道指示器8.UseVisualStyleBackColor = false;
            // 
            // 左洞行车道指示器7
            // 
            this.左洞行车道指示器7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞行车道指示器7.FlatAppearance.BorderSize = 0;
            this.左洞行车道指示器7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞行车道指示器7.ImageKey = "左指示灯.png";
            this.左洞行车道指示器7.ImageList = this.车道指示器按钮图片集;
            this.左洞行车道指示器7.Location = new System.Drawing.Point(689, 259);
            this.左洞行车道指示器7.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞行车道指示器7.Name = "左洞行车道指示器7";
            this.左洞行车道指示器7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞行车道指示器7.Size = new System.Drawing.Size(51, 49);
            this.左洞行车道指示器7.TabIndex = 25;
            this.左洞行车道指示器7.UseVisualStyleBackColor = false;
            // 
            // 左洞行车道指示器6
            // 
            this.左洞行车道指示器6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞行车道指示器6.FlatAppearance.BorderSize = 0;
            this.左洞行车道指示器6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞行车道指示器6.ImageKey = "左指示灯.png";
            this.左洞行车道指示器6.ImageList = this.车道指示器按钮图片集;
            this.左洞行车道指示器6.Location = new System.Drawing.Point(942, 259);
            this.左洞行车道指示器6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞行车道指示器6.Name = "左洞行车道指示器6";
            this.左洞行车道指示器6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞行车道指示器6.Size = new System.Drawing.Size(51, 49);
            this.左洞行车道指示器6.TabIndex = 24;
            this.左洞行车道指示器6.UseVisualStyleBackColor = false;
            this.左洞行车道指示器6.Click += new System.EventHandler(this.左洞行车道指示器6_Click);
            // 
            // 左洞行车道指示器5
            // 
            this.左洞行车道指示器5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞行车道指示器5.FlatAppearance.BorderSize = 0;
            this.左洞行车道指示器5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞行车道指示器5.ImageKey = "左指示灯.png";
            this.左洞行车道指示器5.ImageList = this.车道指示器按钮图片集;
            this.左洞行车道指示器5.Location = new System.Drawing.Point(1381, 259);
            this.左洞行车道指示器5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞行车道指示器5.Name = "左洞行车道指示器5";
            this.左洞行车道指示器5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞行车道指示器5.Size = new System.Drawing.Size(51, 49);
            this.左洞行车道指示器5.TabIndex = 23;
            this.左洞行车道指示器5.UseVisualStyleBackColor = false;
            this.左洞行车道指示器5.Click += new System.EventHandler(this.左洞行车道指示器5_Click);
            // 
            // 左洞行车道指示器4
            // 
            this.左洞行车道指示器4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞行车道指示器4.FlatAppearance.BorderSize = 0;
            this.左洞行车道指示器4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞行车道指示器4.ImageKey = "左指示灯.png";
            this.左洞行车道指示器4.ImageList = this.车道指示器按钮图片集;
            this.左洞行车道指示器4.Location = new System.Drawing.Point(1637, 259);
            this.左洞行车道指示器4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞行车道指示器4.Name = "左洞行车道指示器4";
            this.左洞行车道指示器4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞行车道指示器4.Size = new System.Drawing.Size(51, 49);
            this.左洞行车道指示器4.TabIndex = 22;
            this.左洞行车道指示器4.UseVisualStyleBackColor = false;
            // 
            // 左洞行车道指示器3
            // 
            this.左洞行车道指示器3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞行车道指示器3.FlatAppearance.BorderSize = 0;
            this.左洞行车道指示器3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞行车道指示器3.ImageKey = "左指示灯.png";
            this.左洞行车道指示器3.ImageList = this.车道指示器按钮图片集;
            this.左洞行车道指示器3.Location = new System.Drawing.Point(1962, 259);
            this.左洞行车道指示器3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞行车道指示器3.Name = "左洞行车道指示器3";
            this.左洞行车道指示器3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞行车道指示器3.Size = new System.Drawing.Size(51, 49);
            this.左洞行车道指示器3.TabIndex = 21;
            this.左洞行车道指示器3.UseVisualStyleBackColor = false;
            // 
            // 左洞行车道指示器2
            // 
            this.左洞行车道指示器2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞行车道指示器2.FlatAppearance.BorderSize = 0;
            this.左洞行车道指示器2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞行车道指示器2.ImageKey = "左指示灯.png";
            this.左洞行车道指示器2.ImageList = this.车道指示器按钮图片集;
            this.左洞行车道指示器2.Location = new System.Drawing.Point(2185, 259);
            this.左洞行车道指示器2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞行车道指示器2.Name = "左洞行车道指示器2";
            this.左洞行车道指示器2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞行车道指示器2.Size = new System.Drawing.Size(51, 49);
            this.左洞行车道指示器2.TabIndex = 20;
            this.左洞行车道指示器2.UseVisualStyleBackColor = false;
            // 
            // 左洞行车道指示器1
            // 
            this.左洞行车道指示器1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞行车道指示器1.FlatAppearance.BorderSize = 0;
            this.左洞行车道指示器1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞行车道指示器1.ImageKey = "左指示灯.png";
            this.左洞行车道指示器1.ImageList = this.车道指示器按钮图片集;
            this.左洞行车道指示器1.Location = new System.Drawing.Point(2365, 259);
            this.左洞行车道指示器1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞行车道指示器1.Name = "左洞行车道指示器1";
            this.左洞行车道指示器1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞行车道指示器1.Size = new System.Drawing.Size(51, 49);
            this.左洞行车道指示器1.TabIndex = 10;
            this.左洞行车道指示器1.UseVisualStyleBackColor = false;
            // 
            // 左洞慢车道指示器9
            // 
            this.左洞慢车道指示器9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞慢车道指示器9.FlatAppearance.BorderSize = 0;
            this.左洞慢车道指示器9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞慢车道指示器9.ImageKey = "左指示灯.png";
            this.左洞慢车道指示器9.ImageList = this.车道指示器按钮图片集;
            this.左洞慢车道指示器9.Location = new System.Drawing.Point(183, 180);
            this.左洞慢车道指示器9.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞慢车道指示器9.Name = "左洞慢车道指示器9";
            this.左洞慢车道指示器9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞慢车道指示器9.Size = new System.Drawing.Size(51, 61);
            this.左洞慢车道指示器9.TabIndex = 35;
            this.左洞慢车道指示器9.UseVisualStyleBackColor = false;
            // 
            // 左洞慢车道指示器8
            // 
            this.左洞慢车道指示器8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞慢车道指示器8.FlatAppearance.BorderSize = 0;
            this.左洞慢车道指示器8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞慢车道指示器8.ImageKey = "左指示灯.png";
            this.左洞慢车道指示器8.ImageList = this.车道指示器按钮图片集;
            this.左洞慢车道指示器8.Location = new System.Drawing.Point(413, 180);
            this.左洞慢车道指示器8.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞慢车道指示器8.Name = "左洞慢车道指示器8";
            this.左洞慢车道指示器8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞慢车道指示器8.Size = new System.Drawing.Size(51, 61);
            this.左洞慢车道指示器8.TabIndex = 34;
            this.左洞慢车道指示器8.UseVisualStyleBackColor = false;
            // 
            // 左洞慢车道指示器7
            // 
            this.左洞慢车道指示器7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞慢车道指示器7.FlatAppearance.BorderSize = 0;
            this.左洞慢车道指示器7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞慢车道指示器7.ImageKey = "左指示灯.png";
            this.左洞慢车道指示器7.ImageList = this.车道指示器按钮图片集;
            this.左洞慢车道指示器7.Location = new System.Drawing.Point(689, 180);
            this.左洞慢车道指示器7.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞慢车道指示器7.Name = "左洞慢车道指示器7";
            this.左洞慢车道指示器7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞慢车道指示器7.Size = new System.Drawing.Size(51, 61);
            this.左洞慢车道指示器7.TabIndex = 33;
            this.左洞慢车道指示器7.UseVisualStyleBackColor = false;
            // 
            // 左洞慢车道指示器6
            // 
            this.左洞慢车道指示器6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞慢车道指示器6.FlatAppearance.BorderSize = 0;
            this.左洞慢车道指示器6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞慢车道指示器6.ImageKey = "左指示灯.png";
            this.左洞慢车道指示器6.ImageList = this.车道指示器按钮图片集;
            this.左洞慢车道指示器6.Location = new System.Drawing.Point(942, 180);
            this.左洞慢车道指示器6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞慢车道指示器6.Name = "左洞慢车道指示器6";
            this.左洞慢车道指示器6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞慢车道指示器6.Size = new System.Drawing.Size(51, 61);
            this.左洞慢车道指示器6.TabIndex = 32;
            this.左洞慢车道指示器6.UseVisualStyleBackColor = false;
            this.左洞慢车道指示器6.Click += new System.EventHandler(this.左洞慢车道指示器6_Click);
            // 
            // 左洞慢车道指示器5
            // 
            this.左洞慢车道指示器5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞慢车道指示器5.FlatAppearance.BorderSize = 0;
            this.左洞慢车道指示器5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞慢车道指示器5.ImageKey = "左指示灯.png";
            this.左洞慢车道指示器5.ImageList = this.车道指示器按钮图片集;
            this.左洞慢车道指示器5.Location = new System.Drawing.Point(1381, 180);
            this.左洞慢车道指示器5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞慢车道指示器5.Name = "左洞慢车道指示器5";
            this.左洞慢车道指示器5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞慢车道指示器5.Size = new System.Drawing.Size(51, 61);
            this.左洞慢车道指示器5.TabIndex = 31;
            this.左洞慢车道指示器5.UseVisualStyleBackColor = false;
            this.左洞慢车道指示器5.Click += new System.EventHandler(this.左洞慢车道指示器5_Click);
            // 
            // 左洞慢车道指示器4
            // 
            this.左洞慢车道指示器4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞慢车道指示器4.FlatAppearance.BorderSize = 0;
            this.左洞慢车道指示器4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞慢车道指示器4.ImageKey = "左指示灯.png";
            this.左洞慢车道指示器4.ImageList = this.车道指示器按钮图片集;
            this.左洞慢车道指示器4.Location = new System.Drawing.Point(1637, 180);
            this.左洞慢车道指示器4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞慢车道指示器4.Name = "左洞慢车道指示器4";
            this.左洞慢车道指示器4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞慢车道指示器4.Size = new System.Drawing.Size(51, 61);
            this.左洞慢车道指示器4.TabIndex = 30;
            this.左洞慢车道指示器4.UseVisualStyleBackColor = false;
            // 
            // 左洞慢车道指示器3
            // 
            this.左洞慢车道指示器3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞慢车道指示器3.FlatAppearance.BorderSize = 0;
            this.左洞慢车道指示器3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞慢车道指示器3.ImageKey = "左指示灯.png";
            this.左洞慢车道指示器3.ImageList = this.车道指示器按钮图片集;
            this.左洞慢车道指示器3.Location = new System.Drawing.Point(1962, 180);
            this.左洞慢车道指示器3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞慢车道指示器3.Name = "左洞慢车道指示器3";
            this.左洞慢车道指示器3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞慢车道指示器3.Size = new System.Drawing.Size(51, 61);
            this.左洞慢车道指示器3.TabIndex = 29;
            this.左洞慢车道指示器3.UseVisualStyleBackColor = false;
            // 
            // 左洞慢车道指示器2
            // 
            this.左洞慢车道指示器2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞慢车道指示器2.FlatAppearance.BorderSize = 0;
            this.左洞慢车道指示器2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞慢车道指示器2.ImageKey = "左指示灯.png";
            this.左洞慢车道指示器2.ImageList = this.车道指示器按钮图片集;
            this.左洞慢车道指示器2.Location = new System.Drawing.Point(2185, 180);
            this.左洞慢车道指示器2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞慢车道指示器2.Name = "左洞慢车道指示器2";
            this.左洞慢车道指示器2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞慢车道指示器2.Size = new System.Drawing.Size(51, 61);
            this.左洞慢车道指示器2.TabIndex = 28;
            this.左洞慢车道指示器2.UseVisualStyleBackColor = false;
            // 
            // 左洞慢车道指示器1
            // 
            this.左洞慢车道指示器1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.左洞慢车道指示器1.FlatAppearance.BorderSize = 0;
            this.左洞慢车道指示器1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.左洞慢车道指示器1.ImageKey = "左指示灯.png";
            this.左洞慢车道指示器1.ImageList = this.车道指示器按钮图片集;
            this.左洞慢车道指示器1.Location = new System.Drawing.Point(2365, 180);
            this.左洞慢车道指示器1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.左洞慢车道指示器1.Name = "左洞慢车道指示器1";
            this.左洞慢车道指示器1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞慢车道指示器1.Size = new System.Drawing.Size(51, 61);
            this.左洞慢车道指示器1.TabIndex = 9;
            this.左洞慢车道指示器1.UseVisualStyleBackColor = false;
            this.左洞慢车道指示器1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.Transparent;
            this.Background.Image = global::dbcommfc7.Properties.Resources.底图3;
            this.Background.Location = new System.Drawing.Point(26, 156);
            this.Background.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(2424, 600);
            this.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Background.TabIndex = 1;
            this.Background.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(139, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 34);
            this.label2.TabIndex = 51;
            this.label2.Text = "ZK1+205";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(358, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 34);
            this.label3.TabIndex = 52;
            this.label3.Text = "ZK1+625";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(645, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 34);
            this.label4.TabIndex = 53;
            this.label4.Text = "ZK2+115";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(904, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 34);
            this.label5.TabIndex = 54;
            this.label5.Text = "ZK2+625";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(1340, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 34);
            this.label6.TabIndex = 55;
            this.label6.Text = "ZK3+125";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(1593, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 34);
            this.label7.TabIndex = 56;
            this.label7.Text = "ZK3+625";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(1916, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 34);
            this.label8.TabIndex = 57;
            this.label8.Text = "ZK4+122";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(2141, 114);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 34);
            this.label9.TabIndex = 58;
            this.label9.Text = "ZK4+633";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(2317, 114);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 34);
            this.label10.TabIndex = 59;
            this.label10.Text = "ZK4+834";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(139, 698);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 34);
            this.label11.TabIndex = 60;
            this.label11.Text = "YK1+195";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(370, 698);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 34);
            this.label12.TabIndex = 61;
            this.label12.Text = "YK1+625";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(645, 698);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 34);
            this.label13.TabIndex = 62;
            this.label13.Text = "YK2+120";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(904, 698);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 34);
            this.label14.TabIndex = 63;
            this.label14.Text = "YK2+627";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(1340, 698);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 34);
            this.label15.TabIndex = 64;
            this.label15.Text = "YK3+127";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(1593, 698);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 34);
            this.label16.TabIndex = 65;
            this.label16.Text = "YK3+625";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(1916, 698);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 34);
            this.label17.TabIndex = 66;
            this.label17.Text = "YK4+127";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(2141, 772);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 34);
            this.label18.TabIndex = 67;
            this.label18.Text = "YK4+627";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(2317, 772);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(134, 34);
            this.label19.TabIndex = 68;
            this.label19.Text = "YK4+914";
            // 
            // LaneLightController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(2475, 1276);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.右洞超车道指示器9);
            this.Controls.Add(this.右洞超车道指示器8);
            this.Controls.Add(this.右洞超车道指示器7);
            this.Controls.Add(this.右洞超车道指示器6);
            this.Controls.Add(this.右洞超车道指示器5);
            this.Controls.Add(this.右洞超车道指示器4);
            this.Controls.Add(this.右洞超车道指示器3);
            this.Controls.Add(this.右洞超车道指示器2);
            this.Controls.Add(this.右洞超车道指示器1);
            this.Controls.Add(this.右洞行车道指示器9);
            this.Controls.Add(this.右洞行车道指示器8);
            this.Controls.Add(this.右洞行车道指示器7);
            this.Controls.Add(this.右洞行车道指示器6);
            this.Controls.Add(this.右洞行车道指示器5);
            this.Controls.Add(this.右洞行车道指示器4);
            this.Controls.Add(this.右洞行车道指示器3);
            this.Controls.Add(this.右洞行车道指示器2);
            this.Controls.Add(this.右洞行车道指示器1);
            this.Controls.Add(this.右洞慢车道指示器9);
            this.Controls.Add(this.右洞慢车道指示器8);
            this.Controls.Add(this.右洞慢车道指示器7);
            this.Controls.Add(this.右洞慢车道指示器6);
            this.Controls.Add(this.右洞慢车道指示器5);
            this.Controls.Add(this.右洞慢车道指示器4);
            this.Controls.Add(this.右洞慢车道指示器3);
            this.Controls.Add(this.右洞慢车道指示器2);
            this.Controls.Add(this.右洞慢车道指示器1);
            this.Controls.Add(this.左洞超车道指示器9);
            this.Controls.Add(this.左洞超车道指示器8);
            this.Controls.Add(this.左洞超车道指示器7);
            this.Controls.Add(this.左洞超车道指示器6);
            this.Controls.Add(this.左洞超车道指示器5);
            this.Controls.Add(this.左洞超车道指示器4);
            this.Controls.Add(this.左洞超车道指示器3);
            this.Controls.Add(this.左洞超车道指示器2);
            this.Controls.Add(this.左洞超车道指示器1);
            this.Controls.Add(this.左洞行车道指示器9);
            this.Controls.Add(this.左洞行车道指示器8);
            this.Controls.Add(this.左洞行车道指示器7);
            this.Controls.Add(this.左洞行车道指示器6);
            this.Controls.Add(this.左洞行车道指示器5);
            this.Controls.Add(this.左洞行车道指示器4);
            this.Controls.Add(this.左洞行车道指示器3);
            this.Controls.Add(this.左洞行车道指示器2);
            this.Controls.Add(this.左洞行车道指示器1);
            this.Controls.Add(this.左洞慢车道指示器9);
            this.Controls.Add(this.左洞慢车道指示器8);
            this.Controls.Add(this.左洞慢车道指示器7);
            this.Controls.Add(this.左洞慢车道指示器6);
            this.Controls.Add(this.左洞慢车道指示器5);
            this.Controls.Add(this.左洞慢车道指示器4);
            this.Controls.Add(this.左洞慢车道指示器3);
            this.Controls.Add(this.左洞慢车道指示器2);
            this.Controls.Add(this.左洞慢车道指示器1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.Background);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "LaneLightController";
            this.Text = "车道指示器控制器";
            this.Load += new System.EventHandler(this.LaneLightController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.ImageList 车道指示器按钮图片集;
        private System.Windows.Forms.Button 左洞慢车道指示器1;
        private System.Windows.Forms.Button 左洞慢车道指示器2;
        private System.Windows.Forms.Button 左洞慢车道指示器3;
        private System.Windows.Forms.Button 左洞慢车道指示器4;
        private System.Windows.Forms.Button 左洞慢车道指示器5;
        private System.Windows.Forms.Button 左洞慢车道指示器6;
        private System.Windows.Forms.Button 左洞慢车道指示器7;
        private System.Windows.Forms.Button 左洞慢车道指示器8;
        private System.Windows.Forms.Button 左洞慢车道指示器9;

        private System.Windows.Forms.Button 左洞行车道指示器1;
        private System.Windows.Forms.Button 左洞行车道指示器2;
        private System.Windows.Forms.Button 左洞行车道指示器3;
        private System.Windows.Forms.Button 左洞行车道指示器4;
        private System.Windows.Forms.Button 左洞行车道指示器5;
        private System.Windows.Forms.Button 左洞行车道指示器6;
        private System.Windows.Forms.Button 左洞行车道指示器7;
        private System.Windows.Forms.Button 左洞行车道指示器8;
        private System.Windows.Forms.Button 左洞行车道指示器9;
        private System.Windows.Forms.Button 左洞超车道指示器1;
        private System.Windows.Forms.Button 左洞超车道指示器2;
        private System.Windows.Forms.Button 左洞超车道指示器3;
        private System.Windows.Forms.Button 左洞超车道指示器4;
        private System.Windows.Forms.Button 左洞超车道指示器5;
        private System.Windows.Forms.Button 左洞超车道指示器6;
        private System.Windows.Forms.Button 左洞超车道指示器7;
        private System.Windows.Forms.Button 左洞超车道指示器8;
        private System.Windows.Forms.Button 左洞超车道指示器9;

        private System.Windows.Forms.Button 右洞慢车道指示器1;
        private System.Windows.Forms.Button 右洞慢车道指示器2;
        private System.Windows.Forms.Button 右洞慢车道指示器3;
        private System.Windows.Forms.Button 右洞慢车道指示器4;
        private System.Windows.Forms.Button 右洞慢车道指示器5;
        private System.Windows.Forms.Button 右洞慢车道指示器6;
        private System.Windows.Forms.Button 右洞慢车道指示器7;
        private System.Windows.Forms.Button 右洞慢车道指示器8;
        private System.Windows.Forms.Button 右洞慢车道指示器9;
        private System.Windows.Forms.Button 右洞行车道指示器1;
        private System.Windows.Forms.Button 右洞行车道指示器2;
        private System.Windows.Forms.Button 右洞行车道指示器3;
        private System.Windows.Forms.Button 右洞行车道指示器4;
        private System.Windows.Forms.Button 右洞行车道指示器5;
        private System.Windows.Forms.Button 右洞行车道指示器6;
        private System.Windows.Forms.Button 右洞行车道指示器7;
        private System.Windows.Forms.Button 右洞行车道指示器8;
        private System.Windows.Forms.Button 右洞行车道指示器9;
        private System.Windows.Forms.Button 右洞超车道指示器1;
        private System.Windows.Forms.Button 右洞超车道指示器2;
        private System.Windows.Forms.Button 右洞超车道指示器3;
        private System.Windows.Forms.Button 右洞超车道指示器4;
        private System.Windows.Forms.Button 右洞超车道指示器5;
        private System.Windows.Forms.Button 右洞超车道指示器6;
        private System.Windows.Forms.Button 右洞超车道指示器7;
        private System.Windows.Forms.Button 右洞超车道指示器8;
        private System.Windows.Forms.Button 右洞超车道指示器9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}

