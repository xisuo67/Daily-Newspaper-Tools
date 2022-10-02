using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class UserDTO
    {
        public Guid UserId { get; set; }

        public string UserName { get; set; }

        public Bitmap Head { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 部门GUID
        /// </summary>
        public Guid? DepartmentId { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmentName { get; set; }
    }
}
