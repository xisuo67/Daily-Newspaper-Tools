using Core.Service;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Dependency
{
    public interface IOrganizationUnitSyncService : IService
    {
        /// <summary>
        /// 同步组织架构
        /// </summary>
        /// <returns></returns>
        List<Department> GetOrganizationSync();

        /// <summary>
        /// 同步组织架构下所有用户数据
        /// </summary>
        /// <returns></returns>
        List<User> GetOrganizationUsersSync();

        /// <summary>
        /// 同步用户前校验
        /// </summary>
        /// <returns></returns>
        bool VerifyBeforeSyncUser();
    }
}
