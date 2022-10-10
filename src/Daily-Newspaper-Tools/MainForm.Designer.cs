
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.uiAvatar = new Sunny.UI.UIAvatar();
            this.uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiHeaderButton12 = new Sunny.UI.UIHeaderButton();
            this.Header.SuspendLayout();
            this.uiContextMenuStrip1.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Header.Controls.Add(this.uiPanel1);
            this.Header.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(204, 35);
            this.Header.Size = new System.Drawing.Size(918, 72);
            this.Header.Style = Sunny.UI.UIStyle.Custom;
            this.Header.StyleCustomMode = true;
            // 
            // Aside
            // 
            this.Aside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.Aside.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.Aside.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.Aside.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Aside.Size = new System.Drawing.Size(204, 825);
            // 
            // uiAvatar
            // 
            this.uiAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiAvatar.AvatarSize = 55;
            this.uiAvatar.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar.Icon = Sunny.UI.UIAvatar.UIIcon.Text;
            this.uiAvatar.Location = new System.Drawing.Point(17, 6);
            this.uiAvatar.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar.Name = "uiAvatar";
            this.uiAvatar.Size = new System.Drawing.Size(60, 60);
            this.uiAvatar.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar.TabIndex = 27;
            this.uiAvatar.Text = "Avatar";
            this.uiAvatar.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiAvatar.Click += new System.EventHandler(this.uiAvatar_Click);
            // 
            // uiContextMenuStrip1
            // 
            this.uiContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiContextMenuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem});
            this.uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            this.uiContextMenuStrip1.Size = new System.Drawing.Size(113, 30);
            this.uiContextMenuStrip1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiHeaderButton12);
            this.uiPanel1.Controls.Add(this.uiPanel2);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.Empty;
            this.uiPanel1.Size = new System.Drawing.Size(918, 72);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.uiAvatar);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel2.Location = new System.Drawing.Point(838, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.RectColor = System.Drawing.Color.Empty;
            this.uiPanel2.Size = new System.Drawing.Size(80, 72);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel2.TabIndex = 0;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiHeaderButton12
            // 
            this.uiHeaderButton12.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiHeaderButton12.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiHeaderButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiHeaderButton12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiHeaderButton12.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiHeaderButton12.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiHeaderButton12.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiHeaderButton12.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiHeaderButton12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiHeaderButton12.Location = new System.Drawing.Point(711, 4);
            this.uiHeaderButton12.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton12.Name = "uiHeaderButton12";
            this.uiHeaderButton12.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.uiHeaderButton12.Radius = 0;
            this.uiHeaderButton12.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton12.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton12.Size = new System.Drawing.Size(97, 65);
            this.uiHeaderButton12.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton12.Symbol = 61595;
            this.uiHeaderButton12.SymbolColor = System.Drawing.Color.Black;
            this.uiHeaderButton12.SymbolOffset = new System.Drawing.Point(1, 2);
            this.uiHeaderButton12.SymbolSize = 41;
            this.uiHeaderButton12.TabIndex = 6;
            this.uiHeaderButton12.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiHeaderButton12.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiHeaderButton12.Click += new System.EventHandler(this.uiHeaderButton12_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1122, 860);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "日报工具";
            this.ZoomScaleRect = new System.Drawing.Rectangle(-98, 15, 1024, 720);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.Aside, 0);
            this.Controls.SetChildIndex(this.Header, 0);
            this.Header.ResumeLayout(false);
            this.uiContextMenuStrip1.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIAvatar uiAvatar;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIHeaderButton uiHeaderButton12;
    }
}