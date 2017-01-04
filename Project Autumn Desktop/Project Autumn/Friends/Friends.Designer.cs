namespace Project_Autumn
{
    partial class Friends
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
            this.LBFriends = new System.Windows.Forms.ListBox();
            this.BuOpenPm = new System.Windows.Forms.Button();
            this.BuRemove = new System.Windows.Forms.Button();
            this.BuExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBFriends
            // 
            this.LBFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LBFriends.ForeColor = System.Drawing.Color.White;
            this.LBFriends.FormattingEnabled = true;
            this.LBFriends.Items.AddRange(new object[] {
            "Mum",
            "Couldn\'t",
            "Get",
            "Her",
            "Fat",
            "Ass",
            "Of",
            "The",
            "Remote"});
            this.LBFriends.Location = new System.Drawing.Point(12, 12);
            this.LBFriends.Name = "LBFriends";
            this.LBFriends.Size = new System.Drawing.Size(183, 277);
            this.LBFriends.TabIndex = 0;
            // 
            // BuOpenPm
            // 
            this.BuOpenPm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuOpenPm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuOpenPm.Location = new System.Drawing.Point(212, 41);
            this.BuOpenPm.Name = "BuOpenPm";
            this.BuOpenPm.Size = new System.Drawing.Size(75, 23);
            this.BuOpenPm.TabIndex = 2;
            this.BuOpenPm.Text = "PM";
            this.BuOpenPm.UseVisualStyleBackColor = false;
            // 
            // BuRemove
            // 
            this.BuRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuRemove.Location = new System.Drawing.Point(212, 70);
            this.BuRemove.Name = "BuRemove";
            this.BuRemove.Size = new System.Drawing.Size(75, 23);
            this.BuRemove.TabIndex = 3;
            this.BuRemove.Text = "Remove";
            this.BuRemove.UseVisualStyleBackColor = false;
            this.BuRemove.Click += new System.EventHandler(this.BuRemove_Click);
            // 
            // BuExit
            // 
            this.BuExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuExit.Location = new System.Drawing.Point(212, 12);
            this.BuExit.Name = "BuExit";
            this.BuExit.Size = new System.Drawing.Size(75, 23);
            this.BuExit.TabIndex = 1;
            this.BuExit.Text = "Exit";
            this.BuExit.UseVisualStyleBackColor = false;
            this.BuExit.Click += new System.EventHandler(this.BuExit_Click);
            // 
            // Friends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(298, 301);
            this.Controls.Add(this.BuRemove);
            this.Controls.Add(this.BuOpenPm);
            this.Controls.Add(this.BuExit);
            this.Controls.Add(this.LBFriends);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Friends";
            this.Text = "Friends";
            this.Load += new System.EventHandler(this.Friends_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBFriends;
        private System.Windows.Forms.Button BuOpenPm;
        private System.Windows.Forms.Button BuRemove;
        private System.Windows.Forms.Button BuExit;
    }
}