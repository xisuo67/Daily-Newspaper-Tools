using Core.Service;
using Daily_Newspaper_Tools.Common.Login;
using DAL;
using DAL.Entity;
using Module.OrganizationUnit.DomainServices;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolsHelper.Extensions;

namespace Daily_Newspaper_Tools.Views
{
    public partial class UserEditForm : UIEditForm
    {
        private readonly LazyService<OrganizationUnitDomainService> _organizationUnitDomainService = new LazyService<OrganizationUnitDomainService>();
        private List<Department> departments = new List<Department>();
        public UserEditForm(bool IsOrganization = false)
        {
            InitializeComponent();
            if (IsOrganization)
                uiCmbTreeDepartment.Enabled = true;
            uiTxtPassword.TextBox.UseSystemPasswordChar = true;
        }
        #region 生成树结构私有方法
        private void InitDepartment()
        {
            var departments = _organizationUnitDomainService.Instance.GetList();
            var trees = _organizationUnitDomainService.Instance.GetDeparentmentHasNoTree(departments);
            uiCmbTreeDepartment.Nodes.Clear();

            uiCmbTreeDepartment.Nodes.AddRange(trees.ToArray());

            var departmentName = departments.FirstOrDefault(e => e.Id == this.user.DepartmentId)?.Name;
            uiCmbTreeDepartment.Text = departmentName;
        }
        #endregion

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
                user.Password = uiTxtPassword.Text.Trim().MyEncrypt();
                user.Name = uiTxtName.Text.Trim();
                user.UserName = uiTxtUserName.Text.Trim();

                var stringId = uiCmbTreeDepartment.SelectedNode?.Tag.ToString();
                Guid id = Guid.Empty;
                Guid.TryParse(stringId, out id);
                user.DepartmentId = id == Guid.Empty ? user.DepartmentId : id;
                return user;
            }
            set
            {
                user = value;
                uiTxtPassword.Text = value.Password.MyDecrypt();
                uiTxtName.Text = value.Name;
                uiTxtUserName.Text = value.UserName;
                InitDepartment();
            }
        }
    }
}
