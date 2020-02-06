namespace SQLGUIProject
{
    partial class CreateNewQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewQuery));
            this.uxQueryTextTextBox = new System.Windows.Forms.TextBox();
            this.uxQueryNameTextBox = new System.Windows.Forms.TextBox();
            this.queryLbl = new System.Windows.Forms.Label();
            this.queryTextlbl = new System.Windows.Forms.Label();
            this.uxSaveQueryButton = new System.Windows.Forms.Button();
            this.uxTestQueryButton = new System.Windows.Forms.Button();
            this.uxCancelbutton = new System.Windows.Forms.Button();
            this.lblParamters = new System.Windows.Forms.Label();
            this.uxParameterGrid = new System.Windows.Forms.DataGridView();
            this.paramTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxDBChckBx = new System.Windows.Forms.CheckBox();
            this.lblMP2Version = new System.Windows.Forms.Label();
            this.uxAddParamBtn = new System.Windows.Forms.Button();
            this.emptyParameterError = new System.Windows.Forms.ErrorProvider(this.components);
            this.uxServerListBx = new System.Windows.Forms.CheckedListBox();
            this.serverlbl = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.queryNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.queryTextError = new System.Windows.Forms.ErrorProvider(this.components);
            this.serverError = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.uxParameterGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyParameterError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryTextError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxQueryTextTextBox
            // 
            this.uxQueryTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxQueryTextTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxQueryTextTextBox.Location = new System.Drawing.Point(2, 2);
            this.uxQueryTextTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxQueryTextTextBox.Multiline = true;
            this.uxQueryTextTextBox.Name = "uxQueryTextTextBox";
            this.uxQueryTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.uxQueryTextTextBox.Size = new System.Drawing.Size(432, 143);
            this.uxQueryTextTextBox.TabIndex = 3;
            this.uxQueryTextTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uxQueryTextTextBox_KeyDown);
            this.uxQueryTextTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.uxQueryTextTextBox_MouseUp);
            // 
            // uxQueryNameTextBox
            // 
            this.uxQueryNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxQueryNameTextBox.Location = new System.Drawing.Point(9, 20);
            this.uxQueryNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxQueryNameTextBox.Name = "uxQueryNameTextBox";
            this.uxQueryNameTextBox.Size = new System.Drawing.Size(192, 20);
            this.uxQueryNameTextBox.TabIndex = 1;
            // 
            // queryLbl
            // 
            this.queryLbl.AutoSize = true;
            this.queryLbl.Location = new System.Drawing.Point(9, 4);
            this.queryLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.queryLbl.Name = "queryLbl";
            this.queryLbl.Size = new System.Drawing.Size(66, 13);
            this.queryLbl.TabIndex = 2;
            this.queryLbl.Text = "Query Name";
            // 
            // queryTextlbl
            // 
            this.queryTextlbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryTextlbl.AutoSize = true;
            this.queryTextlbl.Location = new System.Drawing.Point(9, 51);
            this.queryTextlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.queryTextlbl.Name = "queryTextlbl";
            this.queryTextlbl.Size = new System.Drawing.Size(59, 13);
            this.queryTextlbl.TabIndex = 3;
            this.queryTextlbl.Text = "Query Text";
            // 
            // uxSaveQueryButton
            // 
            this.uxSaveQueryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxSaveQueryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxSaveQueryButton.Location = new System.Drawing.Point(73, 136);
            this.uxSaveQueryButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxSaveQueryButton.Name = "uxSaveQueryButton";
            this.uxSaveQueryButton.Size = new System.Drawing.Size(64, 32);
            this.uxSaveQueryButton.TabIndex = 7;
            this.uxSaveQueryButton.Text = "Save";
            this.uxSaveQueryButton.UseVisualStyleBackColor = true;
            this.uxSaveQueryButton.Click += new System.EventHandler(this.uxSaveQueryButton_Click);
            // 
            // uxTestQueryButton
            // 
            this.uxTestQueryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTestQueryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxTestQueryButton.Location = new System.Drawing.Point(2, 136);
            this.uxTestQueryButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxTestQueryButton.Name = "uxTestQueryButton";
            this.uxTestQueryButton.Size = new System.Drawing.Size(67, 32);
            this.uxTestQueryButton.TabIndex = 6;
            this.uxTestQueryButton.Text = "Test";
            this.uxTestQueryButton.UseVisualStyleBackColor = true;
            this.uxTestQueryButton.Click += new System.EventHandler(this.uxTestQueryButton_Click);
            // 
            // uxCancelbutton
            // 
            this.uxCancelbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxCancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxCancelbutton.Location = new System.Drawing.Point(141, 136);
            this.uxCancelbutton.Margin = new System.Windows.Forms.Padding(2);
            this.uxCancelbutton.Name = "uxCancelbutton";
            this.uxCancelbutton.Size = new System.Drawing.Size(67, 32);
            this.uxCancelbutton.TabIndex = 8;
            this.uxCancelbutton.Text = "Cancel";
            this.uxCancelbutton.UseVisualStyleBackColor = true;
            this.uxCancelbutton.Click += new System.EventHandler(this.uxCancelbutton_Click);
            // 
            // lblParamters
            // 
            this.lblParamters.AutoSize = true;
            this.lblParamters.Location = new System.Drawing.Point(2, 3);
            this.lblParamters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParamters.Name = "lblParamters";
            this.lblParamters.Size = new System.Drawing.Size(91, 13);
            this.lblParamters.TabIndex = 7;
            this.lblParamters.Text = "Query Parameters";
            // 
            // uxParameterGrid
            // 
            this.uxParameterGrid.AllowUserToAddRows = false;
            this.uxParameterGrid.AllowUserToDeleteRows = false;
            this.uxParameterGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxParameterGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uxParameterGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.uxParameterGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.uxParameterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxParameterGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paramTxt,
            this.valueTxt});
            this.uxParameterGrid.Location = new System.Drawing.Point(1, 18);
            this.uxParameterGrid.Margin = new System.Windows.Forms.Padding(2);
            this.uxParameterGrid.Name = "uxParameterGrid";
            this.uxParameterGrid.RowHeadersVisible = false;
            this.uxParameterGrid.RowTemplate.Height = 24;
            this.uxParameterGrid.Size = new System.Drawing.Size(209, 150);
            this.uxParameterGrid.TabIndex = 4;
            this.uxParameterGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.uxParameterGrid_CellEnter);
            this.uxParameterGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.uxParameterGrid_DataBindingComplete);
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
            this.valueTxt.HeaderText = "Parameter Name";
            this.valueTxt.Name = "valueTxt";
            this.valueTxt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.valueTxt.Width = 150;
            // 
            // uxDBChckBx
            // 
            this.uxDBChckBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxDBChckBx.AutoSize = true;
            this.uxDBChckBx.Location = new System.Drawing.Point(428, 11);
            this.uxDBChckBx.Margin = new System.Windows.Forms.Padding(2);
            this.uxDBChckBx.Name = "uxDBChckBx";
            this.uxDBChckBx.Size = new System.Drawing.Size(15, 14);
            this.uxDBChckBx.TabIndex = 2;
            this.uxDBChckBx.UseVisualStyleBackColor = true;
            // 
            // lblMP2Version
            // 
            this.lblMP2Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMP2Version.AutoSize = true;
            this.lblMP2Version.Location = new System.Drawing.Point(333, 11);
            this.lblMP2Version.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMP2Version.Name = "lblMP2Version";
            this.lblMP2Version.Size = new System.Drawing.Size(91, 13);
            this.lblMP2Version.TabIndex = 11;
            this.lblMP2Version.Text = "Specify Database";
            // 
            // uxAddParamBtn
            // 
            this.uxAddParamBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxAddParamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxAddParamBtn.Location = new System.Drawing.Point(345, 29);
            this.uxAddParamBtn.Margin = new System.Windows.Forms.Padding(2);
            this.uxAddParamBtn.Name = "uxAddParamBtn";
            this.uxAddParamBtn.Size = new System.Drawing.Size(100, 34);
            this.uxAddParamBtn.TabIndex = 13;
            this.uxAddParamBtn.TabStop = false;
            this.uxAddParamBtn.Text = "Insert Parameter";
            this.uxAddParamBtn.UseVisualStyleBackColor = true;
            this.uxAddParamBtn.Click += new System.EventHandler(this.uxAddParamBtn_Click);
            // 
            // emptyParameterError
            // 
            this.emptyParameterError.ContainerControl = this;
            // 
            // uxServerListBx
            // 
            this.uxServerListBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxServerListBx.FormattingEnabled = true;
            this.uxServerListBx.Location = new System.Drawing.Point(1, 19);
            this.uxServerListBx.Name = "uxServerListBx";
            this.uxServerListBx.Size = new System.Drawing.Size(200, 109);
            this.uxServerListBx.TabIndex = 5;
            // 
            // serverlbl
            // 
            this.serverlbl.AutoSize = true;
            this.serverlbl.Location = new System.Drawing.Point(2, 3);
            this.serverlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serverlbl.Name = "serverlbl";
            this.serverlbl.Size = new System.Drawing.Size(104, 13);
            this.serverlbl.TabIndex = 15;
            this.serverlbl.Text = "Associated Server(s)";
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
            this.splitContainer1.Panel1.Controls.Add(this.uxParameterGrid);
            this.splitContainer1.Panel1.Controls.Add(this.lblParamters);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.uxServerListBx);
            this.splitContainer1.Panel2.Controls.Add(this.serverlbl);
            this.splitContainer1.Panel2.Controls.Add(this.uxCancelbutton);
            this.splitContainer1.Panel2.Controls.Add(this.uxSaveQueryButton);
            this.splitContainer1.Panel2.Controls.Add(this.uxTestQueryButton);
            this.splitContainer1.Size = new System.Drawing.Size(430, 170);
            this.splitContainer1.SplitterDistance = 216;
            this.splitContainer1.TabIndex = 16;
            // 
            // queryNameError
            // 
            this.queryNameError.ContainerControl = this;
            // 
            // queryTextError
            // 
            this.queryTextError.ContainerControl = this;
            // 
            // serverError
            // 
            this.serverError.ContainerControl = this;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(9, 67);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.uxQueryTextTextBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel2MinSize = 85;
            this.splitContainer2.Size = new System.Drawing.Size(436, 311);
            this.splitContainer2.SplitterDistance = 134;
            this.splitContainer2.TabIndex = 17;
            // 
            // CreateNewQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 381);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.uxAddParamBtn);
            this.Controls.Add(this.uxDBChckBx);
            this.Controls.Add(this.lblMP2Version);
            this.Controls.Add(this.queryTextlbl);
            this.Controls.Add(this.queryLbl);
            this.Controls.Add(this.uxQueryNameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(470, 420);
            this.Name = "CreateNewQuery";
            this.Text = "CreateNewQuery";
            ((System.ComponentModel.ISupportInitialize)(this.uxParameterGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyParameterError)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.queryNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryTextError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverError)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxQueryTextTextBox;
        private System.Windows.Forms.TextBox uxQueryNameTextBox;
        private System.Windows.Forms.Label queryLbl;
        private System.Windows.Forms.Label queryTextlbl;
        private System.Windows.Forms.Button uxSaveQueryButton;
        private System.Windows.Forms.Button uxTestQueryButton;
        private System.Windows.Forms.Button uxCancelbutton;
        private System.Windows.Forms.Label lblParamters;
        private System.Windows.Forms.DataGridView uxParameterGrid;
        private System.Windows.Forms.CheckBox uxDBChckBx;
        private System.Windows.Forms.Label lblMP2Version;
        private System.Windows.Forms.Button uxAddParamBtn;
        private System.Windows.Forms.ErrorProvider emptyParameterError;
        private System.Windows.Forms.CheckedListBox uxServerListBx;
        private System.Windows.Forms.Label serverlbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueTxt;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ErrorProvider queryNameError;
        private System.Windows.Forms.ErrorProvider queryTextError;
        private System.Windows.Forms.ErrorProvider serverError;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}