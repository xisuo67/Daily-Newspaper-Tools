
namespace Daily_Newspaper_Tools.Views
{
    partial class ContactEditForm
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
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiTxtName = new Sunny.UI.UITextBox();
            this.uiTxtEmail = new Sunny.UI.UITextBox();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 219);
            this.pnlBtm.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.pnlBtm.Size = new System.Drawing.Size(597, 55);
            this.pnlBtm.Style = Sunny.UI.UIStyle.Custom;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(469, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(354, 12);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(35, 78);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "姓名：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(35, 131);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "邮箱：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTxtName
            // 
            this.uiTxtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxtName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTxtName.Location = new System.Drawing.Point(117, 72);
            this.uiTxtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxtName.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxtName.Name = "uiTxtName";
            this.uiTxtName.ShowText = false;
            this.uiTxtName.Size = new System.Drawing.Size(439, 29);
            this.uiTxtName.TabIndex = 4;
            this.uiTxtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxtName.Watermark = "";
            this.uiTxtName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTxtEmail
            // 
            this.uiTxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxtEmail.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTxtEmail.Location = new System.Drawing.Point(117, 131);
            this.uiTxtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxtEmail.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxtEmail.Name = "uiTxtEmail";
            this.uiTxtEmail.ShowText = false;
            this.uiTxtEmail.Size = new System.Drawing.Size(439, 29);
            this.uiTxtEmail.TabIndex = 5;
            this.uiTxtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxtEmail.Watermark = "";
            this.uiTxtEmail.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ContactEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(599, 277);
            this.Controls.Add(this.uiTxtEmail);
            this.Controls.Add(this.uiTxtName);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Name = "ContactEditForm";
            this.Text = "ContactEditForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.uiTxtName, 0);
            this.Controls.SetChildIndex(this.uiTxtEmail, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox uiTxtName;
        private Sunny.UI.UITextBox uiTxtEmail;
    }
}