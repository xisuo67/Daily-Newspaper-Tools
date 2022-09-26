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
    public partial class EmailContactsForm : UIPage
    {
        public EmailContactsForm()
        {
            InitializeComponent();
            //SunnyUI封装的加列函数，也可以和原生的一样，从Columns里面添加列
            uiDataGridView1.AddCheckBoxColumn("选择", "Id", 20);
            uiDataGridView1.AddColumn("联系人姓名", "Name");
            uiDataGridView1.AddColumn("邮件地址", "Email");
            InitData();
        }
        private void InitData()
        {
            //SunnyUI常用的初始化配置，看个人喜好用或者不用。
            uiDataGridView1.Init();
            var searchParam = this.uiTxtSearch.Text.Trim();
            List<Contacts> datas = new List<Contacts>();
            if (LoginContext.Current!=null)
            {
                using (var ctx = new EntityContext())
                {
                    if (string.IsNullOrEmpty(searchParam))
                    {
                        datas = ctx.Contacts.Where(e => e.UserId == LoginContext.Current.UserId).ToList();
                    }
                    else
                    {
                        datas = ctx.Contacts.Where(e => e.UserId == LoginContext.Current.UserId && (e.Name.Contains(searchParam) || e.Email.Contains(searchParam))).ToList();
                    }
                }
            }
            uiDataGridView1.DataSource = datas;
        }

        private void uiBtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void uiBtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void uiBtnBatchDel_Click(object sender, EventArgs e)
        {

        }
    }
}
