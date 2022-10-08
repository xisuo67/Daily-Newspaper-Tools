using Module.Login.DTO.WorkWeChat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.OrganizationUnit.DTO
{
    /// <summary>
    /// 企业微信部门
    /// 接口文档：https://developer.work.weixin.qq.com/document/path/90208
    /// </summary>
    public class WorkWeChatDepartments
    {
        /// <summary>
        /// 创建的部门id
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 部门名称，代开发自建应用需要管理员授权才返回；此字段从2019年12月30日起，对新创建第三方应用不再返回，2020年6月30日起，对所有历史第三方应用不再返回name，返回的name字段使用id代替，后续第三方仅通讯录应用可获取，未返回名称的情况需要通过通讯录展示组件来展示部门名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 父部门id。根部门为1
        /// </summary>
        public string parentid { get; set; }

        /// <summary>
        /// 在父部门中的次序值。order值大的排序靠前。值范围是[0, 2^32)
        /// </summary>
        public string order { get; set; }
    }

    public class WorkWeChatDepartmentsDTO : ApiBaseResult
    { 
        public List<WorkWeChatDepartments> department { get; set; }
    }
}
