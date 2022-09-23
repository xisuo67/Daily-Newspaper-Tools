using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class EmailTaskConfig
    {
        /// <summary>
        /// 多用户
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        ///id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 是否现在发送
        /// </summary>
        public bool? IsSendNow { get; set; }
        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime? TaskTime { get; set; }
    }
}
