
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace dbcommfc7
{
    partial class DBCOMTEST
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            try

            {

          

            }

            catch

            {

            };

            if (disposing)

            {

                if (components != null)

                {

                    components.Dispose();

                }

            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBCOMTEST));
            this.axDbCommOcxFC71 = new AxDBCOMMOCXLibFC7.AxDbCommOcxFC7();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtxTagCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseConnect = new System.Windows.Forms.Button();
            this.OpenRemoteConnect = new System.Windows.Forms.Button();
            this.OpenLocal = new System.Windows.Forms.Button();
            this.TexSetTimeOut = new System.Windows.Forms.TextBox();
            this.txtGetUpdateTm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TexSetUpdateTm = new System.Windows.Forms.TextBox();
            this.txtGetTimeOut = new System.Windows.Forms.TextBox();
            this.btnSetUpDateTm = new System.Windows.Forms.Button();
            this.btnGetUpDateTm = new System.Windows.Forms.Button();
            this.btnSetTimeOut = new System.Windows.Forms.Button();
            this.btnGetTimeOut = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GetAlarmData = new System.Windows.Forms.RadioButton();
            this.GetAlarmCount = new System.Windows.Forms.RadioButton();
            this.GetStatus = new System.Windows.Forms.RadioButton();
            this.txtTagVal = new System.Windows.Forms.TextBox();
            this.btnHisData = new System.Windows.Forms.Button();
            this.txtRegNO = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.DelChangeTagByNO = new System.Windows.Forms.RadioButton();
            this.DelChangeTagByName = new System.Windows.Forms.RadioButton();
            this.GetRagData = new System.Windows.Forms.RadioButton();
            this.RemoveChangeTagPars = new System.Windows.Forms.RadioButton();
            this.SetChangeTagPar = new System.Windows.Forms.RadioButton();
            this.SetData = new System.Windows.Forms.RadioButton();
            this.GetData = new System.Windows.Forms.RadioButton();
            this.GetTagTypePars = new System.Windows.Forms.RadioButton();
            this.GetTagType = new System.Windows.Forms.RadioButton();
            this.GetTagPars = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TagTypeEdit = new System.Windows.Forms.TextBox();
            this.GetTagParCount = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.GetNodeInfo = new System.Windows.Forms.RadioButton();
            this.GetNodeAllTagName = new System.Windows.Forms.RadioButton();
            this.txtTagName = new System.Windows.Forms.TextBox();
            this.NodeIDEdit = new System.Windows.Forms.TextBox();
            this.GetAllTagName = new System.Windows.Forms.RadioButton();
            this.startUDPClient = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rhTxtDataChg = new System.Windows.Forms.RichTextBox();
            this.rhTxtResult = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.receivedUDPMessage = new System.Windows.Forms.RichTextBox();
            this.sendedUDPMessage = new System.Windows.Forms.RichTextBox();
            this.SendUDPMessage = new System.Windows.Forms.Button();
            this.sendMessageRichTextboard = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnExportData = new System.Windows.Forms.Button();
            this.btnLoadSchema = new System.Windows.Forms.Button();
            this.btnExecuteSql = new System.Windows.Forms.Button();
            this.txtSql = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvSqliteData = new System.Windows.Forms.DataGridView();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSelectDb = new System.Windows.Forms.Button();
            this.txtDbPath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axDbCommOcxFC71)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSqliteData)).BeginInit();
            this.SuspendLayout();
            // 
            // axDbCommOcxFC71
            // 
            this.axDbCommOcxFC71.Enabled = true;
            this.axDbCommOcxFC71.Location = new System.Drawing.Point(609, 319);
            this.axDbCommOcxFC71.Name = "axDbCommOcxFC71";
            this.axDbCommOcxFC71.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axDbCommOcxFC71.OcxState")));
            this.axDbCommOcxFC71.Size = new System.Drawing.Size(32, 32);
            this.axDbCommOcxFC71.TabIndex = 0;
            this.axDbCommOcxFC71.DataChange += new AxDBCOMMOCXLibFC7._DDbCommOcxEventsFC7_DataChangeEventHandler(this.axDbCommOcxFC71_DataChange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtxTagCount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CloseConnect);
            this.groupBox1.Controls.Add(this.OpenRemoteConnect);
            this.groupBox1.Controls.Add(this.OpenLocal);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接";
            // 
            // txtxTagCount
            // 
            this.txtxTagCount.Enabled = false;
            this.txtxTagCount.Location = new System.Drawing.Point(66, 148);
            this.txtxTagCount.Name = "txtxTagCount";
            this.txtxTagCount.ReadOnly = true;
            this.txtxTagCount.Size = new System.Drawing.Size(49, 21);
            this.txtxTagCount.TabIndex = 13;
            this.txtxTagCount.Text = "-1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(13, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "总点数";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 21);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "2006";
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "192.168.11.240";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "远程Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "远程IP";
            // 
            // CloseConnect
            // 
            this.CloseConnect.Location = new System.Drawing.Point(10, 48);
            this.CloseConnect.Name = "CloseConnect";
            this.CloseConnect.Size = new System.Drawing.Size(74, 20);
            this.CloseConnect.TabIndex = 0;
            this.CloseConnect.Text = "关闭连接";
            this.CloseConnect.UseVisualStyleBackColor = true;
            this.CloseConnect.Click += new System.EventHandler(this.CloseConnect_Click);
            // 
            // OpenRemoteConnect
            // 
            this.OpenRemoteConnect.Location = new System.Drawing.Point(96, 22);
            this.OpenRemoteConnect.Name = "OpenRemoteConnect";
            this.OpenRemoteConnect.Size = new System.Drawing.Size(74, 20);
            this.OpenRemoteConnect.TabIndex = 0;
            this.OpenRemoteConnect.Text = "远程连接";
            this.OpenRemoteConnect.UseVisualStyleBackColor = true;
            this.OpenRemoteConnect.Click += new System.EventHandler(this.OpenRemoteConnect_Click);
            // 
            // OpenLocal
            // 
            this.OpenLocal.Location = new System.Drawing.Point(10, 22);
            this.OpenLocal.Name = "OpenLocal";
            this.OpenLocal.Size = new System.Drawing.Size(74, 20);
            this.OpenLocal.TabIndex = 0;
            this.OpenLocal.Text = "本地连接";
            this.OpenLocal.UseVisualStyleBackColor = true;
            this.OpenLocal.Click += new System.EventHandler(this.OpenLocalConnect_Click);
            // 
            // TexSetTimeOut
            // 
            this.TexSetTimeOut.Location = new System.Drawing.Point(84, 40);
            this.TexSetTimeOut.Name = "TexSetTimeOut";
            this.TexSetTimeOut.Size = new System.Drawing.Size(56, 21);
            this.TexSetTimeOut.TabIndex = 3;
            this.TexSetTimeOut.Text = "500";
            this.TexSetTimeOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TexSetTimeOut_KeyPress);
            // 
            // txtGetUpdateTm
            // 
            this.txtGetUpdateTm.Enabled = false;
            this.txtGetUpdateTm.HideSelection = false;
            this.txtGetUpdateTm.Location = new System.Drawing.Point(84, 67);
            this.txtGetUpdateTm.Name = "txtGetUpdateTm";
            this.txtGetUpdateTm.ReadOnly = true;
            this.txtGetUpdateTm.Size = new System.Drawing.Size(56, 21);
            this.txtGetUpdateTm.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(147, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "ms";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(148, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(147, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(147, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "ms";
            // 
            // TexSetUpdateTm
            // 
            this.TexSetUpdateTm.Location = new System.Drawing.Point(84, 94);
            this.TexSetUpdateTm.Name = "TexSetUpdateTm";
            this.TexSetUpdateTm.Size = new System.Drawing.Size(56, 21);
            this.TexSetUpdateTm.TabIndex = 7;
            this.TexSetUpdateTm.Text = "500";
            this.TexSetUpdateTm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TexSetUpdateTm_KeyPress);
            // 
            // txtGetTimeOut
            // 
            this.txtGetTimeOut.Enabled = false;
            this.txtGetTimeOut.HideSelection = false;
            this.txtGetTimeOut.Location = new System.Drawing.Point(84, 14);
            this.txtGetTimeOut.Name = "txtGetTimeOut";
            this.txtGetTimeOut.ReadOnly = true;
            this.txtGetTimeOut.Size = new System.Drawing.Size(56, 21);
            this.txtGetTimeOut.TabIndex = 1;
            // 
            // btnSetUpDateTm
            // 
            this.btnSetUpDateTm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSetUpDateTm.Location = new System.Drawing.Point(6, 95);
            this.btnSetUpDateTm.Name = "btnSetUpDateTm";
            this.btnSetUpDateTm.Size = new System.Drawing.Size(74, 20);
            this.btnSetUpDateTm.TabIndex = 6;
            this.btnSetUpDateTm.Text = "设更新周期";
            this.btnSetUpDateTm.UseVisualStyleBackColor = true;
            this.btnSetUpDateTm.Click += new System.EventHandler(this.btnSetUpDateTm_Click);
            // 
            // btnGetUpDateTm
            // 
            this.btnGetUpDateTm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGetUpDateTm.Location = new System.Drawing.Point(5, 68);
            this.btnGetUpDateTm.Name = "btnGetUpDateTm";
            this.btnGetUpDateTm.Size = new System.Drawing.Size(74, 20);
            this.btnGetUpDateTm.TabIndex = 4;
            this.btnGetUpDateTm.Text = "获更新周期";
            this.btnGetUpDateTm.UseVisualStyleBackColor = true;
            this.btnGetUpDateTm.Click += new System.EventHandler(this.btnGetUpDateTm_Click);
            // 
            // btnSetTimeOut
            // 
            this.btnSetTimeOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSetTimeOut.Location = new System.Drawing.Point(6, 40);
            this.btnSetTimeOut.Name = "btnSetTimeOut";
            this.btnSetTimeOut.Size = new System.Drawing.Size(73, 21);
            this.btnSetTimeOut.TabIndex = 2;
            this.btnSetTimeOut.Text = "设发送超时";
            this.btnSetTimeOut.UseVisualStyleBackColor = true;
            this.btnSetTimeOut.Click += new System.EventHandler(this.btnSetTimeOut_Click);
            // 
            // btnGetTimeOut
            // 
            this.btnGetTimeOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGetTimeOut.Location = new System.Drawing.Point(6, 15);
            this.btnGetTimeOut.Name = "btnGetTimeOut";
            this.btnGetTimeOut.Size = new System.Drawing.Size(73, 20);
            this.btnGetTimeOut.TabIndex = 0;
            this.btnGetTimeOut.Text = "获发送超时";
            this.btnGetTimeOut.UseVisualStyleBackColor = true;
            this.btnGetTimeOut.Click += new System.EventHandler(this.btnGetTimeOut_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GetAlarmData);
            this.groupBox3.Controls.Add(this.GetAlarmCount);
            this.groupBox3.Controls.Add(this.GetStatus);
            this.groupBox3.Controls.Add(this.txtTagVal);
            this.groupBox3.Controls.Add(this.btnHisData);
            this.groupBox3.Controls.Add(this.txtRegNO);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.DelChangeTagByNO);
            this.groupBox3.Controls.Add(this.DelChangeTagByName);
            this.groupBox3.Controls.Add(this.GetRagData);
            this.groupBox3.Controls.Add(this.RemoveChangeTagPars);
            this.groupBox3.Controls.Add(this.SetChangeTagPar);
            this.groupBox3.Controls.Add(this.SetData);
            this.groupBox3.Controls.Add(this.GetData);
            this.groupBox3.Controls.Add(this.GetTagTypePars);
            this.groupBox3.Controls.Add(this.GetTagType);
            this.groupBox3.Controls.Add(this.GetTagPars);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.TagTypeEdit);
            this.groupBox3.Controls.Add(this.GetTagParCount);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.GetNodeInfo);
            this.groupBox3.Controls.Add(this.GetNodeAllTagName);
            this.groupBox3.Controls.Add(this.txtTagName);
            this.groupBox3.Controls.Add(this.NodeIDEdit);
            this.groupBox3.Controls.Add(this.GetAllTagName);
            this.groupBox3.Location = new System.Drawing.Point(186, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(455, 296);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "接口函数";
            // 
            // GetAlarmData
            // 
            this.GetAlarmData.AutoSize = true;
            this.GetAlarmData.Location = new System.Drawing.Point(216, 234);
            this.GetAlarmData.Name = "GetAlarmData";
            this.GetAlarmData.Size = new System.Drawing.Size(155, 16);
            this.GetAlarmData.TabIndex = 31;
            this.GetAlarmData.TabStop = true;
            this.GetAlarmData.Text = "报警数据(GetAlarmData)";
            this.GetAlarmData.UseVisualStyleBackColor = true;
            this.GetAlarmData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GetAlarmData_MouseClick);
            // 
            // GetAlarmCount
            // 
            this.GetAlarmCount.AutoSize = true;
            this.GetAlarmCount.Location = new System.Drawing.Point(23, 236);
            this.GetAlarmCount.Name = "GetAlarmCount";
            this.GetAlarmCount.Size = new System.Drawing.Size(149, 16);
            this.GetAlarmCount.TabIndex = 30;
            this.GetAlarmCount.TabStop = true;
            this.GetAlarmCount.Text = "报警数(GetAlarmCount)";
            this.GetAlarmCount.UseVisualStyleBackColor = true;
            this.GetAlarmCount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GetAlarmCount_MouseClick);
            // 
            // GetStatus
            // 
            this.GetStatus.AutoSize = true;
            this.GetStatus.Location = new System.Drawing.Point(216, 215);
            this.GetStatus.Name = "GetStatus";
            this.GetStatus.Size = new System.Drawing.Size(185, 16);
            this.GetStatus.TabIndex = 29;
            this.GetStatus.TabStop = true;
            this.GetStatus.Text = "获取组件连接状态(GetStatus)";
            this.GetStatus.UseVisualStyleBackColor = true;
            this.GetStatus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GetStatus_MouseClick);
            // 
            // txtTagVal
            // 
            this.txtTagVal.Location = new System.Drawing.Point(314, 19);
            this.txtTagVal.Name = "txtTagVal";
            this.txtTagVal.Size = new System.Drawing.Size(70, 21);
            this.txtTagVal.TabIndex = 21;
            this.txtTagVal.Text = "0";
            this.txtTagVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTagVal_KeyPress);
            // 
            // btnHisData
            // 
            this.btnHisData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHisData.Location = new System.Drawing.Point(23, 263);
            this.btnHisData.Name = "btnHisData";
            this.btnHisData.Size = new System.Drawing.Size(102, 22);
            this.btnHisData.TabIndex = 22;
            this.btnHisData.Text = "历史";
            this.btnHisData.UseVisualStyleBackColor = true;
            this.btnHisData.Click += new System.EventHandler(this.btnHisData_Click);
            // 
            // txtRegNO
            // 
            this.txtRegNO.Location = new System.Drawing.Point(314, 46);
            this.txtRegNO.Name = "txtRegNO";
            this.txtRegNO.Size = new System.Drawing.Size(70, 21);
            this.txtRegNO.TabIndex = 20;
            this.txtRegNO.Text = "1";
            this.txtRegNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegNO_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(246, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "注册编号";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(246, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 28;
            this.label15.Text = "设置数据";
            // 
            // DelChangeTagByNO
            // 
            this.DelChangeTagByNO.AutoSize = true;
            this.DelChangeTagByNO.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DelChangeTagByNO.Location = new System.Drawing.Point(216, 195);
            this.DelChangeTagByNO.Name = "DelChangeTagByNO";
            this.DelChangeTagByNO.Size = new System.Drawing.Size(227, 16);
            this.DelChangeTagByNO.TabIndex = 15;
            this.DelChangeTagByNO.Text = "以注册编号注销点(DelChangeTagByNO)";
            this.DelChangeTagByNO.UseVisualStyleBackColor = true;
            this.DelChangeTagByNO.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DelChangeTagByNO_MouseClick);
            // 
            // DelChangeTagByName
            // 
            this.DelChangeTagByName.AutoSize = true;
            this.DelChangeTagByName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DelChangeTagByName.Location = new System.Drawing.Point(216, 176);
            this.DelChangeTagByName.Name = "DelChangeTagByName";
            this.DelChangeTagByName.Size = new System.Drawing.Size(215, 16);
            this.DelChangeTagByName.TabIndex = 14;
            this.DelChangeTagByName.Text = "以点名注销点(DelChangeTagByName)";
            this.DelChangeTagByName.UseVisualStyleBackColor = true;
            this.DelChangeTagByName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DelChangeTagByName_MouseClick);
            // 
            // GetRagData
            // 
            this.GetRagData.AutoSize = true;
            this.GetRagData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GetRagData.Location = new System.Drawing.Point(216, 138);
            this.GetRagData.Name = "GetRagData";
            this.GetRagData.Size = new System.Drawing.Size(179, 16);
            this.GetRagData.TabIndex = 13;
            this.GetRagData.Text = "获取注册点数据(GetRagData)";
            this.GetRagData.UseVisualStyleBackColor = true;
            this.GetRagData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GetRagData_MouseClick);
            // 
            // RemoveChangeTagPars
            // 
            this.RemoveChangeTagPars.AutoSize = true;
            this.RemoveChangeTagPars.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RemoveChangeTagPars.Location = new System.Drawing.Point(216, 157);
            this.RemoveChangeTagPars.Name = "RemoveChangeTagPars";
            this.RemoveChangeTagPars.Size = new System.Drawing.Size(233, 16);
            this.RemoveChangeTagPars.TabIndex = 12;
            this.RemoveChangeTagPars.Text = "注销所有注册点(RemoveChangeTagPars)";
            this.RemoveChangeTagPars.UseVisualStyleBackColor = true;
            this.RemoveChangeTagPars.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RemoveChangeTagPars_MouseClick);
            // 
            // SetChangeTagPar
            // 
            this.SetChangeTagPar.AutoSize = true;
            this.SetChangeTagPar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SetChangeTagPar.Location = new System.Drawing.Point(216, 119);
            this.SetChangeTagPar.Name = "SetChangeTagPar";
            this.SetChangeTagPar.Size = new System.Drawing.Size(233, 16);
            this.SetChangeTagPar.TabIndex = 11;
            this.SetChangeTagPar.Text = "注册数据变化通知点(SetChangeTagPar)";
            this.SetChangeTagPar.UseVisualStyleBackColor = true;
            this.SetChangeTagPar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetChangeTagPar_MouseClick);
            // 
            // SetData
            // 
            this.SetData.AutoSize = true;
            this.SetData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SetData.Location = new System.Drawing.Point(216, 100);
            this.SetData.Name = "SetData";
            this.SetData.Size = new System.Drawing.Size(125, 16);
            this.SetData.TabIndex = 10;
            this.SetData.Text = "设置数据(SetData)";
            this.SetData.UseVisualStyleBackColor = true;
            this.SetData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetData_MouseClick);
            // 
            // GetData
            // 
            this.GetData.AutoSize = true;
            this.GetData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GetData.Location = new System.Drawing.Point(216, 81);
            this.GetData.Name = "GetData";
            this.GetData.Size = new System.Drawing.Size(125, 16);
            this.GetData.TabIndex = 9;
            this.GetData.Text = "实时数据(GetData)";
            this.GetData.UseVisualStyleBackColor = true;
            this.GetData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GetData_MouseClick);
            // 
            // GetTagTypePars
            // 
            this.GetTagTypePars.AutoSize = true;
            this.GetTagTypePars.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GetTagTypePars.Location = new System.Drawing.Point(23, 176);
            this.GetTagTypePars.Name = "GetTagTypePars";
            this.GetTagTypePars.Size = new System.Drawing.Size(179, 16);
            this.GetTagTypePars.TabIndex = 8;
            this.GetTagTypePars.Text = "点类型参数(GetTagTypePars)";
            this.GetTagTypePars.UseVisualStyleBackColor = true;
            this.GetTagTypePars.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GetTagTypePars_MouseClick);
            // 
            // GetTagType
            // 
            this.GetTagType.AutoSize = true;
            this.GetTagType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GetTagType.Location = new System.Drawing.Point(23, 138);
            this.GetTagType.Name = "GetTagType";
            this.GetTagType.Size = new System.Drawing.Size(131, 16);
            this.GetTagType.TabIndex = 7;
            this.GetTagType.Text = "点类型(GetTagType)";
            this.GetTagType.UseVisualStyleBackColor = true;
            this.GetTagType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GetTagType_MouseClick);
            // 
            // GetTagPars
            // 
            this.GetTagPars.AutoSize = true;
            this.GetTagPars.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GetTagPars.Location = new System.Drawing.Point(23, 157);
            this.GetTagPars.Name = "GetTagPars";
            this.GetTagPars.Size = new System.Drawing.Size(131, 16);
            this.GetTagPars.TabIndex = 6;
            this.GetTagPars.Text = "点参数(GetTagPars)";
            this.GetTagPars.UseVisualStyleBackColor = true;
            this.GetTagPars.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GetTagPars_MouseClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(21, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 14;
            this.label13.Text = "点类型";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(21, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "点名";
            // 
            // TagTypeEdit
            // 
            this.TagTypeEdit.Location = new System.Drawing.Point(74, 66);
            this.TagTypeEdit.Name = "TagTypeEdit";
            this.TagTypeEdit.Size = new System.Drawing.Size(70, 21);
            this.TagTypeEdit.TabIndex = 18;
            this.TagTypeEdit.Text = "0";
            this.TagTypeEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TagTypeEdit_KeyPress);
            // 
            // GetTagParCount
            // 
            this.GetTagParCount.AutoSize = true;
            this.GetTagParCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GetTagParCount.Location = new System.Drawing.Point(23, 119);
            this.GetTagParCount.Name = "GetTagParCount";
            this.GetTagParCount.Size = new System.Drawing.Size(179, 16);
            this.GetTagParCount.TabIndex = 5;
            this.GetTagParCount.Text = "点参数个数(GetTagParCount)";
            this.GetTagParCount.UseVisualStyleBackColor = true;
            this.GetTagParCount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GetTagParCount_MouseClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(21, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "节点ID";
            // 
            // GetNodeInfo
            // 
            this.GetNodeInfo.AutoSize = true;
            this.GetNodeInfo.BackColor = System.Drawing.SystemColors.Control;
            this.GetNodeInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GetNodeInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GetNodeInfo.Location = new System.Drawing.Point(23, 215);
            this.GetNodeInfo.Name = "GetNodeInfo";
            this.GetNodeInfo.Size = new System.Drawing.Size(173, 16);
            this.GetNodeInfo.TabIndex = 4;
            this.GetNodeInfo.Text = "节点下点信息(GetNodeInfo)";
            this.GetNodeInfo.UseVisualStyleBackColor = false;
            this.GetNodeInfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GetNodeInfo_MouseClick);
            // 
            // GetNodeAllTagName
            // 
            this.GetNodeAllTagName.AutoSize = true;
            this.GetNodeAllTagName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GetNodeAllTagName.Location = new System.Drawing.Point(23, 195);
            this.GetNodeAllTagName.Name = "GetNodeAllTagName";
            this.GetNodeAllTagName.Size = new System.Drawing.Size(197, 16);
            this.GetNodeAllTagName.TabIndex = 2;
            this.GetNodeAllTagName.Text = "节点下点名(GetNodeAllTagName)";
            this.GetNodeAllTagName.UseVisualStyleBackColor = true;
            this.GetNodeAllTagName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GetNodeAllTagName_MouseClick);
            // 
            // txtTagName
            // 
            this.txtTagName.Location = new System.Drawing.Point(74, 20);
            this.txtTagName.Name = "txtTagName";
            this.txtTagName.Size = new System.Drawing.Size(128, 21);
            this.txtTagName.TabIndex = 16;
            this.txtTagName.Text = "a1";
            // 
            // NodeIDEdit
            // 
            this.NodeIDEdit.Location = new System.Drawing.Point(74, 43);
            this.NodeIDEdit.Name = "NodeIDEdit";
            this.NodeIDEdit.Size = new System.Drawing.Size(70, 21);
            this.NodeIDEdit.TabIndex = 17;
            this.NodeIDEdit.Text = "0";
            this.NodeIDEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NodeIDEdit_KeyPress);
            // 
            // GetAllTagName
            // 
            this.GetAllTagName.AutoSize = true;
            this.GetAllTagName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GetAllTagName.Location = new System.Drawing.Point(23, 100);
            this.GetAllTagName.Name = "GetAllTagName";
            this.GetAllTagName.Size = new System.Drawing.Size(149, 16);
            this.GetAllTagName.TabIndex = 1;
            this.GetAllTagName.Text = "总点名(GetAllTagName)";
            this.GetAllTagName.UseVisualStyleBackColor = true;
            this.GetAllTagName.CheckedChanged += new System.EventHandler(this.GetAllTagName_CheckedChanged);
            this.GetAllTagName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GetAllTagName_MouseClick);
            // 
            // startUDPClient
            // 
            this.startUDPClient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startUDPClient.Location = new System.Drawing.Point(664, 24);
            this.startUDPClient.Name = "startUDPClient";
            this.startUDPClient.Size = new System.Drawing.Size(83, 23);
            this.startUDPClient.TabIndex = 32;
            this.startUDPClient.Text = "开启UDP监听";
            this.startUDPClient.UseVisualStyleBackColor = true;
            this.startUDPClient.Click += new System.EventHandler(this.startUDPClient_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.rhTxtDataChg);
            this.groupBox4.Controls.Add(this.rhTxtResult);
            this.groupBox4.Location = new System.Drawing.Point(12, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(629, 237);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "注册点变化";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "结果";
            // 
            // rhTxtDataChg
            // 
            this.rhTxtDataChg.Location = new System.Drawing.Point(300, 42);
            this.rhTxtDataChg.Name = "rhTxtDataChg";
            this.rhTxtDataChg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rhTxtDataChg.Size = new System.Drawing.Size(291, 189);
            this.rhTxtDataChg.TabIndex = 1;
            this.rhTxtDataChg.Text = "";
            // 
            // rhTxtResult
            // 
            this.rhTxtResult.Location = new System.Drawing.Point(6, 35);
            this.rhTxtResult.Name = "rhTxtResult";
            this.rhTxtResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rhTxtResult.Size = new System.Drawing.Size(291, 189);
            this.rhTxtResult.TabIndex = 0;
            this.rhTxtResult.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSetTimeOut);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnGetUpDateTm);
            this.groupBox2.Controls.Add(this.txtGetUpdateTm);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtGetTimeOut);
            this.groupBox2.Controls.Add(this.TexSetUpdateTm);
            this.groupBox2.Controls.Add(this.TexSetTimeOut);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnGetTimeOut);
            this.groupBox2.Controls.Add(this.btnSetUpDateTm);
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 126);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // receivedUDPMessage
            // 
            this.receivedUDPMessage.Location = new System.Drawing.Point(664, 59);
            this.receivedUDPMessage.Name = "receivedUDPMessage";
            this.receivedUDPMessage.ReadOnly = true;
            this.receivedUDPMessage.Size = new System.Drawing.Size(746, 500);
            this.receivedUDPMessage.TabIndex = 33;
            this.receivedUDPMessage.Text = "";
            // 
            // sendedUDPMessage
            // 
            this.sendedUDPMessage.Location = new System.Drawing.Point(664, 598);
            this.sendedUDPMessage.Name = "sendedUDPMessage";
            this.sendedUDPMessage.Size = new System.Drawing.Size(475, 96);
            this.sendedUDPMessage.TabIndex = 34;
            this.sendedUDPMessage.Text = "";
            this.sendedUDPMessage.Visible = false;
            // 
            // SendUDPMessage
            // 
            this.SendUDPMessage.Location = new System.Drawing.Point(1278, 653);
            this.SendUDPMessage.Name = "SendUDPMessage";
            this.SendUDPMessage.Size = new System.Drawing.Size(145, 41);
            this.SendUDPMessage.TabIndex = 35;
            this.SendUDPMessage.Text = "发送数据";
            this.SendUDPMessage.UseVisualStyleBackColor = true;
            this.SendUDPMessage.Visible = false;
            this.SendUDPMessage.Click += new System.EventHandler(this.SendUDPMessage_Click);
            // 
            // sendMessageRichTextboard
            // 
            this.sendMessageRichTextboard.Location = new System.Drawing.Point(1417, 59);
            this.sendMessageRichTextboard.Name = "sendMessageRichTextboard";
            this.sendMessageRichTextboard.Size = new System.Drawing.Size(616, 500);
            this.sendMessageRichTextboard.TabIndex = 36;
            this.sendMessageRichTextboard.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnExportData);
            this.groupBox5.Controls.Add(this.btnLoadSchema);
            this.groupBox5.Controls.Add(this.btnExecuteSql);
            this.groupBox5.Controls.Add(this.txtSql);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.dgvSqliteData);
            this.groupBox5.Controls.Add(this.cmbTables);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.btnSelectDb);
            this.groupBox5.Controls.Add(this.txtDbPath);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(647, 288);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1398, 418);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SQLite 数据库读取";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "数据库文件";
            // 
            // txtDbPath
            // 
            this.txtDbPath.Location = new System.Drawing.Point(95, 25);
            this.txtDbPath.Name = "txtDbPath";
            this.txtDbPath.ReadOnly = true;
            this.txtDbPath.Size = new System.Drawing.Size(1050, 21);
            this.txtDbPath.TabIndex = 1;
            // 
            // btnSelectDb
            // 
            this.btnSelectDb.Location = new System.Drawing.Point(1160, 23);
            this.btnSelectDb.Name = "btnSelectDb";
            this.btnSelectDb.Size = new System.Drawing.Size(100, 25);
            this.btnSelectDb.TabIndex = 2;
            this.btnSelectDb.Text = "选择数据库";
            this.btnSelectDb.UseVisualStyleBackColor = true;
            this.btnSelectDb.Click += new System.EventHandler(this.btnSelectDb_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 3;
            this.label16.Text = "表名";
            // 
            // cmbTables
            // 
            this.cmbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTables.Location = new System.Drawing.Point(95, 57);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(200, 20);
            this.cmbTables.TabIndex = 4;
            this.cmbTables.SelectedIndexChanged += new System.EventHandler(this.cmbTables_SelectedIndexChanged);
            // 
            // dgvSqliteData
            // 
            this.dgvSqliteData.AllowUserToAddRows = false;
            this.dgvSqliteData.AllowUserToDeleteRows = false;
            this.dgvSqliteData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSqliteData.Location = new System.Drawing.Point(17, 95);
            this.dgvSqliteData.Name = "dgvSqliteData";
            this.dgvSqliteData.ReadOnly = true;
            this.dgvSqliteData.RowHeadersWidth = 62;
            this.dgvSqliteData.Size = new System.Drawing.Size(1360, 200);
            this.dgvSqliteData.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 310);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 6;
            this.label17.Text = "SQL 语句";
            // 
            // txtSql
            // 
            this.txtSql.Location = new System.Drawing.Point(95, 307);
            this.txtSql.Multiline = true;
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(1050, 45);
            this.txtSql.TabIndex = 7;
            // 
            // btnExecuteSql
            // 
            this.btnExecuteSql.Location = new System.Drawing.Point(1160, 305);
            this.btnExecuteSql.Name = "btnExecuteSql";
            this.btnExecuteSql.Size = new System.Drawing.Size(100, 25);
            this.btnExecuteSql.TabIndex = 8;
            this.btnExecuteSql.Text = "执行 SQL";
            this.btnExecuteSql.UseVisualStyleBackColor = true;
            this.btnExecuteSql.Click += new System.EventHandler(this.btnExecuteSql_Click);
            // 
            // btnLoadSchema
            // 
            this.btnLoadSchema.Location = new System.Drawing.Point(320, 55);
            this.btnLoadSchema.Name = "btnLoadSchema";
            this.btnLoadSchema.Size = new System.Drawing.Size(100, 25);
            this.btnLoadSchema.TabIndex = 9;
            this.btnLoadSchema.Text = "查看表结构";
            this.btnLoadSchema.UseVisualStyleBackColor = true;
            this.btnLoadSchema.Click += new System.EventHandler(this.btnLoadSchema_Click);
            // 
            // btnExportData
            // 
            this.btnExportData.Location = new System.Drawing.Point(440, 55);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(100, 25);
            this.btnExportData.TabIndex = 10;
            this.btnExportData.Text = "导出数据";
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // DBCOMTEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2045, 706);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.sendMessageRichTextboard);
            this.Controls.Add(this.SendUDPMessage);
            this.Controls.Add(this.sendedUDPMessage);
            this.Controls.Add(this.receivedUDPMessage);
            this.Controls.Add(this.startUDPClient);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.axDbCommOcxFC71);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "DBCOMTEST";
            this.Text = "大横琴山隧道消息转发平台";
            this.Closed += new System.EventHandler(this.DBCOMTEST_Closing);
            this.Load += new System.EventHandler(this.DBCOMTEST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axDbCommOcxFC71)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSqliteData)).EndInit();
            this.ResumeLayout(false);

        }


                     
        #endregion

        public AxDBCOMMOCXLibFC7.AxDbCommOcxFC7 axDbCommOcxFC71;

        //private AxDBCOMMOCXLibFC7.AxDbCommOcxFC7 axDbCommOcxFC71;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtxTagCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseConnect;
        private System.Windows.Forms.Button OpenRemoteConnect;
        private System.Windows.Forms.Button OpenLocal;
        private System.Windows.Forms.TextBox TexSetTimeOut;
        private System.Windows.Forms.TextBox txtGetUpdateTm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TexSetUpdateTm;
        private System.Windows.Forms.TextBox txtGetTimeOut;
        private System.Windows.Forms.Button btnSetUpDateTm;
        private System.Windows.Forms.Button btnGetUpDateTm;
        private System.Windows.Forms.Button btnSetTimeOut;
        private System.Windows.Forms.Button btnGetTimeOut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTagVal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRegNO;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnHisData;
        private System.Windows.Forms.RadioButton DelChangeTagByNO;
        private System.Windows.Forms.RadioButton DelChangeTagByName;
        private System.Windows.Forms.RadioButton GetRagData;
        private System.Windows.Forms.RadioButton RemoveChangeTagPars;
        private System.Windows.Forms.RadioButton SetChangeTagPar;
        private System.Windows.Forms.TextBox TagTypeEdit;
        private System.Windows.Forms.TextBox NodeIDEdit;
        private System.Windows.Forms.TextBox txtTagName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton SetData;
        private System.Windows.Forms.RadioButton GetData;
        private System.Windows.Forms.RadioButton GetTagTypePars;
        private System.Windows.Forms.RadioButton GetTagType;
        private System.Windows.Forms.RadioButton GetTagPars;
        private System.Windows.Forms.RadioButton GetTagParCount;
        private System.Windows.Forms.RadioButton GetNodeInfo;
        private System.Windows.Forms.RadioButton GetNodeAllTagName;
        private System.Windows.Forms.RadioButton GetAllTagName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rhTxtDataChg;
        private System.Windows.Forms.RichTextBox rhTxtResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton GetStatus;
        private System.Windows.Forms.RadioButton GetAlarmCount;
        private System.Windows.Forms.RadioButton GetAlarmData;
        private System.Windows.Forms.Button startUDPClient;
        private System.Windows.Forms.RichTextBox receivedUDPMessage;
        private System.Windows.Forms.RichTextBox sendedUDPMessage;
        private System.Windows.Forms.Button SendUDPMessage;
        private System.Windows.Forms.RichTextBox sendMessageRichTextboard;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.Button btnLoadSchema;
        private System.Windows.Forms.Button btnExecuteSql;
        private System.Windows.Forms.TextBox txtSql;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvSqliteData;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSelectDb;
        private System.Windows.Forms.TextBox txtDbPath;
        private System.Windows.Forms.Label label10;
    }

}