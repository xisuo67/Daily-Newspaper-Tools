using DAL.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    /// <summary>
    /// 第三方组织架构映射表
    /// </summary>
    public class ThirdPartyDepartmentMapping
    {
        /// <summary>
        /// 日报系统部门表Id
        /// </summary>
        [Key]
        public Guid DepartmentMappingId { get; set; }

        /// <summary>
        /// 第三方系统组织架构Id
        /// </summary>
        public string ThirdPartyId { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        public string order { get; set; }
        /// <summary>
        /// 日报系统父级id
        /// </summary>
        public Guid? DepartmentMappingParentId { get; set; }

        /// <summary>
        /// 第三方系统组织架构ParentId
        /// </summary>
        public string ThirdPartyParentId { get; set; }

       
        /// <summary>
        /// 第三方系统枚举
        /// </summary>
        public ThirdPartySystemEnum FromSystem { get; set; }
    }
}
