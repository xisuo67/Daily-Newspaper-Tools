
namespace Daily_Newspaper_Tools
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("登录");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("注册");
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.uiNavBar1 = new Sunny.UI.UINavBar();
            this.uiTxtPassword = new Sunny.UI.UITextBox();
            this.uiTxtUser = new Sunny.UI.UITextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            this.uiNavBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 305);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(59, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(114, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(761, 3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(15, 14);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 7;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(740, 3);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(15, 14);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 8;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // uiNavBar1
            // 
            this.uiNavBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiNavBar1.Controls.Add(this.label1);
            this.uiNavBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiNavBar1.DropMenuFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiNavBar1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiNavBar1.Location = new System.Drawing.Point(250, 0);
            this.uiNavBar1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiNavBar1.Name = "uiNavBar1";
            treeNode3.Name = "节点0";
            treeNode3.Text = "登录";
            treeNode4.Name = "节点1";
            treeNode4.Text = "注册";
            this.uiNavBar1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.uiNavBar1.SelectedIndex = 0;
            this.uiNavBar1.Size = new System.Drawing.Size(530, 89);
            this.uiNavBar1.TabIndex = 11;
            this.uiNavBar1.Text = "uiNavBar1";
            this.uiNavBar1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTxtPassword
            // 
            this.uiTxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiTxtPassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.uiTxtPassword.ForeColor = System.Drawing.Color.Silver;
            this.uiTxtPassword.Location = new System.Drawing.Point(290, 159);
            this.uiTxtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxtPassword.Name = "uiTxtPassword";
            this.uiTxtPassword.ShowText = false;
            this.uiTxtPassword.Size = new System.Drawing.Size(429, 37);
            this.uiTxtPassword.Style = Sunny.UI.UIStyle.Custom;
            this.uiTxtPassword.TabIndex = 14;
            this.uiTxtPassword.Text = "密码";
            this.uiTxtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxtPassword.Watermark = "";
            this.uiTxtPassword.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTxtUser
            // 
            this.uiTxtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxtUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiTxtUser.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.uiTxtUser.ForeColor = System.Drawing.Color.Silver;
            this.uiTxtUser.ForeDisableColor = System.Drawing.Color.White;
            this.uiTxtUser.Location = new System.Drawing.Point(290, 105);
            this.uiTxtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxtUser.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxtUser.Name = "uiTxtUser";
            this.uiTxtUser.ShowText = false;
            this.uiTxtUser.Size = new System.Drawing.Size(429, 35);
            this.uiTxtUser.Style = Sunny.UI.UIStyle.Custom;
            this.uiTxtUser.TabIndex = 13;
            this.uiTxtUser.Text = "用户名";
            this.uiTxtUser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxtUser.Watermark = "";
            this.uiTxtUser.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.ForeColor = System.Drawing.Color.LightGray;
            this.btnlogin.Location = new System.Drawing.Point(393, 252);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(199, 37);
            this.btnlogin.TabIndex = 12;
            this.btnlogin.Text = "登录";
            this.btnlogin.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(780, 305);
            this.Controls.Add(this.uiTxtPassword);
            this.Controls.Add(this.uiTxtUser);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.uiNavBar1);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            this.uiNavBar1.ResumeLayout(false);
            this.uiNavBar1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private Sunny.UI.UINavBar uiNavBar1;
        private Sunny.UI.UITextBox uiTxtPassword;
        private Sunny.UI.UITextBox uiTxtUser;
        private System.Windows.Forms.Button btnlogin;
    }
}

