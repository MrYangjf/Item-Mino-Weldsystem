namespace LaserIntelliWeldingSystem.UI
{
    partial class TCPServer
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
            this.uiRTB_Send = new Sunny.UI.UIRichTextBox();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiBtn_Send = new Sunny.UI.UIButton();
            this.uiRTB_Recvie = new Sunny.UI.UIRichTextBox();
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.btn_Refresh = new Sunny.UI.UISymbolButton();
            this.uiCheckBox2 = new Sunny.UI.UICheckBox();
            this.uiBtn_CorrIP = new Sunny.UI.UIButton();
            this.uiBtn_StartListen = new Sunny.UI.UIButton();
            this.uiBtn_CloseListen = new Sunny.UI.UIButton();
            this.uiCheckBox1 = new Sunny.UI.UICheckBox();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiipTextBox1 = new Sunny.UI.UIIPTextBox();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiRTB_Send
            // 
            this.uiRTB_Send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiRTB_Send.FillColor = System.Drawing.Color.White;
            this.uiRTB_Send.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiRTB_Send.Location = new System.Drawing.Point(13, 459);
            this.uiRTB_Send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRTB_Send.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRTB_Send.Name = "uiRTB_Send";
            this.uiRTB_Send.Padding = new System.Windows.Forms.Padding(2);
            this.uiRTB_Send.ShowText = false;
            this.uiRTB_Send.Size = new System.Drawing.Size(956, 104);
            this.uiRTB_Send.TabIndex = 0;
            this.uiRTB_Send.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLine1
            // 
            this.uiLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine1.Location = new System.Drawing.Point(12, 422);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(957, 29);
            this.uiLine1.TabIndex = 1;
            this.uiLine1.Text = "信息发送";
            this.uiLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiBtn_Send
            // 
            this.uiBtn_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtn_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiBtn_Send.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtn_Send.Location = new System.Drawing.Point(831, 571);
            this.uiBtn_Send.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBtn_Send.Name = "uiBtn_Send";
            this.uiBtn_Send.Size = new System.Drawing.Size(138, 35);
            this.uiBtn_Send.TabIndex = 2;
            this.uiBtn_Send.Text = "发送信息";
            this.uiBtn_Send.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtn_Send.Click += new System.EventHandler(this.uiBtn_Send_Click);
            // 
            // uiRTB_Recvie
            // 
            this.uiRTB_Recvie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiRTB_Recvie.FillColor = System.Drawing.Color.White;
            this.uiRTB_Recvie.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiRTB_Recvie.Location = new System.Drawing.Point(13, 184);
            this.uiRTB_Recvie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRTB_Recvie.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRTB_Recvie.Name = "uiRTB_Recvie";
            this.uiRTB_Recvie.Padding = new System.Windows.Forms.Padding(2);
            this.uiRTB_Recvie.ShowText = false;
            this.uiRTB_Recvie.Size = new System.Drawing.Size(956, 230);
            this.uiRTB_Recvie.TabIndex = 3;
            this.uiRTB_Recvie.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiRTB_Recvie.TextChanged += new System.EventHandler(this.rtb_Log_TextChanged);
            // 
            // uiLine2
            // 
            this.uiLine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLine2.BackColor = System.Drawing.Color.Transparent;
            this.uiLine2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine2.Location = new System.Drawing.Point(13, 147);
            this.uiLine2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(957, 29);
            this.uiLine2.TabIndex = 4;
            this.uiLine2.Text = "信息接受";
            this.uiLine2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox1.Controls.Add(this.btn_Refresh);
            this.uiGroupBox1.Controls.Add(this.uiCheckBox2);
            this.uiGroupBox1.Controls.Add(this.uiBtn_CorrIP);
            this.uiGroupBox1.Controls.Add(this.uiBtn_StartListen);
            this.uiGroupBox1.Controls.Add(this.uiBtn_CloseListen);
            this.uiGroupBox1.Controls.Add(this.uiCheckBox1);
            this.uiGroupBox1.Controls.Add(this.uiTextBox1);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Controls.Add(this.uiipTextBox1);
            this.uiGroupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(13, 14);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(956, 125);
            this.uiGroupBox1.TabIndex = 5;
            this.uiGroupBox1.Text = "服务器信息";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Refresh.Location = new System.Drawing.Point(259, 29);
            this.btn_Refresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(46, 35);
            this.btn_Refresh.Symbol = 361470;
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // uiCheckBox2
            // 
            this.uiCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiCheckBox2.Location = new System.Drawing.Point(125, 35);
            this.uiCheckBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox2.Name = "uiCheckBox2";
            this.uiCheckBox2.Size = new System.Drawing.Size(150, 29);
            this.uiCheckBox2.TabIndex = 9;
            this.uiCheckBox2.Text = "收发启用";
            this.uiCheckBox2.CheckedChanged += new System.EventHandler(this.uiCheckBox2_CheckedChanged);
            // 
            // uiBtn_CorrIP
            // 
            this.uiBtn_CorrIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiBtn_CorrIP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtn_CorrIP.Location = new System.Drawing.Point(565, 66);
            this.uiBtn_CorrIP.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBtn_CorrIP.Name = "uiBtn_CorrIP";
            this.uiBtn_CorrIP.Size = new System.Drawing.Size(77, 35);
            this.uiBtn_CorrIP.TabIndex = 8;
            this.uiBtn_CorrIP.Text = "修改IP";
            this.uiBtn_CorrIP.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtn_CorrIP.Click += new System.EventHandler(this.uiBtn_CorrIP_Click);
            // 
            // uiBtn_StartListen
            // 
            this.uiBtn_StartListen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtn_StartListen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiBtn_StartListen.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtn_StartListen.Location = new System.Drawing.Point(671, 87);
            this.uiBtn_StartListen.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBtn_StartListen.Name = "uiBtn_StartListen";
            this.uiBtn_StartListen.Size = new System.Drawing.Size(138, 35);
            this.uiBtn_StartListen.TabIndex = 7;
            this.uiBtn_StartListen.Text = "开启监听";
            this.uiBtn_StartListen.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtn_StartListen.Click += new System.EventHandler(this.uiBtn_StartListen_Click);
            // 
            // uiBtn_CloseListen
            // 
            this.uiBtn_CloseListen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtn_CloseListen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiBtn_CloseListen.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtn_CloseListen.Location = new System.Drawing.Point(815, 87);
            this.uiBtn_CloseListen.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBtn_CloseListen.Name = "uiBtn_CloseListen";
            this.uiBtn_CloseListen.Size = new System.Drawing.Size(138, 35);
            this.uiBtn_CloseListen.TabIndex = 6;
            this.uiBtn_CloseListen.Text = "关闭监听";
            this.uiBtn_CloseListen.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtn_CloseListen.Click += new System.EventHandler(this.uiBtn_CloseListen_Click);
            // 
            // uiCheckBox1
            // 
            this.uiCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiCheckBox1.Location = new System.Drawing.Point(7, 35);
            this.uiCheckBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox1.Name = "uiCheckBox1";
            this.uiCheckBox1.Size = new System.Drawing.Size(150, 29);
            this.uiCheckBox1.TabIndex = 4;
            this.uiCheckBox1.Text = "允许编辑";
            this.uiCheckBox1.CheckedChanged += new System.EventHandler(this.uiCheckBox1_CheckedChanged);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.Location = new System.Drawing.Point(408, 71);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox1.TabIndex = 3;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(347, 78);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(54, 23);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "Port";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(3, 78);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(41, 23);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "IP";
            // 
            // uiipTextBox1
            // 
            this.uiipTextBox1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiipTextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiipTextBox1.Location = new System.Drawing.Point(51, 72);
            this.uiipTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiipTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiipTextBox1.Name = "uiipTextBox1";
            this.uiipTextBox1.Padding = new System.Windows.Forms.Padding(1);
            this.uiipTextBox1.ShowText = false;
            this.uiipTextBox1.Size = new System.Drawing.Size(289, 29);
            this.uiipTextBox1.TabIndex = 0;
            this.uiipTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TCPServer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(982, 614);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.uiRTB_Recvie);
            this.Controls.Add(this.uiBtn_Send);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.uiRTB_Send);
            this.Name = "TCPServer";
            this.Text = "服务器对话窗";
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIRichTextBox uiRTB_Send;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIButton uiBtn_Send;
        private Sunny.UI.UIRichTextBox uiRTB_Recvie;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIIPTextBox uiipTextBox1;
        private Sunny.UI.UICheckBox uiCheckBox1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIButton uiBtn_CorrIP;
        private Sunny.UI.UIButton uiBtn_StartListen;
        private Sunny.UI.UIButton uiBtn_CloseListen;
        private Sunny.UI.UICheckBox uiCheckBox2;
        private Sunny.UI.UISymbolButton btn_Refresh;
    }
}
