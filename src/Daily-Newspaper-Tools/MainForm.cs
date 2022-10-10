using Daily_Newspaper_Tools.Common.Login;
using Daily_Newspaper_Tools.Views;
using DAL;
using DAL.Entity;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolsHelper.HttpRequest;

namespace Daily_Newspaper_Tools
{
    public partial class MainForm : UIAsideHeaderMainFrame
    {
        private UpdateChecker updateChecker = new UpdateChecker();
        public MainForm()
        {
            InitializeComponent();
            updateChecker.NewVersionFound += updateChecker_NewVersionFound;
            updateChecker.NewVersionFoundFailed += UpdateChecker_NewVersionFoundFailed;
            updateChecker.Check(true);
        }
        #region 检查更新事件
        private void updateChecker_NewVersionFound(object sender, EventArgs e)
        {
            if (updateChecker.Found)
            {
                string title = $"{UpdateChecker.Name} 更新提示";
                string desc = $"点击下载新版本{UpdateChecker.Name} {updateChecker.LatestVersionNumber}";
                UINotifierHelper.ShowNotifier(desc, InfoNotifierClick, UINotifierType.INFO, title, 10000);
            }
                
        }
        private void UpdateChecker_NewVersionFoundFailed(object sender, EventArgs e)
        {
            string title = $"{UpdateChecker.Name} 更新提示";
            string desc = $"自动更新检查失败";
            UINotifierHelper.ShowNotifier(desc, null, UINotifierType.INFO, title, 10000);
        }

        private void InfoNotifierClick(object sender, EventArgs e)
        {
            new Process
            {
                StartInfo = new ProcessStartInfo(updateChecker.LatestVersionUrl)
                {
                    UseShellExecute = true
                }
            }.Start();
        }
        #endregion
        private void InitMenu() {
            int pageIndex = 1000;
            TreeNode parent = Aside.CreateNode("工作管理", 61451, 24, pageIndex);
            //通过设置PageIndex关联，节点文字、图标由相应的Page的Text、Symbol提供
            Aside.CreateChildNode(parent, AddPage(new WorkDetailsForm(), ++pageIndex));
            Aside.CreateChildNode(parent, AddPage(new SynergyDailyForm(), ++pageIndex));
            Aside.CreateChildNode(parent, AddPage(new EmailContactsForm(), ++pageIndex));

            parent = Aside.CreateNode("系统设置", 61818, 24, ++pageIndex);
            Aside.CreateChildNode(parent, AddPage(new EmailConfigForm(), ++pageIndex));
            Aside.CreateChildNode(parent, AddPage(new OrganizationUnitForm(), ++pageIndex));
            //选中第一个节点
            Aside.SelectPage(1001);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowInTaskbar = true;
            if (DialogResult.OK != formLogin.ShowDialog())
            {
                this.Close();
                return;
            }
            InitMenu();
            InitAvatar();

        }
        private void InitAvatar()
        {
            this.uiAvatar.Text = string.IsNullOrEmpty(LoginContext.Current.UserInfo.Name) ? LoginContext.Current.UserInfo.UserName : LoginContext.Current.UserInfo.Name;
        }
        private void uiAvatar_Click(object sender, EventArgs e)
        {
            uiAvatar.ShowContextMenuStrip(uiContextMenuStrip1, 0, uiAvatar.Height);
        }
        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserEditForm frm = new UserEditForm();
            var userDto = LoginContext.Current.UserInfo;
            User user = new User();
            user.MapperFrom(userDto);
            using (var ctx = new EntityContext())
            {
                frm.User = user;
                frm.Render();
                frm.ShowDialog();
                if (frm.IsOK)
                {
                    ctx.Entry(frm.User).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                    ShowSuccessDialog("编辑成功");
                    userDto.MapperFrom(user);
                    LoginContext.Current.UserInfo = userDto;
                    InitAvatar();
                }
                frm.Dispose();
            }
        }

        private void uiHeaderButton12_Click(object sender, EventArgs e)
        {
            new Process
            {
                StartInfo = new ProcessStartInfo("https://github.com/xisuo67/Daily-Newspaper-Tools")
                {
                    UseShellExecute = true
                }
            }.Start();
        }
    }
}
