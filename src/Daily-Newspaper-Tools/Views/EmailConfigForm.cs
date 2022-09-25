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
        }
    }
}
