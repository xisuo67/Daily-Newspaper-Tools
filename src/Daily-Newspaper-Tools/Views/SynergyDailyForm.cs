using Core.Service;
using Daily_Newspaper_Tools.Common.Login;
using DAL;
using DAL.DTO;
using DAL.Entity;
using Module.OrganizationUnit.DomainServices;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
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
        private Guid? CurrentClickUserId = null;
        private readonly LazyService<OrganizationUnitDomainService> _organizationUnitDomainService=new LazyService<OrganizationUnitDomainService>();
        public SynergyDailyForm()
        {
            InitializeComponent();
            DateTime dt = DateTime.Now;  //获取系统当前时间
            uiDatePicker1.Value = dt;
            InitListBox();
            InitDepartment();
        }

        #region 初始化
        /// <summary>
        /// 初始化部门
        /// </summary>
        private void InitDepartment() {
            var departments = _organizationUnitDomainService.Instance.GetList();
            var trees = _organizationUnitDomainService.Instance.ConvertToTree(departments);
            uiCmbTreeDepartment.Nodes.Clear();

            uiCmbTreeDepartment.Nodes.AddRange(trees.ToArray());

            var departmentName = departments.FirstOrDefault(e => e.Id == LoginContext.Current.UserInfo.DepartmentId)?.Name;
            uiCmbTreeDepartment.Text = departmentName;
        }
        /// <summary>
        /// 初始化listbox
        /// </summary>
        private void InitListBox()
        {
            List<UserDTO> userList = new List<UserDTO>();
            using (var ctx = new EntityContext())
            {
                userList = ctx.Users.Select(e => (new UserDTO
                {
                    UserId = e.UserId,
                    Name = string.IsNullOrEmpty(e.Name) ? e.UserName : e.Name,
                })).ToList();
            }
            foreach (var item in userList)
            {
                var bitmap = CreateHead(item.Name);
                item.Head = bitmap;
            }
            this.uiListBox1.DataSource = userList;
            this.uiListBox1.DisplayMember = "Name";
            this.uiListBox1.ValueMember = "UserId";
            this.uiListBox1.SelectedIndex = -1;
        }

        /// <summary>
        /// 根据用户ID及时间查询当前选中人日报信息
        /// </summary>
        /// <param name="UserId"></param>
        private void InitNewspaperData()
        {
            if (this.CurrentClickUserId != null)
            {
                this.uiDataGridView1.Rows.Clear();
                this.uiDataGridView2.Rows.Clear();
                DateTime dt = this.uiDatePicker1.Value;
                using (var ctx = new EntityContext())
                {
                    var workId = ctx.Works.FirstOrDefault(e => e.WorkDate == dt.Date && e.UserId == this.CurrentClickUserId)?.Id;
                    if (workId != null)
                    {
                        var todayworks = ctx.TodayWorkDetails.Where(e => e.WorkId == workId).OrderBy(e => e.Seq).ToList();
                        foreach (var item in todayworks)
                        {
                            DataGridViewRow dataGridViewRow = new DataGridViewRow();
                            dataGridViewRow.CreateCells(this.uiDataGridView1);
                            dataGridViewRow.Cells[0].Value = item.Seq;
                            dataGridViewRow.Cells[1].Value = item.WorkDetails;
                            dataGridViewRow.Cells[2].Value = item.AffiliatedProject;
                            this.uiDataGridView1.Rows.Add(dataGridViewRow);
                        }

                        var tomorrowWorkDetails = ctx.TomorrowWorkDetails.Where(e => e.WorkId == workId).OrderBy(e => e.Seq).ToList();

                        foreach (var item in tomorrowWorkDetails)
                        {
                            System.Windows.Forms.DataGridViewRow dataGridViewRow = new System.Windows.Forms.DataGridViewRow();
                            dataGridViewRow.CreateCells(this.uiDataGridView2);
                            dataGridViewRow.Cells[0].Value = item.Seq;
                            dataGridViewRow.Cells[1].Value = item.WorkDetails;
                            this.uiDataGridView2.Rows.Add(dataGridViewRow);
                        }
                    }
                }
            }

        }
        #endregion
        #region 绘制头像框
        /// <summary>
        /// 生成圆形头像
        /// </summary>
        /// <param name="text">文本</param>
        /// <param name="path">路径</param>
        /// <returns></returns>
        public static Bitmap CreateHead(string text)
        {
            Bitmap bitmap = new Bitmap(50, 50);
            var font = new Font("文泉驿正黑", 8, FontStyle.Bold);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.Transparent);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);

            //画圆
            Brush bush = new SolidBrush(ColorTranslator.FromHtml("#C0C0C0"));//填充的颜色
            g.FillEllipse(bush, rect);
            //文字居中
            SizeF size = g.MeasureString(text, font);
            int nLeft = Convert.ToInt32((bitmap.Width / 2) - (size.Width / 2));
            int nTop = Convert.ToInt32((bitmap.Height / 2) - (size.Height / 2));
            g.DrawString(text, font, new SolidBrush(ColorTranslator.FromHtml("#50A0FF")), nLeft, nTop);

            //MemoryStream ms = new MemoryStream();
            var bmp = CutEllipse(bitmap, rect, bitmap.Size);
            return bmp;
            //return ms;
        }

        /// <summary>
        /// 剪裁圆形
        /// </summary>
        /// <param name="img"></param>
        /// <param name="rec"></param>
        /// <param name="size"></param>
        /// <param name="imgSavePath"></param>
        /// <returns></returns>
        private static Bitmap CutEllipse(Image img, Rectangle rec, Size size)
        {
            Bitmap bitmap = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                using (TextureBrush br = new TextureBrush(img, WrapMode.Clamp, rec))
                {
                    br.ScaleTransform(bitmap.Width / (float)rec.Width, bitmap.Height / (float)rec.Height);
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.FillEllipse(br, new Rectangle(Point.Empty, size));
                }
            }
            return bitmap;
        }
        #endregion

        #region 事件
        private void uiListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush myBrush = Brushes.Black;
            Color RowBackColorSel = Color.FromArgb(150, 200, 250);//选择项目颜色
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                myBrush = new SolidBrush(RowBackColorSel);
            }
            else
            {
                myBrush = new SolidBrush(Color.White);
            }
            e.Graphics.FillRectangle(myBrush, e.Bounds);
            e.DrawFocusRectangle();//焦点框

            var item = uiListBox1.Items[e.Index] as UserDTO;
            if (item != null)
            {
                //绘制图标
                Image image = item.Head;
                Graphics graphics = e.Graphics;
                Rectangle bound = e.Bounds;
                Rectangle imgRec = new Rectangle(
                    bound.X,
                    bound.Y,
                    bound.Height,
                    bound.Height);
                Rectangle textRec = new Rectangle(
                    imgRec.Right,
                    bound.Y+15,
                    bound.Width - imgRec.Right,
                    bound.Height);
                if (image != null)
                {
                    e.Graphics.DrawImage(
                        image,
                        imgRec,
                        0,
                        0,
                        image.Width,
                        image.Height,
                        GraphicsUnit.Pixel);
                    ////绘制字体
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Near;
                    
                    e.Graphics.DrawString(item.Name, e.Font, new SolidBrush(Color.Black), textRec, stringFormat);
                }
            }

        }
        /// <summary>
        /// listbox 点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiListBox1_Click(object sender, EventArgs e)
        {
            var listbox = (Sunny.UI.UIListBox)sender;
            var itemData = listbox.SelectedItem as UserDTO;
            this.CurrentClickUserId = itemData.UserId;
            this.InitNewspaperData();
        }
        private void uiDatePicker1_ValueChanged(object sender, DateTime value)
        {
            this.InitNewspaperData();
        }
        #endregion
    }
}
