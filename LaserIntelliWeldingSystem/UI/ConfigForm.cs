using LaserIntelliWeldingSystem.Communication;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Input;
//using System.ComponentModel;



namespace LaserIntelliWeldingSystem.UI
{
    public partial class ConfigForm : UIForm2
    {
        DataTable ShowdataTable = new DataTable("DataTable");

        public ConfigForm()
        {
            InitializeComponent();
            PageBangdingIni();
            LoadConfigData();
        }


        void PageBangdingIni()
        {
            //uiDataGridView1.DataSource = dataTable;
            ShowdataTable.Columns.Add("No.", typeof(int));
            ShowdataTable.Columns.Add("类型", typeof(string));
            ShowdataTable.Columns.Add("焊丝材质", typeof(string));
            ShowdataTable.Columns.Add("焊接板材", typeof(string));
            ShowdataTable.Columns.Add("时间", typeof(string));
            ShowdataTable.Columns.Add("标识", typeof(string));
        }

        void LoadConfigData()
        {
            GlobalCommData.mConfigManager.SelectTable();
            uiDataGridView1.ClearAll();
            //uiDataGridView1.DataSource = null;
            uiDataGridView1.DataSource = ShowdataTable;
            uiDataGridView1.AutoGenerateColumns = true;
            try
            {
                //设置分页控件总数
                uiPagination1.TotalCount = GlobalCommData.mConfigManager.mTable.Rows.Count;

                //设置分页控件每页数量
                uiPagination1.PageSize = 50;

                //uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;
                ShowdataTable.Rows.Clear();
                for (int i = 0; i < 50; i++)
                {
                    if (i >= GlobalCommData.mConfigManager.mTable.Rows.Count) break;
                    //int m= GlobalCommData.mConfigManager.mTable.Rows[i]["AUTOID"];
                    ShowdataTable.Rows.Add(GlobalCommData.mConfigManager.mTable.Rows[i]["AUTOID"], GlobalCommData.mConfigManager.mTable.Rows[i]["类型"]
                        , GlobalCommData.mConfigManager.mTable.Rows[i]["焊丝材质"], GlobalCommData.mConfigManager.mTable.Rows[i]["焊接板材"]
                        , GlobalCommData.mConfigManager.mTable.Rows[i]["时间"], GlobalCommData.mConfigManager.mTable.Rows[i]["标识"]);
                }

            }
            catch
            {

            }
        }


        private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            ShowdataTable.Rows.Clear();

            for (int i = (pageIndex - 1) * count; i < pageIndex * count; i++)
            {
                if (i >= GlobalCommData.mConfigManager.mTable.Rows.Count) break;
                ShowdataTable.Rows.Add(GlobalCommData.mConfigManager.mTable.Rows[i]["AUTOID"], GlobalCommData.mConfigManager.mTable.Rows[i]["类型"]
                    , GlobalCommData.mConfigManager.mTable.Rows[i]["焊丝材质"], GlobalCommData.mConfigManager.mTable.Rows[i]["焊接板材"]
                    , GlobalCommData.mConfigManager.mTable.Rows[i]["时间"], GlobalCommData.mConfigManager.mTable.Rows[i]["标识"]);
            }

        }


        public override void Translate()
        {
            //必须保留
            base.Translate();
            //读取翻译代码中的多语资源
            CodeTranslator.Load(this);
        }

        private class CodeTranslator : IniCodeTranslator<CodeTranslator>
        {
            public string OpenDir { get; set; } = "";
        }
    }
}
