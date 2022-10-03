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
using ToolsHelper.Extensions;

namespace Daily_Newspaper_Tools.Views
{
    public partial class UserEditForm : UIEditForm
    {
        private List<Department> departments = new List<Department>();
        public UserEditForm()
        {
            InitializeComponent();
            uiTxtPassword.TextBox.UseSystemPasswordChar = true;
        }
        #region 生成树结构私有方法
        private void InitDepartment()
        {
            using (var ctx = new EntityContext())
            {
                departments = ctx.Departments.ToList();
                var trees = ConvertToTree(departments);
                uiCmbTreeDepartment.Nodes.Clear();

                uiCmbTreeDepartment.Nodes.AddRange(trees.ToArray());

                var departmentName = departments.FirstOrDefault(e=>e.Id==this.User.DepartmentId)?.Name;
                uiCmbTreeDepartment.Text = departmentName;
            }
        }
        private List<TreeNode> ConvertToTree(
            List<Department> list,
            Guid? Id = null)
        {
            var result = new List<TreeNode>();
            var childList = Children(list, Id);
            foreach (var item in childList)
            {
                var tree = new TreeNode
                {
                    Name = item.Id.ToString(),
                    Text = item.Name,
                    Tag = item.Id.ToString(),
                };
                var childs = ConvertToTree(list, item.Id);
                foreach (var items in childs)
                {
                    tree.Nodes.Add(items);
                }
                result.Add(tree);
            }

            return result;
        }

        private List<Department> Children(
            List<Department> list,
            Guid? Id)
        {
            var childList = list.Where(x => x.ParentId == Id).ToList();
            return childList;
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


                var stringId = uiCmbTreeDepartment.SelectedNode?.Tag.ToString();
                Guid id = Guid.Empty;
                Guid.TryParse(stringId, out id);
                user.DepartmentId = id;
                //部门后面迭代完成
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
