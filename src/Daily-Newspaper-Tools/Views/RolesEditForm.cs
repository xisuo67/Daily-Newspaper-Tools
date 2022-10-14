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
    public partial class RolesEditForm : UIEditForm
    {
        public RolesEditForm()
        {
            InitializeComponent();
        }

        protected override bool CheckData()
        {
            return CheckEmpty(uiTxtName, "请输入姓名");
        }

        private Roles roles;
        public Roles Roles
        {
            get
            {
                if (roles == null)
                {
                    roles = new Roles();
                }
                roles.Name = uiTxtName.Text.Trim();
                return roles;
            }
            set
            {
                roles = value;
                uiTxtName.Text = value.Name;
            }
        }
    }
}
