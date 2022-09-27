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
using System.Text.RegularExpressions;
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
            if (LoginContext.Current!=null)
            {
                using (var ctx = new EntityContext())
                {
                    workId = ctx.Works.FirstOrDefault(e => e.WorkDate == dt.Date && e.UserId == LoginContext.Current.UserId)?.Id;
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
           
        }
        #endregion

        #region 事件
        private void uiSymbolBtnSearch_Click(object sender, EventArgs e)
        {
            var search = uiTxtSearch.Text.Trim();
            if (string.IsNullOrEmpty(search))
            {
                InitWorkData();
            }
            else
            {
                this.uiDataGridView1.Rows.Clear();
                using (var ctx = new EntityContext())
                {
                    var workId = ctx.Works.Where(x => x.UserId == LoginContext.Current.UserId).Select(work => work.Id);
                    var details = ctx.TodayWorkDetails.Where(x => workId.Contains(x.WorkId) && (x.WorkDetails.Contains(search) || x.AffiliatedProject.Contains(search))).ToList();
                    int seq = 1;
                    foreach (var item in details)
                    {
                        System.Windows.Forms.DataGridViewRow dataGridViewRow = new System.Windows.Forms.DataGridViewRow();
                        dataGridViewRow.CreateCells(this.uiDataGridView1);
                        dataGridViewRow.Cells[0].Value = seq;
                        dataGridViewRow.Cells[1].Value = item.WorkDetails;
                        dataGridViewRow.Cells[2].Value = item.AffiliatedProject;
                        this.uiDataGridView1.Rows.Add(dataGridViewRow);
                        seq++;
                    }
                }
            }
        }

        private void uiSymbolBtnCreate_Click(object sender, EventArgs e)
        {
            if (this.workId != null)
            {
                using (var ctx = new EntityContext())
                {
                    //先删后插

                    var workEntity = ctx.Works.FirstOrDefault(x => x.Id == this.workId);
                    var todayWorkList = ctx.TodayWorkDetails.Where(x => x.WorkId == this.workId);
                    var tomorrowList = ctx.TomorrowWorkDetails.Where(x => x.WorkId == this.workId);
                    ctx.Works.Remove(workEntity);
                    ctx.TodayWorkDetails.RemoveRange(todayWorkList);
                    ctx.TomorrowWorkDetails.RemoveRange(tomorrowList);
                    ctx.SaveChanges();
                }
            }
            DateTime dt = this.uiDatePicker1.Value;
            var date = dt.ToString("yyyyMMdd");
            StringBuilder sb = new StringBuilder();
            string works = $"手麻重症研发-{date}-日报\r\n今日完成工作：\r\n";
            sb.Append(works);
            List<TodayWorkDetails> todayWorksList = new List<TodayWorkDetails>();
            List<TomorrowWorkDetails> tomorrowWorkList = new List<TomorrowWorkDetails>();
            for (int i = 0; i < this.uiDataGridView1.Rows.Count; i++)
            {
                var index = this.uiDataGridView1.Rows[i].Cells[0].Value;
                var work = this.uiDataGridView1.Rows[i].Cells[1].Value;
                var affiliatedproject = this.uiDataGridView1.Rows[i].Cells[2].Value;
                if (work != null)
                {

                    string worksInfo = $"{index}.{work}\r\n";
                    //示例：1.ACIS-23660 局麻手术流程优化(完成)";
                    //匹配0-9.到空格之间的编号，该正则需优化
                    var jiraNumber = Regex.Match(worksInfo, @"(?<=\d.).*?(?=\s)").Value;
                    //TODO:由于正则有问题，截取JIRA编号时可能将整个文本截取，若长度超长，则不截取JIRA编号
                    if (jiraNumber.Length > 20)
                    {
                        jiraNumber = string.Empty;
                    }
                    TodayWorkDetails todayWorkDetails = new TodayWorkDetails()
                    {
                        Id = Guid.NewGuid(),
                        Seq = Convert.ToInt32(index),
                        JIRANumber = jiraNumber,
                        AffiliatedProject = affiliatedproject == null ? string.Empty : affiliatedproject.ToString().Trim(),
                        WorkDetails = work.ToString().Trim()
                    };
                    todayWorksList.Add(todayWorkDetails);
                    sb.Append(worksInfo);
                }
            }
            string tomorrowText = "明日计划工作：\r\n";
            sb.Append(tomorrowText);
            for (int i = 0; i < this.uiDataGridView2.Rows.Count; i++)
            {
                var index = this.uiDataGridView2.Rows[i].Cells[0].Value;
                var work = this.uiDataGridView2.Rows[i].Cells[1].Value;
                if (work != null)
                {
                    string tomorrowworks = $"{index}.{work}\r\n";
                    TomorrowWorkDetails tomorrowWorkDetails = new TomorrowWorkDetails()
                    {
                        Id = Guid.NewGuid(),
                        Seq = Convert.ToInt32(index),
                        WorkDetails = work.ToString()
                    };
                    tomorrowWorkList.Add(tomorrowWorkDetails);
                    sb.Append(tomorrowworks);
                }

            }
            string needHelpworks = "需要协调问题：\r\n";
            sb.Append(needHelpworks);
            uiRichTextBox1.Text = sb.ToString();
            using (var ctx = new EntityContext())
            {
                //新增
                Works workEntity = new Works()
                {
                    Id = Guid.NewGuid(),
                    WorkDate = dt.Date,
                    UserId = LoginContext.Current.UserId,
                };
                ctx.Works.Add(workEntity);
                todayWorksList.ForEach(ItemActivation =>
                {
                    ItemActivation.WorkId = workEntity.Id;
                });
                tomorrowWorkList.ForEach(ItemActivation =>
                {
                    ItemActivation.WorkId = workEntity.Id;
                });
                ctx.TodayWorkDetails.AddRange(todayWorksList);
                ctx.TomorrowWorkDetails.AddRange(tomorrowWorkList);
                ctx.SaveChanges();
                this.workId = workEntity.Id;
            }
        }

        private void uiDataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.Cells[0].Value = e.Row.Index + 1;
        }

        private void uiDataGridView2_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.Cells[0].Value = e.Row.Index + 1;
        }
        #endregion


    }
}
