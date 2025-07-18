using LaserIntelliWeldingSystem.Communication;
using LaserIntelliWeldingSystem.FileIO.XMLFile;
using LaserIntelliWeldingSystem.SQLiteDB;
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
using System.Xml.Linq;
using Newtonsoft.Json;

namespace LaserIntelliWeldingSystem.UI
{
    public partial class ParamAutoPage : UIPage
    {

        string ParamIDName;
        string Jsonstring;

        DataTable ShowdataTable = new DataTable("DataTable");

        public ParamAutoPage()
        {
            InitializeComponent();
            GetAutoParam();
        }

        private void ParamAutoPage_Shown(object sender, EventArgs e)
        {
            //LoadXmlToTree(uiTreeView1.Nodes);
            if (GlobalCommData.mAutoParam != null) LoadParamOnForm();
        }

        private void uibtnShowConfigList_Click(object sender, EventArgs e)
        {
            ConfigForm mConfigForm = new ConfigForm();
            mConfigForm.ShowDialog();
        }

        private void uiAddNewConfig_Click(object sender, EventArgs e)
        {
            string mAutoParamInfo = "";
            if (this.ShowInputStringDialog(ref mAutoParamInfo, true, "请输入配置名称", true))
            {
                //this.ShowInfoDialog(mAutoParamInfo);

                if (!GlobalCommData.mConfigManager.IsHaveTheConfig(mAutoParamInfo))
                {
                    GlobalCommData.ParamConfigXdoc.SetConfig(mAutoParamInfo);
                    GlobalCommData.mAutoParam = new AutoParam(mAutoParamInfo, DateTime.Now);
                    Jsonstring = JsonConvert.SerializeObject(GlobalCommData.mAutoParam);
                    GlobalCommData.mConfigManager.AddProductInfo(GlobalCommData.mAutoParam, Jsonstring);
                    GetAutoParam();
                    if (GlobalCommData.mAutoParam != null) LoadParamOnForm();
                }
                else
                {
                    UIMessageBox.ShowError("已存在当前命名配置");
                }
            }
        }

        void LoadParamOnForm()
        {
            uiComboBox1.Text =GlobalCommData.mAutoParam.WeldType.ToString();

            mAutoParamName.Text = GlobalCommData.mAutoParam.identityInfo;
            WireType.Text = GlobalCommData.mAutoParam.WireType;
            PlateType.Text = GlobalCommData.mAutoParam.PlateType;
            WireDiameter.Value = GlobalCommData.mAutoParam.WireDiameter;
            Platethickness.Value = GlobalCommData.mAutoParam.Platethickness;
            LaserDiameter.Value = GlobalCommData.mAutoParam.LaserDiameter;
            LaserPower.Value = GlobalCommData.mAutoParam.LaserPower;
            FeedSpeed.Value = GlobalCommData.mAutoParam.FeedSpeed;
            RobotSpeed.Value = GlobalCommData.mAutoParam.RobotSpeed;
            SeamWidth.Value = GlobalCommData.mAutoParam.SeamWidth;
            SeamLength.Value = GlobalCommData.mAutoParam.SeamLength;
            MaxSeamWidth.Value = GlobalCommData.mAutoParam.SeamWidthMax;
            MinSeamWidth.Value = GlobalCommData.mAutoParam.SeamWidthMin;
            Sensitivity.Value = GlobalCommData.mAutoParam.Sensitivity;
        }

        void CorParamFromForm()
        {
            //mAutoParam.identityInfo = mAutoParamName.Text;
            GlobalCommData.mAutoParam.WeldType = (SeamType)uiComboBox1.SelectedIndex;
            GlobalCommData.mAutoParam.WireType = WireType.Text;
            GlobalCommData.mAutoParam.PlateType = PlateType.Text;
            GlobalCommData.mAutoParam.WireDiameter = WireDiameter.Value;
            GlobalCommData.mAutoParam.Platethickness = Platethickness.Value;
            GlobalCommData.mAutoParam.LaserDiameter = LaserDiameter.Value;
            GlobalCommData.mAutoParam.LaserPower = LaserPower.Value;
            GlobalCommData.mAutoParam.FeedSpeed = FeedSpeed.Value;
            GlobalCommData.mAutoParam.RobotSpeed = RobotSpeed.Value;
            GlobalCommData.mAutoParam.SeamWidth = SeamWidth.Value;
            GlobalCommData.mAutoParam.SeamLength = SeamLength.Value;
            GlobalCommData.mAutoParam.SeamWidthMax = MaxSeamWidth.Value;
            GlobalCommData.mAutoParam.SeamWidthMin = MinSeamWidth.Value;
            GlobalCommData.mAutoParam.Sensitivity = Sensitivity.Value;
        }

        void RefreshParam() 
        {
            string Jsonstring = GlobalCommData.mConfigManager.GetProductInfo(ParamIDName);
            GlobalCommData.mAutoParam = JsonConvert.DeserializeObject<AutoParam>(Jsonstring);
            WeldProcess.Instance.GetListValue(GlobalCommData.mAutoParam);
            GlobalCommData.mAutoParamManage.DeleteTable(GlobalCommData.mAutoParam.identityInfo);
            GlobalCommData.mAutoParamManage.SelectTable(GlobalCommData.mAutoParam);
            LoadParamOnForm();

        }

        void CorParamDataBase()
        {
            //GlobalCommData.ParamConfigXdoc.SetConfig(mAutoParam.identityInfo);
            Jsonstring = JsonConvert.SerializeObject(GlobalCommData.mAutoParam);
            GlobalCommData.mConfigManager.UpdataConfig(GlobalCommData.mAutoParam.identityInfo, GlobalCommData.mAutoParam, Jsonstring);
        }

        void GetAutoParam()
        {
            ParamIDName = GlobalCommData.ParamConfigXdoc.GetConfig();
            string Jsonstring = GlobalCommData.mConfigManager.GetProductInfo(ParamIDName);
            GlobalCommData.mAutoParam = JsonConvert.DeserializeObject<AutoParam>(Jsonstring);
            GlobalCommData.mAutoParamManage.SelectTable(GlobalCommData.mAutoParam);
        }

        private void btnCorAutoParam_Click(object sender, EventArgs e)
        {
            CorParamFromForm();
            CorParamDataBase();
            RefreshParam();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            //WeldProcess.Instance.GetListValue(mAutoParam);
            AutoValueForm autoValueForm = new AutoValueForm();
            autoValueForm.LoadConfigData(GlobalCommData.mAutoParam);
            autoValueForm.ShowDialog();
        }
    }
}
