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
        /// <summary>
        /// 通过Url拿Code
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string GetCodeByUrl(string url)
        {
            string code = string.Empty;
            if (url.Contains("code"))
            {
                int iStart = url.IndexOf("=");
                int iEnd = url.IndexOf('&', iStart);
                if (iEnd < 0)
                {
                    iEnd = url.Length - iStart;
                }
                else
                {
                    iEnd -= iStart;
                }
                code = url.Substring(iStart + 1, iEnd - 1);
            }
            return code;
        }

        public string FromTokenByUserId(string token)
        {
            throw new NotImplementedException();
        }

        public string GetAttribute()
        {
            return "className";
        }

        public string GetQrcodeDomAttribute()
        {
            return "qrcode lightBorder";
        }

        public string GetToken(string code)
        {
            throw new NotImplementedException();

            //TODO:Token刷新机制
        }
    }
}
