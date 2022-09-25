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
        private Guid UserGUID = Guid.Empty;
        private string UserName = string.Empty;
        public MainForm()
        {
            InitializeComponent();
            int pageIndex = 1000;
            TreeNode parent = Aside.CreateNode("工作管理", 61451, 24, pageIndex);
            //通过设置PageIndex关联，节点文字、图标由相应的Page的Text、Symbol提供
            Aside.CreateChildNode(parent, AddPage(new WorkDetails(), ++pageIndex));

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
            this.UserGUID = formLogin.UserGUID;
            this.UserName = formLogin.UserName;
            this.uiAvatar.Text = this.UserName;
        }
        private void Aside_MenuItemClick(System.Windows.Forms.TreeNode node, NavMenuItem item, int pageIndex)
        {
            Header.Text = "PageIndex: " + pageIndex;
        }
    }
}
