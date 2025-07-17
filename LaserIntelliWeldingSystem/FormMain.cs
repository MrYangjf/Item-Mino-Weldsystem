using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaserIntelliWeldingSystem.Communication;
using LaserIntelliWeldingSystem.FileIO.XMLFile;
using LaserIntelliWeldingSystem.PageUI;
using LaserIntelliWeldingSystem.UI;
using Sunny.UI;

namespace LaserIntelliWeldingSystem
{
    public partial class FormMain : UIForm2
    {
        MainPage mainPage = new MainPage();
        ParamPage paramPage = new ParamPage();
        PCLPage PCLPage = new PCLPage();
        DataReview dataPage = new DataReview();

        bool HidePage = false;

        Dictionary<string, TreeNode> NodeDictionary = new Dictionary<string, TreeNode>();

        public FormMain()
        {
            InitializeComponent();
            this.MainTabControl = uiTabControl1;
            uiNavBar1.TabControl = uiTabControl1;
            //设置初始页面索引（关联页面，唯一不重复即可）
            int pageIndex = 1000;

            LoadPage(pageIndex);

            GlobalCommData.ShowLog("FormMain", "初始化完成");
            //uiStyleManager1.Style = UIStyle.Orange;
        }

        void LoadPage(int pageIndex)
        {
            WindowState = FormWindowState.Maximized;
            //uiNavBar1设置节点，也可以在Nodes属性里配置
            uiNavBar1.Nodes.Add("主页面");
            uiNavBar1.Nodes.Add("参数界面");
            uiNavBar1.Nodes.Add("图形界面");
            uiNavBar1.Nodes.Add("生产界面");

            uiNavBar1.Nodes[0].Name = "主页面";
            uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[0], pageIndex);
            uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[0], 57460);
            AddPage(mainPage, pageIndex);


            uiNavBar1.Nodes[1].Name = "参数界面";
            uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[1], ++pageIndex);
            uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[1], 61451);
            NodeDictionary.Add("参数界面", uiNavBar1.Nodes["参数界面"]);
            AddPage(paramPage, pageIndex);

            uiNavBar1.Nodes[2].Name = "图形界面";
            uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[2], ++pageIndex);
            uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[3], 61950);
            NodeDictionary.Add("图形界面", uiNavBar1.Nodes["图形界面"]);
            AddPage(PCLPage, pageIndex);

            uiNavBar1.Nodes[3].Name = "生产界面";
            uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[3], ++pageIndex);
            uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[3], 61950);
            NodeDictionary.Add("生产界面", uiNavBar1.Nodes["生产界面"]);
            AddPage(dataPage, pageIndex);

            
        }

        private void uiHeaderButton6_Click(object sender, EventArgs e)
        {
            FormLogin mLogin = new FormLogin();
            mLogin.ShowDialog();
        }

        void ShowStatus()
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action(ShowStatus));
            }
            else
            {
                lbl_OperateLevel.Text = GlobalCommData.mOperateLevel.ToString();
                lbl_SystemTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            }
        }

        void OperateLevelControl()
        {
            switch (GlobalCommData.mOperateLevel)
            {
                case OperateLevel.Admin:
                case OperateLevel.Engineer:
                    //ShowTreeNode();
                    break;
                case OperateLevel.Operator:
                    //HideTreeNode();

                    break;
            }
        }

        void HideTreeNode()
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action(HideTreeNode));
            }
            else
            if (!HidePage)
            {
                uiNavBar1.SelectedIndex = 0;
                uiNavBar1.SelectedForeColor = Color.Gray;
                uiNavBar1.SelectedHighColor = Color.Gray;
                uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[1], 1000);
                uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[2], 1000);
                uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[3], 1000);
                HidePage = true;
            }
        }
        void ShowTreeNode()
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action(ShowTreeNode));
            }
            else
            {
                if (HidePage)
                {
                    uiNavBar1.SelectedForeColor = Color.FromArgb(80, 160, 255);
                    uiNavBar1.SelectedHighColor = Color.FromArgb(80, 160, 255);
                    uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[1], 1001);
                    uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[2], 1002);
                    uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[3], 1003);
                    HidePage = false;
                }
            }
        }

        private void uiMillisecondTimer1_Tick(object sender, EventArgs e)
        {
            ShowStatus();
            OperateLevelControl();
        }
    }
}
