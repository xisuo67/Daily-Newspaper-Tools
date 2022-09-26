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
            uiDataGridView1.AddColumn("Id", "Id");
            uiDataGridView1.Columns[1].Visible = false;
            uiDataGridView1.AddColumn("联系人姓名", "Name");
            uiDataGridView1.AddColumn("邮件地址", "Email");
            uiDataGridView1.AddColumn("操作", "",30);
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

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                if (this.uiDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() == "True")
                {
                    this.uiDataGridView1.Rows[e.RowIndex].Cells[0].Value = false;
                }
                else
                {
                    this.uiDataGridView1.Rows[e.RowIndex].Cells[0].Value = true;
                }
            }
        }

        private void uiDataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (this.uiDataGridView1.Columns[e.ColumnIndex].HeaderText == "操作")
                {
                    e.PaintBackground(e.CellBounds, false);//重绘边框
                    //设置要写入字体的大小
                    Font myFont = new Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    SizeF sizeRun = e.Graphics.MeasureString("保存", myFont);
                    SizeF sizeDel = e.Graphics.MeasureString("删除", myFont);
                    float fRun = sizeRun.Width / (sizeRun.Width + sizeDel.Width);
                    float fDel = sizeDel.Width / (sizeRun.Width + sizeDel.Width);
                    //设置每个“按钮的边界”
                    RectangleF rectRun = new RectangleF(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width * fRun, e.CellBounds.Height);
                    RectangleF rectDel = new RectangleF(rectRun.Right, e.CellBounds.Top, e.CellBounds.Width * fDel, e.CellBounds.Height);
                   
                    //设置字体样式
                    StringFormat sf = StringFormat.GenericDefault.Clone() as StringFormat;//设置重绘入单元格的字体样式
                    sf.FormatFlags = StringFormatFlags.DisplayFormatControl;
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Trimming = StringTrimming.EllipsisCharacter;
                    e.Graphics.DrawString("保存", myFont, Brushes.Blue, rectRun, sf);
                    e.Graphics.DrawString("删除", myFont, Brushes.Red, rectDel, sf);
                    e.Handled = true;
                }
            }
        }

        private void uiDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                Point curPosition = e.Location;//当前鼠标在当前单元格中的坐标
                if (this.uiDataGridView1.Columns[e.ColumnIndex].HeaderText == "操作")
                {
                    Graphics g = this.uiDataGridView1.CreateGraphics();
                    Font myFont = new Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    SizeF sizeRun = g.MeasureString("保存", myFont);
                    SizeF sizeDel = g.MeasureString("删除", myFont);
                    float fRun = sizeRun.Width / (sizeRun.Width + sizeDel.Width);
                    float fDel = sizeDel.Width / (sizeRun.Width + sizeDel.Width);
                    Rectangle rectTotal = new Rectangle(0, 0, this.uiDataGridView1.Columns[e.ColumnIndex].Width, this.uiDataGridView1.Rows[e.RowIndex].Height);
                    RectangleF rectRun = new RectangleF(rectTotal.Left, rectTotal.Top, rectTotal.Width * fRun, rectTotal.Height);
                    RectangleF rectDel = new RectangleF(rectRun.Right, rectTotal.Top, rectTotal.Width * fDel, rectTotal.Height);
                    //判断当前鼠标在哪个“按钮”范围内
                    if (rectRun.Contains(curPosition))
                    {
                        //do_Save_dan(e.RowIndex);//保存
                    }

                    else if (rectDel.Contains(curPosition))
                    {
                        //do_Del_dan(e.RowIndex);//删除
                    }
                }
            }
        }
    }
}
