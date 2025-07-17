using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STTech.BytesIO.Tcp;


namespace LaserIntelliWeldingSystem.Communication.TCPIP
{

    class TCPIPComm
    {

        public SSTTCPServer XMLServer = new SSTTCPServer();
        public SSTTCPClient XMLClient = new SSTTCPClient();

        public TCPIPComm()
        {
            LoadConfig();
        }

        public void LoadConfig()
        {
            XMLServer.ServerIP = GlobalCommData.ServerXdoc.GetIP();
            XMLServer.ServerPort = GlobalCommData.ServerXdoc.GetPort();
            XMLClient.TargetIP = GlobalCommData.ClientXdoc.GetIP();
            XMLClient.TargetPort = GlobalCommData.ClientXdoc.GetPort();
        }

        public void StartServerCommmTask()
        {
            XMLServer.StartListening();
        }

        public void StopServerCommmTask()
        {
            XMLServer.StopListening();
        }

        public void StartClientCommmTask()
        {
            XMLClient.StartConnect();
        }
        public void StopClientCommmTask()
        {
            XMLClient.DisConnect();
        }

    }

    public class SSTTCPServer
    {

        string TAG = "TCPServer";

        string _serverIP = "127.0.0.1";
        public string ServerIP
        {
            get { return _serverIP; }
            set { _serverIP = value; }
        }

        int _serverPort = 6000;
        public int ServerPort
        {
            get { return _serverPort; }
            set { _serverPort = value; }
        }

        uint _clientLimited = 5;

        public uint ClientLimited
        {
            get { return _clientLimited; }
            set { _clientLimited = value; }
        }

        public TcpServer ServerSocket;

        public List<string> MessageList = new List<string>();

        public SSTTCPServer()
        {
            ServerSocket = new TcpServer();
        }

        ~SSTTCPServer()
        {
            if (ServerSocket != null)
                ServerSocket.StopAsync();
            ServerSocket.Dispose();
        }

        public void StartListening()
        {

            ServerSocket.Host = _serverIP;
            ServerSocket.Port = _serverPort;
            ServerSocket.MaxConnections = _clientLimited;
            ServerSocket.StartAsync();

            ServerSocket.Started += ServerSocket_Started;
            ServerSocket.Closed += ServerSocket_Closed;

        }

        private void ServerSocket_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            //throw new NotImplementedException();
            GlobalCommData.ShowTcpMessage(TAG, "客户端已断开！");
        }

        private void ServerSocket_Closed(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            GlobalCommData.ShowTcpMessage(TAG, "服务器停止监听！");
            ServerSocket.ClientConnected -= ServerSocket_ClientConnected;
            ServerSocket.ClientDisconnected -= ServerSocket_ClientDisconnected;
        }

        private void ServerSocket_Started(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            GlobalCommData.ShowLog(TAG, "服务器开启监听！");
            ServerSocket.ClientConnected += ServerSocket_ClientConnected;
            ServerSocket.ClientDisconnected += ServerSocket_ClientDisconnected;
        }

        private void ServerSocket_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            //throw new NotImplementedException();
            e.Client.OnDataReceived += Client_OnDataReceived;
            GlobalCommData.ShowTcpMessage(TAG, "客户端已连接！");
        }

        private void Client_OnDataReceived(object sender, STTech.BytesIO.Core.DataReceivedEventArgs e)
        {
            //throw new NotImplementedException();

            TcpClient tcpClient = (TcpClient)sender;
            string Message = e.Data.EncodeToString("GBK");
            string ClientShow = string.Format("服务器接受来自{0}的信息:", tcpClient.RemoteEndPoint.ToString());
            MessageList.Add(Message);
            if(Message.Contains("Start"))
            {
                GlobalCommData.CurrentStatus = MachineStatus.Running;
                //send singal
                tcpClient.Send(Message.GetBytes("utf-8"));
            }
            if (GlobalCommData.CurrentStatus == MachineStatus.Running)
            {
                GlobalCommData.ShowLaserData(TAG, Message);
            }
            else
            {
                GlobalCommData.ShowTcpMessage(TAG, ClientShow + Message);
            }
        }

        public void StopListening()
        {
            ServerSocket.StopAsync();
        }

    }

    public class SSTTCPClient
    {
        string TAG = "TCPClient";

        string _targetIP = "127.0.0.1";
        public string TargetIP
        {
            get { return _targetIP; }
            set { _targetIP = value; }
        }

        int _targetPort = 6000;
        public int TargetPort
        {
            get { return _targetPort; }
            set { _targetPort = value; }
        }

        public TcpClient TcpClient;

       public void Send(string Message)
        {
            TcpClient.Send(Message.GetBytes("utf-8"));
        }

        public void StartConnect()
        {
            TcpClient.Host = _targetIP;
            TcpClient.Port = _targetPort;
            TcpClient.Connect();
            GlobalCommData.ShowLog(TAG, "客户端连接远端服务器！");
        }

        public void DisConnect()
        {
            TcpClient.Disconnect();
            GlobalCommData.ShowLog(TAG, "客户端断开连接！");
        }
    }
}
