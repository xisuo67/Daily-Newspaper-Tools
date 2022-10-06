using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Enums
{
    /// <summary>
    /// 第三方登录
    /// </summary>
    public static class LoginEnum
    {
        /// <summary>
        ///   企业微信登录（用于在工厂中，独立公共类）
        /// </summary>
        public static readonly int WorkWeChatLogin = 1;
        /// <summary>
        /// 微信登录
        /// </summary>
        public static readonly int WeChatLogout = 2;

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
