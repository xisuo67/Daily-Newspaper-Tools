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

            List<User> userInfos = new List<User>();
            userInfos.Add(new User() { UserId =Guid.NewGuid(), Name = "admin" });
            userInfos.Add(new User() { UserId = Guid.NewGuid(), Name = "admin1" });
            userInfos.Add(new User() { UserId = Guid.NewGuid(), Name = "admin2" });
            userInfos.Add(new User() { UserId = Guid.NewGuid(), Name = "admin3" });
            this.listBox1.DataSource = userInfos;
            this.listBox1.DisplayMember = "Name";  // 显示内容  数据的属性
            this.listBox1.ValueMember = "UserId"; // 项的值  数据的属性

            //this.yImageListBox1.DataBindings = userInfos;
        }
    }
}
