using Daily_Newspaper_Tools.Common.Login;
using DAL;
using DAL.Entity;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Newspaper_Tools.Views
{
    public partial class EmailConfigForm : UIPage
    {
        private EmailConfig emailConfig;
        private Guid userId;
        public EmailConfigForm()
        {
            InitializeComponent();
        }

        private void uiBtnSave_Click(object sender, EventArgs e)
        {
            var server=this.uiTxtServer.Text.Trim();
            var email=this.uiTxtEmial.Text.Trim();
            var password=this.uiTxtPassword.Text.Trim();
            if (string.IsNullOrEmpty(server))
            {
                ShowErrorTip("发送服务器不能为空");
            }
            if (string.IsNullOrEmpty(email))
            {
                ShowErrorTip("登录邮箱不能为空");
            }
            if (string.IsNullOrEmpty(password))
            {
                ShowErrorTip("密码不能为空");
            }
            try
            {
                using (var ctx = new EntityContext())
                {
                    var emailConfigs = ctx.EmailConfigs.FirstOrDefault(d => d.UserId == this.userId);
                    EmailConfig config = new EmailConfig()
                    {
                        EmailAddress = email,
                        Email_LoginId = email,
                        Email_LoginPwd = password,
                        Email_Server = server,
                        UserId = this.userId
                    };
                    ctx.EmailConfigs.Add(config);
                    ctx.SaveChanges();
                    ShowSuccessTip("设置成功");
                }
            }
            catch (Exception ex)
            {
                ShowErrorTip("设置失败");
            }
            
        }

        private void EmailConfigForm_Load(object sender, EventArgs e)
        {
            this.userId = LoginContext.Current.UserId;
            using (var ctx = new EntityContext())
            {
                var emailConfigs = ctx.EmailConfigs.FirstOrDefault(d => d.UserId == this.userId);
                if (emailConfigs != null)
                {
                    this.uiTxtServer.Text = emailConfigs.Email_Server;
                    this.uiTxtEmial.Text = emailConfigs.Email_LoginId;
                    this.uiTxtPassword.Text = emailConfigs.Email_LoginPwd;
                }
                this.emailConfig = emailConfigs;
            }
        }
    }
}
