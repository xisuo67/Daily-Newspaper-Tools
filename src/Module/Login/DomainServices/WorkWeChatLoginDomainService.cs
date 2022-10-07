using Module.Login.DTO.WorkWeChat;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Utility.Dependency;
using Utility.DTO;
using Utility.Enums;

namespace Module.Login.DomainServices
{
    /// <summary>
    /// 企业微信登录服务
    /// </summary>
    public class WorkWeChatLoginDomainService : ICommonLoginService
    {
        /// <summary>
        /// 类型key，用于工厂注册
        /// </summary>
        public static readonly string TypeKey = LoginEnum.GlobalKey(LoginEnum.WorkWeChatLogin);
        private readonly string redirectUrl = ConfigurationManager.AppSettings["redirect_uri"];
        private readonly string corpid = ConfigurationManager.AppSettings["corpid"];
        private readonly string agentid = ConfigurationManager.AppSettings["agentid"];
        private readonly string corpsecret = ConfigurationManager.AppSettings["corpsecret"];
        public string GetWebBrowserUrl()
        {
            if (!string.IsNullOrEmpty(redirectUrl) && !string.IsNullOrEmpty(corpid) && !string.IsNullOrEmpty(agentid))
            {
                var encodeRedirectUrl = HttpUtility.UrlEncode(redirectUrl);
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

        public string FromTokenByUserId(LoginParam loginParam)
        {
            string urlUserInfo = $"https://qyapi.weixin.qq.com/cgi-bin/auth/getuserinfo?access_token={loginParam.Token}&code={loginParam.Code}";
            string jsonText = GetJson(urlUserInfo);
            UserInfo userInfo = JsonConvert.DeserializeObject<UserInfo>(jsonText);
            if (userInfo.errcode != "0")
                throw new Exception(userInfo.errcode);
            else
                return userInfo?.userid ?? userInfo?.OPENID;
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
            //TODO:Token刷新机制后面迭代完成，目前不限制token刷新
            //获取token
            //https://qyapi.weixin.qq.com/cgi-bin/gettoken?corpid=ID&corpsecret=SECRET
            string urlToken = $"https://qyapi.weixin.qq.com/cgi-bin/gettoken?corpid={corpid}&corpsecret={corpsecret}";
            string jsonText = GetJson(urlToken);
            var authToken = JsonConvert.DeserializeObject<OAuthToken>(jsonText);
            if (authToken.errcode != "0")
            {
                throw new Exception(authToken.errcode);
            }
            else
                return authToken?.access_token;
        }

        /// <summary>  
        /// 生成Json格式  
        /// </summary>  
        /// <typeparam name="T"></typeparam>  
        /// <param name="obj"></param>  
        /// <returns></returns>  
        private string GetJson(string url)
        {
            WebClient wc = new WebClient();
            wc.Credentials = CredentialCache.DefaultCredentials;
            wc.Encoding = Encoding.UTF8;
            string result = wc.DownloadString(url);
            return result;
        }
    }
}
