namespace Project_Autumn
{
    partial class Users
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
            this.LBUsers = new System.Windows.Forms.ListBox();
            this.BuExit = new System.Windows.Forms.Button();
            this.BuBanUser = new System.Windows.Forms.Button();
            this.BuTimeoutUser = new System.Windows.Forms.Button();
            this.TrackBTimeout = new System.Windows.Forms.TrackBar();
            this.BuLockAccount = new System.Windows.Forms.Button();
            this.TBTrackBCurrentValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // LBUsers
            // 
            this.LBUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LBUsers.ForeColor = System.Drawing.Color.White;
            this.LBUsers.FormattingEnabled = true;
            this.LBUsers.Location = new System.Drawing.Point(19, 45);
            this.LBUsers.Name = "LBUsers";
            this.LBUsers.Size = new System.Drawing.Size(265, 329);
            this.LBUsers.TabIndex = 0;
            this.LBUsers.SelectedIndexChanged += new System.EventHandler(this.LBUsers_SelectedIndexChanged);
            // 
            // BuExit
            // 
            this.BuExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuExit.Location = new System.Drawing.Point(19, 13);
            this.BuExit.Name = "BuExit";
            this.BuExit.Size = new System.Drawing.Size(75, 23);
            this.BuExit.TabIndex = 1;
            this.BuExit.Text = "Exit";
            this.BuExit.UseVisualStyleBackColor = false;
            this.BuExit.Click += new System.EventHandler(this.BuExit_Click);
            // 
            // BuBanUser
            // 
            this.BuBanUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuBanUser.Location = new System.Drawing.Point(305, 45);
            this.BuBanUser.Name = "BuBanUser";
            this.BuBanUser.Size = new System.Drawing.Size(88, 23);
            this.BuBanUser.TabIndex = 2;
            this.BuBanUser.Text = "Ban";
            this.BuBanUser.UseVisualStyleBackColor = false;
            this.BuBanUser.Click += new System.EventHandler(this.BuBanUser_Click);
            // 
            // BuTimeoutUser
            // 
            this.BuTimeoutUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuTimeoutUser.Location = new System.Drawing.Point(305, 104);
            this.BuTimeoutUser.Name = "BuTimeoutUser";
            this.BuTimeoutUser.Size = new System.Drawing.Size(88, 23);
            this.BuTimeoutUser.TabIndex = 3;
            this.BuTimeoutUser.Text = "Timeout";
            this.BuTimeoutUser.UseVisualStyleBackColor = false;
            this.BuTimeoutUser.Click += new System.EventHandler(this.BuTimeoutUser_Click);
            // 
            // TrackBTimeout
            // 
            this.TrackBTimeout.Location = new System.Drawing.Point(305, 133);
            this.TrackBTimeout.Maximum = 30;
            this.TrackBTimeout.Name = "TrackBTimeout";
            this.TrackBTimeout.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBTimeout.Size = new System.Drawing.Size(45, 241);
            this.TrackBTimeout.TabIndex = 4;
            this.TrackBTimeout.Scroll += new System.EventHandler(this.TrackBTimeout_Scroll);
            this.TrackBTimeout.ValueChanged += new System.EventHandler(this.TrackBTimeout_ValueChanged);
            // 
            // BuLockAccount
            // 
            this.BuLockAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuLockAccount.Location = new System.Drawing.Point(305, 75);
            this.BuLockAccount.Name = "BuLockAccount";
            this.BuLockAccount.Size = new System.Drawing.Size(88, 23);
            this.BuLockAccount.TabIndex = 5;
            this.BuLockAccount.Text = "Lock Account";
            this.BuLockAccount.UseVisualStyleBackColor = false;
            this.BuLockAccount.Click += new System.EventHandler(this.BuLockAccount_Click);
            // 
            // TBTrackBCurrentValue
            // 
            this.TBTrackBCurrentValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.TBTrackBCurrentValue.ForeColor = System.Drawing.Color.White;
            this.TBTrackBCurrentValue.Location = new System.Drawing.Point(357, 353);
            this.TBTrackBCurrentValue.Name = "TBTrackBCurrentValue";
            this.TBTrackBCurrentValue.ReadOnly = true;
            this.TBTrackBCurrentValue.Size = new System.Drawing.Size(100, 20);
            this.TBTrackBCurrentValue.TabIndex = 6;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(473, 402);
            this.Controls.Add(this.TBTrackBCurrentValue);
            this.Controls.Add(this.BuLockAccount);
            this.Controls.Add(this.TrackBTimeout);
            this.Controls.Add(this.BuTimeoutUser);
            this.Controls.Add(this.BuBanUser);
            this.Controls.Add(this.BuExit);
            this.Controls.Add(this.LBUsers);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBUsers;
        private System.Windows.Forms.Button BuExit;
        private System.Windows.Forms.Button BuBanUser;
        private System.Windows.Forms.Button BuTimeoutUser;
        private System.Windows.Forms.TrackBar TrackBTimeout;
        private System.Windows.Forms.Button BuLockAccount;
        private System.Windows.Forms.TextBox TBTrackBCurrentValue;
    }
}