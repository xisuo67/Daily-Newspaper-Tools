using Daily_Newspaper_Tools.Common.Login;
using DAL;
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
    public partial class WorkDetailsForm : UIPage
    {
        private Guid? workId = null;
        private List<string> kc = null;
        int a = 0;
        public WorkDetailsForm()
        {
            InitializeComponent();
        }

        private void WorkDetailsForm_Load(object sender, EventArgs e)
        {
            this.InitControls();
            this.InitWorkData();
        }
        #region 初始化相关数据
        /// <summary>
        /// 初始化
        /// </summary>
        private void InitControls()
        {
            DateTime dt = DateTime.Now;  //获取系统当前时间
            DateTime startWeek = dt.AddDays(1 - Convert.ToInt32(dt.DayOfWeek.ToString("d"))); //获取一周的开始日期
            DateTime endweek = startWeek.AddDays(6); //获取本周星期天日期
            uiDatePicker2.Value = startWeek;
            uiDatePicker3.Value = endweek;
        }

        public void InitWorkData()
        {
            DateTime dt = this.uiDatePicker1.Value;
            this.uiDataGridView1.Rows.Clear();
            this.uiDataGridView2.Rows.Clear();
            using (var ctx = new EntityContext())
            {
                workId = ctx.Works.FirstOrDefault(e => e.WorkDate == dt.Date && e.UserId== LoginContext.Current.UserId)?.Id;
                if (workId != null)
                {
                    var todayworks = ctx.TodayWorkDetails.Where(e => e.WorkId == workId).OrderBy(e => e.Seq).ToList();

                    foreach (var item in todayworks)
                    {
                        System.Windows.Forms.DataGridViewRow dataGridViewRow = new System.Windows.Forms.DataGridViewRow();
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
        #endregion

        #region 事件
        private void uiSymbolBtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolBtnCreate_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
