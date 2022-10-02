using Daily_Newspaper_Tools.Common.Login;
using DAL;
using DAL.DTO;
using DAL.Entity;
using Sunny.UI;
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
using ToolsHelper.Extensions;

namespace Daily_Newspaper_Tools
{
    public partial class FormLogin : UIForm
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

    

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (this.btnlogin.Enabled)
                {
                    this.btnlogin_Click(null, null);
                }
            }
            else if (keyData == Keys.Escape)
            {
                this.Close();
            }
            return false;
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
            var userName = this.uiTxtUser.Text.Trim();
            //加密
            var password = this.uiTxtPassword.Text.Trim().MyEncrypt();

            using (var ctx = new EntityContext())
            {
                var userEntity= ctx.Users.FirstOrDefault(d=>d.UserName==userName&& d.Password==password);
                if (userEntity != null)
                {
                    UserDTO userDTO = new UserDTO();
                    userDTO.MapperFrom(userEntity);
                    LoginContext.Current  = new LoginContext(userDTO);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    ShowErrorTip("用户名或密码错误");
                }
            }

        }
        private void btnregistered_Click(object sender, EventArgs e)
        {
            var userName = this.uiTxtUserName.Text.Trim();
            //加密比对
            var password = this.uiTxtPass.Text.Trim().MyEncrypt();
            var againPassword=this.uiTxt.Text.Trim().MyEncrypt();
            if (password!=againPassword)
            {
                ShowErrorTip("两次密码输入不一致，请重新调整");
            }
            else
            {
                try
                {
                    using (var ctx = new EntityContext())
                    {
                        var existsUser = ctx.Users.FirstOrDefault(d => d.UserName == userName);
                        if (existsUser != null)
                        {
                            ShowErrorTip("存在相同用户名，请重新输入");
                        }
                        else
                        {
                            User user = new User()
                            {
                                UserId = Guid.NewGuid(),
                                UserName = userName,
                                Password = password
                            };
                            ctx.Users.Add(user);
                            ctx.SaveChanges();
                            ShowSuccessTip("注册成功,请返回登录页");
                        }
                    }
                }
                catch (Exception ex)
                {

                    ShowErrorTip("注册失败");
                }
                
            }
        }
    }
}
