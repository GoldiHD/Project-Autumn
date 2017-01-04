namespace Project_Autumn
{
    partial class Lobby1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby1));
            this.BuLobby = new System.Windows.Forms.Button();
            this.RTBChatWindow = new System.Windows.Forms.RichTextBox();
            this.TBChat = new System.Windows.Forms.TextBox();
            this.BuSend = new System.Windows.Forms.Button();
            this.LaUsersInLobby = new System.Windows.Forms.Label();
            this.UpdateTick = new System.Windows.Forms.Timer(this.components);
            this.InLobbyChecker = new System.Windows.Forms.Timer(this.components);
            this.LaTitle = new System.Windows.Forms.Label();
            this.LaCurrentLobby = new System.Windows.Forms.Label();
            this.LBUsersInLobby = new System.Windows.Forms.ListBox();
            this.BuAddFriend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BuLobby
            // 
            this.BuLobby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuLobby.ForeColor = System.Drawing.Color.White;
            this.BuLobby.Location = new System.Drawing.Point(12, 10);
            this.BuLobby.Name = "BuLobby";
            this.BuLobby.Size = new System.Drawing.Size(99, 23);
            this.BuLobby.TabIndex = 0;
            this.BuLobby.Text = "Back";
            this.BuLobby.UseVisualStyleBackColor = false;
            this.BuLobby.Click += new System.EventHandler(this.BuLobby_Click);
            // 
            // RTBChatWindow
            // 
            this.RTBChatWindow.BackColor = System.Drawing.Color.Black;
            this.RTBChatWindow.ForeColor = System.Drawing.Color.White;
            this.RTBChatWindow.Location = new System.Drawing.Point(131, 12);
            this.RTBChatWindow.Name = "RTBChatWindow";
            this.RTBChatWindow.Size = new System.Drawing.Size(580, 300);
            this.RTBChatWindow.TabIndex = 1;
            this.RTBChatWindow.Text = "";
            // 
            // TBChat
            // 
            this.TBChat.BackColor = System.Drawing.Color.Black;
            this.TBChat.ForeColor = System.Drawing.Color.White;
            this.TBChat.Location = new System.Drawing.Point(131, 316);
            this.TBChat.Name = "TBChat";
            this.TBChat.Size = new System.Drawing.Size(580, 20);
            this.TBChat.TabIndex = 2;
            // 
            // BuSend
            // 
            this.BuSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuSend.ForeColor = System.Drawing.Color.White;
            this.BuSend.Location = new System.Drawing.Point(12, 316);
            this.BuSend.Name = "BuSend";
            this.BuSend.Size = new System.Drawing.Size(105, 23);
            this.BuSend.TabIndex = 3;
            this.BuSend.Text = "Send";
            this.BuSend.UseVisualStyleBackColor = false;
            this.BuSend.Click += new System.EventHandler(this.BuSend_Click);
            // 
            // LaUsersInLobby
            // 
            this.LaUsersInLobby.AutoSize = true;
            this.LaUsersInLobby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LaUsersInLobby.ForeColor = System.Drawing.Color.White;
            this.LaUsersInLobby.Location = new System.Drawing.Point(13, 71);
            this.LaUsersInLobby.Name = "LaUsersInLobby";
            this.LaUsersInLobby.Size = new System.Drawing.Size(44, 13);
            this.LaUsersInLobby.TabIndex = 5;
            this.LaUsersInLobby.Text = "In lobby";
            // 
            // UpdateTick
            // 
            this.UpdateTick.Enabled = true;
            this.UpdateTick.Tick += new System.EventHandler(this.UpdateTick_Tick);
            // 
            // InLobbyChecker
            // 
            this.InLobbyChecker.Enabled = true;
            this.InLobbyChecker.Interval = 5000;
            this.InLobbyChecker.Tick += new System.EventHandler(this.InLobbyChecker_Tick);
            // 
            // LaTitle
            // 
            this.LaTitle.AutoSize = true;
            this.LaTitle.ForeColor = System.Drawing.Color.White;
            this.LaTitle.Location = new System.Drawing.Point(63, 36);
            this.LaTitle.Name = "LaTitle";
            this.LaTitle.Size = new System.Drawing.Size(45, 13);
            this.LaTitle.TabIndex = 6;
            this.LaTitle.Text = "Lobby 1";
            this.LaTitle.Click += new System.EventHandler(this.LaTitle_Click);
            // 
            // LaCurrentLobby
            // 
            this.LaCurrentLobby.AutoSize = true;
            this.LaCurrentLobby.ForeColor = System.Drawing.Color.White;
            this.LaCurrentLobby.Location = new System.Drawing.Point(13, 36);
            this.LaCurrentLobby.Name = "LaCurrentLobby";
            this.LaCurrentLobby.Size = new System.Drawing.Size(44, 13);
            this.LaCurrentLobby.TabIndex = 7;
            this.LaCurrentLobby.Text = "Current:";
            // 
            // LBUsersInLobby
            // 
            this.LBUsersInLobby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LBUsersInLobby.ForeColor = System.Drawing.Color.White;
            this.LBUsersInLobby.FormattingEnabled = true;
            this.LBUsersInLobby.Location = new System.Drawing.Point(12, 87);
            this.LBUsersInLobby.Name = "LBUsersInLobby";
            this.LBUsersInLobby.Size = new System.Drawing.Size(105, 186);
            this.LBUsersInLobby.TabIndex = 8;
            // 
            // BuAddFriend
            // 
            this.BuAddFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuAddFriend.ForeColor = System.Drawing.Color.White;
            this.BuAddFriend.Location = new System.Drawing.Point(12, 287);
            this.BuAddFriend.Name = "BuAddFriend";
            this.BuAddFriend.Size = new System.Drawing.Size(105, 23);
            this.BuAddFriend.TabIndex = 9;
            this.BuAddFriend.Text = "Add Friend";
            this.BuAddFriend.UseVisualStyleBackColor = false;
            this.BuAddFriend.Click += new System.EventHandler(this.BuAddFriend_Click);
            // 
            // Lobby1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(726, 349);
            this.ControlBox = false;
            this.Controls.Add(this.BuAddFriend);
            this.Controls.Add(this.LBUsersInLobby);
            this.Controls.Add(this.LaCurrentLobby);
            this.Controls.Add(this.LaTitle);
            this.Controls.Add(this.LaUsersInLobby);
            this.Controls.Add(this.BuSend);
            this.Controls.Add(this.TBChat);
            this.Controls.Add(this.RTBChatWindow);
            this.Controls.Add(this.BuLobby);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Lobby1";
            this.Text = "Lobby1";
            this.Load += new System.EventHandler(this.Lobby1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuLobby;
        private System.Windows.Forms.RichTextBox RTBChatWindow;
        private System.Windows.Forms.TextBox TBChat;
        private System.Windows.Forms.Button BuSend;
        private System.Windows.Forms.Label LaUsersInLobby;
        private System.Windows.Forms.Timer UpdateTick;
        private System.Windows.Forms.Timer InLobbyChecker;
        private System.Windows.Forms.Label LaTitle;
        private System.Windows.Forms.Label LaCurrentLobby;
        private System.Windows.Forms.ListBox LBUsersInLobby;
        private System.Windows.Forms.Button BuAddFriend;
    }
}