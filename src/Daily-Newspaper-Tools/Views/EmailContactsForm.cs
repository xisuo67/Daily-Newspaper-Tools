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
            uiDataGridView1.AddCheckBoxColumn("选择","check",20);
            uiDataGridView1.AddColumn("联系人姓名", "Name");
            uiDataGridView1.AddColumn("邮件地址", "Email");
            uiDataGridView1.AddButtonColumn("操作列", "del",40);

            //SunnyUI常用的初始化配置，看个人喜好用或者不用。
            uiDataGridView1.Init();

            //设置分页控件总数
            //uiPagination1.TotalCount = datas.Count;

            ////设置分页控件每页数量
            //uiPagination1.PageSize = 50;

            //uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;

            //设置统计绑定的表格
            uiDataGridViewFooter1.DataGridView = uiDataGridView1;
        }

        public override void Init()
        {
            base.Init();
            uiPagination1.ActivePage = 1;
        }
    }
}
