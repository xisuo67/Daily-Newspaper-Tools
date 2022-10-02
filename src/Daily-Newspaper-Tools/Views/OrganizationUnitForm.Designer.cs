namespace Daily_Newspaper_Tools.Views
{
    partial class OrganizationUnitForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.uiSymbolBtnAdd = new Sunny.UI.UISymbolButton();
            this.uiTxtSearch = new Sunny.UI.UITextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiDataGridView2 = new Sunny.UI.UIDataGridView();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiBtnEditNode = new Sunny.UI.UIButton();
            this.uiBtnCreateRoot = new Sunny.UI.UIButton();
            this.uiSplitContainer1 = new Sunny.UI.UISplitContainer();
            this.uiTreeView1 = new Sunny.UI.UITreeView();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.uiTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiSplitContainer1)).BeginInit();
            this.uiSplitContainer1.Panel1.SuspendLayout();
            this.uiSplitContainer1.Panel2.SuspendLayout();
            this.uiSplitContainer1.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.Frame = null;
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(0, 0);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(546, 415);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabIndex = 0;
            this.uiTabControl1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Controls.Add(this.uiDataGridView1);
            this.tabPage1.Controls.Add(this.uiSymbolBtnAdd);
            this.tabPage1.Controls.Add(this.uiTxtSearch);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(546, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "成员";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.uiDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle23;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(17, 55);
            this.uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.uiDataGridView1.RowTemplate.Height = 23;
            this.uiDataGridView1.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.Size = new System.Drawing.Size(519, 317);
            this.uiDataGridView1.Style = Sunny.UI.UIStyle.Custom;
            this.uiDataGridView1.TabIndex = 16;
            this.uiDataGridView1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolBtnAdd
            // 
            this.uiSymbolBtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolBtnAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolBtnAdd.Location = new System.Drawing.Point(363, 8);
            this.uiSymbolBtnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolBtnAdd.Name = "uiSymbolBtnAdd";
            this.uiSymbolBtnAdd.Size = new System.Drawing.Size(73, 35);
            this.uiSymbolBtnAdd.Symbol = 62004;
            this.uiSymbolBtnAdd.TabIndex = 15;
            this.uiSymbolBtnAdd.Text = "新增";
            this.uiSymbolBtnAdd.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolBtnAdd.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSymbolBtnAdd.Click += new System.EventHandler(this.uiSymbolBtnAdd_Click);
            // 
            // uiTxtSearch
            // 
            this.uiTxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxtSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTxtSearch.Location = new System.Drawing.Point(17, 14);
            this.uiTxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxtSearch.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxtSearch.Name = "uiTxtSearch";
            this.uiTxtSearch.ShowText = false;
            this.uiTxtSearch.Size = new System.Drawing.Size(330, 29);
            this.uiTxtSearch.Symbol = 61442;
            this.uiTxtSearch.TabIndex = 14;
            this.uiTxtSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxtSearch.Watermark = "请输入查询内容,以回车键结束";
            this.uiTxtSearch.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uiDataGridView2);
            this.tabPage2.Controls.Add(this.uiSymbolButton1);
            this.tabPage2.Controls.Add(this.uiTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 60);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "角色";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uiDataGridView2
            // 
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.uiDataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiDataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.uiDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView2.DefaultCellStyle = dataGridViewCellStyle28;
            this.uiDataGridView2.EnableHeadersVisualStyles = false;
            this.uiDataGridView2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.uiDataGridView2.Location = new System.Drawing.Point(14, 49);
            this.uiDataGridView2.Name = "uiDataGridView2";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiDataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.uiDataGridView2.RowTemplate.Height = 23;
            this.uiDataGridView2.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView2.SelectedIndex = -1;
            this.uiDataGridView2.Size = new System.Drawing.Size(173, 2);
            this.uiDataGridView2.Style = Sunny.UI.UIStyle.Custom;
            this.uiDataGridView2.TabIndex = 19;
            this.uiDataGridView2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Location = new System.Drawing.Point(462, 8);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(73, 35);
            this.uiSymbolButton1.Symbol = 62004;
            this.uiSymbolButton1.TabIndex = 18;
            this.uiSymbolButton1.Text = "新增";
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.Location = new System.Drawing.Point(14, 8);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(330, 29);
            this.uiTextBox1.Symbol = 61442;
            this.uiTextBox1.TabIndex = 17;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "请输入查询内容,以回车键结束";
            this.uiTextBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiBtnEditNode
            // 
            this.uiBtnEditNode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiBtnEditNode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtnEditNode.Location = new System.Drawing.Point(138, 10);
            this.uiBtnEditNode.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBtnEditNode.Name = "uiBtnEditNode";
            this.uiBtnEditNode.Size = new System.Drawing.Size(84, 21);
            this.uiBtnEditNode.TabIndex = 8;
            this.uiBtnEditNode.Text = "编辑节点";
            this.uiBtnEditNode.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtnEditNode.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiBtnEditNode.Click += new System.EventHandler(this.uiBtnEditNode_Click);
            // 
            // uiBtnCreateRoot
            // 
            this.uiBtnCreateRoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiBtnCreateRoot.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtnCreateRoot.Location = new System.Drawing.Point(16, 10);
            this.uiBtnCreateRoot.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBtnCreateRoot.Name = "uiBtnCreateRoot";
            this.uiBtnCreateRoot.Size = new System.Drawing.Size(81, 21);
            this.uiBtnCreateRoot.TabIndex = 7;
            this.uiBtnCreateRoot.Text = "新增节点";
            this.uiBtnCreateRoot.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtnCreateRoot.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiBtnCreateRoot.Click += new System.EventHandler(this.uiBtnCreateRoot_Click);
            // 
            // uiSplitContainer1
            // 
            this.uiSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSplitContainer1.Location = new System.Drawing.Point(0, 35);
            this.uiSplitContainer1.MinimumSize = new System.Drawing.Size(20, 20);
            this.uiSplitContainer1.Name = "uiSplitContainer1";
            // 
            // uiSplitContainer1.Panel1
            // 
            this.uiSplitContainer1.Panel1.Controls.Add(this.uiTreeView1);
            this.uiSplitContainer1.Panel1.Controls.Add(this.uiPanel1);
            // 
            // uiSplitContainer1.Panel2
            // 
            this.uiSplitContainer1.Panel2.Controls.Add(this.uiTabControl1);
            this.uiSplitContainer1.Size = new System.Drawing.Size(800, 415);
            this.uiSplitContainer1.SplitterDistance = 243;
            this.uiSplitContainer1.SplitterWidth = 11;
            this.uiSplitContainer1.TabIndex = 1;
            this.uiSplitContainer1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTreeView1
            // 
            this.uiTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTreeView1.FillColor = System.Drawing.Color.White;
            this.uiTreeView1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTreeView1.Location = new System.Drawing.Point(0, 39);
            this.uiTreeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTreeView1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTreeView1.Name = "uiTreeView1";
            this.uiTreeView1.ShowText = false;
            this.uiTreeView1.Size = new System.Drawing.Size(243, 376);
            this.uiTreeView1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTreeView1.TabIndex = 1;
            this.uiTreeView1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTreeView1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiBtnEditNode);
            this.uiPanel1.Controls.Add(this.uiBtnCreateRoot);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(243, 39);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(44, 124);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 168);
            this.treeView1.TabIndex = 17;
            // 
            // OrganizationUnitForm
            // 
            this.AllowShowTitle = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiSplitContainer1);
            this.Name = "OrganizationUnitForm";
            this.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.ShowTitle = true;
            this.Symbol = 361672;
            this.Text = "组织架构设置";
            this.Load += new System.EventHandler(this.OrganizationUnitForm_Load);
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView2)).EndInit();
            this.uiSplitContainer1.Panel1.ResumeLayout(false);
            this.uiSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiSplitContainer1)).EndInit();
            this.uiSplitContainer1.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UISymbolButton uiSymbolBtnAdd;
        private Sunny.UI.UITextBox uiTxtSearch;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UIDataGridView uiDataGridView2;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIButton uiBtnEditNode;
        private Sunny.UI.UIButton uiBtnCreateRoot;
        private Sunny.UI.UISplitContainer uiSplitContainer1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITreeView uiTreeView1;
        private System.Windows.Forms.TreeView treeView1;
    }
}