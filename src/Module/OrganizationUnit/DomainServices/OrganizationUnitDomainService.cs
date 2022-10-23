using DAL;
using DAL.Entity;
using Module.OrganizationUnit.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        /// <summary>
        /// 获取部门下所有用户信息
        /// </summary>
        /// <returns></returns>
        public List<TreeNode> GetDepartmentUser()
        {
            List<TreeNode> treeNodes = new List<TreeNode>();
            using (var ctx = new EntityContext())
            {
                var departments = ctx.Departments.ToList();
                var users = ctx.Users.ToList();
            }
            return treeNodes;
        }
        public string CalculateNextCode(string code)
        {
            throw new NotImplementedException();
        }
        public List<TreeNode> GetDeparentmentHasNoTree(List<Department> list)
        {
            var result = new List<TreeNode>();
            foreach (var item in list)
            {
                var tree = new TreeNode
                {
                    Name = item.Id.ToString(),
                    Text = item.Name,
                    Tag = item.Id.ToString(),
                };
                result.Add(tree);
            }
            return result;
        }
        public List<Department> Children(List<Department> list, Guid? Id)
        {
            var childList = list.Where(x => x.ParentId == Id).ToList();
            return childList;
        }

        public List<TreeNode> ConvertToTree(List<Department> list, Guid? Id = null)
        {
            var result = new List<TreeNode>();
            var childList = Children(list, Id);
            foreach (var item in childList)
            {
                var tree = new TreeNode
                {
                    Name = item.Id.ToString(),
                    Text = item.Name,
                    Tag = item.Id.ToString(),
                };
                var childs = ConvertToTree(list, item.Id);
                foreach (var items in childs)
                {
                    tree.Nodes.Add(items);
                }
                result.Add(tree);
            }

            return result;
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
        /// <summary>
        /// 获取部门所有数据
        /// </summary>
        /// <returns></returns>
        public List<Department> GetList()
        {
            using (var ctx = new EntityContext())
            {
                return ctx.Departments.OrderBy(e => e.Code).ToList();
            }
        }

        public string GetNextChildCode(Guid? parentId)
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
