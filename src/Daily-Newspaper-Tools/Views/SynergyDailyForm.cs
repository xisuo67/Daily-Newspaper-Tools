using DAL;
using DAL.DTO;
using DAL.Entity;
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
        private Dictionary<Guid,Bitmap> userImageDic = new Dictionary<Guid,Bitmap>();
        public SynergyDailyForm()
        {
            InitializeComponent();
            InitListBox();
        }
        private void InitListBox() {
            List<UserDTO> userList = new List<UserDTO>();  
            using (var ctx = new EntityContext())
            {
                userList = ctx.Users.Select(e=>(new UserDTO { 
                    UserId=e.UserId,
                    Name=string.IsNullOrEmpty(e.Name)?e.UserName : e.Name,
                })).ToList();
            }
            foreach (var item in userList)
            {
                var bitmap = CreateHead(item.Name);
                item.Head=bitmap;
            }
            this.uiListBox1.DataSource = userList;
            this.uiListBox1.DisplayMember = "Name";
            this.uiListBox1.ValueMember = "UserId";
        }
        /// <summary>
        /// 生成圆形头像
        /// </summary>
        /// <param name="text">文本</param>
        /// <param name="path">路径</param>
        /// <returns></returns>
        public static Bitmap CreateHead(string text)
        {
            Bitmap bitmap = new Bitmap(50, 50);
            var font = new Font("文泉驿正黑", 12, FontStyle.Bold);
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
                    bound.Y,
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
                    //StringFormat stringFormat = new StringFormat();
                    //stringFormat.Alignment = StringAlignment.Near;
                    //e.Graphics.DrawString(item.Name, e.Font, new SolidBrush(Color.Black), textRec, stringFormat);
                }
            }
           
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
           
        }
    }
}
