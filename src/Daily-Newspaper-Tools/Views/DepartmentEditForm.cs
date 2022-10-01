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
    public partial class DepartmentEditForm : UIEditForm
    {
        public DepartmentEditForm()
        {
            InitializeComponent();
        }

        protected override bool CheckData()
        {
            return CheckEmpty(uiTxtName, "请输入名称");
        }
        private Department department;
        public Department Departments
        {
            get
            {
                if (department == null)
                {
                    department = new Department();
                }
                department.Name = uiTxtName.Text.Trim();
                return department;
            }
            set
            {
                department = value;
                uiTxtName.Text = value.Name;
            }
        }
    }
}
