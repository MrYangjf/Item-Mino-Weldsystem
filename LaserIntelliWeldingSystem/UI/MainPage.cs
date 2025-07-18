using LaserIntelliWeldingSystem.Communication;
using Sunny.UI;
using System.Drawing;
using System;
using System.Reflection;
using PointCloudSharp;
using System.Windows.Forms;
using System.Collections.Generic;
using LaserIntelliWeldingSystem.WeldingData;
using System.Threading;


namespace LaserIntelliWeldingSystem.PageUI
{
    public partial class MainPage : UIPage
    {
        public delegate void LogAppendDelegate(Color messageColor, string text);
        public delegate void LineChartDelegate(string Name, string text);

        //图表变量
        UILineOption option = new UILineOption();
        UILineOption option2 = new UILineOption();
        UILineOption option3 = new UILineOption();
        UILineOption option4 = new UILineOption();
        UILineOption option5 = new UILineOption();

        UILineSeries series;
        UILineSeries series2;
        UILineSeries series3;

        bool robotDataRefresh, laserDataRefresh;

        int ClinkTimes = 0;
        bool StartTest = false;

        public class ChartVar
        {
            public List<double> X;

            public List<double> Y;

            public ChartVar()
            {
                X = new List<double>();
                Y = new List<double>();
            }

            public void Add(double x, double y)
            {
                X.Add(x);
                Y.Add(y);
            }

            public int Count()
            { return X.Count; }

            public void Clear()
            {
                X.Clear(); Y.Clear();
            }

        }

        //实施获取的数据
        ChartVar SeamWidth;
        ChartVar robotSpeed;
        ChartVar LaserPower;
        ChartVar FeedSpeed;

        public MainPage()
        {
            InitializeComponent();
            LoadComponent();
        }

        ~MainPage()
        {
            GlobalCommData.EventInfoHandler -= CommenData_EventInfoHandler;
        }

        void LoadComponent()
        {
            GlobalCommData.EventInfoHandler += CommenData_EventInfoHandler;
            GlobalCommData.EventRobotInfoHandler += GlobalCommData_EventRobotInfoHandler;
            GlobalCommData.EventLineLaserInfoHandler += GlobalCommData_EventLineLaserInfoHandler;
        }

        private void GlobalCommData_EventLineLaserInfoHandler(object sender, MessageLineChart e)
        {
            //throw new NotImplementedException();
            //LineChartDelegate la = new LineChartDelegate(AddLaserOptionData);
            AddLaserOptionData(e.Name, e.Message);

        }

        private void GlobalCommData_EventRobotInfoHandler(object sender, MessageLineChart e)
        {
            //throw new NotImplementedException();
            LineChartDelegate la = new LineChartDelegate(AddRobotOptionData);
        }

        public void AddContourLineChart()
        {
            option.Series["轮廓"].Clear();
            for (int i = 0; i < WeldProcess.Instance.mLaserSeamData.robotWeldData.PointCount; i++)
            {
                uiLineChart1.Option.AddData("轮廓", WeldProcess.Instance.mLaserSeamData.robotWeldData.Points[i].Y,
                    WeldProcess.Instance.mLaserSeamData.robotWeldData.Points[i].Z);
            }

            option.Series["轮廓"].SetMaxCount(WeldProcess.Instance.mLaserSeamData.robotWeldData.PointCount);
            option.Series["焊点"].Clear();
            uiLineChart1.Option.AddData("焊点", WeldProcess.Instance.mLaserSeamData.robotWeldData.WeldPointX,
                   WeldProcess.Instance.mLaserSeamData.robotWeldData.WeldPointY);
            uiLineChart1.Refresh();
        }

        public void AddNewDataLineChart()
        {
            uiLineChart2.Option.Series["焊缝宽度"].Clear();
            SeamWidth.Add(WeldProcess.Instance.mLaserSeamData.robotWeldData.PosX, WeldProcess.Instance.mLaserSeamData.robotWeldData.Width);
            uiLineChart2.Option.AddData("焊缝宽度", SeamWidth.X, SeamWidth.Y);
            if (SeamWidth.Count() < 8)
            {
                uiLineChart2.Option.Series["焊缝宽度"].SetMaxCount(SeamWidth.Count());
                uiLineChart2.Option.XAxis.SetRange(0, SeamWidth.Count() + 1);
            }
            else
            {
                uiLineChart2.Option.Series["焊缝宽度"].SetMaxCount(8);
                uiLineChart2.Option.XAxis.SetRange(SeamWidth.Count() - 6, SeamWidth.Count() + 1);
            }
            uiLineChart2.Refresh();

            uiLineChart3.Option.Series["运动速度"].Clear();
            robotSpeed.Add(WeldProcess.Instance.mLaserSeamData.robotWeldData.PosX, WeldProcess.Instance.mLaserSeamData.laserWeldData.Speed);
            uiLineChart3.Option.AddData("运动速度", robotSpeed.X, robotSpeed.Y);
            if (robotSpeed.Count() < 8)
            {
                uiLineChart3.Option.Series["运动速度"].SetMaxCount(robotSpeed.Count());
                uiLineChart3.Option.XAxis.SetRange(0, robotSpeed.Count() + 1);
            }
            else
            {
                uiLineChart3.Option.Series["运动速度"].SetMaxCount(8);
                uiLineChart3.Option.XAxis.SetRange(robotSpeed.Count() - 6, robotSpeed.Count() + 1);
            }
            uiLineChart3.Refresh();

            uiLineChart4.Option.Series["送丝速度"].Clear();
            FeedSpeed.Add(WeldProcess.Instance.mLaserSeamData.robotWeldData.PosX, WeldProcess.Instance.mLaserSeamData.laserWeldData.FeedSpeed);
            uiLineChart4.Option.AddData("送丝速度", FeedSpeed.X, FeedSpeed.Y);
            if (FeedSpeed.Count() < 8)
            {
                uiLineChart4.Option.Series["送丝速度"].SetMaxCount(FeedSpeed.Count());
                uiLineChart4.Option.XAxis.SetRange(0, FeedSpeed.Count() + 1);
            }
            else
            {
                uiLineChart4.Option.Series["送丝速度"].SetMaxCount(8);
                uiLineChart4.Option.XAxis.SetRange(FeedSpeed.Count() - 6, FeedSpeed.Count() + 1);
            }
            uiLineChart4.Refresh();

            uiLineChart5.Option.Series["激光功率"].Clear();
            LaserPower.Add(WeldProcess.Instance.mLaserSeamData.robotWeldData.PosX, WeldProcess.Instance.mLaserSeamData.laserWeldData.LaserPower);
            uiLineChart5.Option.AddData("激光功率", LaserPower.X, LaserPower.Y);
            if (LaserPower.Count() < 8)
            {
                uiLineChart5.Option.Series["激光功率"].SetMaxCount(LaserPower.Count());
                uiLineChart5.Option.XAxis.SetRange(0, LaserPower.Count() + 1);
            }
            else
            {
                uiLineChart5.Option.Series["激光功率"].SetMaxCount(8);
                uiLineChart5.Option.XAxis.SetRange(LaserPower.Count() - 6, LaserPower.Count() + 1);
            }
            uiLineChart5.Refresh();

        }

        void ResetChartLineData()
        {
            SeamWidth.Clear();
            robotSpeed.Clear();
            LaserPower.Clear();
            FeedSpeed.Clear();
        }

        void AfterInitializeUI()
        {
            option.ToolTip.Visible = true;
            option.Title = new UITitle();
            option.Title.Text = "焊缝模型数据";

            series = option.AddSeries(new UILineSeries("轮廓"));
            series.Width = 8;
            //设置曲线显示最大点数，超过后自动清理
            series.SetMaxCount(5);

            //设置曲线平滑
            series.Smooth = true;

            series3 = option.AddSeries(new UILineSeries("焊点", Color.Red, false));
            series3.Symbol = UILinePointSymbol.Circle;
            series3.SymbolLineWidth = 5;

            option.XAxis.Name = "X";
            option.YAxis.Name = "Y";

            //坐标轴显示小数位数
            option.XAxis.AxisLabel.DecimalPlaces = 2;
            option.YAxis.AxisLabel.DecimalPlaces = 2;
            uiLineChart1.SetOption(option);
            uiLineChart1.ChartStyleType = UIChartStyleType.Dark;


            option2.ToolTip.Visible = true;
            option2.Title = new UITitle();
            option2.Title.Text = "焊缝宽度";
            series = option2.AddSeries(new UILineSeries("焊缝宽度"));
            SeamWidth = new ChartVar();
            series.YAxisDecimalPlaces = 2;
            option2.XAxis.Name = "Robot X";
            option2.YAxis.Name = "Width";

            //坐标轴显示小数位数
            option2.XAxis.AxisLabel.DecimalPlaces = 2;
            option2.YAxis.AxisLabel.DecimalPlaces = 2;
            uiLineChart2.SetOption(option2);
            uiLineChart2.Refresh();

            option3.ToolTip.Visible = true;
            option3.Title = new UITitle();
            option3.Title.Text = "机器人运动速度";
            series = option3.AddSeries(new UILineSeries("运动速度"));
            robotSpeed = new ChartVar();
            series.YAxisDecimalPlaces = 2;
            option3.XAxis.Name = "Robot X";
            option3.YAxis.Name = "Speed";

            //坐标轴显示小数位数
            option3.XAxis.AxisLabel.DecimalPlaces = 2;
            option3.YAxis.AxisLabel.DecimalPlaces = 0;
            uiLineChart3.SetOption(option3);
            uiLineChart3.Refresh();


            option4.ToolTip.Visible = true;
            option4.Title = new UITitle();
            option4.Title.Text = "机器人送丝速度";
            series = option4.AddSeries(new UILineSeries("送丝速度"));
            FeedSpeed = new ChartVar();
            option4.XAxis.Name = "Robot X";
            option4.YAxis.Name = "FeedSpeed";

            //坐标轴显示小数位数
            option4.XAxis.AxisLabel.DecimalPlaces = 2;
            option4.YAxis.AxisLabel.DecimalPlaces = 0;
            uiLineChart4.SetOption(option4);


            option5.ToolTip.Visible = true;
            option5.Title = new UITitle();
            option5.Title.Text = "机器人激光功率";
            series = option5.AddSeries(new UILineSeries("激光功率"));
            LaserPower = new ChartVar();
            option5.XAxis.Name = "Robot X";
            option5.YAxis.Name = "LaserPower";

            //坐标轴显示小数位数
            option5.XAxis.AxisLabel.DecimalPlaces = 2;
            option5.YAxis.AxisLabel.DecimalPlaces = 0;
            uiLineChart5.SetOption(option5);


        }

        void AddLaserOptionData(string name, string Value)
        {
            GlobalCommData.Xpos = GlobalCommData.ReciveXdoc.GetXmlStrValue(Value, "XPos");
            GlobalCommData.Ypos = GlobalCommData.ReciveXdoc.GetXmlStrValue(Value, "YPos");
            GlobalCommData.Zpos = GlobalCommData.ReciveXdoc.GetXmlStrValue(Value, "ZPos");
            GlobalCommData.OffsetY = GlobalCommData.ReciveXdoc.GetXmlStrValue(Value, "OY");
            GlobalCommData.OffsetZ = GlobalCommData.ReciveXdoc.GetXmlStrValue(Value, "OZ");
            GlobalCommData.LaserPower = GlobalCommData.ReciveXdoc.GetXmlStrValue(Value, "LaserPower");
            GlobalCommData.Speed = GlobalCommData.ReciveXdoc.GetXmlStrValue(Value, "Speed");
            GlobalCommData.FeedSpeed = GlobalCommData.ReciveXdoc.GetXmlStrValue(Value, "Feedspeed");

            GlobalCommData.PointNum = GlobalCommData.ReciveXdoc.GetXmlStrValue(Value, "PointNum");
            GlobalCommData.WidthStartNum = GlobalCommData.ReciveXdoc.GetXmlStrValue(Value, "WidthStartNum");
            GlobalCommData.WidthEndNum = GlobalCommData.ReciveXdoc.GetXmlStrValue(Value, "WidthEndNum");
            GlobalCommData.PointsX = GlobalCommData.ReciveXdoc.GetXmlStrValue(Value, "PointX");
            GlobalCommData.PointsY = GlobalCommData.ReciveXdoc.GetXmlStrValue(Value, "PointY");


            robotDataRefresh = WeldProcess.Instance.mLaserSeamData.robotWeldData.SetPoints(GlobalCommData.Xpos, GlobalCommData.Ypos, GlobalCommData.Zpos, GlobalCommData.PointNum, GlobalCommData.PointsX, GlobalCommData.PointsY, GlobalCommData.WidthStartNum, GlobalCommData.WidthEndNum);
            laserDataRefresh = WeldProcess.Instance.mLaserSeamData.laserWeldData.SetData(GlobalCommData.Speed, GlobalCommData.FeedSpeed, GlobalCommData.LaserPower);
            WeldProcess.Instance.WriteOnlineFile();
            FreshChartLine();
            WeldProcess.Instance.AutoAction(GlobalCommData.mAutoParam, SeamWidth, true, 6);
            if (WeldProcess.Instance.Trigger)
            {
                WeldProcess.Instance.Trigger = false;
                GlobalCommData.ShowLog("AutoParamAction", string.Format("执行工艺参数调整！RobotX:{0}", WeldProcess.Instance.StartRobotX));
            }
        }

        void FreshChartLine()
        {

            if (InvokeRequired)
            {
                this.BeginInvoke(new Action(FreshChartLine));
            }
            else
            {

                if (robotDataRefresh) AddContourLineChart();
                if (robotDataRefresh && laserDataRefresh) AddNewDataLineChart();
            }
        }

        void AddRobotOptionData(string name, string Value)
        {
            //uiLineChart2.Option.AddData("Robot", X, Y);
        }

        private void CommenData_EventInfoHandler(object sender, MessageArgs e)
        {
            LogAppendDelegate la = new LogAppendDelegate(LogAppend);
            rtb_Log.Invoke(la, e.MessageShowColor, e.strMessage);
        }

        public void LogAppend(Color color, string strMsg)
        {
            try
            {
                if (rtb_Log.TextLength > 3000)
                {
                    rtb_Log.Clear();
                }
                rtb_Log.SelectionColor = color;
                rtb_Log.AppendText(string.Format("{0}-{1}\n", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), strMsg));
            }
            catch
            { }
        }

        private void rtb_Log_TextChanged(object sender, EventArgs e)
        {
            rtb_Log.SelectionStart = rtb_Log.Text.Length;
            rtb_Log.ScrollToCaret();
        }

        private void MainPage_AfterShown(object sender, EventArgs e)
        {
            //每次页面显示都会刷新
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!StartTest)
            {
                WeldProcess.Instance.StartRecord();
                StartTest = true;
                Test();
            }
            else
            {
                StartTest = false;

                GlobalCommData.PCLFile.SaveFile();
                ClinkTimes = 0;
                ResetChartLineData();
            }
        }

        void Test()
        {
            Thread test = new Thread(() =>
            {
                while (StartTest)
                {
                    ClinkTimes++;
                    Random Xran = new Random();
                    double X = Xran.NextDouble() + ClinkTimes;
                    string poinsx = string.Format("1, 4, {0}, 12, {1}, 20,24", (8 - Xran.NextDouble()).ToString("0.00"), (16 + Xran.NextDouble()).ToString("0.00"));
                    string poinsy = string.Format("10, 10, {0}, {1}, {2}, 14,14", (8 - Xran.NextDouble()).ToString("0.00"), (6 - Xran.NextDouble()).ToString("0.00"), (12 + Xran.NextDouble()).ToString("0.00"));
                    string s = string.Format("<Ext>\r\n  <Pos>\r\n    <XPos>{0}</XPos>\r\n\t<YPos>1.23</YPos>\r\n\t<ZPos>1.23</ZPos>\r\n  </Pos>\r\n  <Robot>\r\n\t<LaserPower>3000</LaserPower>\r\n\t<Speed>50</Speed>\r\n\t<Feedspeed>60</Feedspeed>\r\n  </Robot>\r\n  <Offset>\r\n\t<OY>1.23</OY>\r\n\t<OZ>1.23</OZ>\r\n  </Offset>\r\n  <SeamData>\r\n\t<PointNum>7</PointNum>\r\n\t<WidthStartNum>2</WidthStartNum>\r\n\t<WidthEndNum>4</WidthEndNum>\r\n\t<PointX>{1}</PointX>\r\n\t<PointY>{2}</PointY>\r\n  </SeamData>\r\n</Ext>", X.ToString("0.00"), poinsx, poinsy);
                    GlobalCommData.ShowLaserData("DebugTest", s);
                    Thread.Sleep(50);
                }
            });
            test.IsBackground = true;
            test.Start();
        }

        private void MainPage_Shown(object sender, EventArgs e)
        {
            AfterInitializeUI();
        }
    }
}
