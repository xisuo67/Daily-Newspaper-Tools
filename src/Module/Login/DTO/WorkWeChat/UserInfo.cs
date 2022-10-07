using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Login.DTO.WorkWeChat
{
    public class UserInfo : ApiBaseResult
    {
        /// <summary>
        /// 当用户为企业成员时返回示例如下:成员UserID。若需要获得用户详情信息，可调用通讯录接口：读取成员
        /// </summary>
        public string userid { get; set; }
        /// <summary>
        /// 非企业成员授权时返回示例如下：
        /// </summary>
        public string OPENID { get; set; }

    }
}
