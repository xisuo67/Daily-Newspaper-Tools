using Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Dependency
{
    /// <summary>
    ///  系统登录服务接口，主要用于规范接口，以便于提供服务工厂管理
    ///      /// <code>
    /// 实现本接口的类型规范：
    /// 0.定义：实现类需要定义一个TypeKey，用于唯一识别当前服务
    /// 1.调用：使用工厂创建实例，然后用接口接收调用
    ///     1.1 访问示例：
    ///         var instance = (ICommonLoginService)LoginServiceFactory.Instance.GetInstances(LoginEnum.GlobalKey(WorkWeChatLogin));
    /// </code>
    /// </summary>
    public interface ICommonLoginService:IService
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
