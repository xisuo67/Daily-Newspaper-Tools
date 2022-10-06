using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Dependency
{
    /// <summary>
    /// 第三方登录接口
    /// </summary>
    public interface ILogin : ICommonLoginService
    {
        /// <summary>
        /// 获取第三方dom节点名字
        /// </summary>
        /// <returns></returns>
        string GetAttribute();
        /// <summary>
        /// 获取Dom节点名字，用于判断qrcode是否取到
        /// </summary>
        /// <returns></returns>
        string GetQrcodeDomAttribute();
        /// <summary>
        /// 获取code
        /// </summary>
        string GetCodeByUrl { get; set; }
        /// <summary>
        /// 获取Token
        /// </summary>
        /// <returns></returns>
        string GetToken();
        /// <summary>
        /// 通过token获取用户ID
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        string FromTokenByUserId(string token);
    }
}
