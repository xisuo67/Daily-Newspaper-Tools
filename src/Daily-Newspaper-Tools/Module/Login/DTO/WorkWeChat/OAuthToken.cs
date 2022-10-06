using Daily_Newspaper_Tools.Module.Login.DTO.WorkWeChat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Newspaper_Tools.Module.Login.DTO
{
    public class OAuthToken: ApiBaseResult
    {
        
        /// <summary>
        /// 获取到的凭证，最长为512字节
        /// </summary>
        public string access_token { get; set; }
        /// <summary>
        /// 凭证的有效时间（秒）
        /// access_token的有效期通过返回的expires_in来传达，正常情况下为7200秒（2小时），有效期内重复获取返回相同结果，过期后获取会返回新的access_token。
        /// </summary>
        public string expires_in { get; set; }
    }
}
