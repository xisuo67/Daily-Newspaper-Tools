
namespace Daily_Newspaper_Tools
{
    partial class MainForm
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
            this.uiAvatar = new Sunny.UI.UIAvatar();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Header.Controls.Add(this.uiAvatar);
            this.Header.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(204, 35);
            this.Header.Size = new System.Drawing.Size(820, 72);
            this.Header.Style = Sunny.UI.UIStyle.Custom;
            this.Header.StyleCustomMode = true;
            // 
            // Aside
            // 
            this.Aside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.Aside.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.Aside.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.Aside.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Aside.Size = new System.Drawing.Size(204, 685);
            // 
            // uiAvatar
            // 
            this.uiAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiAvatar.AvatarSize = 55;
            this.uiAvatar.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar.Icon = Sunny.UI.UIAvatar.UIIcon.Text;
            this.uiAvatar.Location = new System.Drawing.Point(747, 9);
            this.uiAvatar.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar.Name = "uiAvatar";
            this.uiAvatar.Size = new System.Drawing.Size(60, 60);
            this.uiAvatar.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar.TabIndex = 27;
            this.uiAvatar.Text = "Avatar";
            this.uiAvatar.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Name = "MainForm";
            this.Text = "日报工具";
            this.ZoomScaleRect = new System.Drawing.Rectangle(-98, 15, 1024, 720);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIAvatar uiAvatar;
    }
}