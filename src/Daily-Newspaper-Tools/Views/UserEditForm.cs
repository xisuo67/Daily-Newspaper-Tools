using Daily_Newspaper_Tools.Common.Login;
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
    public partial class UserEditForm : UIEditForm
    {
        public UserEditForm()
        {
            InitializeComponent();
        }
        protected override bool CheckData()
        {
            return CheckEmpty(uiTxtName, "请输入用户名")
                   && CheckEmpty(uiTxtPassword, "请输入密码");
        }
        private User user;
        public User User
        {
            get
            {
                if (user == null)
                {
                    user = new User();
                }
                user.Password = uiTxtPassword.Text.Trim();
                user.Name = uiTxtName.Text.Trim();
                //部门后面迭代完成
                return user;
            }
            set
            {
                user = value;
                uiTxtPassword.Text = value.Password;
                uiTxtName.Text = value.Name;
                uiTxtUserName.Text = value.UserName;
            }
        }
    }
}
