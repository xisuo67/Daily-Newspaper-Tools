using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    /// <summary>
    /// 
    /// </summary>
    public class Works
    {
        /// <summary>
        /// 主键
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        public DateTime? WorkDate { get; set; }
        /// <summary>
        /// 多用户
        /// </summary>
        public Guid UserId { get; set; }
    }
}
