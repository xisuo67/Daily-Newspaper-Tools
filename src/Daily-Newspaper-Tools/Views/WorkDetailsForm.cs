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
        public WorkDetailsForm()
        {
            InitializeComponent();
        }

        private void WorkDetailsForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 初始化
        /// </summary>
        private void Init()
        {
            DateTime dt = DateTime.Now;  //获取系统当前时间
            DateTime startWeek = dt.AddDays(1 - Convert.ToInt32(dt.DayOfWeek.ToString("d"))); //获取一周的开始日期
            DateTime endweek = startWeek.AddDays(6); //获取本周星期天日期

            uiDatePicker2.Value = startWeek;
            uiDatePicker3.Value = endweek;
        }
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
