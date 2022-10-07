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
            throw new NotImplementedException();
        }

        public List<User> GetOrganizationUsersSync()
        {
            throw new NotImplementedException();
        }
    }
}
