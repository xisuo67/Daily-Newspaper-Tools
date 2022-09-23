using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class EmailTask
    {
       
        public int Id { get; set; }
        /// <summary>
        /// 多用户
        /// </summary>
        public Guid UserId { get; set; }

        public bool? IsSend { get; set; }

        public DateTime SendTime { get; set; }
        public string EmailContent { get; set; }
    }
}
