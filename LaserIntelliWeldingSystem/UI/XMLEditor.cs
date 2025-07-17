using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
using LaserIntelliWeldingSystem.Communication;
using Sunny.UI;

namespace LaserIntelliWeldingSystem.FileIO.XMLFile
{
    public partial class XMLEditor : UIPage
    {
        XElement currentElement;
        XdocumentReaderWriter mXdocumentFile;
        Dictionary<TreeNode, XElement> nodeToXml = new Dictionary<TreeNode, XElement>();
        string dataCellBeginEditValue;

        public XMLEditor()
        {
            InitializeComponent();
        }


        void LoadXmlToTree(XElement x, TreeNodeCollection nodes)
        {
            TreeNode node = new TreeNode(x.Name.ToString());

            nodes.Add(node);
            nodeToXml.Add(node, x);
            if (x.HasElements)
            {
                foreach (var ele in x.Elements())
                {
                    LoadXmlToTree(ele, node.Nodes);
                }
            }
        }

        private void ClearXmlAllInfo()
        {
            uiTreeView1.Nodes.Clear();
            uiDataGridView1.Columns.Clear();
            nodeToXml = new Dictionary<TreeNode, XElement>();
        }

        private void ReadServerXdocument_Click(object sender, EventArgs e)
        {
            ClearXmlAllInfo();

            mXdocumentFile = GlobalCommData.ServerXdoc;
            LoadXmlToTree(mXdocumentFile.mXdocument.Root, uiTreeView1.Nodes);
        }

        private void uiTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            uiDataGridView1.Columns.Clear();
            currentElement = nodeToXml[uiTreeView1.SelectedNode];
            uiDataGridView1.Columns.Add("ElementName", "Name");
            uiDataGridView1.Rows[0].Cells[0].Value = currentElement.Name;
            uiDataGridView1.Columns.Add("ElementText", "Text");
            uiDataGridView1.Rows[0].Cells[1].Value = currentElement.Value;
            if (currentElement.HasAttributes)
            {
                int count = 0;
                foreach (var a in currentElement.Attributes())
                {
                    uiDataGridView1.Columns.Add("AttributeName" + count, "AttributesName" + count);
                    uiDataGridView1.Rows[0].Cells[count * 2 + 2].Value = a.Name;
                    uiDataGridView1.Columns.Add("AttributeValue" + count.ToString(), "AttributesValue" + count.ToString());
                    uiDataGridView1.Rows[0].Cells[count * 2 + 3].Value = a.Value;
                    count++;
                }
            }
        }

        private void uiDataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dataCellBeginEditValue = uiDataGridView1.Rows[0].Cells[e.ColumnIndex].Value.ToString();
        }

        private void uiDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int cIndex = e.ColumnIndex;
            if (cIndex == 0)//改元素名字
            {
                char temp = uiDataGridView1.Rows[0].Cells[cIndex].Value.ToString()[0];
                if (temp > 47 && temp < 58)//48是0，57是9
                {
                    uiDataGridView1.Rows[0].Cells[cIndex].Value = dataCellBeginEditValue;
                    //LogSystem.WriteLog("元素名不能以数字为开头", LogState.Warning);
                }
                else
                {
                    currentElement.Name = uiDataGridView1.Rows[0].Cells[cIndex].Value.ToString();
                    //treeView_XMLTree.SelectedNode.Text = currentElement.Name.ToString();
                }

            }
            else if (cIndex == 1)//改元素值
            {
                currentElement.Value = uiDataGridView1.Rows[0].Cells[cIndex].Value.ToString();
            }
            else
            {
                if (cIndex % 2 == 0)//改元素属性名字
                {
                    char temp = uiDataGridView1.Rows[0].Cells[cIndex].Value.ToString()[0];
                    if (temp > 47 && temp < 58)//检查属性名是否以数字开头
                    {
                        uiDataGridView1.Rows[0].Cells[cIndex].Value = dataCellBeginEditValue;
                        //LogSystem.WriteLog("属性名不能以数字为开头", LogState.Warning);
                    }
                    else
                    {
                        int columnCount = uiDataGridView1.Columns.Count;
                        bool canEdit = true;
                        if (columnCount > 4)//>4是多属性的情况,需要检查是否能修改属性名字
                        {
                            string cellValue = uiDataGridView1.Rows[0].Cells[cIndex].Value.ToString();

                            for (int i = 2; i < columnCount; i += 2)
                            {
                                if (cIndex == i) continue;//跳过自身
                                else
                                {
                                    if (uiDataGridView1.Rows[0].Cells[i].Value.ToString() == cellValue)
                                    {
                                        MessageBox.Show("属性名不能一样！属性名和第" + (i + 1) + "列一样！");
                                        uiDataGridView1.Rows[0].Cells[cIndex].Value = dataCellBeginEditValue;//属性名字回滚
                                        canEdit = false;
                                        break;
                                    }
                                }
                            }
                        }
                        if (canEdit)
                        {   //属性不能改名字，需要重新生成
                            XElement myCompare = new XElement(currentElement);
                            currentElement.Attributes().Remove();
                            foreach (var a in myCompare.Attributes())
                            {
                                if (a.Name == dataCellBeginEditValue)
                                {
                                    currentElement.Add(new XAttribute(uiDataGridView1.Rows[0].Cells[cIndex].Value.ToString(), uiDataGridView1.Rows[0].Cells[cIndex + 1].Value.ToString()));
                                }
                                else
                                {
                                    currentElement.Add(a);
                                }
                            }
                        }
                    }
                }
                else//改元素属性值
                {
                    currentElement.Attribute(uiDataGridView1.Rows[0].Cells[cIndex - 1].Value.ToString()).Value = uiDataGridView1.Rows[0].Cells[cIndex].Value.ToString();
                }
            }
        }

        private void ReadClientXdocument_Click(object sender, EventArgs e)
        {
            ClearXmlAllInfo();
            mXdocumentFile = GlobalCommData.ClientXdoc;
            LoadXmlToTree(mXdocumentFile.mXdocument.Root, uiTreeView1.Nodes);
        }

        private void SaveXdocument_Click(object sender, EventArgs e)
        {
            if (mXdocumentFile != null)
                mXdocumentFile.SaveXdocument();
            else
                UIMessageBox.ShowError("未初始化文档,无法保存！");
        }

        private void 读取发送XML格式文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearXmlAllInfo();
            mXdocumentFile = GlobalCommData.SendXdoc;
            LoadXmlToTree(mXdocumentFile.mXdocument.Root, uiTreeView1.Nodes);
        }

        private void 读取接受XML格式文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearXmlAllInfo();
            mXdocumentFile = GlobalCommData.ReciveXdoc;
            LoadXmlToTree(mXdocumentFile.mXdocument.Root, uiTreeView1.Nodes);
        }
    }
}
