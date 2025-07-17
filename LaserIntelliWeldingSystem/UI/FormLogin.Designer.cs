namespace LaserIntelliWeldingSystem.UI
{
    partial class FormLogin
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
            this.btn_CorPassword = new Sunny.UI.UIButton();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "登录界面";
            // 
            // uiPanel1
            // 
            this.uiPanel1.Location = new System.Drawing.Point(433, 123);
            // 
            // lblSubText
            // 
            this.lblSubText.Location = new System.Drawing.Point(376, 421);
            this.lblSubText.Text = "Verson";
            // 
            // btn_CorPassword
            // 
            this.btn_CorPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CorPassword.FillColor = System.Drawing.Color.Transparent;
            this.btn_CorPassword.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_CorPassword.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_CorPassword.ForeColor = System.Drawing.Color.Black;
            this.btn_CorPassword.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(204)))));
            this.btn_CorPassword.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(204)))));
            this.btn_CorPassword.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(204)))));
            this.btn_CorPassword.Location = new System.Drawing.Point(649, 383);
            this.btn_CorPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_CorPassword.Name = "btn_CorPassword";
            this.btn_CorPassword.Size = new System.Drawing.Size(100, 35);
            this.btn_CorPassword.TabIndex = 10;
            this.btn_CorPassword.Text = "修改密码";
            this.btn_CorPassword.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_CorPassword.Click += new System.EventHandler(this.btn_CorPassword_Click);
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Location = new System.Drawing.Point(649, -3);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton1.Symbol = 61453;
            this.uiSymbolButton1.TabIndex = 11;
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.btn_CorPassword);
            this.Name = "FormLogin";
            this.SubText = "Verson";
            this.Text = "登录页面";
            this.Title = "登录界面";
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblSubText, 0);
            this.Controls.SetChildIndex(this.uiPanel1, 0);
            this.Controls.SetChildIndex(this.btn_CorPassword, 0);
            this.Controls.SetChildIndex(this.uiSymbolButton1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton btn_CorPassword;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
    }
}