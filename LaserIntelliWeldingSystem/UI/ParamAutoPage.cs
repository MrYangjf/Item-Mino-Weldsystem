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
        AutoParam mAutoParam;
        string ParamIDName;
        string Jsonstring;

        DataTable ShowdataTable = new DataTable("DataTable");

        public ParamAutoPage()
        {
            InitializeComponent();
        }

        private void ParamAutoPage_Shown(object sender, EventArgs e)
        {
            //LoadXmlToTree(uiTreeView1.Nodes);
            GetAutoParamFromConfig();
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
                    mAutoParam = new AutoParam(mAutoParamInfo, DateTime.Now);
                    Jsonstring = JsonConvert.SerializeObject(mAutoParam);
                    GlobalCommData.mConfigManager.AddProductInfo(mAutoParam, Jsonstring);
                    GetAutoParamFromConfig();
                }
                else
                {
                    UIMessageBox.ShowError("已存在当前命名配置");
                }
            }
        }

        void LoadParamOnForm()
        {
            uiComboBox1.Text = mAutoParam.WeldType.ToString();

            mAutoParamName.Text = mAutoParam.identityInfo;
            WireType.Text = mAutoParam.WireType;
            PlateType.Text = mAutoParam.PlateType;
            WireDiameter.Value = mAutoParam.WireDiameter;
            Platethickness.Value = mAutoParam.Platethickness;
            LaserDiameter.Value = mAutoParam.LaserDiameter;
            LaserPower.Value = mAutoParam.LaserPower;
            FeedSpeed.Value = mAutoParam.FeedSpeed;
            RobotSpeed.Value = mAutoParam.RobotSpeed;
            SeamWidth.Value = mAutoParam.SeamWidth;
            SeamLength.Value = mAutoParam.SeamLength;
            MaxSeamWidth.Value = mAutoParam.SeamWidthMax;
            MinSeamWidth.Value = mAutoParam.SeamWidthMin;
            Sensitivity.Value = mAutoParam.Sensitivity;
        }

        void CorParamFromForm()
        {
            //mAutoParam.identityInfo = mAutoParamName.Text;
            mAutoParam.WeldType = (SeamType)uiComboBox1.SelectedIndex;
            mAutoParam.WireType = WireType.Text;
            mAutoParam.PlateType = PlateType.Text;
            mAutoParam.WireDiameter = WireDiameter.Value;
            mAutoParam.Platethickness = Platethickness.Value;
            mAutoParam.LaserDiameter = LaserDiameter.Value;
            mAutoParam.LaserPower = LaserPower.Value;
            mAutoParam.FeedSpeed = FeedSpeed.Value;
            mAutoParam.RobotSpeed = RobotSpeed.Value;
            mAutoParam.SeamWidth = SeamWidth.Value;
            mAutoParam.SeamLength = SeamLength.Value;
            mAutoParam.SeamWidthMax = MaxSeamWidth.Value;
            mAutoParam.SeamWidthMin = MinSeamWidth.Value;
            mAutoParam.Sensitivity = Sensitivity.Value;
        }

        void RefreshParam()
        {
            string Jsonstring = GlobalCommData.mConfigManager.GetProductInfo(ParamIDName);
            mAutoParam = JsonConvert.DeserializeObject<AutoParam>(Jsonstring);
            WeldProcess.Instance.GetListValue(mAutoParam);
            GlobalCommData.mAutoParamManage.DeleteTable(mAutoParam.identityInfo);
            GlobalCommData.mAutoParamManage.SelectTable(mAutoParam);
            LoadParamOnForm();

        }

        void CorParamDataBase()
        {
            //GlobalCommData.ParamConfigXdoc.SetConfig(mAutoParam.identityInfo);
            Jsonstring = JsonConvert.SerializeObject(mAutoParam);
            GlobalCommData.mConfigManager.UpdataConfig(mAutoParam.identityInfo, mAutoParam, Jsonstring);
        }

        void GetAutoParamFromConfig()
        {
            ParamIDName = GlobalCommData.ParamConfigXdoc.GetConfig();
            string Jsonstring = GlobalCommData.mConfigManager.GetProductInfo(ParamIDName);
            mAutoParam = JsonConvert.DeserializeObject<AutoParam>(Jsonstring);
            if (mAutoParam != null) LoadParamOnForm();
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
            autoValueForm.LoadConfigData(mAutoParam);
            autoValueForm.ShowDialog();
        }
    }
}
