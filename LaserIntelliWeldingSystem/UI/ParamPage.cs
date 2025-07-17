using LaserIntelliWeldingSystem.FileIO.XMLFile;
using LaserIntelliWeldingSystem.UI;
using Sunny.UI;
using System.Drawing;
using System.Windows.Forms;


namespace LaserIntelliWeldingSystem.PageUI
{
    public partial class ParamPage : UIPage
    {
        XMLEditor mXMLEditor=new XMLEditor ();
        TCPServer mTCPServer=new TCPServer ();
        TCPClinet mTCPClinet=new TCPClinet ();
        ParamAutoPage mParamAutoPage = new ParamAutoPage ();
        public ParamPage()
        {
            InitializeComponent();

            uiNavBar1.TabControl = uiTabControl1;
            uiNavMenu1.TabControl = uiTabControl1;

            int pageIndex = 1000;

            //uiNavBar1设置节点，也可以在Nodes属性里配置
            uiNavBar1.Nodes.Add("文件配置");
            uiNavBar1.Nodes.Add("通讯配置");
            uiNavBar1.Nodes.Add("工艺配置");

            uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[0], pageIndex);
            uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[0], 61451);
            TreeNode parent = uiNavMenu1.CreateNode("文件配置", 61451, 24, pageIndex);
            mXMLEditor.PageIndex = pageIndex;   
            uiTabControl1.AddPage(mXMLEditor);
            uiNavMenu1.CreateChildNode(parent, mXMLEditor.Text, pageIndex);


            uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[1], ++pageIndex);
            uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[1], 61451);
            parent = uiNavMenu1.CreateNode("通讯配置", 61451, 24, pageIndex);
            mTCPServer.PageIndex = pageIndex;
            uiTabControl1.AddPage(mTCPServer);
            uiNavMenu1.CreateChildNode(parent, mTCPServer.Text, pageIndex);
            mTCPClinet.PageIndex = ++pageIndex;
            uiTabControl1.AddPage(mTCPClinet);
            uiNavMenu1.CreateChildNode(parent, mTCPClinet.Text, pageIndex);

            uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[2], ++pageIndex);
            uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[2], 61451);
            parent = uiNavMenu1.CreateNode("工艺配置", 61451, 24, pageIndex);
            mParamAutoPage.PageIndex = pageIndex;
            uiTabControl1.AddPage(mParamAutoPage);
            uiNavMenu1.CreateChildNode(parent, mParamAutoPage.Text, pageIndex);

        }
    }
}
