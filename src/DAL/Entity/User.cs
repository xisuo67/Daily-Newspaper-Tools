﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class User
    {
        public Guid UserId { get; set; }
        /// <summary>
        /// 登录名
        /// </summary>
        public string UserName { get; set; }

        public string Password { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public Guid? DepartmentId { get; set;  }

        public string WeChatUserid { get; set; }
    }
}
