using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using Utility.Dependency;

namespace Module.OrganizationUnit.Interfaces
{
    /// <summary>
    /// 组织架构接口
    /// </summary>
    public interface IOrganizationService
    {
        /// <summary>
        /// 转树结构
        /// </summary>
        /// <param name="list"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        List<TreeNode> ConvertToTree(List<Department> list,Guid? Id = null);


        /// <summary>
        /// 转树结构子集
        /// </summary>
        /// <param name="list"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        List<Department> Children(List<Department> list,Guid? Id);
        /// <summary>
        /// 校验
        /// </summary>
        /// <param name="department"></param>
        bool ValidateOrganizationUnit(Department department);

        /// <summary>
        /// 查询子节点
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="recursive"></param>
        /// <returns></returns>
        List<Department> FindChildren(Guid? parentId, bool recursive = false);

        /// <summary>
        /// 获取所有子节点
        /// </summary>
        /// <param name="code"></param>
        /// <param name="parentId"></param>
        /// <returns></returns>
        List<Department> GetAllChildrenWithParentCode(string code, Guid? parentId);

        /// <summary>
        /// 查询children
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        List<Department> GetChildren(Guid? parentId);

        /// <summary>
        /// 获取部门数据
        /// </summary>
        /// <returns></returns>
        List<Department> GetList();

        /// <summary>
        /// 获取code
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        string GetNextChildCode(Guid? parentId);

        /// <summary>
        /// 获取code或默认值
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        string GetCodeOrDefault(Guid id);

        /// <summary>
        /// 计算下一节点
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        string CalculateNextCode(string code);
        /// <summary>
        /// 获取下一节点
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        string GetLastUnitCode(string code);
        /// <summary>
        /// 创建code
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        string CreateCode(params int[] numbers);
        /// <summary>
        /// 获取parentCode
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        string GetParentCode(string code);
        /// <summary>
        /// 追加code
        /// </summary>
        /// <param name="parentCode"></param>
        /// <param name="childCode"></param>
        /// <returns></returns>
        string AppendCode(string parentCode, string childCode);

        /// <summary>
        /// 获取子节点code或根节点
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        Department GetLastChildOrNull(Guid? parentId);
    }
}
