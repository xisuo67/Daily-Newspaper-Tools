using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class AuthToken
    {
        public Guid Id { get; set; }

        public string Token { get; set; }


        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 超时时间（秒）
        /// </summary>
        public int ExpiresIn { get; set; }

        /// <summary>
        /// 通过创建时间+超时时间计算
        /// </summary>
        public DateTime ExpiresTime { get; set; }
    }
}
