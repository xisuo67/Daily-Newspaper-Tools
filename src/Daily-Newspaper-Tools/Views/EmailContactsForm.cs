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
            uiDataGridView1.AddCheckBoxColumn("", "Checked", 20);
           
            uiDataGridView1.AddColumn("联系人姓名", "Name");
            uiDataGridView1.AddColumn("邮件地址", "Email");
            uiDataGridView1.AddButtonColumn("编辑", "BtnEdit", 40);
            uiDataGridView1.AddButtonColumn("删除", "BtnDel", 40);

            DataGridViewCheckBoxColumn gridViewCheckBoxCol = new DataGridViewCheckBoxColumn
            {
                Width = 20,
                HeaderText = "",
                DefaultCellStyle =
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            },
                ReadOnly = false //若为 true 则无法选择 CheckBox
            };

            //把 dataGridView1 的第一列设置成 CheckBox 格式的列
            uiDataGridView1.Columns.Insert(0, gridViewCheckBoxCol);

            //获取 dataGridView1 中表示单元格显示区域的矩形，通过矩形的位置来设置 CheckBox 的相对位置
            Rectangle rectangle = uiDataGridView1.GetCellDisplayRectangle(0, -1, true);
            rectangle.X = rectangle.Location.X + rectangle.Width + 20;
            rectangle.Y = rectangle.Location.Y + rectangle.Height + 10;

            //新建一个用于“全选”的 CheckBox 对象 checkboxAll
            CheckBox chkOfAll = new CheckBox();
            chkOfAll.Name = "checkboxAll";
            chkOfAll.Size = new Size(18, 18);
            //chkOfAll.Location = rectangle.Location;

            //为 checkboxAll 绑定全选事件
            //chkOfAll.CheckedChanged += new EventHandler(checkboxAll_CheckedChanged);

            //把 checkboxAll 添加到 dataGridView1 中
            uiDataGridView1.Controls.Add(chkOfAll);
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
