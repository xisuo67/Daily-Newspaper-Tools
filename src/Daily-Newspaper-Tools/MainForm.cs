using Daily_Newspaper_Tools.Common.Login;
using Daily_Newspaper_Tools.Views;
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

namespace Daily_Newspaper_Tools
{
    public partial class MainForm : UIAsideHeaderMainFrame
    {
        public MainForm()
        {
            InitializeComponent();
           

        }
        private void InitMenu() {
            int pageIndex = 1000;
            TreeNode parent = Aside.CreateNode("工作管理", 61451, 24, pageIndex);
            //通过设置PageIndex关联，节点文字、图标由相应的Page的Text、Symbol提供
            Aside.CreateChildNode(parent, AddPage(new WorkDetailsForm(), ++pageIndex));
            Aside.CreateChildNode(parent, AddPage(new EmailContactsForm(), ++pageIndex));

            parent = Aside.CreateNode("系统设置", 61818, 24, ++pageIndex);
            Aside.CreateChildNode(parent, AddPage(new EmailConfigForm(), ++pageIndex));

            //parent = Aside.CreateNode("个人设置", 61818, 24, ++pageIndex);
            //Aside.CreateChildNode(parent, AddPage(new EmailConfigForm(), ++pageIndex));


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
            this.uiAvatar.Text = LoginContext.Current.UserInfo.UserName;
        }

        private void uiAvatar_Click(object sender, EventArgs e)
        {
            uiAvatar.ShowContextMenuStrip(uiContextMenuStrip1, 0, uiAvatar.Height);
        }
        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
