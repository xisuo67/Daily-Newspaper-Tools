namespace Daily_Newspaper_Tools.Views
{
    partial class EmailConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiBtnSave = new Sunny.UI.UIButton();
            this.uiTxtEmial = new Sunny.UI.UITextBox();
            this.uiTxtPassword = new Sunny.UI.UITextBox();
            this.uiTxtServer = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(75, 92);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(106, 21);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "发送服务器：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(81, 153);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(95, 36);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "登录邮箱：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(81, 254);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = "密码：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiBtnSave
            // 
            this.uiBtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiBtnSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtnSave.Location = new System.Drawing.Point(330, 353);
            this.uiBtnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBtnSave.Name = "uiBtnSave";
            this.uiBtnSave.Size = new System.Drawing.Size(133, 34);
            this.uiBtnSave.TabIndex = 4;
            this.uiBtnSave.Text = "保存";
            this.uiBtnSave.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtnSave.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiBtnSave.Click += new System.EventHandler(this.uiBtnSave_Click);
            // 
            // uiTxtEmial
            // 
            this.uiTxtEmial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTxtEmial.AutoSize = true;
            this.uiTxtEmial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxtEmial.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTxtEmial.Location = new System.Drawing.Point(183, 160);
            this.uiTxtEmial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxtEmial.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxtEmial.Name = "uiTxtEmial";
            this.uiTxtEmial.ShowText = false;
            this.uiTxtEmial.Size = new System.Drawing.Size(533, 29);
            this.uiTxtEmial.TabIndex = 6;
            this.uiTxtEmial.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxtEmial.Watermark = "请输入登录邮箱";
            this.uiTxtEmial.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTxtPassword
            // 
            this.uiTxtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxtPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTxtPassword.Location = new System.Drawing.Point(183, 254);
            this.uiTxtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxtPassword.Name = "uiTxtPassword";
            this.uiTxtPassword.ShowText = false;
            this.uiTxtPassword.Size = new System.Drawing.Size(533, 29);
            this.uiTxtPassword.TabIndex = 7;
            this.uiTxtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxtPassword.Watermark = "请输入密码";
            this.uiTxtPassword.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTxtServer
            // 
            this.uiTxtServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTxtServer.AutoSize = true;
            this.uiTxtServer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxtServer.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTxtServer.Location = new System.Drawing.Point(188, 90);
            this.uiTxtServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxtServer.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxtServer.Name = "uiTxtServer";
            this.uiTxtServer.ShowText = false;
            this.uiTxtServer.Size = new System.Drawing.Size(528, 29);
            this.uiTxtServer.TabIndex = 8;
            this.uiTxtServer.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxtServer.Watermark = "请输入发送服务器";
            this.uiTxtServer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Red;
            this.uiLabel1.Location = new System.Drawing.Point(58, 92);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(17, 21);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 9;
            this.uiLabel1.Text = "*";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.ForeColor = System.Drawing.Color.Red;
            this.uiLabel5.Location = new System.Drawing.Point(58, 256);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(17, 21);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 10;
            this.uiLabel5.Text = "*";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.ForeColor = System.Drawing.Color.Red;
            this.uiLabel6.Location = new System.Drawing.Point(58, 161);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(17, 21);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel6.TabIndex = 11;
            this.uiLabel6.Text = "*";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // EmailConfig
            // 
            this.AllowShowTitle = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(763, 438);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiTxtServer);
            this.Controls.Add(this.uiTxtPassword);
            this.Controls.Add(this.uiTxtEmial);
            this.Controls.Add(this.uiBtnSave);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Name = "EmailConfig";
            this.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.ShowTitle = true;
            this.Symbol = 61664;
            this.Text = "邮件设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton uiBtnSave;
        private Sunny.UI.UITextBox uiTxtEmial;
        private Sunny.UI.UITextBox uiTxtPassword;
        private Sunny.UI.UITextBox uiTxtServer;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
    }
}