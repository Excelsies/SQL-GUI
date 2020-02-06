namespace SQLGUIProject
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.uxQueryListBox = new System.Windows.Forms.ListBox();
            this.uxServersListBox = new System.Windows.Forms.ListBox();
            this.uxOutputDataGrid = new System.Windows.Forms.DataGridView();
            this.uxCreateNewQuery = new System.Windows.Forms.Button();
            this.lblSQLServers = new System.Windows.Forms.Label();
            this.lblQueries = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxValueGrid = new System.Windows.Forms.DataGridView();
            this.paramTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxQueryTxt = new System.Windows.Forms.TextBox();
            this.uxLaunchSQLBtn = new System.Windows.Forms.Button();
            this.uxCreateNewServer = new System.Windows.Forms.Button();
            this.uxDeleteServerBtn = new System.Windows.Forms.Button();
            this.uxDeleteQueryBtn = new System.Windows.Forms.Button();
            this.uxGoButton = new System.Windows.Forms.Button();
            this.uxNullServerError = new System.Windows.Forms.ErrorProvider(this.components);
            this.uxNullQueryError = new System.Windows.Forms.ErrorProvider(this.components);
            this.uxNullValue = new System.Windows.Forms.ErrorProvider(this.components);
            this.uxEditServerBtn = new System.Windows.Forms.Button();
            this.uxEditQueryBtn = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.importXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetServersQueriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverLookupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.uxOutputDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxValueGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNullServerError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNullQueryError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNullValue)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxQueryListBox
            // 
            this.uxQueryListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxQueryListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxQueryListBox.FormattingEnabled = true;
            this.uxQueryListBox.Location = new System.Drawing.Point(2, 15);
            this.uxQueryListBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxQueryListBox.Name = "uxQueryListBox";
            this.uxQueryListBox.Size = new System.Drawing.Size(222, 145);
            this.uxQueryListBox.TabIndex = 1;
            this.uxQueryListBox.SelectedIndexChanged += new System.EventHandler(this.uxQueryListBox_SelectedIndexChanged);
            // 
            // uxServersListBox
            // 
            this.uxServersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxServersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxServersListBox.FormattingEnabled = true;
            this.uxServersListBox.Location = new System.Drawing.Point(0, 15);
            this.uxServersListBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxServersListBox.Name = "uxServersListBox";
            this.uxServersListBox.Size = new System.Drawing.Size(223, 145);
            this.uxServersListBox.TabIndex = 2;
            this.uxServersListBox.SelectedIndexChanged += new System.EventHandler(this.uxServersListBox_SelectedIndexChanged);
            // 
            // uxOutputDataGrid
            // 
            this.uxOutputDataGrid.AllowUserToAddRows = false;
            this.uxOutputDataGrid.AllowUserToOrderColumns = true;
            this.uxOutputDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxOutputDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.uxOutputDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.uxOutputDataGrid.Location = new System.Drawing.Point(-1, 15);
            this.uxOutputDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.uxOutputDataGrid.Name = "uxOutputDataGrid";
            this.uxOutputDataGrid.ReadOnly = true;
            this.uxOutputDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.uxOutputDataGrid.RowTemplate.Height = 24;
            this.uxOutputDataGrid.RowTemplate.ReadOnly = true;
            this.uxOutputDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.uxOutputDataGrid.ShowCellErrors = false;
            this.uxOutputDataGrid.ShowEditingIcon = false;
            this.uxOutputDataGrid.ShowRowErrors = false;
            this.uxOutputDataGrid.Size = new System.Drawing.Size(642, 305);
            this.uxOutputDataGrid.TabIndex = 3;
            this.uxOutputDataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.uxOutputDataGrid_DataBindingComplete);
            // 
            // uxCreateNewQuery
            // 
            this.uxCreateNewQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxCreateNewQuery.AutoEllipsis = true;
            this.uxCreateNewQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxCreateNewQuery.Location = new System.Drawing.Point(2, 166);
            this.uxCreateNewQuery.Margin = new System.Windows.Forms.Padding(2);
            this.uxCreateNewQuery.Name = "uxCreateNewQuery";
            this.uxCreateNewQuery.Size = new System.Drawing.Size(74, 31);
            this.uxCreateNewQuery.TabIndex = 5;
            this.uxCreateNewQuery.Text = "New Query";
            this.uxCreateNewQuery.UseVisualStyleBackColor = true;
            this.uxCreateNewQuery.Click += new System.EventHandler(this.uxCreateNewQuery_Click);
            // 
            // lblSQLServers
            // 
            this.lblSQLServers.AutoSize = true;
            this.lblSQLServers.Location = new System.Drawing.Point(2, 0);
            this.lblSQLServers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSQLServers.Name = "lblSQLServers";
            this.lblSQLServers.Size = new System.Drawing.Size(67, 13);
            this.lblSQLServers.TabIndex = 6;
            this.lblSQLServers.Text = "SQL Servers";
            // 
            // lblQueries
            // 
            this.lblQueries.AutoSize = true;
            this.lblQueries.Location = new System.Drawing.Point(2, 0);
            this.lblQueries.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQueries.Name = "lblQueries";
            this.lblQueries.Size = new System.Drawing.Size(43, 13);
            this.lblQueries.TabIndex = 7;
            this.lblQueries.Text = "Queries";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Results";
            // 
            // uxValueGrid
            // 
            this.uxValueGrid.AllowUserToAddRows = false;
            this.uxValueGrid.AllowUserToDeleteRows = false;
            this.uxValueGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxValueGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.uxValueGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.uxValueGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxValueGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paramTxt,
            this.valueTxt});
            this.uxValueGrid.Location = new System.Drawing.Point(5, 15);
            this.uxValueGrid.Margin = new System.Windows.Forms.Padding(2);
            this.uxValueGrid.Name = "uxValueGrid";
            this.uxValueGrid.RowHeadersVisible = false;
            this.uxValueGrid.RowTemplate.Height = 24;
            this.uxValueGrid.Size = new System.Drawing.Size(225, 305);
            this.uxValueGrid.TabIndex = 9;
            this.uxValueGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.uxValueGrid_DataBindingComplete);
            this.uxValueGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView1_DataError);
            // 
            // paramTxt
            // 
            this.paramTxt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.paramTxt.HeaderText = "Parameter";
            this.paramTxt.Name = "paramTxt";
            this.paramTxt.ReadOnly = true;
            this.paramTxt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.paramTxt.Width = 61;
            // 
            // valueTxt
            // 
            this.valueTxt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.valueTxt.HeaderText = "Value";
            this.valueTxt.Name = "valueTxt";
            this.valueTxt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.valueTxt.Width = 200;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(2, 0);
            this.lblValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(39, 13);
            this.lblValue.TabIndex = 10;
            this.lblValue.Text = "Values";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Query";
            // 
            // uxQueryTxt
            // 
            this.uxQueryTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxQueryTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxQueryTxt.Location = new System.Drawing.Point(3, 15);
            this.uxQueryTxt.Margin = new System.Windows.Forms.Padding(2);
            this.uxQueryTxt.Multiline = true;
            this.uxQueryTxt.Name = "uxQueryTxt";
            this.uxQueryTxt.ReadOnly = true;
            this.uxQueryTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uxQueryTxt.Size = new System.Drawing.Size(395, 147);
            this.uxQueryTxt.TabIndex = 13;
            // 
            // uxLaunchSQLBtn
            // 
            this.uxLaunchSQLBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxLaunchSQLBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxLaunchSQLBtn.Location = new System.Drawing.Point(316, 166);
            this.uxLaunchSQLBtn.Margin = new System.Windows.Forms.Padding(2);
            this.uxLaunchSQLBtn.Name = "uxLaunchSQLBtn";
            this.uxLaunchSQLBtn.Size = new System.Drawing.Size(79, 31);
            this.uxLaunchSQLBtn.TabIndex = 14;
            this.uxLaunchSQLBtn.Text = "Launch SQL";
            this.uxLaunchSQLBtn.UseVisualStyleBackColor = true;
            this.uxLaunchSQLBtn.Click += new System.EventHandler(this.uxLaunchSQLBtn_Click);
            // 
            // uxCreateNewServer
            // 
            this.uxCreateNewServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxCreateNewServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxCreateNewServer.Location = new System.Drawing.Point(0, 166);
            this.uxCreateNewServer.Margin = new System.Windows.Forms.Padding(2);
            this.uxCreateNewServer.Name = "uxCreateNewServer";
            this.uxCreateNewServer.Size = new System.Drawing.Size(80, 31);
            this.uxCreateNewServer.TabIndex = 15;
            this.uxCreateNewServer.Text = "New Server";
            this.uxCreateNewServer.UseVisualStyleBackColor = true;
            this.uxCreateNewServer.Click += new System.EventHandler(this.uxCreateNewServer_Click);
            // 
            // uxDeleteServerBtn
            // 
            this.uxDeleteServerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxDeleteServerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxDeleteServerBtn.Location = new System.Drawing.Point(157, 166);
            this.uxDeleteServerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.uxDeleteServerBtn.Name = "uxDeleteServerBtn";
            this.uxDeleteServerBtn.Size = new System.Drawing.Size(69, 31);
            this.uxDeleteServerBtn.TabIndex = 16;
            this.uxDeleteServerBtn.Text = "Delete";
            this.uxDeleteServerBtn.UseVisualStyleBackColor = true;
            this.uxDeleteServerBtn.Click += new System.EventHandler(this.uxDeleteServerBtn_Click);
            // 
            // uxDeleteQueryBtn
            // 
            this.uxDeleteQueryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxDeleteQueryBtn.AutoEllipsis = true;
            this.uxDeleteQueryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxDeleteQueryBtn.Location = new System.Drawing.Point(151, 166);
            this.uxDeleteQueryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.uxDeleteQueryBtn.Name = "uxDeleteQueryBtn";
            this.uxDeleteQueryBtn.Size = new System.Drawing.Size(69, 31);
            this.uxDeleteQueryBtn.TabIndex = 17;
            this.uxDeleteQueryBtn.Text = "Delete";
            this.uxDeleteQueryBtn.UseVisualStyleBackColor = true;
            this.uxDeleteQueryBtn.Click += new System.EventHandler(this.uxDeleteQueryBtn_Click);
            // 
            // uxGoButton
            // 
            this.uxGoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxGoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxGoButton.Location = new System.Drawing.Point(235, 166);
            this.uxGoButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxGoButton.Name = "uxGoButton";
            this.uxGoButton.Size = new System.Drawing.Size(79, 31);
            this.uxGoButton.TabIndex = 4;
            this.uxGoButton.Text = "Go";
            this.uxGoButton.UseVisualStyleBackColor = true;
            this.uxGoButton.Click += new System.EventHandler(this.uxGoButton_Click);
            // 
            // uxNullServerError
            // 
            this.uxNullServerError.ContainerControl = this;
            // 
            // uxNullQueryError
            // 
            this.uxNullQueryError.ContainerControl = this;
            // 
            // uxNullValue
            // 
            this.uxNullValue.ContainerControl = this;
            // 
            // uxEditServerBtn
            // 
            this.uxEditServerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxEditServerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxEditServerBtn.Location = new System.Drawing.Point(84, 166);
            this.uxEditServerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.uxEditServerBtn.Name = "uxEditServerBtn";
            this.uxEditServerBtn.Size = new System.Drawing.Size(69, 31);
            this.uxEditServerBtn.TabIndex = 20;
            this.uxEditServerBtn.Text = "Edit";
            this.uxEditServerBtn.UseVisualStyleBackColor = true;
            this.uxEditServerBtn.Click += new System.EventHandler(this.uxEditServerBtn_Click);
            // 
            // uxEditQueryBtn
            // 
            this.uxEditQueryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxEditQueryBtn.AutoEllipsis = true;
            this.uxEditQueryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxEditQueryBtn.Location = new System.Drawing.Point(78, 166);
            this.uxEditQueryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.uxEditQueryBtn.Name = "uxEditQueryBtn";
            this.uxEditQueryBtn.Size = new System.Drawing.Size(69, 31);
            this.uxEditQueryBtn.TabIndex = 21;
            this.uxEditQueryBtn.Text = "Edit";
            this.uxEditQueryBtn.UseVisualStyleBackColor = true;
            this.uxEditQueryBtn.Click += new System.EventHandler(this.uxEditQueryBtn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(874, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importXMLToolStripMenuItem,
            this.exportXMLToolStripMenuItem,
            this.resetServersQueriesToolStripMenuItem,
            this.serverLookupToolStripMenuItem,
            this.themeToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // importXMLToolStripMenuItem
            // 
            this.importXMLToolStripMenuItem.Name = "importXMLToolStripMenuItem";
            this.importXMLToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.importXMLToolStripMenuItem.Text = "Import XML";
            this.importXMLToolStripMenuItem.Click += new System.EventHandler(this.importXMLToolStripMenuItem_Click);
            // 
            // exportXMLToolStripMenuItem
            // 
            this.exportXMLToolStripMenuItem.Name = "exportXMLToolStripMenuItem";
            this.exportXMLToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exportXMLToolStripMenuItem.Text = "Export XML";
            this.exportXMLToolStripMenuItem.Click += new System.EventHandler(this.exportXMLToolStripMenuItem_Click);
            // 
            // resetServersQueriesToolStripMenuItem
            // 
            this.resetServersQueriesToolStripMenuItem.Name = "resetServersQueriesToolStripMenuItem";
            this.resetServersQueriesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.resetServersQueriesToolStripMenuItem.Text = "Reset Servers/Queries";
            this.resetServersQueriesToolStripMenuItem.Click += new System.EventHandler(this.resetServersQueriesToolStripMenuItem_Click);
            // 
            // serverLookupToolStripMenuItem
            // 
            this.serverLookupToolStripMenuItem.Name = "serverLookupToolStripMenuItem";
            this.serverLookupToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.serverLookupToolStripMenuItem.Text = "Server Lookup";
            this.serverLookupToolStripMenuItem.Click += new System.EventHandler(this.serverLookupToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            this.themeToolStripMenuItem.Click += new System.EventHandler(this.themeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.uxOutputDataGrid);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.uxValueGrid);
            this.splitContainer1.Panel2.Controls.Add(this.lblValue);
            this.splitContainer1.Size = new System.Drawing.Size(857, 322);
            this.splitContainer1.SplitterDistance = 642;
            this.splitContainer1.TabIndex = 23;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(3, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel1MinSize = 450;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.uxQueryTxt);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.uxGoButton);
            this.splitContainer2.Panel2.Controls.Add(this.uxLaunchSQLBtn);
            this.splitContainer2.Panel2MinSize = 160;
            this.splitContainer2.Size = new System.Drawing.Size(856, 199);
            this.splitContainer2.SplitterDistance = 455;
            this.splitContainer2.TabIndex = 24;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.uxServersListBox);
            this.splitContainer3.Panel1.Controls.Add(this.lblSQLServers);
            this.splitContainer3.Panel1.Controls.Add(this.uxCreateNewServer);
            this.splitContainer3.Panel1.Controls.Add(this.uxEditServerBtn);
            this.splitContainer3.Panel1.Controls.Add(this.uxDeleteServerBtn);
            this.splitContainer3.Panel1MinSize = 225;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.uxQueryListBox);
            this.splitContainer3.Panel2.Controls.Add(this.lblQueries);
            this.splitContainer3.Panel2.Controls.Add(this.uxCreateNewQuery);
            this.splitContainer3.Panel2.Controls.Add(this.uxDeleteQueryBtn);
            this.splitContainer3.Panel2.Controls.Add(this.uxEditQueryBtn);
            this.splitContainer3.Panel2MinSize = 220;
            this.splitContainer3.Size = new System.Drawing.Size(455, 199);
            this.splitContainer3.SplitterDistance = 225;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer4.Location = new System.Drawing.Point(6, 28);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer4.Panel1MinSize = 85;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer4.Size = new System.Drawing.Size(864, 538);
            this.splitContainer4.SplitterDistance = 206;
            this.splitContainer4.TabIndex = 25;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 572);
            this.Controls.Add(this.splitContainer4);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(754, 593);
            this.Name = "main";
            this.Text = "SQL GUI";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxOutputDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxValueGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNullServerError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNullQueryError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNullValue)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxQueryListBox;
        private System.Windows.Forms.ListBox uxServersListBox;
        private System.Windows.Forms.DataGridView uxOutputDataGrid;
        private System.Windows.Forms.Button uxCreateNewQuery;
        private System.Windows.Forms.Label lblSQLServers;
        private System.Windows.Forms.Label lblQueries;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uxQueryTxt;
        private System.Windows.Forms.Button uxLaunchSQLBtn;
        private System.Windows.Forms.Button uxCreateNewServer;
        private System.Windows.Forms.Button uxDeleteServerBtn;
        private System.Windows.Forms.Button uxDeleteQueryBtn;
        private System.Windows.Forms.Button uxGoButton;
        private System.Windows.Forms.ErrorProvider uxNullServerError;
        private System.Windows.Forms.ErrorProvider uxNullQueryError;
        private System.Windows.Forms.ErrorProvider uxNullValue;
        private System.Windows.Forms.Button uxEditQueryBtn;
        private System.Windows.Forms.Button uxEditServerBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem importXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.DataGridView uxValueGrid;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem exportXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueTxt;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetServersQueriesToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ToolStripMenuItem serverLookupToolStripMenuItem;
    }
}

