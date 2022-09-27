using Daily_Newspaper_Tools.Common.Login;
using DAL;
using DAL.DTO;
using DAL.Entity;
using Sunny.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolsHelper;

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
            if (LoginContext.Current != null)
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
        private void uiDataGridView3_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.Cells[0].Value = e.Row.Index + 1;
        }
        /// <summary>
        /// 日报，日期选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void uiDatePicker1_ValueChanged(object sender, DateTime value)
        {
            InitWorkData();
        }

        /// <summary>
        /// 生成周报
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiSymbolBtnCreateWeekDetail_Click(object sender, EventArgs e)
        {

            this.uiRichTextBox2.Text = CreateWeekWorks();
            uiRichTextBox2.Font = new Font("微软雅黑", 10, uiRichTextBox2.Font.Style);
            changeColor(kc.ToArray());
        }
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiSymbolBtnSendEmail_Click(object sender, EventArgs e)
        {
            uiSymbolBtnSendEmail.Enabled = false;
            var weekWorks = this.uiRichTextBox2.Rtf;
            string contacts = string.Empty;
            if (string.IsNullOrEmpty(this.uiRichTextBox2.Text))
            {
                MessageBox.Show("请先生成周报再发送");
            }
            else
            {
                string content = RtfToHtmlConverter.ConvertRtfToHtml(weekWorks);
                using (var ctx = new EntityContext())
                {
                    var emailConfig = ctx.EmailConfigs.FirstOrDefault();
                    if (emailConfig != null)
                    {
                        contacts = string.Join(";", ctx.Contacts.Select(x => x.Email));
                        if (string.IsNullOrEmpty(contacts))
                        {
                            ShowErrorTip("请先配置联系人邮箱");
                        }
                        var emailTaskConfig = ctx.EmailTaskConfigs.FirstOrDefault();
                        if (emailTaskConfig != null)
                        {
                            //立即发送
                            if (emailTaskConfig.IsSendNow == true)
                            {
                                SendEmail sendEmail = new SendEmail(emailConfig.EmailAddress, emailConfig.Email_Server, emailConfig.Email_LoginId, emailConfig.Email_LoginPwd);
                                bool isSend = sendEmail.Send(contacts, "周报", content);
                                if (isSend)
                                    ShowSuccessTip("发送成功");
                                else

                                    ShowErrorTip("发送失败");
                            }
                            else
                            {
                                var taskTime = (DateTime)emailTaskConfig.TaskTime;
                                DateTime sendTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, taskTime.Hour, taskTime.Minute, taskTime.Second);
                                EmailTask emailTask = new EmailTask()
                                {
                                    EmailContent = content,
                                    IsSend = false,
                                    SendTime = sendTime
                                };
                                ctx.EmailTasks.Add(emailTask);
                                ShowSuccessTip($"任务设置成功，邮件将于今晚发送");
                            }
                        }
                        else
                        {
                            ShowErrorTip("请先配置邮件设置");
                        }
                    }
                    else
                    {
                        ShowErrorTip("请先配置联系人邮箱");
                    }
                    ctx.SaveChanges();
                }
            }
            uiSymbolBtnSendEmail.Enabled = true;
        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 改变richTextBox中指定字符串的颜色
        /// 调用即可
        /// </summary>
        /// <param name="str" value="为指定的字符串"></param>

        public int changeColor(string[] str)
        {
            ArrayList list = null;
            int b = 0;
            for (int i = 0; i < str.Length; i++)
            {
                list = getIndexArray(uiRichTextBox2.Text, str[i]);
                b += list.Count;
            }
            for (int i = 0; i < str.Length; i++)
            {
                list = getIndexArray(uiRichTextBox2.Text, str[i]);
                if (list.Count == 0)
                {
                    continue;
                }
                if (a == b)
                {
                    uiRichTextBox2.SelectionColor = Color.Empty;
                    return b;
                }
                for (int j = 0; j < list.Count; j++)
                {
                    int index = (int)list[j];
                    uiRichTextBox2.Select(index, str[i].Length);
                    uiRichTextBox2.SelectionFont = new Font("微软雅黑", 10, FontStyle.Bold);
                    this.uiRichTextBox2.Focus();
                    //设置光标的位置到文本尾 
                    this.uiRichTextBox2.Select(this.uiRichTextBox2.TextLength, 0);
                }
            }
            return b;
        }

        public ArrayList getIndexArray(String inputStr, String findStr)
        {
            ArrayList list = new ArrayList();
            int start = 0;
            while (start < inputStr.Length)
            {
                int index = inputStr.IndexOf(findStr, start);
                if (index >= 0)
                {
                    list.Add(index);
                    start = index + findStr.Length;
                }
                else
                {
                    break;
                }
            }
            return list;
        }
        private string CreateWeekWorks()
        {
            var startDate = uiDatePicker2.Value.Date;
            var endDate = uiDatePicker3.Value.Date;
            using (var ctx = new EntityContext())
            {
                //查询当前周数据
                var weekWorks = (from x in ctx.Works
                                 where x.WorkDate >= startDate && x.WorkDate <= endDate && x.UserId==LoginContext.Current.UserId
                                 join y in ctx.TodayWorkDetails on x.Id equals y.WorkId
                                 select new WeekWorksDTO
                                 {
                                     Id = y.Id,
                                     WorkDate = x.WorkDate,
                                     WorkDetails = y.WorkDetails,
                                     WorkId = y.WorkId,
                                     AffiliatedProject = y.AffiliatedProject,
                                     JIRANumber = y.JIRANumber,
                                     Seq = y.Seq,
                                 }).ToList();

                //对项目分组求和，求出当前周，不同项目处理JIRA数量

                var details = weekWorks.GroupBy(x => x.AffiliatedProject).Select(x => new WeekWorksDetailsDTO
                {
                    AffiliatedProject = x.Key,
                    WeekWorksDTOs = x.ToList(),
                }).OrderBy(x => x.AffiliatedProject).ToList();

                StringBuilder sb = new StringBuilder();
                kc = new List<string>();
                string currentWrokDetail = "一、本周工作内容";
                sb.Append(currentWrokDetail + "\r\n");
                kc.Add(currentWrokDetail);
                int index = 1;
                //针对分组信息去重
                details.ForEach(x =>
                {
                    if (string.IsNullOrEmpty(x.AffiliatedProject) || x.AffiliatedProject.Contains("调休"))
                    {
                        //判断是否存在调休
                        if (x.WeekWorksDTOs.Exists(a => a.WorkDetails.Contains("调休")))
                        {
                            return;
                        }
                    }
                    else
                    {
                        //判断是否存在重复数据，如果存在重复数据，根据时间取最后一条状态
                        //例：xxx任务状态，未完成30% ，50% 存在多条记录，则根据时间取最后一条数据状态生成周报
                        //TODO：待实现以上逻辑
                        var repeatDic = x.WeekWorksDTOs.Where(a => a.JIRANumber != "代码评审").OrderByDescending(q => q.WorkDate).GroupBy(q => q.JIRANumber).ToList();

                        if (repeatDic.Count != 0)
                        {
                            string titile = string.Empty;
                            titile = $"{index}. {x.AffiliatedProject}({repeatDic.Count}个)";
                            sb.Append(titile + "\r\n");
                            kc.Add(titile);
                            int seq = 1;
                            foreach (var item in repeatDic)
                            {
                                var workDetails = item.OrderByDescending(b => b.WorkDate).First();
                                string title = string.Empty;
                                sb.Append($"{seq}) {workDetails.WorkDetails}\r\n");
                                seq++;
                            }
                            index++;
                        }
                    }

                });
                sb.Append("\r\n");
                string nextWork = "二、下周工作计划";
                sb.Append(nextWork + "\r\n");
                kc.Add(nextWork);
                for (int i = 0; i < this.uiDataGridView3.Rows.Count; i++)
                {
                    var num = this.uiDataGridView3.Rows[i].Cells[0].Value;
                    var work = this.uiDataGridView3.Rows[i].Cells[1].Value;
                    if (work != null)
                        sb.Append($"{num}) {work}\r\n");
                }

                return sb.ToString();

            }
        }
        #endregion
    }
}
