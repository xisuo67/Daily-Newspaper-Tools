﻿using Core.Service;
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
    }
}
