using LaserIntelliWeldingSystem.Communication;
using LaserIntelliWeldingSystem.WeldingData;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaserIntelliWeldingSystem.UI
{
    public partial class AutoValueForm : UIForm2
    {
        DataTable ShowdataTable = new DataTable("DataTable");

        public AutoValueForm()
        {
            InitializeComponent();
            PageBangdingIni();
            //LoadConfigData();
        }

        void PageBangdingIni()
        {
            //uiDataGridView1.DataSource = dataTable;
            ShowdataTable.Columns.Add("焊缝宽度", typeof(string));
            ShowdataTable.Columns.Add("焊接速度", typeof(string));
            ShowdataTable.Columns.Add("送丝速度", typeof(string));
            ShowdataTable.Columns.Add("焊接功率", typeof(string));
        }

        public void LoadConfigData(AutoParam autoParam)
        {
            //GlobalCommData.mConfigManager.SelectTable();
            GlobalCommData.mAutoParamManage.SelectTable(autoParam);
            uiDataGridView1.ClearAll();
            //uiDataGridView1.DataSource = null;
            uiDataGridView1.DataSource = ShowdataTable;
            uiDataGridView1.AutoGenerateColumns = true;
            try
            {

                //uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;
                ShowdataTable.Rows.Clear();
                for (int i = 0; i < WeldProcess.Instance.SeamWidthList.Count; i++)
                {
                    ShowdataTable.Rows.Add(WeldProcess.Instance.SeamWidthList[i], WeldProcess.Instance.RobotSpeedDic[WeldProcess.Instance.SeamWidthList[i]]
                        , WeldProcess.Instance.FeedSpeedDic[WeldProcess.Instance.SeamWidthList[i]]
                        , WeldProcess.Instance.LaserPowerDic[WeldProcess.Instance.SeamWidthList[i]]);
                }

            }
            catch
            {

            }
        }
    }
}
