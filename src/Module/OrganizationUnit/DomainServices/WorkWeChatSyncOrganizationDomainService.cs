using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Dependency;
using Utility.Enums;

namespace Module.OrganizationUnit.DomainServices
{
    public class WorkWeChatSyncOrganizationDomainService : IOrganizationUnitSyncService
    {

        /// <summary>
        /// 类型key，用于工厂注册
        /// </summary>
        public static readonly string TypeKey = LoginEnum.GlobalKey(OrganizationUnitEnum.WorkWeChatSync);
        public List<Department> GetOrganizationSync()
        {
            //企业微信同步组织架构接口文档地址：https://developer.work.weixin.qq.com/document/path/90208

            //接口地址：https://qyapi.weixin.qq.com/cgi-bin/department/list?access_token=ACCESS_TOKEN&id=ID

           // 参数           必须    说明
           //access_token    是    调用接口凭证
           // id              否   部门id。获取指定部门及其下的子部门（以及子部门的子部门等等，递归）。 如果不填，默认获取全量组织架构


            throw new NotImplementedException();
        }

        public List<User> GetOrganizationUsersSync()
        {
            //同步企业微信人员信息，接口文档地址：

            //接口地址：https://qyapi.weixin.qq.com/cgi-bin/user/simplelist?access_token=ACCESS_TOKEN&department_id=DEPARTMENT_ID&fetch_child=1/0(1递归获取，0只获取本部门)
            throw new NotImplementedException();
        }
    }
}
