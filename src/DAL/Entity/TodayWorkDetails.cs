﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class TodayWorkDetails
    {
        /// <summary>
        /// 主键
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Work表主键
        /// </summary>
        public Guid WorkId { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        public int Seq { get; set; }

        /// <summary>
        /// 工作详情
        /// </summary>
        public string WorkDetails { get; set; }


        /// <summary>
        /// 所属项目
        /// </summary>
        public string AffiliatedProject { get; set; }

        /// <summary>
        /// jira编号
        /// </summary>
        public string JIRANumber { get; set; }
    }
}
