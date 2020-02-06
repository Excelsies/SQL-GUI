namespace SQLGUIProject
{
    partial class QueryTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryTest));
            this.uxServersListBox = new System.Windows.Forms.ListBox();
            this.lblSQLServers = new System.Windows.Forms.Label();
            this.uxValueGrid = new System.Windows.Forms.DataGridView();
            this.paramTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblValue = new System.Windows.Forms.Label();
            this.uxOutputDataGrid = new System.Windows.Forms.DataGridView();
            this.uxGoButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxValueGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxOutputDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxServersListBox
            // 
            this.uxServersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxServersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxServersListBox.FormattingEnabled = true;
            this.uxServersListBox.Location = new System.Drawing.Point(2, 12);
            this.uxServersListBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxServersListBox.Name = "uxServersListBox";
            this.uxServersListBox.Size = new System.Drawing.Size(197, 197);
            this.uxServersListBox.TabIndex = 1;
            // 
            // lblSQLServers
            // 
            this.lblSQLServers.AutoSize = true;
            this.lblSQLServers.Location = new System.Drawing.Point(2, 0);
            this.lblSQLServers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSQLServers.Name = "lblSQLServers";
            this.lblSQLServers.Size = new System.Drawing.Size(67, 13);
            this.lblSQLServers.TabIndex = 7;
            this.lblSQLServers.Text = "SQL Servers";
            // 
            // uxValueGrid
            // 
            this.uxValueGrid.AllowUserToAddRows = false;
            this.uxValueGrid.AllowUserToDeleteRows = false;
            this.uxValueGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxValueGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uxValueGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.uxValueGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.uxValueGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxValueGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paramTxt,
            this.valueTxt});
            this.uxValueGrid.Location = new System.Drawing.Point(2, 15);
            this.uxValueGrid.Margin = new System.Windows.Forms.Padding(2);
            this.uxValueGrid.Name = "uxValueGrid";
            this.uxValueGrid.RowHeadersVisible = false;
            this.uxValueGrid.RowTemplate.Height = 24;
            this.uxValueGrid.Size = new System.Drawing.Size(201, 194);
            this.uxValueGrid.TabIndex = 2;
            this.uxValueGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.uxValueGrid_DataBindingComplete);
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
            this.lblValue.TabIndex = 11;
            this.lblValue.Text = "Values";
            // 
            // uxOutputDataGrid
            // 
            this.uxOutputDataGrid.AllowUserToAddRows = false;
            this.uxOutputDataGrid.AllowUserToOrderColumns = true;
            this.uxOutputDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxOutputDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uxOutputDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.uxOutputDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.uxOutputDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxOutputDataGrid.Location = new System.Drawing.Point(2, 37);
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
            this.uxOutputDataGrid.Size = new System.Drawing.Size(406, 167);
            this.uxOutputDataGrid.TabIndex = 4;
            this.uxOutputDataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.uxOutputDataGrid_DataBindingComplete);
            // 
            // uxGoButton
            // 
            this.uxGoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxGoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxGoButton.Location = new System.Drawing.Point(176, 1);
            this.uxGoButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxGoButton.Name = "uxGoButton";
            this.uxGoButton.Size = new System.Drawing.Size(56, 31);
            this.uxGoButton.TabIndex = 3;
            this.uxGoButton.Text = "Go";
            this.uxGoButton.UseVisualStyleBackColor = true;
            this.uxGoButton.Click += new System.EventHandler(this.uxGoButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1MinSize = 80;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.uxOutputDataGrid);
            this.splitContainer1.Panel2.Controls.Add(this.uxGoButton);
            this.splitContainer1.Panel2MinSize = 85;
            this.splitContainer1.Size = new System.Drawing.Size(410, 421);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.TabIndex = 14;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lblSQLServers);
            this.splitContainer2.Panel1.Controls.Add(this.uxServersListBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.uxValueGrid);
            this.splitContainer2.Panel2.Controls.Add(this.lblValue);
            this.splitContainer2.Size = new System.Drawing.Size(407, 211);
            this.splitContainer2.SplitterDistance = 201;
            this.splitContainer2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Results";
            // 
            // QueryTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 444);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(451, 483);
            this.Name = "QueryTest";
            this.Text = "QueryTest";
            ((System.ComponentModel.ISupportInitialize)(this.uxValueGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxOutputDataGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox uxServersListBox;
        private System.Windows.Forms.Label lblSQLServers;
        private System.Windows.Forms.DataGridView uxValueGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueTxt;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.DataGridView uxOutputDataGrid;
        private System.Windows.Forms.Button uxGoButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label3;
    }
}