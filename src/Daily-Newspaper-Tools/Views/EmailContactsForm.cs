using Daily_Newspaper_Tools.Common.Login;
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
using AutoMapper;
namespace Daily_Newspaper_Tools.Views
{
    public partial class EmailContactsForm : UIPage
    {
        private static MapperConfiguration config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Contacts, ContactsDTO>();
        });
        private static IMapper mapper = config.CreateMapper();
        public EmailContactsForm()
        {
            InitializeComponent();
            //SunnyUI封装的加列函数，也可以和原生的一样，从Columns里面添加列
            uiDataGridView1.AddCheckBoxColumn("选择", "Id", 20);
            uiDataGridView1.AddColumn("联系人姓名", "Name");
            uiDataGridView1.AddColumn("邮件地址", "Email");
            uiDataGridView1.AddButtonColumn("编辑", "BtnEdit", 40);
            uiDataGridView1.AddButtonColumn("删除", "BtnDel", 40);
        }
        private void InitData()
        {
            //SunnyUI常用的初始化配置，看个人喜好用或者不用。
            uiDataGridView1.Init();
            var searchParam = this.uiTxtSearch.Text.Trim();
            List<ContactsDTO> datas = new List<ContactsDTO>();
            if (LoginContext.Current != null)
            {
                using (var ctx = new EntityContext())
                {
                    if (string.IsNullOrEmpty(searchParam))
                    {
                        var data = ctx.Contacts.Where(e => e.UserId == LoginContext.Current.UserId).ToList();
                        datas = mapper.Map<List<ContactsDTO>>(data);
                    }
                    else
                    {
                        var data = ctx.Contacts.Where(e => e.UserId == LoginContext.Current.UserId && (e.Name.Contains(searchParam) || e.Email.Contains(searchParam))).ToList();
                        datas = mapper.Map<List<ContactsDTO>>(data);
                    }
                }
            }
            uiDataGridView1.DataSource = datas;
        }

        private void uiBtnSearch_Click(object sender, EventArgs e)
        {
            this.InitData();
        }

        private void uiBtnAdd_Click(object sender, EventArgs e)
        {
            ContactEditForm frm = new ContactEditForm();
            frm.Render();
            frm.ShowDialogWithMask();
            if (frm.IsOK)
            {
                var contacts = frm.Contacts;
                contacts.UserId = LoginContext.Current.UserId;
                using (var ctx = new EntityContext())
                {
                    ctx.Contacts.Add(contacts);
                    ctx.SaveChanges();
                }
                ShowSuccessDialog("添加成功");
            }
            frm.Dispose();
            this.InitData();
        }

        private void uiBtnBatchDel_Click(object sender, EventArgs e)
        {

        }

        private void EmailContactsForm_Load(object sender, EventArgs e)
        {
            this.InitData();
        }
    }
}
