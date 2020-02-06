namespace SQLGUIProject
{
    partial class ServerLookup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerLookup));
            this.label1 = new System.Windows.Forms.Label();
            this.filterTxtBx = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.dbServerGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dbServerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter:";
            // 
            // filterTxtBx
            // 
            this.filterTxtBx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filterTxtBx.Location = new System.Drawing.Point(134, 6);
            this.filterTxtBx.Name = "filterTxtBx";
            this.filterTxtBx.Size = new System.Drawing.Size(168, 20);
            this.filterTxtBx.TabIndex = 1;
            this.filterTxtBx.TextChanged += new System.EventHandler(this.filterTxtBx_TextChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeBtn.Location = new System.Drawing.Point(220, 397);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(82, 27);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.refreshBtn.Location = new System.Drawing.Point(99, 397);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(82, 27);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "Refresh List";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // dbServerGrid
            // 
            this.dbServerGrid.AllowUserToAddRows = false;
            this.dbServerGrid.AllowUserToOrderColumns = true;
            this.dbServerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbServerGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dbServerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dbServerGrid.Location = new System.Drawing.Point(11, 31);
            this.dbServerGrid.Margin = new System.Windows.Forms.Padding(2);
            this.dbServerGrid.Name = "dbServerGrid";
            this.dbServerGrid.ReadOnly = true;
            this.dbServerGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dbServerGrid.RowTemplate.Height = 24;
            this.dbServerGrid.RowTemplate.ReadOnly = true;
            this.dbServerGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dbServerGrid.ShowCellErrors = false;
            this.dbServerGrid.ShowEditingIcon = false;
            this.dbServerGrid.ShowRowErrors = false;
            this.dbServerGrid.Size = new System.Drawing.Size(377, 361);
            this.dbServerGrid.TabIndex = 5;
            this.dbServerGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dbServerGrid_DataBindingComplete);
            // 
            // ServerLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 428);
            this.Controls.Add(this.dbServerGrid);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.filterTxtBx);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(379, 467);
            this.Name = "ServerLookup";
            this.Text = "ServerLookup";
            ((System.ComponentModel.ISupportInitialize)(this.dbServerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterTxtBx;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView dbServerGrid;
    }
}