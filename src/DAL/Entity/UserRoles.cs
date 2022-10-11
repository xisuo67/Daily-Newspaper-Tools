using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class UserRoles
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// 角色id
        /// </summary>

        public Guid RoleId { get; set; }
    }
}
