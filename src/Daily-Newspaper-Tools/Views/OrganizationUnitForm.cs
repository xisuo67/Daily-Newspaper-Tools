using DAL.Entity;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Newspaper_Tools.Views
{
    public partial class OrganizationUnitForm : UIPage
    {
        public OrganizationUnitForm()
        {
            InitializeComponent();
        }
        #region 事件
        /// <summary>
        /// 新增节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiBtnCreateRoot_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 编辑节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiBtnEditNode_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 新增成员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiSymbolBtnAdd_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 新增节点
        /// </summary>
        /// <param name="department"></param>
        private void Create(Department department)
        {
            department.Code = GetNextChildCode(department.ParentId);
        }

        /// <summary>
        /// 校验
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        private bool ValidateOrganizationUnit(Department department)
        {
            return false;
        }
        /// <summary>
        /// 查询子节点
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="recursive"></param>
        /// <returns></returns>
        public List<Department> FindChildren(Guid? parentId, bool recursive = false)
        {
            return null;
        }
        /// <summary>
        /// 获取code
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        private string GetNextChildCode(Guid? parentId)
        {
            return null;
        }
        /// <summary>
        /// 获取子节点code或根节点
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>

        private Department GetLastChildOrNullAsync(Guid? parentId)
        {
            return null;
        }
        #endregion
    }
}
