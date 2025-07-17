namespace LaserIntelliWeldingSystem.PageUI
{
    partial class MainPage
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rtb_Log = new Sunny.UI.UIRichTextBox();
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            this.button1 = new System.Windows.Forms.Button();
            this.uiLineChart1 = new Sunny.UI.UILineChart();
            this.uiTitlePanel3 = new Sunny.UI.UITitlePanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uiLineChart5 = new Sunny.UI.UILineChart();
            this.uiLineChart4 = new Sunny.UI.UILineChart();
            this.uiLineChart3 = new Sunny.UI.UILineChart();
            this.uiLineChart2 = new Sunny.UI.UILineChart();
            this.uiSplitContainer1 = new Sunny.UI.UISplitContainer();
            this.uiTitlePanel1.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            this.uiTitlePanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiSplitContainer1)).BeginInit();
            this.uiSplitContainer1.Panel1.SuspendLayout();
            this.uiSplitContainer1.Panel2.SuspendLayout();
            this.uiSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_Log
            // 
            this.rtb_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Log.FillColor = System.Drawing.Color.White;
            this.rtb_Log.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtb_Log.Location = new System.Drawing.Point(4, 41);
            this.rtb_Log.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_Log.MinimumSize = new System.Drawing.Size(1, 1);
            this.rtb_Log.Name = "rtb_Log";
            this.rtb_Log.Padding = new System.Windows.Forms.Padding(2);
            this.rtb_Log.ShowText = false;
            this.rtb_Log.Size = new System.Drawing.Size(1244, 134);
            this.rtb_Log.TabIndex = 0;
            this.rtb_Log.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rtb_Log.TextChanged += new System.EventHandler(this.rtb_Log_TextChanged);
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.rtb_Log);
            this.uiTitlePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiTitlePanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel1.Location = new System.Drawing.Point(0, 390);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.ShowText = false;
            this.uiTitlePanel1.Size = new System.Drawing.Size(1252, 180);
            this.uiTitlePanel1.TabIndex = 1;
            this.uiTitlePanel1.Text = "日志信息";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.button1);
            this.uiTitlePanel2.Controls.Add(this.uiLineChart1);
            this.uiTitlePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel2.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.ShowText = false;
            this.uiTitlePanel2.Size = new System.Drawing.Size(500, 355);
            this.uiTitlePanel2.TabIndex = 2;
            this.uiTitlePanel2.Text = "线激光数据输入";
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTitlePanel2.ZoomScaleDisabled = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "测试按钮";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uiLineChart1
            // 
            this.uiLineChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLineChart1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart1.LegendFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart1.Location = new System.Drawing.Point(4, 42);
            this.uiLineChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLineChart1.MouseDownType = Sunny.UI.UILineChartMouseDownType.Zoom;
            this.uiLineChart1.Name = "uiLineChart1";
            this.uiLineChart1.ShowFocusColor = true;
            this.uiLineChart1.Size = new System.Drawing.Size(494, 305);
            this.uiLineChart1.SubFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart1.TabIndex = 1;
            this.uiLineChart1.Text = "uiLineChart1";
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Controls.Add(this.tableLayoutPanel1);
            this.uiTitlePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel3.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.ShowText = false;
            this.uiTitlePanel3.Size = new System.Drawing.Size(747, 355);
            this.uiTitlePanel3.TabIndex = 3;
            this.uiTitlePanel3.Text = "机器人焊接参数";
            this.uiTitlePanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.uiLineChart5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.uiLineChart4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.uiLineChart3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.uiLineChart2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 308);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // uiLineChart5
            // 
            this.uiLineChart5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLineChart5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart5.LegendFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart5.Location = new System.Drawing.Point(373, 157);
            this.uiLineChart5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLineChart5.MouseDownType = Sunny.UI.UILineChartMouseDownType.Zoom;
            this.uiLineChart5.Name = "uiLineChart5";
            this.uiLineChart5.Size = new System.Drawing.Size(364, 148);
            this.uiLineChart5.SubFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart5.TabIndex = 5;
            this.uiLineChart5.Text = "uiLineChart5";
            // 
            // uiLineChart4
            // 
            this.uiLineChart4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLineChart4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart4.LegendFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart4.Location = new System.Drawing.Point(3, 157);
            this.uiLineChart4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLineChart4.MouseDownType = Sunny.UI.UILineChartMouseDownType.Zoom;
            this.uiLineChart4.Name = "uiLineChart4";
            this.uiLineChart4.Size = new System.Drawing.Size(364, 148);
            this.uiLineChart4.SubFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart4.TabIndex = 4;
            this.uiLineChart4.Text = "uiLineChart4";
            // 
            // uiLineChart3
            // 
            this.uiLineChart3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLineChart3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart3.LegendFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart3.Location = new System.Drawing.Point(373, 3);
            this.uiLineChart3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLineChart3.MouseDownType = Sunny.UI.UILineChartMouseDownType.Zoom;
            this.uiLineChart3.Name = "uiLineChart3";
            this.uiLineChart3.Size = new System.Drawing.Size(364, 148);
            this.uiLineChart3.SubFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart3.TabIndex = 3;
            this.uiLineChart3.Text = "uiLineChart3";
            // 
            // uiLineChart2
            // 
            this.uiLineChart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLineChart2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart2.LegendFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart2.Location = new System.Drawing.Point(3, 3);
            this.uiLineChart2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLineChart2.MouseDownType = Sunny.UI.UILineChartMouseDownType.Zoom;
            this.uiLineChart2.Name = "uiLineChart2";
            this.uiLineChart2.Size = new System.Drawing.Size(364, 148);
            this.uiLineChart2.SubFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart2.TabIndex = 2;
            this.uiLineChart2.Text = "uiLineChart2";
            // 
            // uiSplitContainer1
            // 
            this.uiSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSplitContainer1.IsSplitterFixed = true;
            this.uiSplitContainer1.Location = new System.Drawing.Point(0, 35);
            this.uiSplitContainer1.MinimumSize = new System.Drawing.Size(20, 20);
            this.uiSplitContainer1.Name = "uiSplitContainer1";
            // 
            // uiSplitContainer1.Panel1
            // 
            this.uiSplitContainer1.Panel1.Controls.Add(this.uiTitlePanel2);
            // 
            // uiSplitContainer1.Panel2
            // 
            this.uiSplitContainer1.Panel2.Controls.Add(this.uiTitlePanel3);
            this.uiSplitContainer1.Size = new System.Drawing.Size(1252, 355);
            this.uiSplitContainer1.SplitterDistance = 500;
            this.uiSplitContainer1.SplitterWidth = 5;
            this.uiSplitContainer1.TabIndex = 1;
            // 
            // MainPage
            // 
            this.AllowShowTitle = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1252, 570);
            this.Controls.Add(this.uiSplitContainer1);
            this.Controls.Add(this.uiTitlePanel1);
            this.Name = "MainPage";
            this.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.ShowTitle = true;
            this.Symbol = 57460;
            this.Text = "主页面";
            this.AfterShown += new System.EventHandler(this.MainPage_AfterShown);
            this.Shown += new System.EventHandler(this.MainPage_Shown);
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel2.ResumeLayout(false);
            this.uiTitlePanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.uiSplitContainer1.Panel1.ResumeLayout(false);
            this.uiSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiSplitContainer1)).EndInit();
            this.uiSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIRichTextBox rtb_Log;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private Sunny.UI.UITitlePanel uiTitlePanel3;
        private Sunny.UI.UISplitContainer uiSplitContainer1;
        private Sunny.UI.UILineChart uiLineChart1;
        private Sunny.UI.UILineChart uiLineChart2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UILineChart uiLineChart5;
        private Sunny.UI.UILineChart uiLineChart4;
        private Sunny.UI.UILineChart uiLineChart3;
        private System.Windows.Forms.Button button1;
    }
}
