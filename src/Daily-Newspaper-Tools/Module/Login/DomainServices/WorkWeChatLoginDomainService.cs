using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Utility.Dependency;
using Utility.Enums;
using static System.Net.Mime.MediaTypeNames;

namespace Daily_Newspaper_Tools.Module.Login.DomainServices
{
    /// <summary>
    /// 企业微信登录服务
    /// </summary>
    internal class WorkWeChatLoginDomainService : ICommonLoginService
    {
        /// <summary>
        /// 类型key，用于工厂注册
        /// </summary>
        public static readonly string TypeKey = LoginEnum.GlobalKey(LoginEnum.WorkWeChatLogin);

        public string GetWebBrowserUrl()
        {
           var redirectUrl =  ConfigurationManager.AppSettings["redirect_uri"];
            string corpid = ConfigurationManager.AppSettings["corpid"];
            string agentid = ConfigurationManager.AppSettings["agentid"];
            if (!string.IsNullOrEmpty(redirectUrl) && !string.IsNullOrEmpty(corpid) && !string.IsNullOrEmpty(agentid))
            {
                var encodeRedirectUrl= HttpUtility.UrlEncode(redirectUrl);
                //TODO:redirectUrl编码后拼接为url，返回 http%3A%2F%2Fmyapp.com%3A4200%2F
                //https://open.work.weixin.qq.com/wwopen/sso/qrConnect?appid=CORPID&agentid=AGENTID&redirect_uri=REDIRECT_URI&state=STATE
                string url = $"https://open.work.weixin.qq.com/wwopen/sso/qrConnect?appid={corpid}&agentid={agentid}&redirect_uri={encodeRedirectUrl}&state=200";
                return url;
            }
            else
            {
                throw new Exception("未能读取到配置信息，请按规定配置节点后，重新尝试");
            }


            
        }
        public string GetCodeByUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string FromTokenByUserId(string token)
        {
            throw new NotImplementedException();
        }

        public string GetAttribute()
        {
            throw new NotImplementedException();
        }

        public string GetQrcodeDomAttribute()
        {
            throw new NotImplementedException();
        }

        public string GetToken()
        {
            throw new NotImplementedException();
        }
    }
}
