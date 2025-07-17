using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaserIntelliWeldingSystem.FileIO.INIFile
{
    /// <summary>
    /// ini文件操作类
    /// </summary>
    public class IniFile
    {
        private string m_strPath = "";
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="iniPath">文件路径</param>
        public IniFile(string iniPath)
        {
            this.m_strPath = iniPath;
        }
        /// <summary>
        /// 获取配置文件目录
        /// </summary>
        /// <returns></returns>
        public static string GetConfigFileDirectory()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\Config";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }
        /// <summary>
        /// 获取用户自定义文件路径
        /// </summary>
        /// <param name="iniFileName"></param>
        /// <returns></returns>
        public static string GetCustomerIniPath(string iniFileName)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\Config";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (iniFileName.EndsWith(".ini"))
            {
                return string.Format(@"{0}\{1}", path, iniFileName);
            }
            return string.Format(@"{0}\{1}.ini", path, iniFileName);
        }
        /// <summary>
        /// 获取Config文件路径
        /// </summary>
        /// <returns></returns>
        public static string GetConfigIniPath()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\Config";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return string.Format(@"{0}\Config.ini", path);
        }
        /// <summary>
        /// 获取Device文件路径
        /// </summary>
        /// <returns></returns>
        public static string GetDeviceIniPath()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\Config";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return string.Format(@"{0}\Device.ini", path);
        }
        /// <summary>
        /// 获取Mes文件路径
        /// </summary>
        /// <returns></returns>
        public static string GetMesIniPath()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\Config";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return string.Format(@"{0}\Mes.ini", path);
        }
        /// <summary>
        /// 读配置
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="defaultVal">默认值</param>
        /// <returns></returns>
        public string ReadValue(string section, string key, string defaultVal = "")
        {
            StringBuilder retVal = new StringBuilder(0xff);
            Win32API.GetPrivateProfileString(section, key, defaultVal, retVal, 0xff, this.m_strPath);
            return retVal.ToString();
        }
        /// <summary>
        /// 写配置
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="Value">默认值</param>
        public void WriteValue(string section, string key, string Value)
        {
            Win32API.WritePrivateProfileString(section, key, Value, this.m_strPath);
        }
    }
}
