namespace LaserIntelliWeldingSystem.UI
{
    partial class PCLPage
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
            this.renderWindowControl1 = new Kitware.VTK.RenderWindowControl();
            this.btn_LoadFile = new Sunny.UI.UISymbolButton();
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.btn_ShowPoint = new Sunny.UI.UIButton();
            this.uiTitlePanel1.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // renderWindowControl1
            // 
            this.renderWindowControl1.AddTestActors = false;
            this.renderWindowControl1.BackColor = System.Drawing.Color.Black;
            this.renderWindowControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderWindowControl1.Location = new System.Drawing.Point(0, 0);
            this.renderWindowControl1.Margin = new System.Windows.Forms.Padding(48, 65, 48, 65);
            this.renderWindowControl1.Name = "renderWindowControl1";
            this.renderWindowControl1.Size = new System.Drawing.Size(802, 571);
            this.renderWindowControl1.TabIndex = 0;
            this.renderWindowControl1.TestText = null;
            // 
            // btn_LoadFile
            // 
            this.btn_LoadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_LoadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoadFile.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadFile.Location = new System.Drawing.Point(3, 10);
            this.btn_LoadFile.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_LoadFile.Name = "btn_LoadFile";
            this.btn_LoadFile.Size = new System.Drawing.Size(215, 35);
            this.btn_LoadFile.Symbol = 61717;
            this.btn_LoadFile.TabIndex = 1;
            this.btn_LoadFile.Text = "打开点云数据";
            this.btn_LoadFile.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadFile.Click += new System.EventHandler(this.btn_LoadFile_Click);
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.uiPanel2);
            this.uiTitlePanel1.Controls.Add(this.uiPanel1);
            this.uiTitlePanel1.Controls.Add(this.renderWindowControl1);
            this.uiTitlePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel1.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.ShowText = false;
            this.uiTitlePanel1.Size = new System.Drawing.Size(802, 571);
            this.uiTitlePanel1.TabIndex = 3;
            this.uiTitlePanel1.Text = "显示窗口";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(802, 38);
            this.uiPanel2.TabIndex = 2;
            this.uiPanel2.Text = "当前数据显示";
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiButton2);
            this.uiPanel1.Controls.Add(this.btn_LoadFile);
            this.uiPanel1.Controls.Add(this.btn_ShowPoint);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 523);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(802, 48);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiButton2
            // 
            this.uiButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(699, 10);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.TabIndex = 1;
            this.uiButton2.Text = "表面渲染";
            this.uiButton2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // btn_ShowPoint
            // 
            this.btn_ShowPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ShowPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowPoint.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ShowPoint.Location = new System.Drawing.Point(593, 10);
            this.btn_ShowPoint.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_ShowPoint.Name = "btn_ShowPoint";
            this.btn_ShowPoint.Size = new System.Drawing.Size(100, 35);
            this.btn_ShowPoint.TabIndex = 0;
            this.btn_ShowPoint.Text = "点云显示";
            this.btn_ShowPoint.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ShowPoint.Click += new System.EventHandler(this.btn_ShowPoint_Click);
            // 
            // PCLPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(802, 571);
            this.Controls.Add(this.uiTitlePanel1);
            this.Name = "PCLPage";
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Kitware.VTK.RenderWindowControl renderWindowControl1;
        private Sunny.UI.UISymbolButton btn_LoadFile;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton btn_ShowPoint;
        private Sunny.UI.UIPanel uiPanel2;
    }
}
