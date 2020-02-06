namespace SQLGUIProject
{
    partial class ServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            this.lblServerName = new System.Windows.Forms.Label();
            this.lblMPVersion = new System.Windows.Forms.Label();
            this.uxServerNameTxt = new System.Windows.Forms.TextBox();
            this.uxWAChckBx = new System.Windows.Forms.CheckBox();
            this.uxCancelBtn = new System.Windows.Forms.Button();
            this.uxOKBtn = new System.Windows.Forms.Button();
            this.uxUsernameTxt = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.uxPasswordTxt = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.uxNullUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.uxNullPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.uxNullServerName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uxNullUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNullPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNullServerName)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(9, 20);
            this.lblServerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(69, 13);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "Server Name";
            // 
            // lblMPVersion
            // 
            this.lblMPVersion.AutoSize = true;
            this.lblMPVersion.Location = new System.Drawing.Point(9, 76);
            this.lblMPVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMPVersion.Name = "lblMPVersion";
            this.lblMPVersion.Size = new System.Drawing.Size(122, 13);
            this.lblMPVersion.TabIndex = 1;
            this.lblMPVersion.Text = "Windows Authentication";
            // 
            // uxServerNameTxt
            // 
            this.uxServerNameTxt.Location = new System.Drawing.Point(88, 17);
            this.uxServerNameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.uxServerNameTxt.Name = "uxServerNameTxt";
            this.uxServerNameTxt.Size = new System.Drawing.Size(234, 20);
            this.uxServerNameTxt.TabIndex = 1;
            // 
            // uxWAChckBx
            // 
            this.uxWAChckBx.AutoSize = true;
            this.uxWAChckBx.Location = new System.Drawing.Point(135, 76);
            this.uxWAChckBx.Margin = new System.Windows.Forms.Padding(2);
            this.uxWAChckBx.Name = "uxWAChckBx";
            this.uxWAChckBx.Size = new System.Drawing.Size(15, 14);
            this.uxWAChckBx.TabIndex = 4;
            this.uxWAChckBx.UseVisualStyleBackColor = true;
            this.uxWAChckBx.CheckedChanged += new System.EventHandler(this.uxWAChckBx_CheckedChanged);
            // 
            // uxCancelBtn
            // 
            this.uxCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxCancelBtn.Location = new System.Drawing.Point(260, 70);
            this.uxCancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.uxCancelBtn.Name = "uxCancelBtn";
            this.uxCancelBtn.Size = new System.Drawing.Size(62, 24);
            this.uxCancelBtn.TabIndex = 6;
            this.uxCancelBtn.Text = "Cancel";
            this.uxCancelBtn.UseVisualStyleBackColor = true;
            this.uxCancelBtn.Click += new System.EventHandler(this.uxCancelBtn_Click);
            // 
            // uxOKBtn
            // 
            this.uxOKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxOKBtn.Location = new System.Drawing.Point(194, 70);
            this.uxOKBtn.Margin = new System.Windows.Forms.Padding(2);
            this.uxOKBtn.Name = "uxOKBtn";
            this.uxOKBtn.Size = new System.Drawing.Size(62, 24);
            this.uxOKBtn.TabIndex = 5;
            this.uxOKBtn.Text = "OK";
            this.uxOKBtn.UseVisualStyleBackColor = true;
            this.uxOKBtn.Click += new System.EventHandler(this.uxOKBtn_Click);
            // 
            // uxUsernameTxt
            // 
            this.uxUsernameTxt.Location = new System.Drawing.Point(69, 46);
            this.uxUsernameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.uxUsernameTxt.Name = "uxUsernameTxt";
            this.uxUsernameTxt.Size = new System.Drawing.Size(91, 20);
            this.uxUsernameTxt.TabIndex = 2;
            this.uxUsernameTxt.TextChanged += new System.EventHandler(this.uxUsernameTxt_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(10, 49);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            // 
            // uxPasswordTxt
            // 
            this.uxPasswordTxt.Location = new System.Drawing.Point(225, 46);
            this.uxPasswordTxt.Margin = new System.Windows.Forms.Padding(2);
            this.uxPasswordTxt.Name = "uxPasswordTxt";
            this.uxPasswordTxt.Size = new System.Drawing.Size(97, 20);
            this.uxPasswordTxt.TabIndex = 3;
            this.uxPasswordTxt.UseSystemPasswordChar = true;
            this.uxPasswordTxt.TextChanged += new System.EventHandler(this.uxPasswordTxt_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(166, 49);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // uxNullUsername
            // 
            this.uxNullUsername.ContainerControl = this;
            // 
            // uxNullPassword
            // 
            this.uxNullPassword.ContainerControl = this;
            // 
            // uxNullServerName
            // 
            this.uxNullServerName.ContainerControl = this;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 99);
            this.Controls.Add(this.uxPasswordTxt);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.uxUsernameTxt);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.uxOKBtn);
            this.Controls.Add(this.uxCancelBtn);
            this.Controls.Add(this.uxWAChckBx);
            this.Controls.Add(this.uxServerNameTxt);
            this.Controls.Add(this.lblMPVersion);
            this.Controls.Add(this.lblServerName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(349, 138);
            this.MinimumSize = new System.Drawing.Size(349, 138);
            this.Name = "ServerForm";
            this.Text = "ServerForm";
            ((System.ComponentModel.ISupportInitialize)(this.uxNullUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNullPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNullServerName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label lblMPVersion;
        private System.Windows.Forms.TextBox uxServerNameTxt;
        private System.Windows.Forms.CheckBox uxWAChckBx;
        private System.Windows.Forms.Button uxCancelBtn;
        private System.Windows.Forms.Button uxOKBtn;
        private System.Windows.Forms.TextBox uxUsernameTxt;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox uxPasswordTxt;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ErrorProvider uxNullUsername;
        private System.Windows.Forms.ErrorProvider uxNullPassword;
        private System.Windows.Forms.ErrorProvider uxNullServerName;
    }
}