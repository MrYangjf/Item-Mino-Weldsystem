using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Data.SqlTypes;

namespace LaserIntelliWeldingSystem.SQLiteDB
{
    public class SQLiteDataBase
    {
        SQLiteConnection Connection;
        /// <summary>
        /// 构造函数
        /// </summary>
        public SQLiteDataBase()
        {

        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="DataBasePath">数据源路径,适应Acess数据源</param>
        public SQLiteDataBase(string DataBasePath)
        {
            string ConnectionString = string.Format("Data Source={0}", DataBasePath);

            Connection = new SQLiteConnection(ConnectionString);
            //OnInitConnect();
        }

        /// <summary>
        /// 析构函数
        /// </summary>
        ~SQLiteDataBase()
        {
            //try
            //{
            //    if (Connection != null)
            //        Connection.Close();
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(string.Format("数据库关闭失败，系统异常信息：{0}", e.Message));
            //}
            //try
            //{
            //    //Dispose();
            //}
            //catch (Exception ex)
            //{
            //    //MessageBox.Show(string.Format("数据库释放失败,系统异常信息：{1}", ex.Message));
            //}
        }
        /// <summary>
        /// 连接数据源
        /// </summary>
        public void OnInitConnect()
        {
            Connection.Open();
        }
        /// <summary>
        /// 断开数据源
        /// </summary>
        public void ExitConnect()
        {
            Connection.Close();
        }
        /// <summary>
        /// 释放数据库资源
        /// </summary>
        public void Dispose()
        {
            // 确保连接被关闭
            try
            {
                if (Connection != null)
                {
                    Connection.Dispose();
                    Connection = null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("数据库释放失败,系统异常信息：{1}", e.Message));
            }
        }
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <param name="DataBasePath"></param>
        public void ConnectDBFile(string DataBasePath)
        {
            string ConnectionString = string.Format("Data Source={0}", DataBasePath);
            Connection = new SQLiteConnection(ConnectionString);
        }

        /// <summary>
        /// 执行数据库语句,一般用于执行Insert,Update,Select等执行,
        /// </summary>
        /// <param name="strSQL">要执行的SQL语句</param>
        /// <returns>TRUE/False</returns>
        public bool ExecuteSQL(string strSQL)
        {
            OnInitConnect();
            try
            {
                var cmd = new SQLiteCommand(strSQL, Connection);
                int count = cmd.ExecuteNonQuery();
                if (count == -1)//表示更新不成功
                {
                    ExitConnect();
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("GetDataSet失败，SqlString={0},系统异常信息：{1}", strSQL, e.Message));
                return false;
            }
            finally
            {
                ExitConnect();
            }
        }
        /// <summary>
        /// 读取数据库语句
        /// 一般用来执行Select语句,返回一个DataSet结构数据,用于自己解析
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <returns>DataSet</returns>
        public DataSet GetDataSet(string strSQL)
        {
            var dataset = new DataSet();
            OnInitConnect();
            try
            {
                var adapter = new SQLiteDataAdapter(strSQL, Connection);
                adapter.Fill(dataset);
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("GetDataSet失败，SqlString={0},系统异常信息：{1}", strSQL, e.Message));
            }
            finally
            {
                ExitConnect();
            }
            return dataset;
        }

        /// <summary>
        /// 用于是否存在当前表
        /// </summary>
        /// <param name="TableName">参数TableName为所要查找的表名</param>
        /// <returns></returns>
        public bool IsExistTable(string TableName)
        {
            Connection.Open();
            //方法一:需修改文件屬性
            //var dateset = new DataSet();
            //String strSQL1 = string.Format("SELECT Count(*) AS RTab FROM MSysObjects WHERE ((MSysObjects.Name)Like '{0}')",TableName);
            //var adapter = new OleDbDataAdapter(strSQL1, Connection);
            ////int count = adapter.Fill();
            //adapter.Fill(dateset);
            //int tablecount = dateset.Tables.Count;
            //Connection.
            //方法二:
            DataTable schemaTable = Connection.GetSchema("Tables");
            string hhh = string.Format("TABLE_TYPE='table'and TABLE_NAME='{0}'", TableName);
            DataRow[] dr = schemaTable.Select(hhh);
            Connection.Close();
            foreach (DataRow dr2 in dr)
            {
                //MessageBox.Show("存在表!");
                return true;
            }
            return false;

        }
        /// <summary>
        /// 用于删除N天前的表
        /// </summary>
        /// <param name="n">参数n为保留天数，以前全部删掉</param>
        public void DropDateTable(double n)
        {
            Connection.Open();
            DataTable schemaTable = Connection.GetSchema("Tables", new string[] { null, null, null, "TABLE" });
            for (int i = 0; i < schemaTable.Rows.Count; i++)
            {
                try
                {
                    string tables = schemaTable.Rows[i][2].ToString();
                    DateTime date = Convert.ToDateTime(tables);
                    DateTime time = DateTime.Now.AddDays(-n);
                    if (date <= time)
                    {

                        String strSQL = string.Format("DROP TABLE {0}", tables);
                        var cmd = new SQLiteCommand(strSQL, Connection);
                        int count = cmd.ExecuteNonQuery();
                    }
                }
                catch
                {
                }

            }
            Connection.Close();
        }
        /// <summary>
        /// 判断是否存在文件
        /// </summary>
        /// <param name="strPathName">参数为数据库路径名</param>
        /// <returns></returns>
        public bool IsExistFile(string strPathName)
        {
            if (System.IO.File.Exists(strPathName))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// 创建表,此函数默认为创建字符列表项，其他请自行创建
        /// </summary>
        /// <param name="strTableName">参数1为表名</param>
        /// <param name="TableColumn">,参数2为要创建表的列名,把要建立的项放到一个数组里,项容量为10字符</param>
        /// <returns>成功true,失败false</returns>
        public bool CreateTable(string strTableName, string[] TableColumn)
        {
            if (TableColumn.Length > 0)
            {
                try
                {
                    if (!IsExistTable(strTableName))
                    {
                        //如果不存在,就創建當天的數據表
                        string strTableColumn = "";
                        for (int i = 0; i < TableColumn.Length; i++)
                        {
                            strTableColumn += ",[" + TableColumn[i] + "] char(10) not null";
                        }
                        OnInitConnect();
                        String strSQL = string.Format("CREATE TABLE {0}([AUTOID] INTEGER PRIMARY KEY AUTOINCREMENT{1})", strTableName, strTableColumn);
                        var cmd = new SQLiteCommand(strSQL, Connection);
                        int count = cmd.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception hh)
                {
                    MessageBox.Show(hh.ToString());
                }
                finally
                {
                    ExitConnect();
                }
            }
            return false;
        }
        /// <summary>
        /// 创建表,此函数默认为创建字符串列表项，其他请自行创建
        /// </summary>
        /// <param name="strTableName">表名</param>
        /// <param name="TableColumn">列名,把要建立的项放到一个数组里</param>
        /// <param name="Columnlength">对应列的数据容量长度</param>
        /// <returns>成功true,失败false</returns>
        public bool CreateTable(string strTableName, string[] TableColumn, int[] Columnlength)
        {
            if (TableColumn.Length > 0)
            {
                try
                {
                    //如果不存在,就创建当天
                    string strTableColumn = "";
                    string strlength = "";
                    for (int i = 0; i < TableColumn.Length; i++)
                    {
                        strlength = string.Format("] char({0}) not null", Columnlength[i]);
                        strTableColumn += ",[" + TableColumn[i] + strlength;

                    }
                    OnInitConnect();
                    String strSQL = string.Format("CREATE TABLE {0}([AUTOID] AUTOINCREMENT{1})", strTableName, strTableColumn);
                    var cmd = new SQLiteCommand(strSQL, Connection);
                    int count = cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception hh)
                {
                    MessageBox.Show(hh.ToString());
                }
                finally
                {
                    ExitConnect();
                }
            }
            return false;
        }

        public bool Insert(String tableName, string[] TableColumn, string[] Values)
        {
            String sqlString = "Insert into " + tableName;
            string addstr1 = "";
            string addstr2 = "";
            for (int i = 0; i < TableColumn.Length; i++)
            {
                if (i == 0)
                {
                    addstr1 += TableColumn[i];
                    addstr2 += "'" + Values[i] + "'";
                }
                else
                {
                    addstr1 += "," + TableColumn[i];
                    addstr2 += "," + "'" + Values[i] + "'";
                }
            }
            sqlString += "(" + addstr1 + ")VALUES(" + addstr2 + ")";
            return ExecuteSQL(sqlString);
        }

        public bool Updata(String tableName, string[] TableColumn, string[] Values, string AddressName, string Value)
        {
            String sqlString = "UPDATE " + tableName + " SET ";
            string addstr1 = "";
            string addstr2 = "";
            for (int i = 0; i < TableColumn.Length; i++)
            {
                if (i == 0)
                {
                    addstr1 += TableColumn[i] + "=" + Values[i];
                }
                else
                {
                    addstr1 += "," + TableColumn[i] + "=" + Values[i];
                }
            }
            addstr2 += AddressName + "=" + Value;
            sqlString += addstr1 + " WHERE " + addstr2;
            return ExecuteSQL(sqlString);
        }

        public void DropTable(String tableName)
        {
            string Sqlstr = string.Format("DROP TABLE IF EXISTS '{0}'", tableName);
            ExecuteSQL(Sqlstr);
        }

        /// <summary>
        /// 公有方法，获取数据，返回一个DataTable。
        /// </summary>
        /// <param name="sqlString">Sql语句</param>
        /// <returns>DataTable</returns>
        public DataTable GetDataTable(String sqlString)
        {
            DataSet dataset = GetDataSet(sqlString);
            dataset.CaseSensitive = false;
            if (dataset.Tables.Count > 0)
                return dataset.Tables[0];

            return null;
        }

        /// <summary>
        /// 公有方法，获取数据，返回一个DataRow。
        /// </summary>
        /// <param name="sqlString">Sql语句</param>
        /// <returns>DataRow</returns>
        public DataRow GetDataRow(String sqlString)
        {
            DataSet dataset = GetDataSet(sqlString);
            dataset.CaseSensitive = false;
            if (dataset.Tables[0].Rows.Count > 0)
            {
                return dataset.Tables[0].Rows[0];
            }
            return null;
        }

        /// <summary>
        /// 公有方法，获取数据，返回一个字符串。
        /// </summary>
        /// <param name="sqlString">Sql语句</param>
        /// <returns>string</returns>
        public string GetDataString(String sqlString)
        {
            DataSet dataset = GetDataSet(sqlString);
            dataset.CaseSensitive = false;
            if (dataset.Tables[0].Rows.Count > 0)
            {
                return dataset.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
            }
            return "";
        }

        public string GetDateTableCellValue(string Tablename, string info)
        {
            string strsql = string.Format(" SELECT [对象] FROM {0} WHERE [标识] = '{1}'", Tablename, info);
            return GetDataString(strsql);
        }

        public string GetDateTableKeyValue(string Tablename, string Key)
        {
            string strsql = string.Format(" SELECT {1} FROM {0}", Tablename, Key);
            return GetDataString(strsql);
        }

        public bool GetDateTableHaveValue(string Tablename, string info)
        {
            string strsql = string.Format(" SELECT [对象] FROM {0} WHERE [标识] = '{1}'", Tablename, info);
            DataSet dataset = GetDataSet(strsql);
            dataset.CaseSensitive = false;
            if (dataset.Tables[0].Rows.Count > 0) return true;
            else return false;
        }

        /// <summary>
        /// 选取表格
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public DataTable select(string tableName)
        {
            string strsql = "SELECT * FROM " + tableName;
            DataTable dt = GetDataTable(strsql);
            return dt;
        }
    }
}
