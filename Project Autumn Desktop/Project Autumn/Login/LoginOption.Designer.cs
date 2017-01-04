namespace Project_Autumn
{
    partial class LoginOption
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
            this.BuSaveSettings = new System.Windows.Forms.Button();
            this.LaIP = new System.Windows.Forms.Label();
            this.TBIPAddress = new System.Windows.Forms.TextBox();
            this.BuBack = new System.Windows.Forms.Button();
            this.TBDatabase = new System.Windows.Forms.TextBox();
            this.LaDatabase = new System.Windows.Forms.Label();
            this.TBUId = new System.Windows.Forms.TextBox();
            this.LaUId = new System.Windows.Forms.Label();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.LaPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BuSaveSettings
            // 
            this.BuSaveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuSaveSettings.ForeColor = System.Drawing.Color.White;
            this.BuSaveSettings.Location = new System.Drawing.Point(13, 364);
            this.BuSaveSettings.Name = "BuSaveSettings";
            this.BuSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.BuSaveSettings.TabIndex = 0;
            this.BuSaveSettings.Text = "Save";
            this.BuSaveSettings.UseVisualStyleBackColor = false;
            this.BuSaveSettings.Click += new System.EventHandler(this.BuSaveSettings_Click);
            // 
            // LaIP
            // 
            this.LaIP.AutoSize = true;
            this.LaIP.ForeColor = System.Drawing.Color.White;
            this.LaIP.Location = new System.Drawing.Point(13, 63);
            this.LaIP.Name = "LaIP";
            this.LaIP.Size = new System.Drawing.Size(17, 13);
            this.LaIP.TabIndex = 1;
            this.LaIP.Text = "IP";
            // 
            // TBIPAddress
            // 
            this.TBIPAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.TBIPAddress.ForeColor = System.Drawing.Color.White;
            this.TBIPAddress.Location = new System.Drawing.Point(72, 60);
            this.TBIPAddress.Name = "TBIPAddress";
            this.TBIPAddress.Size = new System.Drawing.Size(100, 20);
            this.TBIPAddress.TabIndex = 2;
            this.TBIPAddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BuBack
            // 
            this.BuBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuBack.ForeColor = System.Drawing.Color.White;
            this.BuBack.Location = new System.Drawing.Point(400, 364);
            this.BuBack.Name = "BuBack";
            this.BuBack.Size = new System.Drawing.Size(75, 23);
            this.BuBack.TabIndex = 3;
            this.BuBack.Text = "Back";
            this.BuBack.UseVisualStyleBackColor = false;
            this.BuBack.Click += new System.EventHandler(this.BuBack_Click);
            // 
            // TBDatabase
            // 
            this.TBDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.TBDatabase.ForeColor = System.Drawing.Color.White;
            this.TBDatabase.Location = new System.Drawing.Point(72, 86);
            this.TBDatabase.Name = "TBDatabase";
            this.TBDatabase.Size = new System.Drawing.Size(100, 20);
            this.TBDatabase.TabIndex = 5;
            // 
            // LaDatabase
            // 
            this.LaDatabase.AutoSize = true;
            this.LaDatabase.ForeColor = System.Drawing.Color.White;
            this.LaDatabase.Location = new System.Drawing.Point(13, 89);
            this.LaDatabase.Name = "LaDatabase";
            this.LaDatabase.Size = new System.Drawing.Size(53, 13);
            this.LaDatabase.TabIndex = 4;
            this.LaDatabase.Text = "Database";
            // 
            // TBUId
            // 
            this.TBUId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.TBUId.ForeColor = System.Drawing.Color.White;
            this.TBUId.Location = new System.Drawing.Point(72, 112);
            this.TBUId.Name = "TBUId";
            this.TBUId.Size = new System.Drawing.Size(100, 20);
            this.TBUId.TabIndex = 7;
            // 
            // LaUId
            // 
            this.LaUId.AutoSize = true;
            this.LaUId.ForeColor = System.Drawing.Color.White;
            this.LaUId.Location = new System.Drawing.Point(13, 115);
            this.LaUId.Name = "LaUId";
            this.LaUId.Size = new System.Drawing.Size(41, 13);
            this.LaUId.TabIndex = 6;
            this.LaUId.Text = "User Id";
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.TBPassword.ForeColor = System.Drawing.Color.White;
            this.TBPassword.Location = new System.Drawing.Point(72, 138);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(100, 20);
            this.TBPassword.TabIndex = 9;
            // 
            // LaPassword
            // 
            this.LaPassword.AutoSize = true;
            this.LaPassword.ForeColor = System.Drawing.Color.White;
            this.LaPassword.Location = new System.Drawing.Point(13, 141);
            this.LaPassword.Name = "LaPassword";
            this.LaPassword.Size = new System.Drawing.Size(53, 13);
            this.LaPassword.TabIndex = 8;
            this.LaPassword.Text = "Password";
            // 
            // LoginOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(485, 399);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.LaPassword);
            this.Controls.Add(this.TBUId);
            this.Controls.Add(this.LaUId);
            this.Controls.Add(this.TBDatabase);
            this.Controls.Add(this.LaDatabase);
            this.Controls.Add(this.BuBack);
            this.Controls.Add(this.TBIPAddress);
            this.Controls.Add(this.LaIP);
            this.Controls.Add(this.BuSaveSettings);
            this.Name = "LoginOption";
            this.Text = "LoginOption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuSaveSettings;
        private System.Windows.Forms.Label LaIP;
        private System.Windows.Forms.TextBox TBIPAddress;
        private System.Windows.Forms.Button BuBack;
        private System.Windows.Forms.TextBox TBDatabase;
        private System.Windows.Forms.Label LaDatabase;
        private System.Windows.Forms.TextBox TBUId;
        private System.Windows.Forms.Label LaUId;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Label LaPassword;
    }
}