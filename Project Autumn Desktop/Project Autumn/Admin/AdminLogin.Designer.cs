namespace Project_Autumn
{
    partial class AdminLogin
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
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.LaUsername = new System.Windows.Forms.Label();
            this.LaPassword = new System.Windows.Forms.Label();
            this.BuLogin = new System.Windows.Forms.Button();
            this.BuBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBUsername
            // 
            this.TBUsername.AllowDrop = true;
            this.TBUsername.Location = new System.Drawing.Point(108, 130);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(100, 20);
            this.TBUsername.TabIndex = 0;
            // 
            // TBPassword
            // 
            this.TBPassword.AllowDrop = true;
            this.TBPassword.Location = new System.Drawing.Point(108, 179);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = 'X';
            this.TBPassword.Size = new System.Drawing.Size(100, 20);
            this.TBPassword.TabIndex = 1;
            // 
            // LaUsername
            // 
            this.LaUsername.AllowDrop = true;
            this.LaUsername.AutoSize = true;
            this.LaUsername.Location = new System.Drawing.Point(47, 133);
            this.LaUsername.Name = "LaUsername";
            this.LaUsername.Size = new System.Drawing.Size(55, 13);
            this.LaUsername.TabIndex = 2;
            this.LaUsername.Text = "Username";
            // 
            // LaPassword
            // 
            this.LaPassword.AllowDrop = true;
            this.LaPassword.AutoSize = true;
            this.LaPassword.Location = new System.Drawing.Point(49, 182);
            this.LaPassword.Name = "LaPassword";
            this.LaPassword.Size = new System.Drawing.Size(53, 13);
            this.LaPassword.TabIndex = 3;
            this.LaPassword.Text = "Password";
            // 
            // BuLogin
            // 
            this.BuLogin.Location = new System.Drawing.Point(43, 307);
            this.BuLogin.Name = "BuLogin";
            this.BuLogin.Size = new System.Drawing.Size(75, 23);
            this.BuLogin.TabIndex = 4;
            this.BuLogin.Text = "Login";
            this.BuLogin.UseVisualStyleBackColor = true;
            this.BuLogin.Click += new System.EventHandler(this.BuLogin_Click);
            // 
            // BuBack
            // 
            this.BuBack.Location = new System.Drawing.Point(176, 307);
            this.BuBack.Name = "BuBack";
            this.BuBack.Size = new System.Drawing.Size(75, 23);
            this.BuBack.TabIndex = 5;
            this.BuBack.Text = "Back";
            this.BuBack.UseVisualStyleBackColor = true;
            this.BuBack.Click += new System.EventHandler(this.BuBack_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 366);
            this.ControlBox = false;
            this.Controls.Add(this.BuBack);
            this.Controls.Add(this.BuLogin);
            this.Controls.Add(this.LaPassword);
            this.Controls.Add(this.LaUsername);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBUsername);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Label LaUsername;
        private System.Windows.Forms.Label LaPassword;
        private System.Windows.Forms.Button BuLogin;
        private System.Windows.Forms.Button BuBack;
    }
}