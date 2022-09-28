using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Department
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }
        /// <summary>
        /// 父级id
        /// </summary>
        public Guid? ParentId { get; set; }
    }
}
