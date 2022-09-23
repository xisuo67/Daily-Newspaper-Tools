using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    /// <summary>
    /// 联系人
    /// </summary>
    public class Contacts
    {
        public int Id { get; set; }
        /// <summary>
        /// 多用户
        /// </summary>
        public Guid UserId { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
    }
}
