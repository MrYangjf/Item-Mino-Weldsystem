using LaserIntelliWeldingSystem.Communication;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
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
    public class AuthManage
    {
        public SQLiteDataBase AuthDataBase;
        string Path = Application.StartupPath + "\\DataBase";
        string Filename = "\\Auth.db";
        string DataBaseFile;
        string[] Cols = { "User", "Password", "Userlevel" };
        string[] AuthValues = { "Admin", "MINO123456", "0" };
        string TableName = "AuthTable";
        public AuthManage()
        {
            IniUser();
            if (!Directory.Exists(Path)) Directory.CreateDirectory(Path);
            DataBaseFile = Path + Filename;

            NewAuthdbFile();

            ReadPassword();
        }

        public void NewAuthdbFile()
        {
            AuthDataBase = new SQLiteDataBase(DataBaseFile);
            string[] EngValues = { "Engineer", "123", "1" };

            if (!AuthDataBase.IsExistTable(TableName))
            {
                AuthDataBase.CreateTable(TableName, Cols);
                AuthDataBase.Insert(TableName, Cols, AuthValues);
                AuthDataBase.Insert(TableName, Cols, EngValues);
            }
        }

        public void CorEngineerPassword(string PasswordValue)
        {
            string[] EngCol = { "User" };
            string[] EngValue = { "'Engineer'" };
            AuthDataBase.Updata(TableName, EngCol, EngValue, "Password", PasswordValue);
        }

        string ReadEngineerPassword()
        {
            string Re;
            string Sqlstring = "SELECT Password FROM AuthTable WHERE User = 'Engineer'";
            Re = AuthDataBase.GetDataString(Sqlstring);
            return Re;

        }

        void IniUser()
        {
            User.Add("Admin");
            User.Add("Engineer");
            User.Add("Operater");
            Userlevel.Add("Admin", OperateLevel.Admin);
            Userlevel.Add("Engineer", OperateLevel.Engineer);
            Userlevel.Add("Operater", OperateLevel.Operator);
        }

        public void ReadPassword()
        {
            Password.Add("Admin", "MINO123456");
            Password.Add("Engineer", ReadEngineerPassword());
            Password.Add("Operater", "null");
        }

        public List<string> User = new List<string>();
        public Dictionary<string, string> Password = new Dictionary<string, string>();
        public Dictionary<string, OperateLevel> Userlevel = new Dictionary<string, OperateLevel>();
    }
}
