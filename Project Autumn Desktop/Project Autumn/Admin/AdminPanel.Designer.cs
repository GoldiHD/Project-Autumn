namespace Project_Autumn
{
    partial class AdminPanel
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
            this.LaAddUser = new System.Windows.Forms.Label();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.LaUsername = new System.Windows.Forms.Label();
            this.LaEmail = new System.Windows.Forms.Label();
            this.LaPassword = new System.Windows.Forms.Label();
            this.LaPrivileges = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.PrivilegesTier = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PrivilegesTier)).BeginInit();
            this.SuspendLayout();
            // 
            // LaAddUser
            // 
            this.LaAddUser.AutoSize = true;
            this.LaAddUser.Location = new System.Drawing.Point(13, 13);
            this.LaAddUser.Name = "LaAddUser";
            this.LaAddUser.Size = new System.Drawing.Size(51, 13);
            this.LaAddUser.TabIndex = 0;
            this.LaAddUser.Text = "Add User";
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(77, 50);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(100, 20);
            this.TBUsername.TabIndex = 1;
            // 
            // LaUsername
            // 
            this.LaUsername.AutoSize = true;
            this.LaUsername.Location = new System.Drawing.Point(16, 53);
            this.LaUsername.Name = "LaUsername";
            this.LaUsername.Size = new System.Drawing.Size(55, 13);
            this.LaUsername.TabIndex = 2;
            this.LaUsername.Text = "Username";
            // 
            // LaEmail
            // 
            this.LaEmail.AutoSize = true;
            this.LaEmail.Location = new System.Drawing.Point(16, 94);
            this.LaEmail.Name = "LaEmail";
            this.LaEmail.Size = new System.Drawing.Size(35, 13);
            this.LaEmail.TabIndex = 3;
            this.LaEmail.Text = "E-mail";
            // 
            // LaPassword
            // 
            this.LaPassword.AutoSize = true;
            this.LaPassword.Location = new System.Drawing.Point(16, 126);
            this.LaPassword.Name = "LaPassword";
            this.LaPassword.Size = new System.Drawing.Size(53, 13);
            this.LaPassword.TabIndex = 4;
            this.LaPassword.Text = "Password";
            // 
            // LaPrivileges
            // 
            this.LaPrivileges.AutoSize = true;
            this.LaPrivileges.Location = new System.Drawing.Point(16, 165);
            this.LaPrivileges.Name = "LaPrivileges";
            this.LaPrivileges.Size = new System.Drawing.Size(52, 13);
            this.LaPrivileges.TabIndex = 6;
            this.LaPrivileges.Text = "Privileges";
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(77, 91);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(100, 20);
            this.TBEmail.TabIndex = 7;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(77, 126);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(100, 20);
            this.TBPassword.TabIndex = 8;
            // 
            // PrivilegesTier
            // 
            this.PrivilegesTier.Location = new System.Drawing.Point(77, 163);
            this.PrivilegesTier.Name = "PrivilegesTier";
            this.PrivilegesTier.Size = new System.Drawing.Size(100, 20);
            this.PrivilegesTier.TabIndex = 9;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 418);
            this.Controls.Add(this.PrivilegesTier);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.LaPrivileges);
            this.Controls.Add(this.LaPassword);
            this.Controls.Add(this.LaEmail);
            this.Controls.Add(this.LaUsername);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.LaAddUser);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)(this.PrivilegesTier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LaAddUser;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.Label LaUsername;
        private System.Windows.Forms.Label LaEmail;
        private System.Windows.Forms.Label LaPassword;
        private System.Windows.Forms.Label LaPrivileges;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.NumericUpDown PrivilegesTier;
    }
}