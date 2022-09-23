using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class TomorrowWorkDetails
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
    }
}
