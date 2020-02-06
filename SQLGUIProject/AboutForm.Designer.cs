namespace SQLGUIProject
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.nameLbl = new System.Windows.Forms.Label();
            this.versionLbl = new System.Windows.Forms.Label();
            this.cultureLbl = new System.Windows.Forms.Label();
            this.changeLogBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(57, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(86, 13);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "applicationName";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versionLbl
            // 
            this.versionLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.versionLbl.AutoSize = true;
            this.versionLbl.Location = new System.Drawing.Point(57, 22);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(93, 13);
            this.versionLbl.TabIndex = 1;
            this.versionLbl.Text = "applicationVersion";
            this.versionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cultureLbl
            // 
            this.cultureLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cultureLbl.AutoSize = true;
            this.cultureLbl.Location = new System.Drawing.Point(57, 46);
            this.cultureLbl.Name = "cultureLbl";
            this.cultureLbl.Size = new System.Drawing.Size(91, 13);
            this.cultureLbl.TabIndex = 2;
            this.cultureLbl.Text = "applicationCulture";
            this.cultureLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeLogBtn
            // 
            this.changeLogBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.changeLogBtn.Location = new System.Drawing.Point(60, 68);
            this.changeLogBtn.Name = "changeLogBtn";
            this.changeLogBtn.Size = new System.Drawing.Size(78, 23);
            this.changeLogBtn.TabIndex = 2;
            this.changeLogBtn.Text = "Change Log";
            this.changeLogBtn.UseVisualStyleBackColor = true;
            this.changeLogBtn.Click += new System.EventHandler(this.changeLogBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.okBtn.Location = new System.Drawing.Point(60, 97);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(78, 23);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 123);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.changeLogBtn);
            this.Controls.Add(this.cultureLbl);
            this.Controls.Add(this.versionLbl);
            this.Controls.Add(this.nameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(219, 162);
            this.MinimumSize = new System.Drawing.Size(219, 162);
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label versionLbl;
        private System.Windows.Forms.Label cultureLbl;
        private System.Windows.Forms.Button changeLogBtn;
        private System.Windows.Forms.Button okBtn;
    }
}