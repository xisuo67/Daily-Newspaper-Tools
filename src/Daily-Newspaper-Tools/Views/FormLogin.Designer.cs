﻿
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiTxtPassword = new Sunny.UI.UITextBox();
            this.uiTxtUser = new Sunny.UI.UITextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiTxt = new Sunny.UI.UITextBox();
            this.uiTxtPass = new Sunny.UI.UITextBox();
            this.uiTxtUserName = new Sunny.UI.UITextBox();
            this.btnregistered = new System.Windows.Forms.Button();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiSymbolBtnWeChat = new Sunny.UI.UISymbolButton();
            this.uiToolTip1 = new Sunny.UI.UIToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            this.uiTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 323);
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
            this.label1.Location = new System.Drawing.Point(490, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(761, 8);
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
            this.btnminimizar.Location = new System.Drawing.Point(740, 8);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(15, 14);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 8;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiTabControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.Frame = null;
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(273, 45);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(482, 266);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTabControl1.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiTabControl1.TabIndex = 10;
            this.uiTabControl1.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiTabControl1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.tabPage1.Controls.Add(this.uiSymbolBtnWeChat);
            this.tabPage1.Controls.Add(this.uiTxtPassword);
            this.tabPage1.Controls.Add(this.uiLine1);
            this.tabPage1.Controls.Add(this.uiTxtUser);
            this.tabPage1.Controls.Add(this.btnlogin);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(482, 226);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "登录";
            // 
            // uiTxtPassword
            // 
            this.uiTxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiTxtPassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.uiTxtPassword.ForeColor = System.Drawing.Color.Silver;
            this.uiTxtPassword.Location = new System.Drawing.Point(13, 72);
            this.uiTxtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxtPassword.Name = "uiTxtPassword";
            this.uiTxtPassword.ShowText = false;
            this.uiTxtPassword.Size = new System.Drawing.Size(429, 37);
            this.uiTxtPassword.Style = Sunny.UI.UIStyle.Custom;
            this.uiTxtPassword.TabIndex = 5;
            this.uiTxtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxtPassword.Watermark = "密码";
            this.uiTxtPassword.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTxtUser
            // 
            this.uiTxtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxtUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiTxtUser.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.uiTxtUser.ForeColor = System.Drawing.Color.Silver;
            this.uiTxtUser.ForeDisableColor = System.Drawing.Color.White;
            this.uiTxtUser.Location = new System.Drawing.Point(13, 17);
            this.uiTxtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxtUser.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxtUser.Name = "uiTxtUser";
            this.uiTxtUser.ShowText = false;
            this.uiTxtUser.Size = new System.Drawing.Size(429, 35);
            this.uiTxtUser.Style = Sunny.UI.UIStyle.Custom;
            this.uiTxtUser.TabIndex = 4;
            this.uiTxtUser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxtUser.Watermark = "用户名";
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
            this.btnlogin.Location = new System.Drawing.Point(128, 117);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(199, 37);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "登录";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.tabPage2.Controls.Add(this.uiTxt);
            this.tabPage2.Controls.Add(this.uiTxtPass);
            this.tabPage2.Controls.Add(this.uiTxtUserName);
            this.tabPage2.Controls.Add(this.btnregistered);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(482, 226);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "注册";
            // 
            // uiTxt
            // 
            this.uiTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiTxt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.uiTxt.ForeColor = System.Drawing.Color.Silver;
            this.uiTxt.Location = new System.Drawing.Point(16, 110);
            this.uiTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxt.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxt.Name = "uiTxt";
            this.uiTxt.ShowText = false;
            this.uiTxt.Size = new System.Drawing.Size(429, 37);
            this.uiTxt.Style = Sunny.UI.UIStyle.Custom;
            this.uiTxt.TabIndex = 9;
            this.uiTxt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxt.Watermark = "确认密码";
            this.uiTxt.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTxtPass
            // 
            this.uiTxtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxtPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiTxtPass.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.uiTxtPass.ForeColor = System.Drawing.Color.Silver;
            this.uiTxtPass.Location = new System.Drawing.Point(16, 63);
            this.uiTxtPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxtPass.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxtPass.Name = "uiTxtPass";
            this.uiTxtPass.ShowText = false;
            this.uiTxtPass.Size = new System.Drawing.Size(429, 37);
            this.uiTxtPass.Style = Sunny.UI.UIStyle.Custom;
            this.uiTxtPass.TabIndex = 8;
            this.uiTxtPass.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxtPass.Watermark = "密码";
            this.uiTxtPass.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTxtUserName
            // 
            this.uiTxtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxtUserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiTxtUserName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.uiTxtUserName.ForeColor = System.Drawing.Color.Silver;
            this.uiTxtUserName.ForeDisableColor = System.Drawing.Color.White;
            this.uiTxtUserName.Location = new System.Drawing.Point(16, 17);
            this.uiTxtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxtUserName.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxtUserName.Name = "uiTxtUserName";
            this.uiTxtUserName.ShowText = false;
            this.uiTxtUserName.Size = new System.Drawing.Size(429, 35);
            this.uiTxtUserName.Style = Sunny.UI.UIStyle.Custom;
            this.uiTxtUserName.TabIndex = 7;
            this.uiTxtUserName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxtUserName.Watermark = "用户名";
            this.uiTxtUserName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnregistered
            // 
            this.btnregistered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnregistered.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnregistered.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnregistered.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnregistered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistered.ForeColor = System.Drawing.Color.LightGray;
            this.btnregistered.Location = new System.Drawing.Point(158, 155);
            this.btnregistered.Name = "btnregistered";
            this.btnregistered.Size = new System.Drawing.Size(199, 37);
            this.btnregistered.TabIndex = 6;
            this.btnregistered.Text = "注册";
            this.btnregistered.UseVisualStyleBackColor = false;
            this.btnregistered.Click += new System.EventHandler(this.btnregistered_Click);
            // 
            // uiLine1
            // 
            this.uiLine1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.ForeColor = System.Drawing.Color.Gray;
            this.uiLine1.LineColor = System.Drawing.Color.Gray;
            this.uiLine1.Location = new System.Drawing.Point(56, 158);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(338, 29);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 6;
            this.uiLine1.Text = "其他登录方式";
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolBtnWeChat
            // 
            this.uiSymbolBtnWeChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolBtnWeChat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiSymbolBtnWeChat.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiSymbolBtnWeChat.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiSymbolBtnWeChat.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiSymbolBtnWeChat.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiSymbolBtnWeChat.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolBtnWeChat.Location = new System.Drawing.Point(197, 193);
            this.uiSymbolBtnWeChat.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolBtnWeChat.Name = "uiSymbolBtnWeChat";
            this.uiSymbolBtnWeChat.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiSymbolBtnWeChat.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiSymbolBtnWeChat.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiSymbolBtnWeChat.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.uiSymbolBtnWeChat.Size = new System.Drawing.Size(44, 26);
            this.uiSymbolBtnWeChat.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolBtnWeChat.Symbol = 161911;
            this.uiSymbolBtnWeChat.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uiSymbolBtnWeChat.TabIndex = 7;
            this.uiSymbolBtnWeChat.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolBtnWeChat.TipsText = "企业微信登录";
            this.uiSymbolBtnWeChat.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSymbolBtnWeChat.Click += new System.EventHandler(this.uiSymbolBtnWeChat_Click);
            // 
            // uiToolTip1
            // 
            this.uiToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.uiToolTip1.OwnerDraw = true;
            // 
            // FormLogin
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(780, 323);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "Form1";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 780, 305);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Sunny.UI.UITextBox uiTxtPassword;
        private Sunny.UI.UITextBox uiTxtUser;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UITextBox uiTxtPass;
        private Sunny.UI.UITextBox uiTxtUserName;
        private System.Windows.Forms.Button btnregistered;
        private Sunny.UI.UITextBox uiTxt;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISymbolButton uiSymbolBtnWeChat;
        private Sunny.UI.UIToolTip uiToolTip1;
    }
}

