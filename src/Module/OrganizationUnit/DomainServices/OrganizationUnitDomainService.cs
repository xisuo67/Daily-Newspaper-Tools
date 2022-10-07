using DAL.Entity;
using Module.OrganizationUnit.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Module.OrganizationUnit.DomainServices
{
    /// <summary>
    /// 组织架构服务
    /// </summary>
    public class OrganizationUnitDomainService : IOrganizationService
    {
        public string AppendCode(string parentCode, string childCode)
        {
            throw new NotImplementedException();
        }

        public string CalculateNextCode(string code)
        {
            throw new NotImplementedException();
        }

        public List<Department> Children(List<Department> list, Guid? Id)
        {
            throw new NotImplementedException();
        }

        public List<TreeNode> ConvertToTree(List<Department> list, Guid? Id = null)
        {
            throw new NotImplementedException();
        }

        public string CreateCode(params int[] numbers)
        {
            throw new NotImplementedException();
        }

        public List<Department> FindChildren(Guid? parentId, bool recursive = false)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAllChildrenWithParentCode(string code, Guid? parentId)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetChildren(Guid? parentId)
        {
            throw new NotImplementedException();
        }

        public string GetCodeOrDefault(Guid id)
        {
            throw new NotImplementedException();
        }

        public Department GetLastChildOrNull(Guid? parentId)
        {
            throw new NotImplementedException();
        }

        public string GetLastUnitCode(string code)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetList()
        {
            throw new NotImplementedException();
        }

        public string GetNextChildCode(Guid? parentId)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetOrganizationSync()
        {
            throw new NotImplementedException();
        }

        public string GetParentCode(string code)
        {
            throw new NotImplementedException();
        }

        public bool ValidateOrganizationUnit(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
