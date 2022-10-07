using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Enums
{
    /// <summary>
    /// 组织架构同步枚举
    /// </summary>
    public static class OrganizationUnitEnum
    {
        /// <summary>
        ///   从企业微信同步（用于在工厂中，独立公共类）
        /// </summary>
        public static readonly int WorkWeChatSync = 1;
        /// <summary>
        /// 从其他方式同步（自行拓展枚举即可）
        /// </summary>
        public static readonly int OtherSync = 2;

        //TODO:更多登录自行扩展


        /// <summary>
        /// 获取全局唯一key，用于登录工厂
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string GlobalKey(int item)
        {
            return $"{typeof(LoginEnum)}.{item}";
        }
    }
}
