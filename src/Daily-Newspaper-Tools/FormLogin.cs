using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Newspaper_Tools
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void uiNavBar1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region 文本事件

        private void uiTxtUser_Enter(object sender, EventArgs e)
        {
            if (uiTxtUser.Text == "用户名")
            {
                uiTxtUser.Text = "";
                uiTxtUser.ForeColor = Color.LightGray;
            }
        }

        private void uiTxtUser_Leave(object sender, EventArgs e)
        {
            if (uiTxtUser.Text == "")
            {
                uiTxtUser.Text = "用户名";
                uiTxtUser.ForeColor = Color.Silver;
            }
        }

        private void uiTxtPassword_Enter(object sender, EventArgs e)
        {
            if (uiTxtPassword.Text == "密码")
            {
                uiTxtPassword.Text = "";
                uiTxtPassword.ForeColor = Color.LightGray;
                uiTxtPassword.TextBox.UseSystemPasswordChar =true;
            }
        }

        private void uiTxtPassword_Leave(object sender, EventArgs e)
        {
            if (uiTxtPassword.Text == "")
            {
                uiTxtPassword.Text = "密码";
                uiTxtPassword.ForeColor = Color.Silver;
                uiTxtPassword.TextBox.UseSystemPasswordChar =false;
            }
        }
        #endregion 

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnregister_Click(object sender, EventArgs e)
        {

        }

        
    }
}
