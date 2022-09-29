using DAL;
using DAL.DTO;
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
    /// <summary>
    /// 日报协同功能
    /// </summary>
    public partial class SynergyDailyForm : UIPage
    {
        public SynergyDailyForm()
        {
            InitializeComponent();
            InitListBox();
        }
        private void InitListBox() {
            using (var ctx = new EntityContext())
            {
                var users=ctx.Users.Select(e=>(new UserDTO { 
                    UserId=e.UserId,
                    Name=string.IsNullOrEmpty(e.Name)?e.UserName : e.Name,
                })).ToList();

                this.uiListBox1.DataSource=users;
                this.uiListBox1.DisplayMember = "Name";
                this.uiListBox1.ValueMember="UserId";
            }
        }
    }
}
