using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Diagnostics.Eventing.Reader;
using Sunny.UI;

namespace LaserIntelliWeldingSystem.FileIO.XMLFile
{
    public class XdocumentReaderWriter
    {
        public XDocument mXdocument;
        TextReader Reader;

        public string m_strConfig = AppDomain.CurrentDomain.BaseDirectory + @"\Config\";//XML文件位置
        string m_strConfigXmlName = "Config.xml";//XML文件名
        public XdocumentReaderWriter(string XMLName)
        {
            if (XMLName != "")
            {
                if (!XMLName.Contains(".xml")) XMLName += ".xml";
                m_strConfigXmlName = XMLName;
            }
            string m_strConfigXml = m_strConfig + m_strConfigXmlName;
            if (CheckFile(m_strConfigXml))
            {
                mXdocument = XDocument.Load(m_strConfigXml);
            }
            else
            {
                NewXdocument();
                SaveXdocument();
            }
        }

        ~XdocumentReaderWriter() { }

        bool CheckFile(string m_strConfigXml)
        {
            bool CheckRes = true;
            if (!Directory.Exists(m_strConfig))
            {
                CheckRes = false;
                Directory.CreateDirectory(m_strConfig);
            }
            if (!File.Exists(m_strConfigXml))
            {
                CheckRes = false;
            }
            return CheckRes;
        }

        public void NewXdocument()
        {
            mXdocument = new XDocument(new XElement("Root"));
        }

        public void SaveXdocument()
        {
            string m_strConfigXml = m_strConfig + m_strConfigXmlName;
            if (mXdocument != null)
                mXdocument.Save(m_strConfigXml);
            else
                UIMessageBox.ShowError("未打开任何文件，无法保存");
        }

        public string GetIP()
        {
            try
            {
                string Ip = mXdocument.Descendants("IP").FirstOrDefault().Value;
                return Ip;
            }
            catch
            {
                return "";
            }
        }

        public int GetPort()
        {
            try
            {
                int port = int.Parse(mXdocument.Descendants("PORT").FirstOrDefault().Value);
                return port;
            }
            catch
            { return -1; }
        }

        public string GetConfig()
        {
            try
            {
                string ID = mXdocument.Descendants("ConfigName").FirstOrDefault().Value;
                return ID;
            }
            catch
            {
                return "";
            }
        }

        public void SetConfig(string Name)
        {
            try
            {
                 mXdocument.Descendants("ConfigName").FirstOrDefault().Value= Name;
                SaveXdocument();
            }
            catch
            {
            }
        }

        public string GetXMLSendStr()
        {
            string XMLconvertstring;
            XMLconvertstring = mXdocument.ToString(SaveOptions.DisableFormatting);
            return XMLconvertstring;
        }

        public string GetXmlStrValue(string XMLStr, string Element, string Attribute)
        {
            string ValueStr;
            Reader = new StringReader(XMLStr);
            mXdocument = XDocument.Load(Reader);
            ValueStr = mXdocument.Descendants(Element).FirstOrDefault().Attribute(Attribute).Value;
            return ValueStr;
        }

        public string GetXmlStrValue(string XMLStr, string Element)
        {
            string ValueStr;
            Reader = new StringReader(XMLStr);
            mXdocument = XDocument.Load(Reader);
            ValueStr = mXdocument.Descendants(Element).FirstOrDefault().Value;
            return ValueStr;
        }
    }
}
