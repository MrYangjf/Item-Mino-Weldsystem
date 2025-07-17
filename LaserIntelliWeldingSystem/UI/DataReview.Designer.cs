namespace LaserIntelliWeldingSystem.PageUI
{
    partial class DataReview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiTitlePanel3 = new Sunny.UI.UITitlePanel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uiLineChart5 = new Sunny.UI.UILineChart();
            this.uiLineChart4 = new Sunny.UI.UILineChart();
            this.uiLineChart3 = new Sunny.UI.UILineChart();
            this.uiLineChart2 = new Sunny.UI.UILineChart();
            this.uiSplitContainer1 = new Sunny.UI.UISplitContainer();
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.DoughnutChart = new Sunny.UI.UIDoughnutChart();
            this.btn_LoadFile = new Sunny.UI.UISymbolButton();
            this.uiCalendar1 = new Sunny.UI.UICalendar();
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.uiDataGridViewFooter1 = new Sunny.UI.UIDataGridViewFooter();
            this.uiPagination1 = new Sunny.UI.UIPagination();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiTitlePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiSplitContainer1)).BeginInit();
            this.uiSplitContainer1.Panel1.SuspendLayout();
            this.uiSplitContainer1.Panel2.SuspendLayout();
            this.uiSplitContainer1.SuspendLayout();
            this.uiTableLayoutPanel1.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Controls.Add(this.trackBar1);
            this.uiTitlePanel3.Controls.Add(this.tableLayoutPanel1);
            this.uiTitlePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel3.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.Padding = new System.Windows.Forms.Padding(1, 35, 1, 1);
            this.uiTitlePanel3.ShowText = false;
            this.uiTitlePanel3.Size = new System.Drawing.Size(564, 529);
            this.uiTitlePanel3.TabIndex = 3;
            this.uiTitlePanel3.Text = "机器人焊接参数";
            this.uiTitlePanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar1.Location = new System.Drawing.Point(1, 472);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(562, 56);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(557, 428);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // uiLineChart5
            // 
            this.uiLineChart5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLineChart5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart5.LegendFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart5.Location = new System.Drawing.Point(281, 217);
            this.uiLineChart5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLineChart5.MouseDownType = Sunny.UI.UILineChartMouseDownType.Zoom;
            this.uiLineChart5.Name = "uiLineChart5";
            this.uiLineChart5.Size = new System.Drawing.Size(273, 208);
            this.uiLineChart5.SubFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart5.TabIndex = 5;
            this.uiLineChart5.Text = "uiLineChart5";
            this.uiLineChart5.DoubleClick += new System.EventHandler(this.uiLineChart5_DoubleClick);
            // 
            // uiLineChart4
            // 
            this.uiLineChart4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLineChart4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart4.LegendFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart4.Location = new System.Drawing.Point(3, 217);
            this.uiLineChart4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLineChart4.MouseDownType = Sunny.UI.UILineChartMouseDownType.Zoom;
            this.uiLineChart4.Name = "uiLineChart4";
            this.uiLineChart4.Size = new System.Drawing.Size(272, 208);
            this.uiLineChart4.SubFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart4.TabIndex = 4;
            this.uiLineChart4.Text = "uiLineChart4";
            this.uiLineChart4.DoubleClick += new System.EventHandler(this.uiLineChart4_DoubleClick);
            // 
            // uiLineChart3
            // 
            this.uiLineChart3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLineChart3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart3.LegendFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart3.Location = new System.Drawing.Point(281, 3);
            this.uiLineChart3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLineChart3.MouseDownType = Sunny.UI.UILineChartMouseDownType.Zoom;
            this.uiLineChart3.Name = "uiLineChart3";
            this.uiLineChart3.Size = new System.Drawing.Size(273, 208);
            this.uiLineChart3.SubFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart3.TabIndex = 3;
            this.uiLineChart3.Text = "uiLineChart3";
            this.uiLineChart3.DoubleClick += new System.EventHandler(this.uiLineChart3_DoubleClick);
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
            this.uiLineChart2.Size = new System.Drawing.Size(272, 208);
            this.uiLineChart2.SubFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart2.TabIndex = 2;
            this.uiLineChart2.Text = "uiLineChart2";
            this.uiLineChart2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.uiLineChart2_MouseDoubleClick);
            // 
            // uiSplitContainer1
            // 
            this.uiSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSplitContainer1.IsSplitterFixed = true;
            this.uiSplitContainer1.Location = new System.Drawing.Point(303, 3);
            this.uiSplitContainer1.MinimumSize = new System.Drawing.Size(20, 20);
            this.uiSplitContainer1.Name = "uiSplitContainer1";
            // 
            // uiSplitContainer1.Panel1
            // 
            this.uiSplitContainer1.Panel1.Controls.Add(this.uiTitlePanel1);
            // 
            // uiSplitContainer1.Panel2
            // 
            this.uiSplitContainer1.Panel2.Controls.Add(this.uiTitlePanel3);
            this.uiSplitContainer1.Size = new System.Drawing.Size(946, 529);
            this.uiSplitContainer1.SplitterDistance = 377;
            this.uiSplitContainer1.SplitterWidth = 5;
            this.uiSplitContainer1.TabIndex = 1;
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.ColumnCount = 2;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.Controls.Add(this.uiSplitContainer1, 1, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.uiPanel1, 0, 0);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 1;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(1252, 535);
            this.uiTableLayoutPanel1.TabIndex = 3;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.DoughnutChart);
            this.uiPanel1.Controls.Add(this.btn_LoadFile);
            this.uiPanel1.Controls.Add(this.uiCalendar1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(4, 5);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(292, 525);
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoughnutChart
            // 
            this.DoughnutChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DoughnutChart.Font = new System.Drawing.Font("宋体", 12F);
            this.DoughnutChart.LegendFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DoughnutChart.Location = new System.Drawing.Point(3, 273);
            this.DoughnutChart.MinimumSize = new System.Drawing.Size(1, 1);
            this.DoughnutChart.Name = "DoughnutChart";
            this.DoughnutChart.Size = new System.Drawing.Size(286, 246);
            this.DoughnutChart.SubFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DoughnutChart.TabIndex = 3;
            this.DoughnutChart.Text = "uiDoughnutChart1";
            // 
            // btn_LoadFile
            // 
            this.btn_LoadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoadFile.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadFile.Location = new System.Drawing.Point(3, 232);
            this.btn_LoadFile.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_LoadFile.Name = "btn_LoadFile";
            this.btn_LoadFile.Size = new System.Drawing.Size(286, 35);
            this.btn_LoadFile.Symbol = 61452;
            this.btn_LoadFile.TabIndex = 2;
            this.btn_LoadFile.Text = "确认生产日期";
            this.btn_LoadFile.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadFile.Click += new System.EventHandler(this.btn_LoadFile_Click);
            // 
            // uiCalendar1
            // 
            this.uiCalendar1.Date = new System.DateTime(2024, 12, 26, 0, 0, 0, 0);
            this.uiCalendar1.FillColor = System.Drawing.Color.White;
            this.uiCalendar1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCalendar1.Location = new System.Drawing.Point(3, 3);
            this.uiCalendar1.MinimumSize = new System.Drawing.Size(240, 180);
            this.uiCalendar1.Name = "uiCalendar1";
            this.uiCalendar1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiCalendar1.Size = new System.Drawing.Size(286, 223);
            this.uiCalendar1.TabIndex = 1;
            this.uiCalendar1.Text = "uiCalendar1";
            this.uiCalendar1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.uiDataGridView1);
            this.uiTitlePanel1.Controls.Add(this.uiDataGridViewFooter1);
            this.uiTitlePanel1.Controls.Add(this.uiPagination1);
            this.uiTitlePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiTitlePanel1.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(1, 35, 1, 1);
            this.uiTitlePanel1.ShowText = false;
            this.uiTitlePanel1.Size = new System.Drawing.Size(377, 529);
            this.uiTitlePanel1.TabIndex = 2;
            this.uiTitlePanel1.Text = "DataViewer";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiDataGridView1
            // 
            this.uiDataGridView1.AllowUserToAddRows = false;
            this.uiDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.uiDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.uiDataGridView1.ColumnHeadersHeight = 32;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle33;
            this.uiDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(1, 35);
            this.uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.uiDataGridView1.RowHeadersVisible = false;
            this.uiDataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.uiDataGridView1.RowTemplate.Height = 23;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.Size = new System.Drawing.Size(375, 429);
            this.uiDataGridView1.TabIndex = 9;
            this.uiDataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView1_CellDoubleClick);
            // 
            // uiDataGridViewFooter1
            // 
            this.uiDataGridViewFooter1.DataGridView = this.uiDataGridView1;
            this.uiDataGridViewFooter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiDataGridViewFooter1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiDataGridViewFooter1.Location = new System.Drawing.Point(1, 464);
            this.uiDataGridViewFooter1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiDataGridViewFooter1.Name = "uiDataGridViewFooter1";
            this.uiDataGridViewFooter1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiDataGridViewFooter1.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.uiDataGridViewFooter1.Size = new System.Drawing.Size(375, 29);
            this.uiDataGridViewFooter1.TabIndex = 8;
            this.uiDataGridViewFooter1.Text = "uiDataGridViewFooter1";
            // 
            // uiPagination1
            // 
            this.uiPagination1.ButtonFillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(204)))));
            this.uiPagination1.ButtonStyleInherited = false;
            this.uiPagination1.CausesValidation = false;
            this.uiPagination1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPagination1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiPagination1.Location = new System.Drawing.Point(1, 493);
            this.uiPagination1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPagination1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPagination1.Name = "uiPagination1";
            this.uiPagination1.PagerCount = 5;
            this.uiPagination1.PageSize = 50;
            this.uiPagination1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPagination1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPagination1.ShowText = false;
            this.uiPagination1.Size = new System.Drawing.Size(375, 35);
            this.uiPagination1.TabIndex = 7;
            this.uiPagination1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPagination1.ZoomScaleDisabled = true;
            this.uiPagination1.PageChanged += new Sunny.UI.UIPagination.OnPageChangeEventHandler(this.uiPagination1_PageChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Column1";
            this.Column1.FillWeight = 20F;
            this.Column1.HeaderText = "No.";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Column2";
            this.Column2.FillWeight = 133.9572F;
            this.Column2.HeaderText = "FileName";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Column3";
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "Datatype";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // DataReview
            // 
            this.AllowShowTitle = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1252, 570);
            this.Controls.Add(this.uiTableLayoutPanel1);
            this.Name = "DataReview";
            this.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.ShowTitle = true;
            this.Symbol = 57460;
            this.Text = "生产数据";
            this.AfterShown += new System.EventHandler(this.MainPage_AfterShown);
            this.Shown += new System.EventHandler(this.DataReview_Shown);
            this.uiTitlePanel3.ResumeLayout(false);
            this.uiTitlePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.uiSplitContainer1.Panel1.ResumeLayout(false);
            this.uiSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiSplitContainer1)).EndInit();
            this.uiSplitContainer1.ResumeLayout(false);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.uiTitlePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITitlePanel uiTitlePanel3;
        private Sunny.UI.UISplitContainer uiSplitContainer1;
        private Sunny.UI.UILineChart uiLineChart2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UILineChart uiLineChart5;
        private Sunny.UI.UILineChart uiLineChart4;
        private Sunny.UI.UILineChart uiLineChart3;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UICalendar uiCalendar1;
        private Sunny.UI.UISymbolButton btn_LoadFile;
        private Sunny.UI.UIDoughnutChart DoughnutChart;
        private System.Windows.Forms.TrackBar trackBar1;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UIDataGridViewFooter uiDataGridViewFooter1;
        private Sunny.UI.UIPagination uiPagination1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
