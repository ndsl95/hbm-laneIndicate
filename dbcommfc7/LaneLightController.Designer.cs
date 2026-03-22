
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
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.SuspendLayout();
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(957, 445);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.logTextBox.Size = new System.Drawing.Size(381, 199);
            this.logTextBox.TabIndex = 0;
            this.logTextBox.Text = "";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 707);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(65, 12);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "状态：就绪";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.richTextBox1.Location = new System.Drawing.Point(14, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(175, 50);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "左洞出口";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBox2.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox2.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox2.Location = new System.Drawing.Point(1163, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(175, 50);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "左洞入口";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBox3.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.richTextBox3.Location = new System.Drawing.Point(1164, 383);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(175, 50);
            this.richTextBox3.TabIndex = 8;
            this.richTextBox3.Text = "右洞出口";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBox4.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox4.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox4.Location = new System.Drawing.Point(14, 383);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(175, 50);
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
            this.右洞超车道指示器9.Location = new System.Drawing.Point(100, 223);
            this.右洞超车道指示器9.Name = "右洞超车道指示器9";
            this.右洞超车道指示器9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞超车道指示器9.Size = new System.Drawing.Size(28, 28);
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
            this.右洞超车道指示器8.Location = new System.Drawing.Point(225, 223);
            this.右洞超车道指示器8.Name = "右洞超车道指示器8";
            this.右洞超车道指示器8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞超车道指示器8.Size = new System.Drawing.Size(28, 28);
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
            this.右洞超车道指示器7.Location = new System.Drawing.Point(376, 223);
            this.右洞超车道指示器7.Name = "右洞超车道指示器7";
            this.右洞超车道指示器7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞超车道指示器7.Size = new System.Drawing.Size(28, 28);
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
            this.右洞超车道指示器6.Location = new System.Drawing.Point(514, 223);
            this.右洞超车道指示器6.Name = "右洞超车道指示器6";
            this.右洞超车道指示器6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞超车道指示器6.Size = new System.Drawing.Size(28, 28);
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
            this.右洞超车道指示器5.Location = new System.Drawing.Point(721, 223);
            this.右洞超车道指示器5.Name = "右洞超车道指示器5";
            this.右洞超车道指示器5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞超车道指示器5.Size = new System.Drawing.Size(28, 28);
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
            this.右洞超车道指示器4.Location = new System.Drawing.Point(875, 223);
            this.右洞超车道指示器4.Name = "右洞超车道指示器4";
            this.右洞超车道指示器4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞超车道指示器4.Size = new System.Drawing.Size(28, 28);
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
            this.右洞超车道指示器3.Location = new System.Drawing.Point(1068, 223);
            this.右洞超车道指示器3.Name = "右洞超车道指示器3";
            this.右洞超车道指示器3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞超车道指示器3.Size = new System.Drawing.Size(28, 28);
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
            this.右洞超车道指示器2.Location = new System.Drawing.Point(1192, 223);
            this.右洞超车道指示器2.Name = "右洞超车道指示器2";
            this.右洞超车道指示器2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞超车道指示器2.Size = new System.Drawing.Size(28, 28);
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
            this.右洞超车道指示器1.Location = new System.Drawing.Point(1290, 223);
            this.右洞超车道指示器1.Name = "右洞超车道指示器1";
            this.右洞超车道指示器1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞超车道指示器1.Size = new System.Drawing.Size(28, 35);
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
            this.右洞行车道指示器9.Location = new System.Drawing.Point(100, 261);
            this.右洞行车道指示器9.Name = "右洞行车道指示器9";
            this.右洞行车道指示器9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞行车道指示器9.Size = new System.Drawing.Size(28, 28);
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
            this.右洞行车道指示器8.Location = new System.Drawing.Point(225, 261);
            this.右洞行车道指示器8.Name = "右洞行车道指示器8";
            this.右洞行车道指示器8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞行车道指示器8.Size = new System.Drawing.Size(28, 28);
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
            this.右洞行车道指示器7.Location = new System.Drawing.Point(376, 261);
            this.右洞行车道指示器7.Name = "右洞行车道指示器7";
            this.右洞行车道指示器7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞行车道指示器7.Size = new System.Drawing.Size(28, 28);
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
            this.右洞行车道指示器6.Location = new System.Drawing.Point(514, 261);
            this.右洞行车道指示器6.Name = "右洞行车道指示器6";
            this.右洞行车道指示器6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞行车道指示器6.Size = new System.Drawing.Size(28, 28);
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
            this.右洞行车道指示器5.Location = new System.Drawing.Point(721, 261);
            this.右洞行车道指示器5.Name = "右洞行车道指示器5";
            this.右洞行车道指示器5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞行车道指示器5.Size = new System.Drawing.Size(28, 28);
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
            this.右洞行车道指示器4.Location = new System.Drawing.Point(875, 261);
            this.右洞行车道指示器4.Name = "右洞行车道指示器4";
            this.右洞行车道指示器4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞行车道指示器4.Size = new System.Drawing.Size(28, 28);
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
            this.右洞行车道指示器3.Location = new System.Drawing.Point(1068, 261);
            this.右洞行车道指示器3.Name = "右洞行车道指示器3";
            this.右洞行车道指示器3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞行车道指示器3.Size = new System.Drawing.Size(28, 28);
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
            this.右洞行车道指示器2.Location = new System.Drawing.Point(1192, 261);
            this.右洞行车道指示器2.Name = "右洞行车道指示器2";
            this.右洞行车道指示器2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞行车道指示器2.Size = new System.Drawing.Size(28, 28);
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
            this.右洞行车道指示器1.Location = new System.Drawing.Point(1290, 261);
            this.右洞行车道指示器1.Name = "右洞行车道指示器1";
            this.右洞行车道指示器1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞行车道指示器1.Size = new System.Drawing.Size(28, 28);
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
            this.右洞慢车道指示器9.Location = new System.Drawing.Point(100, 296);
            this.右洞慢车道指示器9.Name = "右洞慢车道指示器9";
            this.右洞慢车道指示器9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞慢车道指示器9.Size = new System.Drawing.Size(28, 28);
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
            this.右洞慢车道指示器8.Location = new System.Drawing.Point(225, 296);
            this.右洞慢车道指示器8.Name = "右洞慢车道指示器8";
            this.右洞慢车道指示器8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞慢车道指示器8.Size = new System.Drawing.Size(28, 28);
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
            this.右洞慢车道指示器7.Location = new System.Drawing.Point(376, 296);
            this.右洞慢车道指示器7.Name = "右洞慢车道指示器7";
            this.右洞慢车道指示器7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞慢车道指示器7.Size = new System.Drawing.Size(28, 28);
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
            this.右洞慢车道指示器6.Location = new System.Drawing.Point(514, 296);
            this.右洞慢车道指示器6.Name = "右洞慢车道指示器6";
            this.右洞慢车道指示器6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞慢车道指示器6.Size = new System.Drawing.Size(28, 28);
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
            this.右洞慢车道指示器5.Location = new System.Drawing.Point(721, 296);
            this.右洞慢车道指示器5.Name = "右洞慢车道指示器5";
            this.右洞慢车道指示器5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞慢车道指示器5.Size = new System.Drawing.Size(28, 28);
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
            this.右洞慢车道指示器4.Location = new System.Drawing.Point(875, 296);
            this.右洞慢车道指示器4.Name = "右洞慢车道指示器4";
            this.右洞慢车道指示器4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞慢车道指示器4.Size = new System.Drawing.Size(28, 28);
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
            this.右洞慢车道指示器3.Location = new System.Drawing.Point(1068, 296);
            this.右洞慢车道指示器3.Name = "右洞慢车道指示器3";
            this.右洞慢车道指示器3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞慢车道指示器3.Size = new System.Drawing.Size(28, 28);
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
            this.右洞慢车道指示器2.Location = new System.Drawing.Point(1192, 296);
            this.右洞慢车道指示器2.Name = "右洞慢车道指示器2";
            this.右洞慢车道指示器2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞慢车道指示器2.Size = new System.Drawing.Size(28, 28);
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
            this.右洞慢车道指示器1.Location = new System.Drawing.Point(1290, 296);
            this.右洞慢车道指示器1.Name = "右洞慢车道指示器1";
            this.右洞慢车道指示器1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.右洞慢车道指示器1.Size = new System.Drawing.Size(28, 28);
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
            this.左洞超车道指示器9.Location = new System.Drawing.Point(100, 149);
            this.左洞超车道指示器9.Name = "左洞超车道指示器9";
            this.左洞超车道指示器9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞超车道指示器9.Size = new System.Drawing.Size(28, 28);
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
            this.左洞超车道指示器8.Location = new System.Drawing.Point(225, 149);
            this.左洞超车道指示器8.Name = "左洞超车道指示器8";
            this.左洞超车道指示器8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞超车道指示器8.Size = new System.Drawing.Size(28, 28);
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
            this.左洞超车道指示器7.Location = new System.Drawing.Point(376, 149);
            this.左洞超车道指示器7.Name = "左洞超车道指示器7";
            this.左洞超车道指示器7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞超车道指示器7.Size = new System.Drawing.Size(28, 28);
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
            this.左洞超车道指示器6.Location = new System.Drawing.Point(514, 149);
            this.左洞超车道指示器6.Name = "左洞超车道指示器6";
            this.左洞超车道指示器6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞超车道指示器6.Size = new System.Drawing.Size(28, 28);
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
            this.左洞超车道指示器5.Location = new System.Drawing.Point(721, 149);
            this.左洞超车道指示器5.Name = "左洞超车道指示器5";
            this.左洞超车道指示器5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞超车道指示器5.Size = new System.Drawing.Size(28, 28);
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
            this.左洞超车道指示器4.Location = new System.Drawing.Point(875, 149);
            this.左洞超车道指示器4.Name = "左洞超车道指示器4";
            this.左洞超车道指示器4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞超车道指示器4.Size = new System.Drawing.Size(28, 28);
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
            this.左洞超车道指示器3.Location = new System.Drawing.Point(1088, 149);
            this.左洞超车道指示器3.Name = "左洞超车道指示器3";
            this.左洞超车道指示器3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞超车道指示器3.Size = new System.Drawing.Size(28, 28);
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
            this.左洞超车道指示器2.Location = new System.Drawing.Point(1192, 149);
            this.左洞超车道指示器2.Name = "左洞超车道指示器2";
            this.左洞超车道指示器2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞超车道指示器2.Size = new System.Drawing.Size(28, 28);
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
            this.左洞超车道指示器1.Location = new System.Drawing.Point(1290, 149);
            this.左洞超车道指示器1.Name = "左洞超车道指示器1";
            this.左洞超车道指示器1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞超车道指示器1.Size = new System.Drawing.Size(28, 28);
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
            this.左洞行车道指示器9.Location = new System.Drawing.Point(100, 114);
            this.左洞行车道指示器9.Name = "左洞行车道指示器9";
            this.左洞行车道指示器9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞行车道指示器9.Size = new System.Drawing.Size(28, 28);
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
            this.左洞行车道指示器8.Location = new System.Drawing.Point(225, 114);
            this.左洞行车道指示器8.Name = "左洞行车道指示器8";
            this.左洞行车道指示器8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞行车道指示器8.Size = new System.Drawing.Size(28, 28);
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
            this.左洞行车道指示器7.Location = new System.Drawing.Point(376, 114);
            this.左洞行车道指示器7.Name = "左洞行车道指示器7";
            this.左洞行车道指示器7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞行车道指示器7.Size = new System.Drawing.Size(28, 28);
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
            this.左洞行车道指示器6.Location = new System.Drawing.Point(514, 114);
            this.左洞行车道指示器6.Name = "左洞行车道指示器6";
            this.左洞行车道指示器6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞行车道指示器6.Size = new System.Drawing.Size(28, 28);
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
            this.左洞行车道指示器5.Location = new System.Drawing.Point(721, 114);
            this.左洞行车道指示器5.Name = "左洞行车道指示器5";
            this.左洞行车道指示器5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞行车道指示器5.Size = new System.Drawing.Size(28, 28);
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
            this.左洞行车道指示器4.Location = new System.Drawing.Point(875, 114);
            this.左洞行车道指示器4.Name = "左洞行车道指示器4";
            this.左洞行车道指示器4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞行车道指示器4.Size = new System.Drawing.Size(28, 28);
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
            this.左洞行车道指示器3.Location = new System.Drawing.Point(1088, 114);
            this.左洞行车道指示器3.Name = "左洞行车道指示器3";
            this.左洞行车道指示器3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞行车道指示器3.Size = new System.Drawing.Size(28, 28);
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
            this.左洞行车道指示器2.Location = new System.Drawing.Point(1192, 114);
            this.左洞行车道指示器2.Name = "左洞行车道指示器2";
            this.左洞行车道指示器2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞行车道指示器2.Size = new System.Drawing.Size(28, 28);
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
            this.左洞行车道指示器1.Location = new System.Drawing.Point(1290, 114);
            this.左洞行车道指示器1.Name = "左洞行车道指示器1";
            this.左洞行车道指示器1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞行车道指示器1.Size = new System.Drawing.Size(28, 28);
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
            this.左洞慢车道指示器9.Location = new System.Drawing.Point(100, 76);
            this.左洞慢车道指示器9.Name = "左洞慢车道指示器9";
            this.左洞慢车道指示器9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞慢车道指示器9.Size = new System.Drawing.Size(28, 35);
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
            this.左洞慢车道指示器8.Location = new System.Drawing.Point(225, 76);
            this.左洞慢车道指示器8.Name = "左洞慢车道指示器8";
            this.左洞慢车道指示器8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞慢车道指示器8.Size = new System.Drawing.Size(28, 35);
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
            this.左洞慢车道指示器7.Location = new System.Drawing.Point(376, 76);
            this.左洞慢车道指示器7.Name = "左洞慢车道指示器7";
            this.左洞慢车道指示器7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞慢车道指示器7.Size = new System.Drawing.Size(28, 35);
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
            this.左洞慢车道指示器6.Location = new System.Drawing.Point(514, 76);
            this.左洞慢车道指示器6.Name = "左洞慢车道指示器6";
            this.左洞慢车道指示器6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞慢车道指示器6.Size = new System.Drawing.Size(28, 35);
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
            this.左洞慢车道指示器5.Location = new System.Drawing.Point(721, 76);
            this.左洞慢车道指示器5.Name = "左洞慢车道指示器5";
            this.左洞慢车道指示器5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞慢车道指示器5.Size = new System.Drawing.Size(28, 35);
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
            this.左洞慢车道指示器4.Location = new System.Drawing.Point(875, 76);
            this.左洞慢车道指示器4.Name = "左洞慢车道指示器4";
            this.左洞慢车道指示器4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞慢车道指示器4.Size = new System.Drawing.Size(28, 35);
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
            this.左洞慢车道指示器3.Location = new System.Drawing.Point(1088, 76);
            this.左洞慢车道指示器3.Name = "左洞慢车道指示器3";
            this.左洞慢车道指示器3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞慢车道指示器3.Size = new System.Drawing.Size(28, 35);
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
            this.左洞慢车道指示器2.Location = new System.Drawing.Point(1192, 76);
            this.左洞慢车道指示器2.Name = "左洞慢车道指示器2";
            this.左洞慢车道指示器2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞慢车道指示器2.Size = new System.Drawing.Size(28, 35);
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
            this.左洞慢车道指示器1.Location = new System.Drawing.Point(1290, 76);
            this.左洞慢车道指示器1.Name = "左洞慢车道指示器1";
            this.左洞慢车道指示器1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.左洞慢车道指示器1.Size = new System.Drawing.Size(28, 35);
            this.左洞慢车道指示器1.TabIndex = 9;
            this.左洞慢车道指示器1.UseVisualStyleBackColor = false;
            this.左洞慢车道指示器1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.Transparent;
            this.Background.Image = global::dbcommfc7.Properties.Resources.底图2;
            this.Background.Location = new System.Drawing.Point(35, 66);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1241, 320);
            this.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Background.TabIndex = 1;
            this.Background.TabStop = false;
            // 
            // LaneLightController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1350, 729);
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
    }
}

