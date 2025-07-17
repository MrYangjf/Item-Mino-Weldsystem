using LaserIntelliWeldingSystem.Communication;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Windows.Input;

namespace LaserIntelliWeldingSystem.SQLiteDB
{
    public class ProductDatabaseManage
    {
        public SQLiteDataBase ProductDatabase;
        string Path = Application.StartupPath + "\\DataBase";
        string Filename = "\\Product.db";
        string DataBaseFile;
        string[] Cols = { "SN", "Time", "InspectionType", "Result", "Info" };
        string[] ValuesCol(string SN, DateTime StartTime,string Type, string Result, string CheckInfo)
        {
            return new string[] { SN, StartTime.ToString("yyyyMMddHHmmss"), Type, Result, CheckInfo };
        }
        string TodayTableName()
        {
            return "T" + DateTime.Now.ToString("yyyyMMdd");
        }

        public string TableName;
        public DataTable mTable;

        public string FindTableName(DateTime ChoseTime)
        {
            return "T" + ChoseTime.ToString("yyyyMMdd");
        }

        public ProductDatabaseManage()
        {
            if (!Directory.Exists(Path)) Directory.CreateDirectory(Path);
            DataBaseFile = Path + Filename;
            NewAuthdbFile();
        }

        void NewAuthdbFile()
        {
            ProductDatabase = new SQLiteDataBase(DataBaseFile);

            if (!ProductDatabase.IsExistTable(TodayTableName()))
            {
                ProductDatabase.CreateTable(TodayTableName(), Cols);
            }
        }

        public void SelectTable(DateTime ChoseTime)
        {
            TableName = FindTableName(ChoseTime);
            mTable = ProductDatabase.select(TableName);
        }

        public void AddProductInfo(string SN,DateTime StartTime ,string Type, string Result, string CheckInfo)
        {
            ProductDatabase.Insert(TodayTableName(), Cols, ValuesCol(SN, StartTime,Type, Result, CheckInfo));
        }

        public void NewDaysDatebase()
        {
            if (!ProductDatabase.IsExistTable(TodayTableName()))
            {
                ProductDatabase.CreateTable(TodayTableName(), Cols);
            }
        }

    }
}

