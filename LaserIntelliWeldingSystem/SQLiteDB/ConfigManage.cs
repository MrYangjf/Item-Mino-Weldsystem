using LaserIntelliWeldingSystem.Communication;
using LaserIntelliWeldingSystem.FileIO;
using LaserIntelliWeldingSystem.WeldingData;
using Newtonsoft.Json;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LaserIntelliWeldingSystem.SQLiteDB
{
    public class ConfigManage
    {
        public SQLiteDataBase ProductDatabase;
        string Path = Application.StartupPath + "\\DataBase";
        string Filename = "\\Config.db";
        string DataBaseFile;
        string[] Cols = { "类型", "焊丝材质", "焊接板材", "时间", "标识", "对象" };
        string[] ValuesCol(string Type, string wire, string Plate, DateTime StartTime, string Info, string Jsonstr)
        {
            return new string[] { Type, wire, Plate, StartTime.ToString("yyyyMMddHHmmss"), Info, Jsonstr };
        }

        public string TableName;
        public DataTable mTable;

        public string FindTableName()
        {
            return "ParamConfigTable";
        }

        public ConfigManage()
        {
            if (!Directory.Exists(Path)) Directory.CreateDirectory(Path);
            DataBaseFile = Path + Filename;
            TableName = FindTableName();
            NewdbFile();
        }

        void NewdbFile()
        {
            ProductDatabase = new SQLiteDataBase(DataBaseFile);

            if (!ProductDatabase.IsExistTable(TableName))
            {
                ProductDatabase.CreateTable(TableName, Cols);
            }
        }

        public void SelectTable()
        {
            mTable = ProductDatabase.select(TableName);
        }

        public void AddProductInfo(string Type, string wire, string Plate, DateTime StartTime, string Info, string Jsonstr)
        {
            ProductDatabase.Insert(TableName, Cols, ValuesCol(Type, wire, Plate, StartTime, Info, Jsonstr));
        }

        public void AddProductInfo(AutoParam autoParam, string Jsonstr)
        {
            ProductDatabase.Insert(TableName, Cols, ValuesCol(autoParam.WeldType.ToString(), autoParam.WireType, autoParam.PlateType, autoParam.CreatTime, autoParam.identityInfo, Jsonstr));
        }

        public string GetProductInfo(string info)
        {
            return ProductDatabase.GetDateTableCellValue(TableName, info);
        }

        public void UpdataConfig(string info, AutoParam mAutoParam, string json)
        {
            info = string.Format("'{0}'", info);
            json = string.Format("'{0}'", json);
            string wiretypr = string.Format("'{0}'", mAutoParam.WireType);
            string platetypr = string.Format("'{0}'", mAutoParam.PlateType);
            string seamtype = string.Format("'{0}'", mAutoParam.WeldType);

            string[] Col = { "[类型]", "[焊丝材质]", "[焊接板材]", "[对象]" };
            string[] Value = { seamtype, wiretypr, platetypr, json };
            ProductDatabase.Updata(TableName, Col, Value, "[标识]", info);
        }

        public bool IsHaveTheConfig(string info)
        {
            return ProductDatabase.GetDateTableHaveValue(TableName, info);
        }

    }

    public class AutoValueManage
    {
        public SQLiteDataBase ProductDatabase;
        string Path = Application.StartupPath + "\\DataBase";
        string Filename = "\\AutoParamValue.db";
        string DataBaseFile;
        string[] Cols = { "焊缝宽度", "送丝速度", "激光功率", "焊接速度" };
        string[] ValuesCol(string Width, string FeedSpeed, string LaserPower, string RobotSpeed)
        {
            return new string[] { Width, FeedSpeed, LaserPower, RobotSpeed };
        }



        public string TableName = "test";
        public DataTable mTable;


        public AutoValueManage()
        {
            if (!Directory.Exists(Path)) Directory.CreateDirectory(Path);
            DataBaseFile = Path + Filename;
            NewdbFile();
        }



        void NewdbFile()
        {
            ProductDatabase = new SQLiteDataBase(DataBaseFile);

            if (!ProductDatabase.IsExistTable(TableName))
            {
                ProductDatabase.CreateTable(TableName, Cols);
            }
        }

        void CreatTable(string info)
        {
            TableName = info;
            if (!ProductDatabase.IsExistTable(TableName))
            {
                ProductDatabase.CreateTable(TableName, Cols);
            }
        }

        public void DeleteTable(string TableName)
        {
            ProductDatabase.DropTable(TableName);
        }

        public void SelectTable(AutoParam autoParam)
        {
            TableName = autoParam.identityInfo;
            if (ProductDatabase.IsExistTable(TableName))
            {
                string jsonstr = GetProductInfo("[焊缝宽度]");
                WeldProcess.Instance.SeamWidthList = JsonConvert.DeserializeObject<List<double>>(jsonstr);
                jsonstr = GetProductInfo("[送丝速度]");
                WeldProcess.Instance.FeedSpeedDic = JsonConvert.DeserializeObject<Dictionary<double, double>>(jsonstr);
                jsonstr = GetProductInfo("[激光功率]");
                WeldProcess.Instance.LaserPowerDic = JsonConvert.DeserializeObject<Dictionary<double, double>>(jsonstr);
                jsonstr = GetProductInfo("[焊接速度]");
                WeldProcess.Instance.RobotSpeedDic = JsonConvert.DeserializeObject<Dictionary<double, double>>(jsonstr);
            }
            else
            {
                CreatTable(autoParam.identityInfo);
                WeldProcess.Instance.GetListValue(autoParam);
                string Width = JsonConvert.SerializeObject(WeldProcess.Instance.SeamWidthList);
                string FeedSpeed = JsonConvert.SerializeObject(WeldProcess.Instance.FeedSpeedDic);
                string LaserPower = JsonConvert.SerializeObject(WeldProcess.Instance.LaserPowerDic);
                string RobotSpeed = JsonConvert.SerializeObject(WeldProcess.Instance.RobotSpeedDic);
                AddProductInfo(Width, FeedSpeed, LaserPower, RobotSpeed);
            }
        }

        string GetProductInfo(string info)
        {
            return ProductDatabase.GetDateTableKeyValue(TableName, info);
        }

        public void AddProductInfo(string Width, string FeedSpeed, string LaserPower, string RobotSpeed)
        {
            ProductDatabase.Insert(TableName, Cols, ValuesCol(Width, FeedSpeed, LaserPower, RobotSpeed));
        }


    }
}