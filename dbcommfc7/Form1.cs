using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dbcommfc7
{
    public partial class Form1 : Form
    {
        public Form1()
        {        
            InitializeComponent();
        }

        private void axDbCommOcxFC71_StatusChange(object sender, AxDBCOMMOCXLibFC7._DDbCommOcxEventsFC7_StatusChangeEvent e)
        {

        }



        private void InsertHisData_Click(object sender, EventArgs e)
        {
            bool bConnState = axDbCommOcxFC71.IsConnected();
            if (!bConnState)
            {
                MessageBox.Show("没有连接！");
                return;
            }

            DateTime dtInsert=new DateTime(dateTimePicker1.Value.Date.Year,dateTimePicker1.Value.Date.Month
                ,dateTimePicker1.Value.Date.Day,dateTimePicker2.Value.Hour
                ,dateTimePicker2.Value.Minute,dateTimePicker2.Value.Second);
            string strTagName=TagName.Text;
            object objTimeSh=(object)textBox2.Text;
            object objDataVal=(object)textBox3.Text;
            int iInHis = axDbCommOcxFC71.InsertHisData(ref strTagName, (object) dtInsert, objTimeSh, objDataVal);
            if (iInHis > 0)
            {
                rtbGetHis.Text = "插入成功！";
            } 
            else
            {
                rtbGetHis.Text = "插入失败！";            
            }
        }

        private void GetHisData_Click(object sender, EventArgs e)
        {
            bool bConnState = axDbCommOcxFC71.IsConnected();
            if (!bConnState)
            {
                MessageBox.Show("没有连接！");
                return;
            }

            DateTime StartTime = new DateTime(gethisstardata.Value.Date.Year, gethisstardata.Value.Date.Month, gethisstardata.Value.Date.Day, gethisstartime.Value.Hour, gethisstartime.Value.Minute, gethisstartime.Value.Second);
            DateTime EndTime = new DateTime(gethisenddata.Value.Date.Year, gethisenddata.Value.Date.Month, gethisenddata.Value.Date.Day, gethisendtime.Value.Hour, gethisendtime.Value.Minute, gethisendtime.Value.Second);
            int DataCount = Convert.ToInt32(txtDataCount.Text);
            string txtagname = txtGthTagName.Text;
           
            object objGetHis=axDbCommOcxFC71.GetHisData(StartTime, EndTime, DataCount, (object)txtagname);
            try
            {
                if (objGetHis.Equals((object)null))
                {
                    rtbGetHis.Text = "获取失败!";

                }
                else
                {             
                    object[] objTemp = (object[])objGetHis;
                    int nCount = Math.Min(objTemp.Length, 10);
                    string cTemp = "获取成功！\r\n实际显示条数：" + nCount.ToString()+ "\r\n";
                    for (int i = 0; i < nCount; i++)
                    {
                        cTemp = cTemp + txtGthTagName.Text + " = " + objTemp[i].ToString();
                        cTemp = cTemp + "\r\n";
                    }
                    rtbGetHis.Text = cTemp;
                }
            }
            catch (System.NullReferenceException)
            {
                return;
            }
        }

        private void GetHisTrace_Click(object sender, EventArgs e)
        {
            bool bConnState = axDbCommOcxFC71.IsConnected();
            if (!bConnState)
            {
                MessageBox.Show("没有连接！");
                return;
            }

            DateTime StartTime = new DateTime(gethisstardata.Value.Date.Year, gethisstardata.Value.Date.Month, gethisstardata.Value.Date.Day, gethisstartime.Value.Hour, gethisstartime.Value.Minute, gethisstartime.Value.Second);
            DateTime EndTime = new DateTime(gethisenddata.Value.Date.Year, gethisenddata.Value.Date.Month, gethisenddata.Value.Date.Day, gethisendtime.Value.Hour, gethisendtime.Value.Minute, gethisendtime.Value.Second);
            string txtagname = txtGthTagName.Text;
            object objHisTrace=axDbCommOcxFC71.GetHisTrace(StartTime, EndTime, ref txtagname);
            if (objHisTrace==null)
            {
                rtbGetHis.Text = "获取失败！";
            } 
            else
            {
                object[,] objTemp = (object[,])objHisTrace;
                int Bound1 = objTemp.GetUpperBound(0);
                int Bound2 = objTemp.GetUpperBound(1);
                int nTemp = Convert.ToInt32(txtDataCount.Text);
                int nCow = Math.Min(Bound1, nTemp);// Bound1 > nTemp ? nTemp : Bound1;
                string cTemp = "获取成功！\r\n历史追忆记录实际显示条数：" + nCow.ToString() + "\r\n";

                for (int i = 0; i < nCow + 1; i++)
                {
                    for (int j = 0; j < Bound2 + 1; j++)
                    {
                        switch(j)
                        {
                            case 0: 
                                cTemp = cTemp + "时间：" + objTemp[i, j].ToString();
                                break;
                            case 1:
                                cTemp = cTemp + "毫秒：" + objTemp[i, j].ToString();
                                break;
                            case 2:
                                cTemp = cTemp + "追忆数据：" + objTemp[i, j].ToString() + "\r\n";
                                break;
                            default:break;
                        }                
                    }
                    rtbGetHis.Text = cTemp;
                }
            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;

            if ((int)e.KeyChar == 46)
            {
                if (textBox3.Text.Length <= 0)
                    e.Handled = true;
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(textBox3.Text, out oldf);
                    b2 = float.TryParse(textBox3.Text + e.KeyChar.ToString(), out f);
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtDataCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;

        }

        }
    }

