namespace Daily_Newspaper_Tools.Views
{
    partial class RolesEditForm
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTxtName = new Sunny.UI.UITextBox();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 124);
            this.pnlBtm.Size = new System.Drawing.Size(451, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(323, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(208, 12);
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(17, 60);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(74, 21);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "角色名称";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTxtName
            // 
            this.uiTxtName.AutoSize = true;
            this.uiTxtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxtName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTxtName.Location = new System.Drawing.Point(98, 60);
            this.uiTxtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxtName.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxtName.Name = "uiTxtName";
            this.uiTxtName.ShowText = false;
            this.uiTxtName.Size = new System.Drawing.Size(327, 29);
            this.uiTxtName.TabIndex = 3;
            this.uiTxtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxtName.Watermark = "";
            this.uiTxtName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // RolesEditForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(453, 182);
            this.Controls.Add(this.uiTxtName);
            this.Controls.Add(this.uiLabel1);
            this.Name = "RolesEditForm";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 3);
            this.ShowTitle = false;
            this.Text = "";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.uiTxtName, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTxtName;
    }
}