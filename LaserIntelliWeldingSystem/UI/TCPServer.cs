using LaserIntelliWeldingSystem.Communication;
using Sunny.UI;
using System;
using System.Drawing;


namespace LaserIntelliWeldingSystem.UI
{
    public partial class TCPServer : UIPage
    {
        public delegate void LogAppendDelegate(Color color, string text);

        public TCPServer()
        {
            InitializeComponent();
            Showconfig();
            EnableEditor(false);
            EnableSend(false);
            GlobalCommData.EventTcpInfoHandler += GlobalCommData_EventTcpInfoHandler;
        }

        private void GlobalCommData_EventTcpInfoHandler(object sender, MessageArgs e)
        {
            //throw new NotImplementedException();
            LogAppendDelegate la = new LogAppendDelegate(LogAppend);
            uiRTB_Recvie.Invoke(la, e.MessageShowColor, e.strMessage);
        }

        void Showconfig()
        {
            uiipTextBox1.Text = GlobalCommData.TCPIPComm.XMLServer.ServerIP;
            uiTextBox1.Text = GlobalCommData.TCPIPComm.XMLServer.ServerPort.ToString();
        }

        void ChangeConfig()
        {
            GlobalCommData.TCPIPComm.XMLServer.ServerIP = uiipTextBox1.Text;
            GlobalCommData.TCPIPComm.XMLServer.ServerPort = int.Parse(uiTextBox1.Text);
        }

        void EnableEditor(bool enable)
        {
            uiipTextBox1.Enabled = enable;
            uiTextBox1 .Enabled = enable;   
            uiBtn_CorrIP.Enabled = enable;
            uiBtn_StartListen.Enabled = enable; 
            uiBtn_CloseListen.Enabled = enable;
        }

        void EnableSend(bool enable)
        {
            uiBtn_Send.Enabled = enable;
            uiRTB_Send.Enabled = enable;
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


        private void uiCheckBox1_CheckedChanged(object sender, System.EventArgs e)
        {
           EnableEditor(uiCheckBox1.Checked);
        }

        private void uiCheckBox2_CheckedChanged(object sender, System.EventArgs e)
        {
            EnableSend(uiCheckBox2.Checked);    
        }

        private void uiBtn_StartListen_Click(object sender, EventArgs e)
        {
            GlobalCommData.TCPIPComm.StartServerCommmTask();
        }

        private void uiBtn_CloseListen_Click(object sender, EventArgs e)
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

        private void uiBtn_Send_Click(object sender, EventArgs e)
        {

        }
    }
}
