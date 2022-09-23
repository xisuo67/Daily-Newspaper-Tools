using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class EmailConfig
    {
        public int Id { get; set; }
        /// <summary>
        /// 多用户
        /// </summary>
        public Guid UserId { get; set; }
        public string EmailAddress { get; set; }
        public string Email_Server { get; set; }
        public string Email_LoginId { get; set; }
        public string Email_LoginPwd { get; set; }
    }
}
