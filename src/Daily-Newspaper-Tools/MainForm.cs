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
        //private
        public MainForm()
        {
            InitializeComponent();
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
        }
        private void Aside_MenuItemClick(System.Windows.Forms.TreeNode node, NavMenuItem item, int pageIndex)
        {
            Header.Text = "PageIndex: " + pageIndex;
        }
    }
}
