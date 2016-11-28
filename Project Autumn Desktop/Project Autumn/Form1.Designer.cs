namespace Project_Autumn
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.LaUsernameText = new System.Windows.Forms.Label();
            this.LaPassword = new System.Windows.Forms.Label();
            this.BuLogin = new System.Windows.Forms.Button();
            this.BuExit = new System.Windows.Forms.Button();
            this.TBUpdateLink = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LaCurrentVer = new System.Windows.Forms.Label();
            this.LaBuildNum = new System.Windows.Forms.Label();
            this.LaNewVer = new System.Windows.Forms.Label();
            this.LaNewBuildVer = new System.Windows.Forms.Label();
            this.LaDownloadLink = new System.Windows.Forms.Label();
            this.BuUpdateLog = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BuLoginOption = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TBUsername
            // 
            this.TBUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.TBUsername.ForeColor = System.Drawing.Color.White;
            this.TBUsername.Location = new System.Drawing.Point(126, 229);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(100, 20);
            this.TBUsername.TabIndex = 0;
            this.TBUsername.TextChanged += new System.EventHandler(this.TBUsername_TextChanged);
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.TBPassword.ForeColor = System.Drawing.Color.White;
            this.TBPassword.Location = new System.Drawing.Point(126, 276);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = 'X';
            this.TBPassword.Size = new System.Drawing.Size(100, 20);
            this.TBPassword.TabIndex = 1;
            // 
            // LaUsernameText
            // 
            this.LaUsernameText.AutoSize = true;
            this.LaUsernameText.ForeColor = System.Drawing.Color.White;
            this.LaUsernameText.Location = new System.Drawing.Point(69, 232);
            this.LaUsernameText.Name = "LaUsernameText";
            this.LaUsernameText.Size = new System.Drawing.Size(55, 13);
            this.LaUsernameText.TabIndex = 2;
            this.LaUsernameText.Text = "Username";
            // 
            // LaPassword
            // 
            this.LaPassword.AutoSize = true;
            this.LaPassword.ForeColor = System.Drawing.Color.White;
            this.LaPassword.Location = new System.Drawing.Point(69, 279);
            this.LaPassword.Name = "LaPassword";
            this.LaPassword.Size = new System.Drawing.Size(53, 13);
            this.LaPassword.TabIndex = 3;
            this.LaPassword.Text = "Password";
            // 
            // BuLogin
            // 
            this.BuLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuLogin.ForeColor = System.Drawing.Color.White;
            this.BuLogin.Location = new System.Drawing.Point(139, 328);
            this.BuLogin.Name = "BuLogin";
            this.BuLogin.Size = new System.Drawing.Size(75, 23);
            this.BuLogin.TabIndex = 4;
            this.BuLogin.Text = "Login";
            this.BuLogin.UseVisualStyleBackColor = false;
            this.BuLogin.Click += new System.EventHandler(this.BuLogin_Click);
            // 
            // BuExit
            // 
            this.BuExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuExit.ForeColor = System.Drawing.Color.White;
            this.BuExit.Location = new System.Drawing.Point(139, 367);
            this.BuExit.Name = "BuExit";
            this.BuExit.Size = new System.Drawing.Size(75, 23);
            this.BuExit.TabIndex = 5;
            this.BuExit.Text = "Exit";
            this.BuExit.UseVisualStyleBackColor = false;
            this.BuExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // TBUpdateLink
            // 
            this.TBUpdateLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.TBUpdateLink.ForeColor = System.Drawing.Color.White;
            this.TBUpdateLink.Location = new System.Drawing.Point(172, 75);
            this.TBUpdateLink.Name = "TBUpdateLink";
            this.TBUpdateLink.Size = new System.Drawing.Size(100, 20);
            this.TBUpdateLink.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 49);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LaCurrentVer
            // 
            this.LaCurrentVer.AutoSize = true;
            this.LaCurrentVer.ForeColor = System.Drawing.Color.White;
            this.LaCurrentVer.Location = new System.Drawing.Point(36, 22);
            this.LaCurrentVer.Name = "LaCurrentVer";
            this.LaCurrentVer.Size = new System.Drawing.Size(44, 13);
            this.LaCurrentVer.TabIndex = 8;
            this.LaCurrentVer.Text = "Current:";
            // 
            // LaBuildNum
            // 
            this.LaBuildNum.AutoSize = true;
            this.LaBuildNum.ForeColor = System.Drawing.Color.White;
            this.LaBuildNum.Location = new System.Drawing.Point(83, 22);
            this.LaBuildNum.Name = "LaBuildNum";
            this.LaBuildNum.Size = new System.Drawing.Size(42, 13);
            this.LaBuildNum.TabIndex = 9;
            this.LaBuildNum.Text = "Empthy";
            // 
            // LaNewVer
            // 
            this.LaNewVer.AutoSize = true;
            this.LaNewVer.ForeColor = System.Drawing.Color.White;
            this.LaNewVer.Location = new System.Drawing.Point(217, 22);
            this.LaNewVer.Name = "LaNewVer";
            this.LaNewVer.Size = new System.Drawing.Size(32, 13);
            this.LaNewVer.TabIndex = 10;
            this.LaNewVer.Text = "New:";
            // 
            // LaNewBuildVer
            // 
            this.LaNewBuildVer.AutoSize = true;
            this.LaNewBuildVer.ForeColor = System.Drawing.Color.White;
            this.LaNewBuildVer.Location = new System.Drawing.Point(252, 22);
            this.LaNewBuildVer.Name = "LaNewBuildVer";
            this.LaNewBuildVer.Size = new System.Drawing.Size(42, 13);
            this.LaNewBuildVer.TabIndex = 11;
            this.LaNewBuildVer.Text = "Empthy";
            // 
            // LaDownloadLink
            // 
            this.LaDownloadLink.AutoSize = true;
            this.LaDownloadLink.ForeColor = System.Drawing.Color.White;
            this.LaDownloadLink.Location = new System.Drawing.Point(80, 78);
            this.LaDownloadLink.Name = "LaDownloadLink";
            this.LaDownloadLink.Size = new System.Drawing.Size(74, 13);
            this.LaDownloadLink.TabIndex = 12;
            this.LaDownloadLink.Text = "Download link";
            // 
            // BuUpdateLog
            // 
            this.BuUpdateLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuUpdateLog.ForeColor = System.Drawing.Color.White;
            this.BuUpdateLog.Location = new System.Drawing.Point(23, 415);
            this.BuUpdateLog.Name = "BuUpdateLog";
            this.BuUpdateLog.Size = new System.Drawing.Size(75, 23);
            this.BuUpdateLog.TabIndex = 13;
            this.BuUpdateLog.Text = "Update log";
            this.BuUpdateLog.UseVisualStyleBackColor = false;
            this.BuUpdateLog.Click += new System.EventHandler(this.BuUpdateLog_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(244, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Admin Panel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // BuLoginOption
            // 
            this.BuLoginOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuLoginOption.ForeColor = System.Drawing.Color.White;
            this.BuLoginOption.Location = new System.Drawing.Point(139, 414);
            this.BuLoginOption.Name = "BuLoginOption";
            this.BuLoginOption.Size = new System.Drawing.Size(75, 23);
            this.BuLoginOption.TabIndex = 15;
            this.BuLoginOption.Text = "Login Option";
            this.BuLoginOption.UseVisualStyleBackColor = false;
            this.BuLoginOption.Click += new System.EventHandler(this.BuLoginOption_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BuLoginOption);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BuUpdateLog);
            this.Controls.Add(this.LaDownloadLink);
            this.Controls.Add(this.LaNewBuildVer);
            this.Controls.Add(this.LaNewVer);
            this.Controls.Add(this.LaBuildNum);
            this.Controls.Add(this.LaCurrentVer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TBUpdateLink);
            this.Controls.Add(this.BuExit);
            this.Controls.Add(this.BuLogin);
            this.Controls.Add(this.LaPassword);
            this.Controls.Add(this.LaUsernameText);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBUsername);
            this.Name = "Form1";
            this.Text = "Project Autumn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Label LaUsernameText;
        private System.Windows.Forms.Label LaPassword;
        private System.Windows.Forms.Button BuLogin;
        private System.Windows.Forms.Button BuExit;
        private System.Windows.Forms.TextBox TBUpdateLink;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LaCurrentVer;
        private System.Windows.Forms.Label LaBuildNum;
        private System.Windows.Forms.Label LaNewVer;
        private System.Windows.Forms.Label LaNewBuildVer;
        private System.Windows.Forms.Label LaDownloadLink;
        private System.Windows.Forms.Button BuUpdateLog;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BuLoginOption;
    }
}

