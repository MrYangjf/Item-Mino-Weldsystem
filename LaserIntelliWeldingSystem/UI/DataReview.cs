using LaserIntelliWeldingSystem.Communication;
using Sunny.UI;
using System.Drawing;
using System;
using System.Reflection;
using PointCloudSharp;
using Sunny.UI.Win32;
using System.IO;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using LaserIntelliWeldingSystem.WeldingData;


namespace LaserIntelliWeldingSystem.PageUI
{
    public partial class DataReview : UIPage
    {
        DataTable ShowdataTable = new DataTable("DataTable");
        public string[] FilestrArray;
        public List<string> FilestrList;
        public string DataFileName = "";
        public string DataFilePath = "";
        public double MinValueRobotX, MaxValueRobotX, TrackbarRate;

        UILineOption option = new UILineOption();
        UILineOption option2 = new UILineOption();
        UILineOption option3 = new UILineOption();
        UILineOption option4 = new UILineOption();
        UILineOption option5 = new UILineOption();

        UILineSeries series;
        UILineSeries series2;
        UILineSeries series3;

        MainPage.ChartVar RobSpeedchartVar, FeedSpeedchartVar, SeamWidthchartVar, LaserPowerchartVar;


        public DataReview()
        {
            InitializeComponent();
            PageBangdingIni();
        }

        private void DataReview_Shown(object sender, EventArgs e)
        {
            AfterInitializeUI();
        }

        ~DataReview()
        {
        }

        void PageBangdingIni()
        {
            uiCalendar1.Date = DateTime.Today;
            //uiDataGridView1.DataSource = dataTable;
            ShowdataTable.Columns.Add("No.", typeof(int));
            ShowdataTable.Columns.Add("FileName", typeof(string));
            ShowdataTable.Columns.Add("Datatype", typeof(string));
        }
        private void InitPCLDir(DateTime InputDateTime)
        {
            uiDataGridView1.ClearAll();
            string name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            this.DataFilePath = "";
            string path = "D:";
            DataFilePath = path + @"\IntelliSystemPCLData\Online";

            if (Directory.Exists(DataFilePath))
            {
                string year, month, day;
                year = InputDateTime.ToString("yyyy");
                month = InputDateTime.ToString("MM");
                day = InputDateTime.ToString("dd");
                DataFilePath = string.Format(@"{0}\{1}\{2}\{3}", DataFilePath, year, month, day);
                if (Directory.Exists(DataFilePath))
                {
                    FilestrArray = Directory.GetFiles(DataFilePath);
                    //FilestrArray.BubbleSort();
                    if (FilestrArray.Length > 0)
                    {
                        FreshDataGridViewer(InputDateTime);
                    }
                }
            }


        }

        void SeamWidthShowRange(int TrackValue)
        {
            uiLineChart2.Option.XAxis.SetRange(MinValueRobotX + (TrackValue-1)  * TrackbarRate, MinValueRobotX + (TrackValue+1) * TrackbarRate);
            uiLineChart2.Refresh();
            uiLineChart3.Option.XAxis.SetRange(MinValueRobotX + (TrackValue - 1) * TrackbarRate, MinValueRobotX + (TrackValue + 1) * TrackbarRate);
            uiLineChart3.Refresh();
            uiLineChart4.Option.XAxis.SetRange(MinValueRobotX + (TrackValue - 1) * TrackbarRate, MinValueRobotX + (TrackValue + 1) * TrackbarRate);
            uiLineChart4.Refresh();
            uiLineChart5.Option.XAxis.SetRange(MinValueRobotX + (TrackValue - 1) * TrackbarRate, MinValueRobotX + (TrackValue + 1) * TrackbarRate);
            uiLineChart5.Refresh();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            SeamWidthShowRange(trackBar1.Value);
        }

        private void uiLineChart2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            uiLineChart2.Option.XAxis.SetRange(MinValueRobotX, MaxValueRobotX);
            uiLineChart2.Refresh();


        }

        private void uiLineChart4_DoubleClick(object sender, EventArgs e)
        {
            uiLineChart4.Option.XAxis.SetRange(MinValueRobotX, MaxValueRobotX);
            uiLineChart4.Refresh();
        }

        private void uiLineChart3_DoubleClick(object sender, EventArgs e)
        {
            uiLineChart3.Option.XAxis.SetRange(MinValueRobotX, MaxValueRobotX);
            uiLineChart3.Refresh();
        }

        private void uiLineChart5_DoubleClick(object sender, EventArgs e)
        {
            uiLineChart5.Option.XAxis.SetRange(MinValueRobotX, MaxValueRobotX);
            uiLineChart5.Refresh();
        }

        private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            ShowdataTable.Rows.Clear();

            for (int i = (pageIndex - 1) * count; i < pageIndex * count; i++)
            {
                if (i >= FilestrArray.Length) break;
                ShowdataTable.Rows.Add(i + 1, FilestrArray[i], "OnlineData");
            }

            uiDataGridViewFooter1.Clear();
            uiDataGridViewFooter1["No."] = "Total:" + FilestrArray.Length;
        }

        private void btn_LoadFile_Click(object sender, EventArgs e)
        {
            InitPCLDir(uiCalendar1.Date);
        }

        private void uiDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string path = uiDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string[] textLines = File.ReadAllLines(path);
            uiLineChart2.Option.Series["焊缝宽度"].Clear();
            SeamWidthchartVar = new MainPage.ChartVar();
            for (int i = 0; i < textLines.Length; i++)
            {
                double RobotX, Width, RobotSpeed, FeedSpeed, LaserPower;

                try
                {
                    string[] textContent = textLines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    RobotX = double.Parse(textContent[0]);
                    Width = double.Parse(textContent[1]);
                    RobotSpeed = double.Parse(textContent[2]);
                    FeedSpeed = double.Parse(textContent[3]);
                    LaserPower = double.Parse(textContent[4]);
                    if (i < 1)
                    {
                        //文件头 不需要处理
                    }
                    if (i == 2)
                    {
                        MinValueRobotX = RobotX;
                    }
                    else if (i == textLines.Length - 1)
                    {
                        MaxValueRobotX = RobotX;
                    }
                    SeamWidthchartVar.Add(RobotX, Width);
                    RobSpeedchartVar.Add(RobotX, RobotSpeed);
                    FeedSpeedchartVar.Add(RobotX, FeedSpeed);
                    LaserPowerchartVar.Add(RobotX, LaserPower);
                }
                catch { }

            }
            trackBar1.Maximum = textLines.Length - 2;
            TrackbarRate = (MaxValueRobotX - MinValueRobotX) / trackBar1.Maximum;

            uiLineChart2.Option.AddData("焊缝宽度", SeamWidthchartVar.X, SeamWidthchartVar.Y);
            uiLineChart2.Option.XAxis.SetRange(MinValueRobotX, MinValueRobotX + TrackbarRate);
            uiLineChart2.Refresh();

            uiLineChart3.Option.AddData("运动速度", RobSpeedchartVar.X, RobSpeedchartVar.Y);
            uiLineChart3.Option.XAxis.SetRange(MinValueRobotX, MinValueRobotX + TrackbarRate);
            uiLineChart3.Refresh();

            uiLineChart4.Option.AddData("送丝速度", FeedSpeedchartVar.X, FeedSpeedchartVar.Y);
            uiLineChart4.Option.XAxis.SetRange(MinValueRobotX, MinValueRobotX + TrackbarRate);
            uiLineChart4.Refresh();

            uiLineChart5.Option.AddData("激光功率", LaserPowerchartVar.X, LaserPowerchartVar.Y);
            uiLineChart5.Option.XAxis.SetRange(MinValueRobotX, MinValueRobotX + TrackbarRate);
            uiLineChart5.Refresh();

        }

        void FreshDataGridViewer(DateTime InputDateTime)
        {

            //uiDataGridView1.DataSource = null;
            uiDataGridView1.DataSource = ShowdataTable;
            //uiDataGridView1.AutoGenerateColumns = true;
            try
            {
                uiPagination1.TotalCount = FilestrArray.Length;

                //设置分页控件每页数量
                uiPagination1.PageSize = 50;

                //uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;
                ShowdataTable.Rows.Clear();

                for (int i = 0; i < 50; i++)
                {
                    if (i >= FilestrArray.Length) break;
                    ShowdataTable.Rows.Add(i + 1, FilestrArray[i], "OnlineData");

                }
                uiDataGridView1.Columns[0].Width = 30;
                uiDataGridView1.Columns[2].Width = 100;
                uiDataGridViewFooter1.DataGridView = uiDataGridView1;


                uiTitlePanel1.Text = "DataViewer：" + InputDateTime.ToString("yyyyMMdd");
            }
            catch { }
        }

        void AfterInitializeUI()
        {
            option2 = new UILineOption();
            option2.ToolTip.Visible = true;
            option2.Title = new UITitle();
            option2.Title.Text = "焊缝宽度";
            series = option2.AddSeries(new UILineSeries("焊缝宽度"));
            SeamWidthchartVar = new MainPage.ChartVar();
            option2.XAxis.Name = "Robot X";
            option2.YAxis.Name = "Width";

            //坐标轴显示小数位数
            option2.XAxis.AxisLabel.DecimalPlaces = 2;
            option2.YAxis.AxisLabel.DecimalPlaces = 2;
            uiLineChart2.SetOption(option2);


            option3 = new UILineOption();
            option3.ToolTip.Visible = true;
            option3.Title = new UITitle();
            option3.Title.Text = "机器人运动速度";
            series = option3.AddSeries(new UILineSeries("运动速度"));
            RobSpeedchartVar = new MainPage.ChartVar();
            option3.XAxis.Name = "Robot X";
            option3.YAxis.Name = "mm/s";

            //坐标轴显示小数位数
            option3.XAxis.AxisLabel.DecimalPlaces = 2;
            option3.YAxis.AxisLabel.DecimalPlaces = 2;
            uiLineChart3.SetOption(option3);


            option4 = new UILineOption();
            option4.ToolTip.Visible = true;
            option4.Title = new UITitle();
            option4.Title.Text = "机器人送丝速度";
            series = option4.AddSeries(new UILineSeries("送丝速度"));
            FeedSpeedchartVar = new MainPage.ChartVar();
            option4.XAxis.Name = "Robot X";
            option4.YAxis.Name = "mm/s";

            //坐标轴显示小数位数
            option4.XAxis.AxisLabel.DecimalPlaces = 2;
            option4.YAxis.AxisLabel.DecimalPlaces = 2;
            uiLineChart4.SetOption(option4);


            option5 = new UILineOption();
            option5.ToolTip.Visible = true;
            option5.Title = new UITitle();
            option5.Title.Text = "机器人激光功率";
            series = option5.AddSeries(new UILineSeries("激光功率"));
            LaserPowerchartVar = new MainPage.ChartVar();
            option5.XAxis.Name = "Robot X";
            option5.YAxis.Name = "KW";

            //坐标轴显示小数位数
            option5.XAxis.AxisLabel.DecimalPlaces = 2;
            option5.YAxis.AxisLabel.DecimalPlaces = 2;
            uiLineChart5.SetOption(option5);

            var option6 = new UIDoughnutOption();

            //设置Title
            option6.Title = new UITitle();
            option6.Title.Text = "智能填丝焊统计图";
            option6.Title.SubText = "XXXX-XX-XX-XX";
            option6.Title.Left = UILeftAlignment.Center;

            //设置ToolTip
            option6.ToolTip.Visible = true;

            //设置Legend
            option6.Legend = new UILegend();
            option6.Legend.Orient = UIOrient.Vertical;
            option6.Legend.Top = UITopAlignment.Top;
            option6.Legend.Left = UILeftAlignment.Left;

            option6.Legend.AddData("A");
            option6.Legend.AddData("A");
            option6.Legend.AddData("A");
            option6.Legend.AddData("A");
            option6.Legend.AddData("A");
            option6.Legend.AddData("A");
            option6.Legend.AddData("A");

            //设置Series
            var series6 = new UIDoughnutSeries();
            series6.Name = "StarCount";
            series6.Center = new UICenter(50, 55);
            series6.Radius.Inner = 40;
            series6.Radius.Outer = 70;
            series6.Label.Show = true;
            series6.Label.Position = UIPieSeriesLabelPosition.Center;

            //增加数据
            series6.AddData("A", 38);
            series6.AddData("A", 21);
            series6.AddData("A", 11);
            series6.AddData("A", 52);
            series6.AddData("A", 23);
            series6.AddData("A", 26);
            series6.AddData("A", 27);

            //增加Series
            option6.Series.Clear();
            option6.Series.Add(series6);

            //显示数据小数位数
            option6.DecimalPlaces = 1;

            //设置Option
            DoughnutChart.SetOption(option6);

        }


        private void MainPage_AfterShown(object sender, EventArgs e)
        {

        }
    }
}
