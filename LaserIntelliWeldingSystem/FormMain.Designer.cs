namespace LaserIntelliWeldingSystem
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lbl_OperateLevel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.lbl_Status = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_SystemTime = new System.Windows.Forms.ToolStripLabel();
            this.uiNavBar1 = new Sunny.UI.UINavBar();
            this.uiAvatar2 = new Sunny.UI.UIAvatar();
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.uiMillisecondTimer1 = new Sunny.UI.UIMillisecondTimer(this.components);
            this.uiStyleManager1 = new Sunny.UI.UIStyleManager(this.components);
            this.uiHeaderButton6 = new Sunny.UI.UIHeaderButton();
            this.toolStrip1.SuspendLayout();
            this.uiNavBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("宋体", 12F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.lbl_OperateLevel,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.lbl_Status,
            this.toolStripSeparator2,
            this.lbl_SystemTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 693);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1252, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(109, 22);
            this.toolStripLabel1.Text = "权限等级：";
            // 
            // lbl_OperateLevel
            // 
            this.lbl_OperateLevel.Name = "lbl_OperateLevel";
            this.lbl_OperateLevel.Size = new System.Drawing.Size(49, 22);
            this.lbl_OperateLevel.Text = "Null";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(109, 22);
            this.toolStripLabel3.Text = "设备状态：";
            // 
            // lbl_Status
            // 
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(69, 22);
            this.lbl_Status.Text = "Status";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_SystemTime
            // 
            this.lbl_SystemTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbl_SystemTime.Name = "lbl_SystemTime";
            this.lbl_SystemTime.Size = new System.Drawing.Size(89, 22);
            this.lbl_SystemTime.Text = "系统时间";
            // 
            // uiNavBar1
            // 
            this.uiNavBar1.BackColor = System.Drawing.SystemColors.Control;
            this.uiNavBar1.Controls.Add(this.uiHeaderButton6);
            this.uiNavBar1.Controls.Add(this.uiAvatar2);
            this.uiNavBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiNavBar1.DropMenuFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiNavBar1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiNavBar1.ForeColor = System.Drawing.Color.Black;
            this.uiNavBar1.Location = new System.Drawing.Point(0, 35);
            this.uiNavBar1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiNavBar1.Name = "uiNavBar1";
            this.uiNavBar1.Size = new System.Drawing.Size(1252, 94);
            this.uiNavBar1.TabIndex = 3;
            this.uiNavBar1.Text = "uiNavBar1";
            // 
            // uiAvatar2
            // 
            this.uiAvatar2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar2.Icon = Sunny.UI.UIAvatar.UIIcon.Text;
            this.uiAvatar2.Location = new System.Drawing.Point(3, 3);
            this.uiAvatar2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar2.Name = "uiAvatar2";
            this.uiAvatar2.Shape = Sunny.UI.UIShape.Square;
            this.uiAvatar2.Size = new System.Drawing.Size(91, 85);
            this.uiAvatar2.TabIndex = 1;
            this.uiAvatar2.Text = "Logo";
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.uiTabControl1.Location = new System.Drawing.Point(0, 129);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(1252, 564);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabIndex = 6;
            this.uiTabControl1.TabVisible = false;
            this.uiTabControl1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiMillisecondTimer1
            // 
            this.uiMillisecondTimer1.Enabled = true;
            this.uiMillisecondTimer1.Interval = 100;
            this.uiMillisecondTimer1.Tick += new System.EventHandler(this.uiMillisecondTimer1_Tick);
            // 
            // uiHeaderButton6
            // 
            this.uiHeaderButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiHeaderButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiHeaderButton6.FillColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton6.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.uiHeaderButton6.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.uiHeaderButton6.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.uiHeaderButton6.Font = new System.Drawing.Font("宋体", 12F);
            this.uiHeaderButton6.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.uiHeaderButton6.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.uiHeaderButton6.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.uiHeaderButton6.Image = global::LaserIntelliWeldingSystem.Properties.Resources._7;
            this.uiHeaderButton6.Location = new System.Drawing.Point(1183, 3);
            this.uiHeaderButton6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton6.Name = "uiHeaderButton6";
            this.uiHeaderButton6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.uiHeaderButton6.Radius = 0;
            this.uiHeaderButton6.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton6.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton6.Size = new System.Drawing.Size(66, 86);
            this.uiHeaderButton6.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton6.StyleCustomMode = true;
            this.uiHeaderButton6.Symbol = 0;
            this.uiHeaderButton6.TabIndex = 6;
            this.uiHeaderButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.uiHeaderButton6.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiHeaderButton6.TipsText = "权限登录";
            this.uiHeaderButton6.Click += new System.EventHandler(this.uiHeaderButton6_Click);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1252, 724);
            this.CloseAskString = "确认退出程序吗？";
            this.Controls.Add(this.uiTabControl1);
            this.Controls.Add(this.uiNavBar1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormMain";
            this.Text = "智能填丝焊接系统";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.uiNavBar1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private Sunny.UI.UINavBar uiNavBar1;
        private Sunny.UI.UIAvatar uiAvatar2;
        private Sunny.UI.UITabControl uiTabControl1;
        private Sunny.UI.UIHeaderButton uiHeaderButton6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lbl_SystemTime;
        private System.Windows.Forms.ToolStripLabel lbl_OperateLevel;
        private System.Windows.Forms.ToolStripLabel lbl_Status;
        private Sunny.UI.UIMillisecondTimer uiMillisecondTimer1;
        private Sunny.UI.UIStyleManager uiStyleManager1;
    }
}