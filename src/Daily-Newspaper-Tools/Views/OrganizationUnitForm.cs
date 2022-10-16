using AutoMapper;
using Core.Service;
using DAL;
using DAL.DTO;
using DAL.Entity;
using Module.OrganizationUnit.DomainServices;
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
        private readonly LazyService<WorkWeChatSyncOrganizationDomainService> _workWeChatSyncOrganizationDomainService = new LazyService<WorkWeChatSyncOrganizationDomainService>();
        private List<Department> departments = new List<Department>();
        private Guid currentDeparentId= Guid.Empty;
        public OrganizationUnitForm()
        {
            InitializeComponent();
        }
        #region 列表私有方法
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="id"></param>
        private void Edit(Guid id)
        {
            UserEditForm frm = new UserEditForm(true);
            using (var ctx = new EntityContext())
            {
                var user = ctx.Users.FirstOrDefault(e=>e.UserId==id);
                frm.User = user;
                frm.Render();
                frm.ShowDialog();
                if (frm.IsOK)
                {
                    ctx.Entry(frm.User).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                    ShowSuccessTip("编辑成功");
                    this.InitGridData();
                }
                frm.Dispose();
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ids"></param>
        private void Del(Guid id)
        {
            using (var ctx = new EntityContext())
            {
                var user = ctx.Users.FirstOrDefault(e =>e.UserId==id);
                ctx.Users.Remove(user);
                //TODO:删除用户后，需要同时删除日报，迭代后期在做
                ctx.SaveChanges();
                this.ShowSuccessTip("删除成功");
                this.InitGridData();
            }
        }
        #endregion
        #region 事件

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                if (this.uiDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() == "True")
                {
                    this.uiDataGridView1.Rows[e.RowIndex].Cells[0].Value = false;
                }
                else
                {
                    this.uiDataGridView1.Rows[e.RowIndex].Cells[0].Value = true;
                }
            }
        }

        private void uiDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                Point curPosition = e.Location;//当前鼠标在当前单元格中的坐标
                if (this.uiDataGridView1.Columns[e.ColumnIndex].HeaderText == "操作")
                {
                    Graphics g = this.uiDataGridView1.CreateGraphics();
                    Font myFont = new Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    SizeF sizeRun = g.MeasureString("编辑", myFont);
                    SizeF sizeDel = g.MeasureString("删除", myFont);
                    float fRun = sizeRun.Width / (sizeRun.Width + sizeDel.Width);
                    float fDel = sizeDel.Width / (sizeRun.Width + sizeDel.Width);
                    Rectangle rectTotal = new Rectangle(0, 0, this.uiDataGridView1.Columns[e.ColumnIndex].Width, this.uiDataGridView1.Rows[e.RowIndex].Height);
                    RectangleF rectRun = new RectangleF(rectTotal.Left, rectTotal.Top, rectTotal.Width * fRun, rectTotal.Height);
                    RectangleF rectDel = new RectangleF(rectRun.Right, rectTotal.Top, rectTotal.Width * fDel, rectTotal.Height);
                    //判断当前鼠标在哪个“按钮”范围内
                    Guid id = Guid.Empty;
                    var idString = this.uiDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Guid.TryParse(idString, out id);
                    if (rectRun.Contains(curPosition))
                    {
                        this.Edit(id);//编辑
                    }
                    else if (rectDel.Contains(curPosition))
                    {
                        //TODO:删除
                        this.Del(id);
                    }
                }
            }
        }
        private void uiDataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                Point curPosition = e.Location;//当前鼠标在当前单元格中的坐标
                if (this.uiDataGridView2.Columns[e.ColumnIndex].HeaderText == "操作")
                {
                    Graphics g = this.uiDataGridView2.CreateGraphics();
                    Font myFont = new Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    SizeF sizeRun = g.MeasureString("编辑", myFont);
                    SizeF sizeDel = g.MeasureString("删除", myFont);
                    SizeF sizeAuth = g.MeasureString("授权", myFont);
                    float fRun = sizeRun.Width / (sizeRun.Width + sizeDel.Width + sizeAuth.Width);
                    float fDel = sizeDel.Width / (sizeRun.Width + sizeDel.Width + sizeAuth.Width);
                    float fAuth = sizeAuth.Width / (sizeRun.Width + sizeDel.Width + sizeAuth.Width);


                    Rectangle rectTotal = new Rectangle(0, 0, this.uiDataGridView1.Columns[e.ColumnIndex].Width, this.uiDataGridView1.Rows[e.RowIndex].Height);
                    RectangleF rectRun = new RectangleF(rectTotal.Left, rectTotal.Top, rectTotal.Width * fRun, rectTotal.Height);
                    RectangleF rectDel = new RectangleF(rectRun.Right, rectTotal.Top, rectTotal.Width * fDel, rectTotal.Height);

                    RectangleF rectAuth = new RectangleF(rectDel.Right, rectTotal.Top, rectTotal.Width * fAuth, rectTotal.Height);
                    //判断当前鼠标在哪个“按钮”范围内
                    Guid id = Guid.Empty;
                    var idString = this.uiDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Guid.TryParse(idString, out id);
                    if (rectRun.Contains(curPosition))
                    {
                        //this.Edit(id);//编辑
                    }
                    else if (rectDel.Contains(curPosition))
                    {
                        //TODO:删除
                        //this.Del(id);
                    }
                    else if (rectAuth.Contains(curPosition))
                    {
                        //TODO:授权
                    }
                }
            }
        }
        private void uiDataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (this.uiDataGridView1.Columns[e.ColumnIndex].HeaderText == "操作")
                {
                    e.PaintBackground(e.CellBounds, false);//重绘边框
                    //设置要写入字体的大小
                    Font myFont = new Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    SizeF sizeRun = e.Graphics.MeasureString("编辑", myFont);
                    SizeF sizeDel = e.Graphics.MeasureString("删除", myFont);
                    float fRun = sizeRun.Width / (sizeRun.Width + sizeDel.Width);
                    float fDel = sizeDel.Width / (sizeRun.Width + sizeDel.Width);
                    //设置每个“按钮的边界”
                    RectangleF rectRun = new RectangleF(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width * fRun, e.CellBounds.Height);
                    RectangleF rectDel = new RectangleF(rectRun.Right, e.CellBounds.Top, e.CellBounds.Width * fDel, e.CellBounds.Height);

                    //设置字体样式
                    StringFormat sf = StringFormat.GenericDefault.Clone() as StringFormat;//设置重绘入单元格的字体样式
                    sf.FormatFlags = StringFormatFlags.DisplayFormatControl;
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Trimming = StringTrimming.EllipsisCharacter;
                    e.Graphics.DrawString("编辑", myFont, Brushes.Blue, rectRun, sf);
                    e.Graphics.DrawString("删除", myFont, Brushes.Red, rectDel, sf);
                    e.Handled = true;
                }
            }
        }
        private void uiDataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (this.uiDataGridView2.Columns[e.ColumnIndex].HeaderText == "操作")
                {
                    e.PaintBackground(e.CellBounds, false);//重绘边框
                    //设置要写入字体的大小
                    Font myFont = new Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    SizeF sizeRun = e.Graphics.MeasureString("编辑", myFont);
                    SizeF sizeDel = e.Graphics.MeasureString("删除", myFont);
                    SizeF sizeAuth = e.Graphics.MeasureString("授权", myFont);
                    float fRun = sizeRun.Width / (sizeRun.Width + sizeDel.Width+ sizeAuth.Width);
                    float fDel = sizeDel.Width / (sizeRun.Width + sizeDel.Width+ sizeAuth.Width);
                    float fAuth = sizeAuth.Width / (sizeRun.Width + sizeDel.Width+ sizeAuth.Width);
                    //设置每个“按钮的边界”
                    RectangleF rectRun = new RectangleF(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width * fRun, e.CellBounds.Height);
                    RectangleF rectDel = new RectangleF(rectRun.Right, e.CellBounds.Top, e.CellBounds.Width * fDel, e.CellBounds.Height);

                    RectangleF rectAuth = new RectangleF(rectDel.Right, e.CellBounds.Top, e.CellBounds.Width * fAuth, e.CellBounds.Height);
                    //设置字体样式
                    StringFormat sf = StringFormat.GenericDefault.Clone() as StringFormat;//设置重绘入单元格的字体样式
                    sf.FormatFlags = StringFormatFlags.DisplayFormatControl;
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Trimming = StringTrimming.EllipsisCharacter;
                    e.Graphics.DrawString("编辑", myFont, Brushes.Blue, rectRun, sf);
                    e.Graphics.DrawString("删除", myFont, Brushes.Red, rectDel, sf);
                    e.Graphics.DrawString("授权", myFont, Brushes.Red, rectAuth, sf);
                    e.Handled = true;
                }
            }
        }
        private void OrganizationUnitForm_Load(object sender, EventArgs e)
        {
            this.InitDepartment();
            uiDataGridView1.AddColumn("Id", "Id");
            uiDataGridView1.Columns[0].Visible = false;
            uiDataGridView1.AddColumn("用户名", "Name");
            uiDataGridView1.AddColumn("登录账号", "UserName");
            uiDataGridView1.AddColumn("所属部门", "DepartmentName");
            uiDataGridView1.AddColumn("操作", "", 50);

            uiDataGridView2.AddColumn("Id", "Id");
            uiDataGridView2.Columns[0].Visible = false;
            uiDataGridView2.AddColumn("角色名称", "Name");
            uiDataGridView2.AddColumn("操作", "", 50);

            this.InitGridData();
            this.InitRoleDatas();
        }
        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var treeNode = this.uiTreeView1.SelectedNode;
            if (treeNode != null)
            {
                Guid id = Guid.Empty;
                Guid.TryParse(treeNode.Tag.ToString(), out id);
                using (var ctx = new EntityContext())
                {
                    var users = ctx.Users.Where(x=>x.DepartmentId==id);
                    if (users.Count()>0)
                    {
                        ShowErrorTip("当前组织架构下存在成员，请调整成员组织架构后再删除");
                    }
                    else
                    {
                        var entity = ctx.Departments.FirstOrDefault(x => x.Id == id);
                        ctx.Departments.Remove(entity);
                        ctx.SaveChanges();
                        ShowSuccessTip("删除成功");
                        InitDepartment();
                    }
                   
                }
            }
        }
        /// <summary>
        /// 树节点选中显示菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiTreeView1_MouseDown(object sender, MouseEventArgs e)
        {
            Point ClickPoint = new Point(e.X, e.Y);
            TreeNode CurrentNode = uiTreeView1.GetNodeAt(ClickPoint);
            if (e.Button == MouseButtons.Right)//判断点的是不是右键
            {
               
                if (CurrentNode != null)//判断你点的是不是一个节点
                {
                    CurrentNode.ContextMenuStrip = uiContextMenuStrip1;
                    uiTreeView1.SelectedNode = CurrentNode;//选中这个节点
                }
            }
            else if (e.Button == MouseButtons.Left) //左键联动成员数据
            {
                if (CurrentNode != null)
                {
                    Guid id = Guid.Empty;
                    Guid.TryParse(CurrentNode.Tag.ToString(), out id);
                    this.currentDeparentId = id;
                    this.InitGridData();
                }
            }
        }
        /// <summary>
        /// 新增节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiBtnCreateRoot_Click(object sender, EventArgs e)
        {
            Department department = new Department()
            {
                Id = Guid.NewGuid(),
            };
            var treeNode = this.uiTreeView1.SelectedNode;
            if (treeNode != null)
            {
                Guid parentId = Guid.Empty;
                Guid.TryParse(treeNode.Tag.ToString(), out parentId);
                department.ParentId = parentId;
            }

            DepartmentEditForm frm = new DepartmentEditForm();
            frm.Departments = department;
            frm.Render();
            frm.ShowDialogWithMask();
            if (frm.IsOK)
            {
                var isSuccess = Create(frm.Departments);
                if (isSuccess)
                {
                    ShowSuccessTip("添加成功");
                    InitDepartment();
                }
                else
                    ShowErrorTip("添加失败");

            }
            frm.Dispose();
        }
        /// <summary>
        /// 编辑节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiBtnEditNode_Click(object sender, EventArgs e)
        {
            var treeNode = this.uiTreeView1.SelectedNode;
            if (treeNode != null)
            {
                Guid Id = Guid.Empty;
                Guid.TryParse(treeNode.Tag.ToString(), out Id);
                using (var ctx = new EntityContext())
                {
                    var entity = ctx.Departments.FirstOrDefault(x=>x.Id==Id);
                    if (entity!=null)
                    {
                        DepartmentEditForm frm = new DepartmentEditForm();
                        frm.Departments = entity;
                        frm.Render();
                        frm.ShowDialogWithMask();
                        if (frm.IsOK)
                        {
                            ctx.Entry(frm.Departments).State = System.Data.Entity.EntityState.Modified;
                            ctx.SaveChanges();
                            this.ShowSuccessTip("保存成功");
                            this.InitDepartment();
                        }
                        frm.Dispose();
                    }
                    else
                    {
                        ShowErrorTip("未能查询相应信息");
                        this.InitDepartment();
                    }
                }
            }
        }
        /// <summary>
        /// 新增成员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiSymbolBtnAdd_Click(object sender, EventArgs e)
        {
            UserEditForm frm = new UserEditForm(true);
            using (var ctx = new EntityContext())
            {
                var user = new User() {UserId=Guid.NewGuid() };
                frm.User = user;
                frm.Render();
                frm.ShowDialog();
                if (frm.IsOK)
                {
                    ctx.Entry(frm.User).State = System.Data.Entity.EntityState.Added;
                    ctx.SaveChanges();
                    ShowSuccessTip("保存成功");
                    this.InitGridData();
                }
                frm.Dispose();
            }
        }
        #endregion
        #region 初始化列表及数据
        /// <summary>
        /// 初始化角色数据
        /// </summary>
        /// <param name="searchParam"></param>
        private void InitRoleDatas(string searchParam = null)
        {
            uiDataGridView2.Init();
            List<Roles> roles = new List<Roles>();
            using (var ctx = new EntityContext())
            {
                if (string.IsNullOrEmpty(searchParam))
                {
                    roles = ctx.Roles.ToList();
                }
                else
                {
                    roles = ctx.Roles.Where(e => e.Name.Contains(searchParam)).ToList();
                }
            }
            uiDataGridView2.DataSource = roles;
        }
        /// <summary>
        /// 初始化列表数据
        /// </summary>
        private void InitGridData(string searchParam = null)
        {
            uiDataGridView1.Init();
            List<User> users = new List<User>();
            using (var ctx = new EntityContext())
            {
                if (string.IsNullOrEmpty(searchParam))
                {
                    if (this.currentDeparentId == null)
                        users = ctx.Users.ToList();
                    else
                        users = ctx.Users.Where(e => e.DepartmentId == this.currentDeparentId).ToList();
                }
                else
                {
                    if (this.currentDeparentId == null)
                        users = ctx.Users.Where(e=>e.Name.Contains(searchParam)||e.UserName.Contains(searchParam)).ToList();
                    else
                        users = ctx.Users.Where(e => e.DepartmentId == this.currentDeparentId &&(e.Name.Contains(searchParam) || e.UserName.Contains(searchParam))).ToList();
                }

                var datas = users.Select(e=>new {
                    Id=e.UserId,
                    Name=e.Name,
                    UserName=e.UserName,
                    DepartmentName= departments.FirstOrDefault(x=>x.Id==e.DepartmentId)?.Name
                }).ToList();
                uiDataGridView1.DataSource = datas;
            }
         
        }

        #endregion
        #region 生成树结构私有方法
        private void InitDepartment()
        {
            using (var ctx = new EntityContext())
            {
                this.departments = ctx.Departments.ToList();
                var trees = ConvertToTree(departments);
                uiTreeView1.Nodes.Clear();

                uiTreeView1.Nodes.AddRange(trees.ToArray());

                uiTreeView1.ExpandAll();
            }
        }
        private List<TreeNode> ConvertToTree(
            List<Department> list,
            Guid? Id = null)
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

        private List<Department> Children(
            List<Department> list,
            Guid? Id)
        {
            var childList = list.Where(x => x.ParentId == Id).ToList();
            return childList;
        }

        #endregion
        #region 私有方法
        /// <summary>
        /// 新增节点
        /// </summary>
        /// <param name="department"></param>
        private bool Create(Department department)
        {
            department.Code = GetNextChildCode(department.ParentId);
            var validSuccess = ValidateOrganizationUnit(department);
            if (validSuccess)
            {
                using (var ctx = new EntityContext())
                {
                    ctx.Departments.Add(department);
                    ctx.SaveChanges();
                }
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// 校验
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        private bool ValidateOrganizationUnit(Department department)
        {
            var siblings = FindChildren(department.ParentId)
            .Where(ou => ou.Id != department.Id)
            .ToList();

            if (siblings.Any(ou => ou.Name == department.Name))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 查询子节点
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="recursive"></param>
        /// <returns></returns>
        public List<Department> FindChildren(Guid? parentId, bool recursive = false)
        {
            if (!recursive)
            {
                return GetChildren(parentId);
            }

            if (!parentId.HasValue)
            {
                return GetList();
            }

            var code = GetCodeOrDefault(parentId.Value);

            return GetAllChildrenWithParentCode(code, parentId);
        }

        public virtual List<Department> GetAllChildrenWithParentCode(string code, Guid? parentId)
        {
            using (var ctx = new EntityContext())
            {
                return ctx.Departments.Where(x => x.Code.StartsWith(code) && x.Id != parentId.Value).ToList();
            }
        }
        /// <summary>
        /// 查询children
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        public List<Department> GetChildren(Guid? parentId)
        {
            using (var ctx = new EntityContext())
            {
                return ctx.Departments.Where(e => e.ParentId == parentId).ToList();
            }
        }

        public virtual List<Department> GetList()
        {
            using (var ctx = new EntityContext())
            {
                return ctx.Departments.OrderBy(e => e.Name).ToList();
            }
        }
        /// <summary>
        /// 获取code
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        private string GetNextChildCode(Guid? parentId)
        {
            var lastChild = GetLastChildOrNull(parentId);
            if (lastChild != null)
            {
                return CalculateNextCode(lastChild.Code);
            }

            var parentCode = parentId != null
                ? GetCodeOrDefault(parentId.Value)
                : null;

            return AppendCode(
                parentCode,
                CreateCode(1)
            );
        }

        public virtual string GetCodeOrDefault(Guid id)
        {
            using (var ctx = new EntityContext())
            {
                var entity = ctx.Departments.FirstOrDefault(e => e.Id == id);
                return entity?.Code;
            }
        }
        private string CalculateNextCode(string code)
        {
            var parentCode = GetParentCode(code);
            var lastUnitCode = GetLastUnitCode(code);
            return AppendCode(parentCode, CreateCode(Convert.ToInt32(lastUnitCode) + 1));
        }
        public static string GetLastUnitCode(string code)
        {
            if (code.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(code), "code不能为空");
            }

            var splittedCode = code.Split('.');
            return splittedCode[splittedCode.Length - 1];
        }
        public static string CreateCode(params int[] numbers)
        {
            if (numbers.IsNullOrEmpty())
            {
                return null;
            }

            var code = numbers.Select(number => number.ToString(new string('0', 5)));

            return string.Join(".", code);
        }
        public static string GetParentCode(string code)
        {
            if (code.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(code), "code不能为空");
            }
            var splittedCode = code.Split('.');
            if (splittedCode.Length == 1)
            {
                return null;
            }
            var splitCode = splittedCode.Take(splittedCode.Length - 1);
            return string.Join(".", splitCode);
        }
        public static string AppendCode(string parentCode, string childCode)
        {
            if (childCode.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(childCode), "childCode不能为空");
            }

            if (parentCode.IsNullOrEmpty())
            {
                return childCode;
            }

            return parentCode + "." + childCode;
        }
        /// <summary>
        /// 获取子节点code或根节点
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>

        private Department GetLastChildOrNull(Guid? parentId)
        {
            using (var ctx = new EntityContext())
            {
                var children = ctx.Departments.Where(x => x.ParentId == parentId).ToList();
                return children.OrderBy(c => c.Code).LastOrDefault();
            }
        }

        #endregion

        private void uiTxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.Enter)
            {
                var searchParam = uiTxtSearch.Text.Trim();
                if (!string.IsNullOrEmpty(searchParam))
                {
                    InitGridData(searchParam);
                }
            }
        }

        private void uiSymbolBtnRoleAdd_Click(object sender, EventArgs e)
        {
            //ShowInfoTip("功能尚在规划中，尽情期待");
            RolesEditForm frm = new RolesEditForm();
            using (var ctx = new EntityContext())
            {
                Roles roles = new Roles() { Id=Guid.NewGuid()};
                frm.Roles = roles;
                frm.Render();
                frm.ShowDialog();
                if (frm.IsOK)
                {
                    ctx.Entry(frm.Roles).State = System.Data.Entity.EntityState.Added;
                    ctx.SaveChanges();
                    ShowSuccessTip("保存成功");
                    this.InitRoleDatas();
                }
                frm.Dispose();
            }
        }

        private void uiSymbolBtnSync_Click(object sender, EventArgs e)
        {
            uiSymbolBtnSync.ShowContextMenuStrip(uiContextMenuStrip2, 0, uiSymbolBtnSync.Height);
        }

        private void btn_UserSyncByWorkWeChat_Click(object sender, EventArgs e)
        {
            var result = _workWeChatSyncOrganizationDomainService.Instance.VerifyBeforeSyncUser();
            if (result)
            {
                if (ShowAskDialog("该操作将从企业微信中同步用户信息，是否继续？"))
                {
                    _workWeChatSyncOrganizationDomainService.Instance.GetOrganizationUsersSync();
                    ShowSuccessTip("同步成功");
                    this.InitGridData();
                }
            }
            else
            {
                ShowErrorTip("从企业微信同步用户前，请先同步部门信息");
            }
        }

        private void btn_OrganizationSyncByWorkWeChat_Click(object sender, EventArgs e)
        {
            if (ShowAskDialog("该操作将覆盖原有部门信息，是否继续？", true))
            {
                try
                {
                    _workWeChatSyncOrganizationDomainService.Instance.GetOrganizationSync();
                    ShowSuccessTip("同步成功");
                    this.InitDepartment();
                    this.InitGridData();
                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.ToString(),10000);
                }
               
                
            }
        }


    }
}
