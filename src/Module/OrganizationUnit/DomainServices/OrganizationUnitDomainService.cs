using DAL.Entity;
using Module.OrganizationUnit.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.OrganizationUnit.DomainServices
{
    /// <summary>
    /// 组织架构服务
    /// </summary>
    public class OrganizationUnitDomainService : IOrganizationService
    {
        public List<Department> GetOrganizationSync()
        {
            throw new NotImplementedException();
        }
    }
}
