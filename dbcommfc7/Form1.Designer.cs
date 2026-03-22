namespace dbcommfc7
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InsertHisData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TagName = new System.Windows.Forms.TextBox();
            this.DataVal = new System.Windows.Forms.Label();
            this.TimeSh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.axDbCommOcxFC71 = new AxDBCOMMOCXLibFC7.AxDbCommOcxFC7();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GetHisTrace = new System.Windows.Forms.Button();
            this.GetHisData = new System.Windows.Forms.Button();
            this.rtbGetHis = new System.Windows.Forms.RichTextBox();
            this.txtGthTagName = new System.Windows.Forms.TextBox();
            this.txtDataCount = new System.Windows.Forms.TextBox();
            this.gethisendtime = new System.Windows.Forms.DateTimePicker();
            this.gethisenddata = new System.Windows.Forms.DateTimePicker();
            this.gethisstartime = new System.Windows.Forms.DateTimePicker();
            this.gethisstardata = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axDbCommOcxFC71)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsertHisData
            // 
            this.InsertHisData.Location = new System.Drawing.Point(250, 48);
            this.InsertHisData.Name = "InsertHisData";
            this.InsertHisData.Size = new System.Drawing.Size(138, 21);
            this.InsertHisData.TabIndex = 1;
            this.InsertHisData.Text = "插入(InsertHisData)";
            this.InsertHisData.UseVisualStyleBackColor = true;
            this.InsertHisData.Click += new System.EventHandler(this.InsertHisData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.TagName);
            this.groupBox1.Controls.Add(this.DataVal);
            this.groupBox1.Controls.Add(this.TimeSh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.InsertHisData);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 90);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "插入历史数据";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(161, 47);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(74, 21);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(44, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 21);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(191, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 21);
            this.textBox3.TabIndex = 5;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(321, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 21);
            this.textBox2.TabIndex = 5;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // TagName
            // 
            this.TagName.Location = new System.Drawing.Point(44, 20);
            this.TagName.Name = "TagName";
            this.TagName.Size = new System.Drawing.Size(83, 21);
            this.TagName.TabIndex = 5;
            this.TagName.Text = "a1";
            // 
            // DataVal
            // 
            this.DataVal.AutoSize = true;
            this.DataVal.Location = new System.Drawing.Point(133, 23);
            this.DataVal.Name = "DataVal";
            this.DataVal.Size = new System.Drawing.Size(53, 12);
            this.DataVal.TabIndex = 4;
            this.DataVal.Text = "历史数据";
            // 
            // TimeSh
            // 
            this.TimeSh.AutoSize = true;
            this.TimeSh.Location = new System.Drawing.Point(287, 24);
            this.TimeSh.Name = "TimeSh";
            this.TimeSh.Size = new System.Drawing.Size(29, 12);
            this.TimeSh.TabIndex = 4;
            this.TimeSh.Text = "毫秒";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "时间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "点名";
            // 
            // axDbCommOcxFC71
            // 
            this.axDbCommOcxFC71.Enabled = true;
            this.axDbCommOcxFC71.Location = new System.Drawing.Point(356, 99);
            this.axDbCommOcxFC71.Name = "axDbCommOcxFC71";
            this.axDbCommOcxFC71.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axDbCommOcxFC71.OcxState")));
            this.axDbCommOcxFC71.Size = new System.Drawing.Size(32, 32);
            this.axDbCommOcxFC71.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.axDbCommOcxFC71);
            this.groupBox2.Controls.Add(this.GetHisTrace);
            this.groupBox2.Controls.Add(this.GetHisData);
            this.groupBox2.Controls.Add(this.rtbGetHis);
            this.groupBox2.Controls.Add(this.txtGthTagName);
            this.groupBox2.Controls.Add(this.txtDataCount);
            this.groupBox2.Controls.Add(this.gethisendtime);
            this.groupBox2.Controls.Add(this.gethisenddata);
            this.groupBox2.Controls.Add(this.gethisstartime);
            this.groupBox2.Controls.Add(this.gethisstardata);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(7, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 309);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "获取历史";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "结果";
            // 
            // GetHisTrace
            // 
            this.GetHisTrace.Location = new System.Drawing.Point(213, 82);
            this.GetHisTrace.Name = "GetHisTrace";
            this.GetHisTrace.Size = new System.Drawing.Size(175, 20);
            this.GetHisTrace.TabIndex = 8;
            this.GetHisTrace.Text = "获得历史追忆(GetHisTrace)";
            this.GetHisTrace.UseVisualStyleBackColor = true;
            this.GetHisTrace.Click += new System.EventHandler(this.GetHisTrace_Click);
            // 
            // GetHisData
            // 
            this.GetHisData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GetHisData.Location = new System.Drawing.Point(10, 81);
            this.GetHisData.Name = "GetHisData";
            this.GetHisData.Size = new System.Drawing.Size(162, 21);
            this.GetHisData.TabIndex = 6;
            this.GetHisData.Text = "获得历史数据(GetHisData)";
            this.GetHisData.UseVisualStyleBackColor = true;
            this.GetHisData.Click += new System.EventHandler(this.GetHisData_Click);
            // 
            // rtbGetHis
            // 
            this.rtbGetHis.Location = new System.Drawing.Point(10, 134);
            this.rtbGetHis.Name = "rtbGetHis";
            this.rtbGetHis.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbGetHis.Size = new System.Drawing.Size(378, 163);
            this.rtbGetHis.TabIndex = 7;
            this.rtbGetHis.Text = "";
            // 
            // txtGthTagName
            // 
            this.txtGthTagName.Location = new System.Drawing.Point(325, 16);
            this.txtGthTagName.Name = "txtGthTagName";
            this.txtGthTagName.Size = new System.Drawing.Size(63, 21);
            this.txtGthTagName.TabIndex = 5;
            this.txtGthTagName.Text = "tag0_0";
            // 
            // txtDataCount
            // 
            this.txtDataCount.Location = new System.Drawing.Point(325, 43);
            this.txtDataCount.Name = "txtDataCount";
            this.txtDataCount.Size = new System.Drawing.Size(63, 21);
            this.txtDataCount.TabIndex = 4;
            this.txtDataCount.Text = "1";
            this.txtDataCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataCount_KeyPress);
            // 
            // gethisendtime
            // 
            this.gethisendtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.gethisendtime.Location = new System.Drawing.Point(186, 42);
            this.gethisendtime.Name = "gethisendtime";
            this.gethisendtime.ShowUpDown = true;
            this.gethisendtime.Size = new System.Drawing.Size(81, 21);
            this.gethisendtime.TabIndex = 3;
            // 
            // gethisenddata
            // 
            this.gethisenddata.Location = new System.Drawing.Point(71, 42);
            this.gethisenddata.Name = "gethisenddata";
            this.gethisenddata.ShowUpDown = true;
            this.gethisenddata.Size = new System.Drawing.Size(109, 21);
            this.gethisenddata.TabIndex = 2;
            // 
            // gethisstartime
            // 
            this.gethisstartime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.gethisstartime.Location = new System.Drawing.Point(186, 17);
            this.gethisstartime.Name = "gethisstartime";
            this.gethisstartime.ShowUpDown = true;
            this.gethisstartime.Size = new System.Drawing.Size(81, 21);
            this.gethisstartime.TabIndex = 1;
            // 
            // gethisstardata
            // 
            this.gethisstardata.Location = new System.Drawing.Point(71, 17);
            this.gethisstardata.Name = "gethisstardata";
            this.gethisstardata.ShowUpDown = true;
            this.gethisstardata.Size = new System.Drawing.Size(109, 21);
            this.gethisstardata.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(276, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "点名";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(271, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "数据计数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(8, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "结束时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(8, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "起始时间";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 414);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "HisDate";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axDbCommOcxFC71)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InsertHisData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TagName;
        private System.Windows.Forms.Label DataVal;
        private System.Windows.Forms.Label TimeSh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public AxDBCOMMOCXLibFC7.AxDbCommOcxFC7 axDbCommOcxFC71;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GetHisData;
        private System.Windows.Forms.RichTextBox rtbGetHis;
        private System.Windows.Forms.TextBox txtGthTagName;
        private System.Windows.Forms.TextBox txtDataCount;
        private System.Windows.Forms.DateTimePicker gethisendtime;
        private System.Windows.Forms.DateTimePicker gethisenddata;
        private System.Windows.Forms.DateTimePicker gethisstartime;
        private System.Windows.Forms.DateTimePicker gethisstardata;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GetHisTrace;
        private System.Windows.Forms.Label label3;
    }
}

