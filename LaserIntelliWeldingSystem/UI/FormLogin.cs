using LaserIntelliWeldingSystem.Communication;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaserIntelliWeldingSystem.UI
{
    public partial class FormLogin : UILoginForm
    {
        public FormLogin()
        {
            InitializeComponent();
            
            ButtonLoginClick += FormLogin_ButtonLoginClick;
            ButtonCancelClick += FormLogin_ButtonCancelClick;
            UserName = "Engineer";
            ShowCorButton();
        }

        private void FormLogin_ButtonCancelClick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            bool Re = this.ShowAskDialog2("是否注销权限？");
            if (Re) GlobalCommData.mOperateLevel = OperateLevel.Operator;
            Close();
        }

        void ShowCorButton()
        {
            if (GlobalCommData.mOperateLevel == OperateLevel.Engineer)
            {
                if (!btn_CorPassword.Visible) btn_CorPassword.Visible = true;
            }
            else
            {
                btn_CorPassword.Visible = false;
            }
        }

        private void FormLogin_ButtonLoginClick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            string password;
            try
            {
                password = GlobalCommData.mAuthManager.Password[UserName];

                if (password == Password)
                {
                    IsLogin = true;
                    this.ShowSuccessDialog("提示信息", "登陆成功！", UIStyle.Custom);
                    GlobalCommData.mOperateLevel = GlobalCommData.mAuthManager.Userlevel[UserName];
                    this.Close();
                }
                else
                {
                    this.ShowErrorTip("用户名或者密码错误。");
                }
            }
            catch
            {
                this.ShowErrorTip("用户名或者密码错误。");
            }
            Password = "";
            ShowCorButton();
        }

        private void btn_CorPassword_Click(object sender, EventArgs e)
        {
            EditPassword editPassword = new EditPassword();
            editPassword.ShowDialog();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
