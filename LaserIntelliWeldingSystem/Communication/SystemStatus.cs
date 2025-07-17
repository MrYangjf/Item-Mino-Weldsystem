using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaserIntelliWeldingSystem.Communication
{
    public enum MessageType
    {
        Summary,
        Run,
        Flow,
        Debug
    }
    public enum MessageLevel
    {
        Info,
        Warning,
        Error
    }

    public enum TcpMessageLevel
    {
        Info,
        Tips
    }
    public enum MachineStatus
    {
        Running = 0,//运行中
        Alarm = 1,//报警
        EStop = 2,//急停
        Stop = 3,//停止
        NoReset = 4,//未复位
        Reseting = 5 //复位中
    }

    public enum OperateLevel
    {
        Operator = 2,//操作员
        Engineer = 1,//工程师
        Admin = 0,//管理员
    }

}
