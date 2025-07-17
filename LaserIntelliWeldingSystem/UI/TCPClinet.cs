using LaserIntelliWeldingSystem.Communication;
using Sunny.UI;
using System.Drawing;
using System;


namespace LaserIntelliWeldingSystem.UI
{
    public partial class TCPClinet : UIPage
    {
        public delegate void LogAppendDelegate(Color color, string text);

        public TCPClinet()
        {
            InitializeComponent();
            Showconfig();
            EnableEditor(false);
            EnableSend(false);
            GlobalCommData.EventTcpClientInfoHandler += GlobalCommData_EventTcpClientInfoHandler;
        }

        private void GlobalCommData_EventTcpClientInfoHandler(object sender, MessageArgs e)
        {
            //throw new NotImplementedException();
            LogAppendDelegate la = new LogAppendDelegate(LogAppend);
            uiRTB_Recvie.Invoke(la, e.MessageShowColor, e.strMessage);
        }

        public void LogAppend(Color color, string strMsg)
        {
            try
            {
                if (uiRTB_Recvie.TextLength > 3000)
                {
                    uiRTB_Recvie.Clear();
                }
                uiRTB_Recvie.SelectionColor = color;
                uiRTB_Recvie.AppendText(string.Format("{0}-{1}\n", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff"), strMsg));
            }
            catch
            { }
        }

        private void rtb_Log_TextChanged(object sender, EventArgs e)
        {
            uiRTB_Recvie.SelectionStart = uiRTB_Recvie.Text.Length;
            uiRTB_Recvie.ScrollToCaret();
        }

        void Showconfig()
        {
            uiipTextBox1.Text = GlobalCommData.TCPIPComm.XMLClient.TargetIP;
            uiTextBox1.Text = GlobalCommData.TCPIPComm.XMLClient.TargetPort.ToString();
        }

        void ChangeConfig()
        {
            GlobalCommData.TCPIPComm.XMLClient.TargetIP = uiipTextBox1.Text;
            GlobalCommData.TCPIPComm.XMLClient.TargetPort = int.Parse(uiTextBox1.Text);
        }

        void EnableEditor(bool enable)
        {
            uiipTextBox1.Enabled = enable;
            uiTextBox1.Enabled = enable;
            uiBtn_CorrIP.Enabled = enable;
            uiBtn_Connect.Enabled = enable;
            uiBtn_StopConnect.Enabled = enable;
        }

        void EnableSend(bool enable)
        {
            uiBtn_Send.Enabled = enable;
            uiRTB_Send.Enabled = enable;
        }

        private void uiBtn_Send_Click(object sender, System.EventArgs e)
        {

        }

        private void uiCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            EnableEditor(uiCheckBox1.Checked);
        }

        private void uiCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            EnableSend(uiCheckBox2.Checked);
        }

        private void uiBtn_Connect_Click(object sender, EventArgs e)
        {
            GlobalCommData.TCPIPComm.StartClientCommmTask();
        }

        private void uiBtn_StopConnect_Click(object sender, EventArgs e)
        {
            GlobalCommData.TCPIPComm.StopClientCommmTask();
        }

        private void uiBtn_CorrIP_Click(object sender, EventArgs e)
        {
            ChangeConfig();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Showconfig();
        }
    }
}
