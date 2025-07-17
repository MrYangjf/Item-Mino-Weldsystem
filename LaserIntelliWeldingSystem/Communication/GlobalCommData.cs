using LaserIntelliWeldingSystem.Communication.TCPIP;
using LaserIntelliWeldingSystem.FileIO.LOGFile;
using LaserIntelliWeldingSystem.FileIO.XMLFile;
using LaserIntelliWeldingSystem.PCL;
using LaserIntelliWeldingSystem.SQLiteDB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace LaserIntelliWeldingSystem.Communication
{

    public class MachineStatusMessageArgs : EventArgs
    {
        public MachineStatus CurrentMachineStatus = MachineStatus.NoReset;
    }
    public class MessageArgs : EventArgs
    {
        public string strMessage = "";
        public Color MessageShowColor = Color.Black;
    }
    public class MessageLineChart : EventArgs
    {
        public string Name = "";
        public string Message = "";
    }


    class GlobalCommData
    {
        /// <summary>
        /// 状态通知事件
        /// </summary>
        public static event EventHandler<MachineStatusMessageArgs> EevetStatusHandler;

        static MachineStatus machineStatus = MachineStatus.NoReset;
        public static MachineStatus LastStatus = MachineStatus.NoReset;
        public static MachineStatus CurrentStatus
        {
            get
            {
                return machineStatus;
            }
            set
            {
                if (machineStatus != value)
                {
                    LastStatus = machineStatus;
                    machineStatus = value;
                    EventHandler<MachineStatusMessageArgs> handler = EevetStatusHandler;
                    if (handler != null)
                    {
                        handler(null, new MachineStatusMessageArgs() { CurrentMachineStatus = machineStatus });
                    }
                }
            }
        }

        public static string Xpos, Ypos, Zpos, OffsetY, OffsetZ, LaserPower, FeedSpeed, Speed, PointNum, WidthStartNum, WidthEndNum, PointsX, PointsY;


        /// <summary>
        /// 服务器xml文档
        /// </summary>
        public static XdocumentReaderWriter ServerXdoc = new XdocumentReaderWriter("Server");
        /// <summary>
        /// 客户端xml文档
        /// </summary>
        public static XdocumentReaderWriter ClientXdoc = new XdocumentReaderWriter("Client");
        /// <summary>
        /// 发送数据xml文档
        /// </summary>
        public static XdocumentReaderWriter SendXdoc = new XdocumentReaderWriter("Send");
        /// <summary>
        /// 接受数据xml文档
        /// </summary>
        public static XdocumentReaderWriter ReciveXdoc = new XdocumentReaderWriter("Recive");

        /// <summary>
        /// 接受数据xml文档
        /// </summary>
        public static XdocumentReaderWriter ParamConfigXdoc = new XdocumentReaderWriter("Param");

        /// <summary>
        /// 权限管理文件
        /// </summary>
        public static AuthManage mAuthManager = new AuthManage();

        /// <summary>
        /// 操作等级
        /// </summary>
        public static OperateLevel mOperateLevel = OperateLevel.Operator;

        /// <summary>
        /// 配置管理文件
        /// </summary>
        public static ConfigManage mConfigManager = new ConfigManage();

        /// <summary>
        /// 配置文件
        /// </summary>
        public static AutoValueManage mAutoParamManage = new AutoValueManage();

        /// <summary>
        /// 通讯类
        /// </summary>
        public static TCPIPComm TCPIPComm = new TCPIPComm();
        /// <summary>
        /// 日志操作
        /// </summary>
        public static Log MachineLog = new Log("智能填丝焊接系统日志");
        /// <summary>
        /// 日志操作
        /// </summary>
        public static Log TcpMessageLog = new Log("智能填丝焊接通讯日志");

        /// <summary>
        /// PCL文件
        /// </summary>
        public static PCLFileClass PCLFile = new PCLFileClass();

        /// <summary>
        /// 日志信息Handler
        /// </summary>
        public static event EventHandler<MessageArgs> EventInfoHandler;

        /// <summary>
        /// 通讯信息Handler
        /// </summary>
        public static event EventHandler<MessageArgs> EventTcpInfoHandler;

        /// <summary>
        /// Client通讯信息Handler
        /// </summary>
        public static event EventHandler<MessageArgs> EventTcpClientInfoHandler;


        /// <summary>
        /// 线激光通讯信息Handler
        /// </summary>
        public static event EventHandler<MessageLineChart> EventLineLaserInfoHandler;

        /// <summary>
        /// 机器人焊接参数通讯信息Handler
        /// </summary>
        public static event EventHandler<MessageLineChart> EventRobotInfoHandler;

        /// <summary>
        /// 显示日志
        /// </summary>
        /// <param name="TAG"></param>
        /// <param name="message"></param>
        /// <param name="msgLevel"></param>
        /// <param name="msgType"></param>
        public static void ShowLog(string TAG, string message, MessageLevel msgLevel = MessageLevel.Info, MessageType msgType = MessageType.Debug)
        {
            EventHandler<MessageArgs> Handler = EventInfoHandler;
            switch (msgLevel)
            {
                case MessageLevel.Info:
                    Handler?.Invoke(null, new MessageArgs() { strMessage = message });
                    break;
                case MessageLevel.Warning:
                    Handler?.Invoke(null, new MessageArgs() { strMessage = message, MessageShowColor = Color.Blue });
                    break;
                case MessageLevel.Error:
                    Handler?.Invoke(null, new MessageArgs() { strMessage = message, MessageShowColor = Color.Red });
                    break;
            }
            MachineLog.Debug(TAG + Thread.GetDomainID(), message);
        }

        /// <summary>
        /// 通讯显示
        /// </summary>
        /// <param name="TAG"></param>
        /// <param name="message"></param>
        /// <param name="msgLevel"></param>
        /// <param name="msgType"></param>
        public static void ShowTcpMessage(string TAG, string message, TcpMessageLevel msgLevel = TcpMessageLevel.Info)
        {
            EventHandler<MessageArgs> Handler = EventTcpInfoHandler;
            switch (msgLevel)
            {
                case TcpMessageLevel.Info:
                    Handler?.Invoke(null, new MessageArgs() { strMessage = message });
                    break;
                case TcpMessageLevel.Tips:
                    Handler?.Invoke(null, new MessageArgs() { strMessage = message, MessageShowColor = Color.Blue });
                    break;
            }
            TcpMessageLog.Debug(TAG + Thread.GetDomainID(), message);
        }


        public static void ShowTcpClientMessage(string TAG, string message, TcpMessageLevel msgLevel = TcpMessageLevel.Info)
        {
            EventHandler<MessageArgs> Handler = EventTcpClientInfoHandler;
            switch (msgLevel)
            {
                case TcpMessageLevel.Info:
                    Handler?.Invoke(null, new MessageArgs() { strMessage = message });
                    break;
                case TcpMessageLevel.Tips:
                    Handler?.Invoke(null, new MessageArgs() { strMessage = message, MessageShowColor = Color.Blue });
                    break;
            }
            TcpMessageLog.Debug(TAG + Thread.GetDomainID(), message);
        }

        public static void ShowLaserData(string TAG, string message)
        {
            EventHandler<MessageLineChart> Handler = EventLineLaserInfoHandler;
            Handler?.Invoke(null, new MessageLineChart() { Message = message, Name = "" });
            TcpMessageLog.Debug(TAG + Thread.GetDomainID(), message);
        }

    }
}
