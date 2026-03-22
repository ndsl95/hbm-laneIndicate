using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;

using System.Threading;
using System.IO;

namespace dbcommfc7
{
    public partial class DBCOMTEST : Form
    {
        bool bConnState = false;

        public Thread messageHandleThread;

        private SQLiteHelper sqliteHelper;
        private string currentDbPath;

        public DBCOMTEST()
        {
            InitializeComponent();
        }
        ~DBCOMTEST()
        {
            client.Close();
        }

        /// <summary>
        /// 接收和发送的消息
        /// </summary>
        public class UDPMessage
        {
            public MessageType type;
            public string identify;
            public string tag;
            public string value;


            public enum MessageType
            {
                GetData,
                SetData,
                GetDataResult,
                SetDataResult
            }

            public UDPMessage()
            {

            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="_type">接收的类型为GetData、SetData 发送出去设置的类型为GetDataResult SetDataResult</param>
            /// <param name="_tag">点名</param>
            /// <param name="_value">值名</param>
            public UDPMessage(MessageType _type, string _identify, string _tag, string _value)
            {
                type = _type;
                tag = _tag;
                value = _value;
                identify = _identify;
            }

            public UDPMessage(MessageType _type,string _tag,string _value)
            {
                type = _type;
                tag = _tag;
                value = _value;
            }
        }

 



        #region SDK自带函数
        private void OpenLocalConnect_Click(object sender, EventArgs e)
        {
            OpenLocalConnectFunc();
        }

        private void OpenLocalConnectFunc()
        {
            if (bConnState)
            {
                MessageBox.Show("已经有连接！");
                return;
            }
            int iConn = axDbCommOcxFC71.OpenLocalConnect();
            System.Threading.Thread.Sleep(600);
            bConnState = axDbCommOcxFC71.IsConnected();
            if ((iConn > 0) & bConnState)
            {
                rhTxtResult.Text = "本地连接成功！";
            }
            else
            {
                rhTxtResult.Text = "本地连接失败！";
            }
            int iTagCount = axDbCommOcxFC71.GetAllTagCount();
            txtxTagCount.Text = iTagCount.ToString();
        }

        private void OpenRemoteConnect_Click(object sender, EventArgs e)
        {
            if (bConnState)
            {
                MessageBox.Show("已经有连接！");
                return;
            }
            string remoteaddr = textBox1.Text;
            int RemotePortNo = Convert.ToInt32(textBox2.Text);
            string LocalAddr = "";
            int iRemoteConn = axDbCommOcxFC71.OpenRemoteConnect(ref remoteaddr, RemotePortNo, ref LocalAddr, 0);
            System.Threading.Thread.Sleep(600);
            bConnState = axDbCommOcxFC71.IsConnected();
            if ((iRemoteConn) > 0 & bConnState)
            {
                rhTxtResult.Text = "远程连接成功！";
            }
            else
            {
                rhTxtResult.Text = "远程连接失败！";
            }
            int iTagCount = axDbCommOcxFC71.GetAllTagCount();
            txtxTagCount.Text = iTagCount.ToString();
        }

        private void CloseConnect_Click(object sender, EventArgs e)
        {
            axDbCommOcxFC71.CloseConnect();
            System.Threading.Thread.Sleep(600);
            bConnState = axDbCommOcxFC71.IsConnected();
            if (bConnState == false)
            {
                rhTxtResult.Text = "断开连接成功！";
                int iTagCount = axDbCommOcxFC71.GetAllTagCount();
                txtxTagCount.Text = iTagCount.ToString();
            }
            else
            {
                rhTxtResult.Text = "断开连接失败！";
            }
        }

        private void GetAllTagName_MouseClick(object sender, MouseEventArgs e)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                return;
            }
            object objalltagname = axDbCommOcxFC71.GetAllTagName();
            if (objalltagname == null)
            {
                rhTxtResult.Text = "获取失败!";
            }
            else
            {
                txtTagName.BackColor = System.Drawing.Color.White;
                rhTxtResult.Text = "获取成功!";
                object[] objTemp = (object[])objalltagname;

                string result = "";
                for (int i = 0; i < objTemp.Length; i++)
                {
                    rhTxtResult.AppendText("\r\n");
                    rhTxtResult.AppendText(objTemp[i].ToString());
                    result += objTemp[i].ToString() + "|" + "\r\n";
                }
                SendMsgToClient(result);
            }
        }

        private void GetTagParCount_MouseClick(object sender, MouseEventArgs e)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                return;
            }

            string strTemp = txtTagName.Text;

            int iParCount = axDbCommOcxFC71.GetTagParCount(ref strTemp);
            if (iParCount == 0)
            {
                rhTxtResult.Text = "获取失败!";
                txtTagName.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("请检查你输入的点名参数！");
            }
            else
            {
                txtTagName.BackColor = System.Drawing.Color.White;
                rhTxtResult.Text = "获取成功!";
                rhTxtResult.AppendText("\r\n点参数类型个数为:");
                rhTxtResult.AppendText(iParCount.ToString());
            }
        }

        private void GetTagType_MouseClick(object sender, MouseEventArgs e)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                return;
            }
            string strTemp = txtTagName.Text;
            int iTagType = axDbCommOcxFC71.GetTagType(ref strTemp);
            if (iTagType < 0)
            {
                txtTagName.BackColor = System.Drawing.Color.Red;
                rhTxtResult.Text = "获取失败!";
            }
            else
            {
                txtTagName.BackColor = System.Drawing.Color.White;
                string cTemp;
                cTemp = "获取成功!\r\n点类型为：" + iTagType.ToString() + "\r\n";
                cTemp = cTemp + "说明：-1 表示获取失败，0 模拟I/O点，1  数字I/O点,";
                cTemp = cTemp + "2 累计点，3 控制点，4 运算点，5 组合点，6 雪崩过滤点";
                rhTxtResult.Text = cTemp;
            }
        }

        private void GetTagPars_MouseClick(object sender, MouseEventArgs e)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                return;
            }
            string strTemp = txtTagName.Text;
            object objPars = axDbCommOcxFC71.GetTagPars(ref strTemp);
            if (objPars == null)
            {
                txtTagName.BackColor = System.Drawing.Color.Red;
                rhTxtResult.Text = "获取失败!";
            }
            else
            {
                txtTagName.BackColor = System.Drawing.Color.White;
                string cTemp = "获取成功!\r\n";
                object[,] objTemp = (object[,])objPars;
                for (int i = 0; i < objTemp.Length / 3; i++)
                {
                    cTemp = cTemp + "参数" + Convert.ToString(i + 1) + ":";
                    string Tem = "";
                    for (int j = 0; j < 3; j++)//3元素
                    {
                        switch (j)
                        {
                            case 0: Tem = Tem + "序号："; break;
                            case 1: Tem = Tem + "名称："; break;
                            case 2: Tem = Tem + "类型："; break;
                            default: break;
                        }
                        Tem = Tem + objTemp[i, j].ToString() + " ; ";
                    }
                    cTemp = cTemp + Tem + "\r\n";
                }
                rhTxtResult.Text = cTemp;
            }
        }

        private void GetTagTypePars_MouseClick(object sender, MouseEventArgs e)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                return;
            }

            int iTagType = Convert.ToUInt16(TagTypeEdit.Text);
            object objTypePars = axDbCommOcxFC71.GetTagTypePars(iTagType);
            if (objTypePars == null)
            {
                TagTypeEdit.BackColor = System.Drawing.Color.Red;
                rhTxtResult.Text = "获取失败!";
            }
            else
            {
                TagTypeEdit.BackColor = System.Drawing.Color.White;
                string cTemp = "获取成功!\r\n";
                object[,] objTemp = (object[,])objTypePars;//2维
                for (int i = 0; i < (objTemp.Length / 3); i++)
                {
                    cTemp = cTemp + "参数" + Convert.ToString(i + 1) + ":";
                    string Tem = "";
                    for (int j = 0; j < 3; j++)
                    {
                        switch (j)
                        {
                            case 0: Tem = Tem + "序号："; break;
                            case 1: Tem = Tem + "名称："; break;
                            case 2: Tem = Tem + "类型："; break;
                            default: break;
                        }
                        Tem = Tem + objTemp[i, j].ToString() + " ; ";
                    }
                    cTemp = cTemp + Tem + "\r\n";
                }
                rhTxtResult.Text = cTemp;
            }
        }

        private void GetNodeAllTagName_MouseClick(object sender, MouseEventArgs e)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                return;
            }
            int iAreaNO = Convert.ToUInt16(NodeIDEdit.Text);
            object objAllTagName = axDbCommOcxFC71.GetNodeAllTagName(iAreaNO);
            if (objAllTagName == null)
            {
                NodeIDEdit.BackColor = System.Drawing.Color.Red;
                rhTxtResult.Text = "获取失败!";
            }
            else
            {
                NodeIDEdit.BackColor = System.Drawing.Color.White;
                rhTxtResult.Text = "获取成功!";

                object[] objTemp = (object[])objAllTagName;
                for (int i = 0; i < objTemp.Length; i++)
                {
                    rhTxtResult.AppendText("\r\n");
                    rhTxtResult.AppendText(objTemp[i].ToString());
                }
            }
        }

        private void GetNodeInfo_MouseClick(object sender, MouseEventArgs e)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                return;
            }

            int iAreaNO = Convert.ToUInt16(NodeIDEdit.Text);
            object objNodeInfo = axDbCommOcxFC71.GetNodeInfo(iAreaNO);
            if (objNodeInfo == null)
            {
                NodeIDEdit.BackColor = System.Drawing.Color.Red;
                rhTxtResult.Text = "获取失败!";
            }
            else
            {
                NodeIDEdit.BackColor = System.Drawing.Color.White;
                string cTemp = "获取成功!\r\n";

                object[] objTemp = (object[])objNodeInfo;
                cTemp = cTemp + "该节点下有：" + objTemp.Length + "种类型\r\n";
                for (int i = 0; i < objTemp.Length; i++)
                {
                    cTemp = cTemp + "KIND" + Convert.ToString(i + 1) + " = ";
                    cTemp = cTemp + objTemp[i].ToString() + "\r\n";
                }
                rhTxtResult.Text = cTemp + "说明：0模拟I/O点,1数字I/O点,2累计点,3控制点,4运算点,5组合点,6雪崩过滤点";

            }
        }

        private void GetData_MouseClick(object sender, MouseEventArgs e)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                return;
            }

            object objtagname = (object)txtTagName.Text;
            GetDataFunc((string)objtagname);
        }

        private void SetData_MouseClick(object sender, MouseEventArgs e)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                return;
            }

            string tagName = txtTagName.Text;
            string tagValue = txtTagVal.Text;
            SetDataFunc(tagName, tagValue);       
            
        }

        private void SetChangeTagPar_MouseClick(object sender, MouseEventArgs e)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                return;
            }

            object objRegTag = (object)txtTagName.Text;
            object objChange = axDbCommOcxFC71.SetChangeTagPars(objRegTag);
            if (objChange == null)
            {
                txtTagName.BackColor = System.Drawing.Color.Red;
                rhTxtResult.Text = "注册失败!";
            }
            else
            {
                txtTagName.BackColor = System.Drawing.Color.White;
                rhTxtResult.Text = "注册成功!\r\n";
                object[] objTemp = (object[])objChange;
                rhTxtResult.Text = rhTxtResult.Text + "注册编号：" + objTemp[0].ToString() + "\r\n";
                rhTxtResult.Text = rhTxtResult.Text + "说明：点名不带参数时，默认为PV";
            }
        }

        private void GetRagData_MouseClick(object sender, MouseEventArgs e)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                return;
            }

            object objTagName = (object)txtTagName.Text;
            object objTagVal = axDbCommOcxFC71.GetRegData(objTagName);

            if (objTagVal == null)
            {
                txtTagName.BackColor = System.Drawing.Color.Red;
                rhTxtResult.Text = "获取失败!";
            }
            else
            {
                txtTagName.BackColor = System.Drawing.Color.White;
                rhTxtResult.Text = "获取成功!\r\n";
                object[] objTemp = (object[])objTagVal;
                rhTxtResult.Text = rhTxtResult.Text + txtTagName.Text + " = " + objTemp[0].ToString();
                rhTxtResult.Text = rhTxtResult.Text + "\r\n说明：点名不带参数时，默认为PV";
            }
        }

        private void RemoveChangeTagPars_MouseClick(object sender, MouseEventArgs e)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                return;
            }
            bool bRemove = axDbCommOcxFC71.RemoveChangeTagPars();

            if (bRemove)
            {
                rhTxtResult.Text = "注销成功!";
            }
            else
            {
                rhTxtResult.Text = "注销失败!";
            }
        }

        private void DelChangeTagByName_MouseClick(object sender, MouseEventArgs e)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                return;
            }
            object objTagName = (object)txtTagName.Text;
            int iDelName = axDbCommOcxFC71.DelChangeTagParsByName(objTagName);

            if (iDelName <= 0)
            {
                txtTagName.BackColor = System.Drawing.Color.Red;
                rhTxtResult.Text = "注销失败!";
            }
            else
            {
                txtTagName.BackColor = System.Drawing.Color.White;
                rhTxtResult.Text = "注销成功!";
                rhTxtResult.AppendText("\r\n注销点数：");
                rhTxtResult.AppendText(iDelName.ToString());
            }
        }

        private void DelChangeTagByNO_MouseClick(object sender, MouseEventArgs e)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                return;
            }

            object objRagNO = (object)Convert.ToInt32(txtRegNO.Text);
            int iDelNO = axDbCommOcxFC71.DelChangeTagParsByRegNo(objRagNO);
            if (iDelNO <= 0)
            {
                txtRegNO.BackColor = System.Drawing.Color.Red;
                rhTxtResult.Text = "注销失败!";
            }
            else
            {
                txtRegNO.BackColor = System.Drawing.Color.White;
                rhTxtResult.Text = "注销成功!";
                rhTxtResult.AppendText("\r\n注销点个数：");
                rhTxtResult.AppendText(iDelNO.ToString());
            }
        }

        private void GetStatus_MouseClick(object sender, MouseEventArgs e)
        {
            string cTemp;
            int Statue = axDbCommOcxFC71.GetStatus();
            cTemp = "状态值 = " + Statue.ToString() + "\r\n";
            switch (Statue)
            {
                case 0: cTemp = cTemp + "已连接上！\r\n"; break;
                case 1: cTemp = cTemp + "没有连接！\r\n"; break;
                case 2: cTemp = cTemp + "初始化！\r\n"; break;
                case 3: cTemp = cTemp + "显示连接！\r\n"; break;
                case 4: cTemp = cTemp + "重连接！\r\n"; break;
                case 5: cTemp = cTemp + "没有证书文件！\r\n"; break;
                case 6: cTemp = cTemp + "初始化失败！\r\n"; break;
                default: break;
            }
            rhTxtResult.Text = cTemp;
        }

        private void GetAlarmCount_MouseClick(object sender, MouseEventArgs e)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                return;
            }
            int lCount = axDbCommOcxFC71.GetAlarmCount();
            if (0 == lCount)
            {
                rhTxtResult.Text = "获取失败！";
                MessageBox.Show("该数据库中的点未设置报警参数！");
            }
            else
            {
                rhTxtResult.Text = "数据库中有报警参数的点数 = " + lCount.ToString();
            }
        }

        private void GetAlarmData_MouseClick(object sender, MouseEventArgs e)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                return;
            }
            int lCount = 0;
            object objAlarmData;

            objAlarmData = axDbCommOcxFC71.GetAlarmData(0, 10, ref lCount);
            if (objAlarmData == null)
            {
                MessageBox.Show("获取失败！");
                return;
            }

            object[,] objTemp = (object[,])objAlarmData;
            int Bound1 = objTemp.GetUpperBound(0);
            int Bound2 = objTemp.GetUpperBound(1);
            string cTemp = "";
            for (int i = 0; i < Bound1 + 1; i++)
            {
                cTemp = cTemp + "-----报警历史：记录" + (i + 1).ToString() + "\r\n";
                for (int j = 0; j < Bound2; j++)
                {
                    switch (j)
                    {
                        case 0:
                            cTemp = cTemp + "点序号: " + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 1:
                            {
                                DateTime Start = new DateTime(1970, 1, 1, 8, 0, 0);
                                string cSecond = objTemp[i, j].ToString();
                                double dSecond = Convert.ToInt32(cSecond);
                                Start = Start.AddSeconds(dSecond);
                                cTemp = cTemp + "报警时间: " + Start.ToString() + "\r\n";
                            }
                            break;
                        case 2:
                            cTemp = cTemp + "报警时间(毫秒): " + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 3:
                            cTemp = cTemp + "确认: " + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 4:
                            cTemp = cTemp + "报警参数序号: " + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 5:
                            cTemp = cTemp + "报警组: " + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 6:
                            {
                                DateTime Start = new DateTime(1970, 1, 1, 8, 0, 0);
                                DateTime End;
                                string cSecond = objTemp[i, j].ToString();
                                double dSecond = Convert.ToInt32(cSecond);
                                End = Start.AddSeconds(dSecond);
                                if (End == Start)
                                {
                                    cTemp = cTemp + "确认时间: 未确认!" + "\r\n";
                                }
                                else
                                {
                                    cTemp = cTemp + "确认时间: " + End.ToString() + "\r\n";
                                }
                            }
                            break;
                        case 7:
                            cTemp = cTemp + "确认时间(毫秒): " + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 8:
                            cTemp = cTemp + "历史确认标记:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 9:
                            cTemp = cTemp + "节点号:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 10:
                            cTemp = cTemp + "报警优先级:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 11:
                            cTemp = cTemp + "报警值:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 12:
                            cTemp = cTemp + "报警限值:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 13:
                            cTemp = cTemp + "点名:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 14:
                            cTemp = cTemp + "报警类型:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 15:
                            cTemp = cTemp + "报警值:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 16:
                            cTemp = cTemp + "报警限值:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 17:
                            cTemp = cTemp + "标签:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 18:
                            cTemp = cTemp + "标签:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 19:
                            cTemp = cTemp + "标签:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 20:
                            cTemp = cTemp + "标签:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 21:
                            cTemp = cTemp + "标签:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 22:
                            cTemp = cTemp + "标签:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 23:
                            cTemp = cTemp + "标签:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 24:
                            cTemp = cTemp + "标签:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 25:
                            cTemp = cTemp + "标签:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 26:
                            cTemp = cTemp + "标签:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 27:
                            cTemp = cTemp + "确认用户:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        case 28:
                            cTemp = cTemp + "描述信息:" + objTemp[i, j].ToString() + "\r\n";
                            break;
                        default: break;
                    }
                }
                cTemp = cTemp + "\r\n";
            }
            rhTxtResult.Text = cTemp;
        }

        private void btnHisData_Click(object sender, EventArgs e)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                return;
            }
            Form1 f = new Form1();
            f.axDbCommOcxFC71 = this.axDbCommOcxFC71;
            f.ShowDialog();
        }

        private void axDbCommOcxFC71_DataChange(object sender, AxDBCOMMOCXLibFC7._DDbCommOcxEventsFC7_DataChangeEvent e)
        {
            int lCount;
            object eChangeRegTagNo;
            object eChangeRegName;
            object eChangeRegTagValue;
            string cTemp;

            lCount = e.dataCount;
            eChangeRegTagNo = e.regNo;
            eChangeRegName = e.tagName;
            eChangeRegTagValue = e.tagValue;

            object[] TempNo = (object[])eChangeRegTagNo;
            object[] TempName = (object[])eChangeRegName;
            object[] TempValue = (object[])eChangeRegTagValue;
            cTemp = "变化的参数值个数为：" + lCount.ToString() + "\r\n";
            for (int i = 0; i < lCount; i++)
            {
                cTemp = cTemp + "----记录" + (i + 1).ToString() + "\r\n";
                cTemp = cTemp + "注册点注册序号：" + TempNo[i].ToString() + "\r\n";
                cTemp = cTemp + "注册点的点名：" + TempName[i].ToString() + "\r\n";
                cTemp = cTemp + "注册点参数值：" + TempValue[i].ToString() + "\r\n";
            }
            rhTxtDataChg.Text = cTemp;
        }

        private void btnGetTimeOut_Click(object sender, EventArgs e)
        {
            int igetTimeOut = axDbCommOcxFC71.TimeOut;
            txtGetTimeOut.Text = igetTimeOut.ToString();
        }

        private void btnSetTimeOut_Click(object sender, EventArgs e)
        {
            int iSetTimeOut = Convert.ToInt32(TexSetTimeOut.Text);
            axDbCommOcxFC71.TimeOut = iSetTimeOut;
        }

        private void btnGetUpDateTm_Click(object sender, EventArgs e)
        {
            int igetupdata = axDbCommOcxFC71.UpDateTime;
            txtGetUpdateTm.Text = igetupdata.ToString();

        }

        private void btnSetUpDateTm_Click(object sender, EventArgs e)
        {
            int isetupdatetm = Convert.ToInt32(TexSetUpdateTm.Text);
            axDbCommOcxFC71.UpDateTime = isetupdatetm;
        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }

        private void TexSetTimeOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }

        private void TexSetUpdateTm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }

        private void TagTypeEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }

        private void NodeIDEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtTagVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;

            if ((int)e.KeyChar == 46)
            {
                if (txtTagVal.Text.Length <= 0)
                    e.Handled = true;
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(txtTagVal.Text, out oldf);
                    b2 = float.TryParse(txtTagVal.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }

        private void txtRegNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;

        }

        #region SQLite 数据库操作

        private void btnSelectDb_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "SQLite 数据库文件|*.db;*.sqlite;*.sqlite3|所有文件|*.*";
            openFileDialog.Title = "选择 SQLite 数据库文件";
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentDbPath = openFileDialog.FileName;
                txtDbPath.Text = currentDbPath;
                
                try
                {
                    sqliteHelper = new SQLiteHelper(currentDbPath);
                    if (sqliteHelper.TestConnection())
                    {
                        LoadTableNames();
                        rhTxtResult.AppendText("\r\n数据库连接成功！\r\n");
                    }
                    else
                    {
                        MessageBox.Show("无法连接到数据库文件！");
                        rhTxtResult.AppendText("\r\n数据库连接失败！\r\n");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"加载数据库失败：{ex.Message}");
                    rhTxtResult.AppendText($"\r\n加载数据库失败：{ex.Message}\r\n");
                }
            }
        }

        private void LoadTableNames()
        {
            try
            {
                if (sqliteHelper == null) return;

                List<string> tableNames = sqliteHelper.GetTableNames();
                cmbTables.Items.Clear();
                cmbTables.Items.AddRange(tableNames.ToArray());
                
                if (tableNames.Count > 0)
                {
                    cmbTables.SelectedIndex = 0;
                }
                
                rhTxtResult.AppendText($"\r\n共找到 {tableNames.Count} 个表\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载表名失败：{ex.Message}");
            }
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTables.SelectedItem != null && sqliteHelper != null)
            {
                LoadTableData(cmbTables.SelectedItem.ToString());
            }
        }

        private void LoadTableData(string tableName)
        {
            try
            {
                if (sqliteHelper == null) return;

                string sql = $"SELECT * FROM {tableName}";
                DataTable dt = sqliteHelper.ExecuteQuery(sql);
                
                dgvSqliteData.DataSource = dt;
                
                rhTxtResult.AppendText($"\r\n加载表 {tableName} 数据，共 {dt.Rows.Count} 行\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载数据失败：{ex.Message}");
                rhTxtResult.AppendText($"\r\n加载数据失败：{ex.Message}\r\n");
            }
        }

        private void btnExecuteSql_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqliteHelper == null)
                {
                    MessageBox.Show("请先选择数据库文件！");
                    return;
                }

                string sql = txtSql.Text.Trim();
                if (string.IsNullOrEmpty(sql))
                {
                    MessageBox.Show("请输入 SQL 语句！");
                    return;
                }

                string upperSql = sql.ToUpper();
                if (upperSql.StartsWith("SELECT"))
                {
                    DataTable dt = sqliteHelper.ExecuteQuery(sql);
                    dgvSqliteData.DataSource = dt;
                    rhTxtResult.AppendText($"\r\n查询成功，返回 {dt.Rows.Count} 行数据\r\n");
                }
                else
                {
                    int rows = sqliteHelper.ExecuteNonQuery(sql);
                    rhTxtResult.AppendText($"\r\n执行成功，影响 {rows} 行\r\n");
                    
                    if (cmbTables.SelectedItem != null)
                    {
                        LoadTableData(cmbTables.SelectedItem.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"执行 SQL 失败：{ex.Message}");
                rhTxtResult.AppendText($"\r\n执行 SQL 失败：{ex.Message}\r\n");
            }
        }

        private void btnLoadSchema_Click(object sender, EventArgs e)
        {
            if (cmbTables.SelectedItem != null && sqliteHelper != null)
            {
                try
                {
                    string tableName = cmbTables.SelectedItem.ToString();
                    DataTable schema = sqliteHelper.GetTableSchema(tableName);
                    dgvSqliteData.DataSource = schema;
                    rhTxtResult.AppendText($"\r\n加载表 {tableName} 结构成功\r\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"加载表结构失败：{ex.Message}");
                    rhTxtResult.AppendText($"\r\n加载表结构失败：{ex.Message}\r\n");
                }
            }
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            if (dgvSqliteData.DataSource == null)
            {
                MessageBox.Show("没有可导出的数据！");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV 文件|*.csv|文本文件|*.txt";
            saveFileDialog.Title = "导出数据";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable dt = (DataTable)dgvSqliteData.DataSource;
                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        sb.Append(dt.Columns[i].ColumnName);
                        if (i < dt.Columns.Count - 1)
                            sb.Append(",");
                    }
                    sb.AppendLine();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            sb.Append(dt.Rows[i][j].ToString());
                            if (j < dt.Columns.Count - 1)
                                sb.Append(",");
                        }
                        sb.AppendLine();
                    }

                    File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show($"数据导出成功！\n共导出 {dt.Rows.Count} 行数据");
                    rhTxtResult.AppendText($"\r\n数据导出成功，共 {dt.Rows.Count} 行\r\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"导出失败：{ex.Message}");
                }
            }
        }

        #endregion



        private void GetAllTagName_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void DBCOMTEST_Closing(object sender, EventArgs e)
        {
            client.Close();
            client = null;
      
        }

        /// <summary>
        /// 获取实时数据
        /// </summary>
        private void GetDataFunc(string tagName)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                SendMsgToClient("桥接程序连接失败");
                return;
            }

            object objtagname = (object)tagName;
            object objtagvalue = axDbCommOcxFC71.GetData(objtagname);
            if (Object.Equals(null, objtagvalue))
            {
                txtTagName.BackColor = System.Drawing.Color.Red;
                rhTxtResult.Text = "获取失败!";
                //发送消息给Unity3D
                UDPMessage message = new UDPMessage(UDPMessage.MessageType.GetDataResult, tagName, "Error");
                SendMsgToClient(message);
            }
            else
            {
                txtTagName.BackColor = System.Drawing.Color.White;
                string cTemp = "获取成功!\r\n" + txtTagName.Text + " = ";
                object[] objTemp = (object[])objtagvalue;
                cTemp = cTemp + objTemp[0].ToString() + "\r\n";

                rhTxtResult.Text = cTemp + "说明：当参数中没带点参数时，默认是返回点的PV值";


                UDPMessage message = new UDPMessage(UDPMessage.MessageType.GetDataResult, tagName, objTemp[0].ToString());
                SendMsgToClient(message);

            }
        }

        private void GetDataFunc(UDPMessage receiveMessage)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                SendMsgToClient("桥接程序连接失败");
                return;
            }

            object objtagname = (object)receiveMessage.tag;
            object objtagvalue = axDbCommOcxFC71.GetData(objtagname);
            if (Object.Equals(null, objtagvalue))
            {
                txtTagName.BackColor = System.Drawing.Color.Red;
                rhTxtResult.Text = "获取失败!";

                UDPMessage message = new UDPMessage(UDPMessage.MessageType.GetDataResult,receiveMessage.identify, receiveMessage.tag, "Error");
                SendMsgToClient(message);
            }
            else
            {
                txtTagName.BackColor = System.Drawing.Color.White;
                string cTemp = "获取成功!\r\n" + txtTagName.Text + " = ";
                object[] objTemp = (object[])objtagvalue;
                cTemp = cTemp + objTemp[0].ToString() + "\r\n";

                rhTxtResult.Text = cTemp + "说明：当参数中没带点参数时，默认是返回点的PV值";

                //发送消息给Unity3D
                UDPMessage message = new UDPMessage(UDPMessage.MessageType.GetDataResult, receiveMessage.identify, receiveMessage.tag, objTemp[0].ToString());
                SendMsgToClient(message);
            }
        }
        /// <summary>
        /// 设置实时数据
        /// </summary>
        /// <param name="tagName"></param>
        /// <param name="value"></param>
        private void SetDataFunc(string tagName, string value)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                SendMsgToClient("桥接程序连接失败");
                return;
            }

            object objtagname = (object)tagName;
            object objtagval = (object)value;
            int iSetRe = axDbCommOcxFC71.SetData(objtagname, objtagval);

            if (iSetRe <= 0)
            {
                txtTagName.BackColor = System.Drawing.Color.Red;
                txtTagVal.BackColor = System.Drawing.Color.Red;
                rhTxtResult.Text = "获取失败!";

                UDPMessage message = new UDPMessage(UDPMessage.MessageType.GetDataResult, tagName, "Error");
                SendMsgToClient(message);
            }
            else
            {
                txtTagName.BackColor = System.Drawing.Color.White;
                txtTagVal.BackColor = System.Drawing.Color.White;
                rhTxtResult.Text = "获取成功!\r\n";
                rhTxtResult.Text = rhTxtResult.Text + "设置成功个数：" + iSetRe.ToString();

               
                 UDPMessage message = new UDPMessage(UDPMessage.MessageType.SetDataResult, tagName, value);
                 SendMsgToClient(message);
                
            }
        }

        private void SetDataFunc(UDPMessage receiveMessage)
        {
            if (!bConnState)
            {
                MessageBox.Show("没有连接!");
                SendMsgToClient("桥接程序连接失败");
                return;
            }

            object objtagname = (object)receiveMessage.tag;
            object objtagval = (object)receiveMessage.value;
            int iSetRe = axDbCommOcxFC71.SetData(objtagname, objtagval);

            if (iSetRe <= 0)
            {
                txtTagName.BackColor = System.Drawing.Color.Red;
                txtTagVal.BackColor = System.Drawing.Color.Red;
                rhTxtResult.Text = "获取失败!";

                UDPMessage message = new UDPMessage(UDPMessage.MessageType.GetDataResult,receiveMessage.identify, receiveMessage.tag, "Error");
                SendMsgToClient(message);


            }
            else
            {
                txtTagName.BackColor = System.Drawing.Color.White;
                txtTagVal.BackColor = System.Drawing.Color.White;
                rhTxtResult.Text = "获取成功!\r\n";
                rhTxtResult.Text = rhTxtResult.Text + "设置成功个数：" + iSetRe.ToString();


                UDPMessage message = new UDPMessage(UDPMessage.MessageType.SetDataResult, receiveMessage.identify, receiveMessage.tag, iSetRe.ToString());
                SendMsgToClient(message);

            }
        }

        private void DBCOMTEST_Load(object sender, EventArgs e)
        {
            OpenRemoteConnect_Click(sender, e);
            startUDPClient.Visible = false;
            startUDPClient_Click(sender, e);
        }




        #region 海湾消防公司


        #endregion

        #region UDP
        private UdpClient client = new UdpClient(8001);//Port
        string data = "";

        IPEndPoint targetEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8000);
        #endregion

        private void startUDPClient_Click(object sender, EventArgs e)
        {
            try
            {
                client.BeginReceive(new AsyncCallback(recv), null);
            }
            catch (Exception ex)
            {
                receivedUDPMessage.Text += ex.Message.ToString();
            }
        }

        void recv(IAsyncResult result)
        {
            if (client != null)
            {
                try
                {
                    IPEndPoint RemoteIP = new IPEndPoint(IPAddress.Any, 0);
                    byte[] received = client.EndReceive(result, ref RemoteIP);
                    // 注意：这里需要重新拿一个局部变量保存，防止多线程覆盖
                    string receivedData = Encoding.UTF8.GetString(received);

                    // 🌟 关键 1：马上开启下一次接收，绝不等待！让网络层全速运转
                    client.BeginReceive(new AsyncCallback(recv), null);

                    // 🌟 关键 2：使用 BeginInvoke 异步将任务丢给 UI 线程排队处理，不阻塞网络
                    this.BeginInvoke(new MethodInvoker(delegate
                    {
                        // 优化 UI 显示：建议在界面加个 CheckBox 叫 "显示日志"，量大时关掉它
                        // if (chkShowLog.Checked) 
                        // {
                        if (receivedUDPMessage.TextLength >= 10000)
                        {
                            receivedUDPMessage.Clear(); // 用 Clear() 更快
                        }

                        // 使用 AppendText 追加，绝对不要用 text = a + text 这种形式！
                        string newLine = $"{DateTime.Now:G}:{DateTime.Now.Millisecond}:{receivedData}\r\n";
                        receivedUDPMessage.AppendText(newLine);
                        // }

                        // 处理核心逻辑
                        HandleReceiveMessage(receivedData);
                    }));
                }
                catch (Exception ex)
                {
                    // 重启程序前最好记录一下日志
                    System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
                    Application.Exit();
                }
            }
        }

        private void SendUDPMessage_Click(object sender, EventArgs e)
        {
            try
            {
                string result = sendedUDPMessage.Text.ToString();
                byte[] bytes = Encoding.UTF8.GetBytes(result);
                client.Send(bytes, bytes.Length, targetEndPoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        /// <summary>
        /// 将收到的消息转发出去
        /// </summary>
        /// <param name="value"></param>
        private void SendMsgToClient(string value)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(value);
                client.Send(bytes, bytes.Length, targetEndPoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        /// <summary>
        /// 将收到的消息转发出去
        /// </summary>
        /// <param name="value"></param>
        private void SendMsgToClient(UDPMessage value)
        {
            try
            {
                string temp = JsonConvert.SerializeObject(value);

                sendMessageRichTextboard.Text += temp + "\r\n" + sendMessageRichTextboard.Text;

                if(sendMessageRichTextboard.Lines.Length>10000)
                {
                    sendMessageRichTextboard.Text = "";
                }

                byte[] bytes = Encoding.UTF8.GetBytes(temp);
                client.Send(bytes, bytes.Length, targetEndPoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void HandleReceiveMessage(string value)
        {
           
            if (isJsonType(value))
            {
                
                UDPMessage message = JsonConvert.DeserializeObject<UDPMessage>(value);
                switch (message.type)
                {
                    case UDPMessage.MessageType.GetData:
                        GetDataFunc(message);
                        break;
                    case UDPMessage.MessageType.SetData:

                        SetDataFunc(message);

                        break;

                }


            }
            else
            {
                rhTxtResult.AppendText("\r\n");
                rhTxtResult.Text += value;
            }
        }


        /// <summary>
        /// 判断是否为json格式
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool isJsonType(string str)
        {
            bool result = false;
            if (!String.IsNullOrEmpty(str))
            {
                if (str.First() == '{' && str.Last() == '}')
                {
                    result = true;
                }
                else if (str.First() == '[' && str.Last() == ']')
                {
                    result = true;
                }
            }
            return result;
        }
    }
}

