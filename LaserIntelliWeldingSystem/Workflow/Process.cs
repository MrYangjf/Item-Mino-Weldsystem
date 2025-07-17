using LaserIntelliWeldingSystem.Communication;
using LaserIntelliWeldingSystem.FileIO.XMLFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LaserIntelliWeldingSystem.Workflow
{
    abstract class Process
    {
        /// <summary>
        /// 流程标志
        /// </summary>
        public string TAG = "";

        /// <summary>
        /// 工位是否启用
        /// </summary>
        public bool IsStationEnable = false;
        /// <summary>
        /// 工作步数
        /// </summary>
        public int WorkStep = 0;
        /// <summary>
        /// 操作开始时间
        /// </summary>
        public DateTime WorkStartTime = DateTime.Now;

        /// <summary>
        /// 流程处理
        /// </summary>
        public abstract void FlowProcess();

        /// <summary>
        /// 复位流程
        /// </summary>
        public abstract bool ResetProcess();
        /// <summary>
        /// 状态清除
        /// </summary>
        public abstract void ClearStatus();
        /// <summary>
        /// 复位时间
        /// </summary>
        public abstract void ResetWorkTime();
        /// <summary>
        /// 清料流程
        /// </summary>
        public abstract void ClearProduct();
        /// <summary>
        /// 加载配置
        /// </summary>
        public abstract void LoadConfig(XdocumentReaderWriter reader);
        /// <summary>
        /// 保存配置
        /// </summary>
        public abstract void SaveConfig(XdocumentReaderWriter writer);
    }
}
