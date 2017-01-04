namespace Project_Autumn
{
    partial class MainChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainChat));
            this.BuSendMessage = new System.Windows.Forms.Button();
            this.BuJoinLobby2 = new System.Windows.Forms.Button();
            this.BuJoinLobby1 = new System.Windows.Forms.Button();
            this.BuMinimize = new System.Windows.Forms.Button();
            this.TBChat = new System.Windows.Forms.TextBox();
            this.RTBChatWindow = new System.Windows.Forms.RichTextBox();
            this.BuLogout = new System.Windows.Forms.Button();
            this.BuJoinLobby3 = new System.Windows.Forms.Button();
            this.BuJoinLobby4 = new System.Windows.Forms.Button();
            this.BuFriends = new System.Windows.Forms.Button();
            this.LaLobby1 = new System.Windows.Forms.Label();
            this.LaLobby2 = new System.Windows.Forms.Label();
            this.LaLobby3 = new System.Windows.Forms.Label();
            this.LaLobby4 = new System.Windows.Forms.Label();
            this.TBLobby1Status = new System.Windows.Forms.TextBox();
            this.TBLobby2Status = new System.Windows.Forms.TextBox();
            this.TBLobby3Status = new System.Windows.Forms.TextBox();
            this.TBLobby4Status = new System.Windows.Forms.TextBox();
            this.LaTitle = new System.Windows.Forms.Label();
            this.UpdateTick = new System.Windows.Forms.Timer(this.components);
            this.LobbyState = new System.Windows.Forms.Timer(this.components);
            this.BuUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BuSendMessage
            // 
            this.BuSendMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuSendMessage.ForeColor = System.Drawing.Color.White;
            this.BuSendMessage.Location = new System.Drawing.Point(156, 366);
            this.BuSendMessage.Name = "BuSendMessage";
            this.BuSendMessage.Size = new System.Drawing.Size(75, 23);
            this.BuSendMessage.TabIndex = 0;
            this.BuSendMessage.Text = "Send";
            this.BuSendMessage.UseVisualStyleBackColor = false;
            this.BuSendMessage.Click += new System.EventHandler(this.BuSendMessage_Click);
            // 
            // BuJoinLobby2
            // 
            this.BuJoinLobby2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuJoinLobby2.ForeColor = System.Drawing.Color.White;
            this.BuJoinLobby2.Location = new System.Drawing.Point(12, 135);
            this.BuJoinLobby2.Name = "BuJoinLobby2";
            this.BuJoinLobby2.Size = new System.Drawing.Size(75, 23);
            this.BuJoinLobby2.TabIndex = 1;
            this.BuJoinLobby2.Text = "Join";
            this.BuJoinLobby2.UseVisualStyleBackColor = false;
            this.BuJoinLobby2.Click += new System.EventHandler(this.BuJoinLobby2_Click);
            // 
            // BuJoinLobby1
            // 
            this.BuJoinLobby1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuJoinLobby1.ForeColor = System.Drawing.Color.White;
            this.BuJoinLobby1.Location = new System.Drawing.Point(12, 106);
            this.BuJoinLobby1.Name = "BuJoinLobby1";
            this.BuJoinLobby1.Size = new System.Drawing.Size(75, 23);
            this.BuJoinLobby1.TabIndex = 2;
            this.BuJoinLobby1.Text = "Join";
            this.BuJoinLobby1.UseVisualStyleBackColor = false;
            this.BuJoinLobby1.Click += new System.EventHandler(this.BuJoinLobby1_Click);
            // 
            // BuMinimize
            // 
            this.BuMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuMinimize.ForeColor = System.Drawing.Color.White;
            this.BuMinimize.Location = new System.Drawing.Point(808, 10);
            this.BuMinimize.Name = "BuMinimize";
            this.BuMinimize.Size = new System.Drawing.Size(75, 23);
            this.BuMinimize.TabIndex = 3;
            this.BuMinimize.Text = "_";
            this.BuMinimize.UseVisualStyleBackColor = false;
            this.BuMinimize.Click += new System.EventHandler(this.BuMinimize_Click);
            // 
            // TBChat
            // 
            this.TBChat.BackColor = System.Drawing.Color.Black;
            this.TBChat.ForeColor = System.Drawing.Color.White;
            this.TBChat.Location = new System.Drawing.Point(253, 368);
            this.TBChat.Name = "TBChat";
            this.TBChat.Size = new System.Drawing.Size(549, 20);
            this.TBChat.TabIndex = 4;
            // 
            // RTBChatWindow
            // 
            this.RTBChatWindow.BackColor = System.Drawing.Color.Black;
            this.RTBChatWindow.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBChatWindow.ForeColor = System.Drawing.Color.White;
            this.RTBChatWindow.Location = new System.Drawing.Point(253, 61);
            this.RTBChatWindow.Name = "RTBChatWindow";
            this.RTBChatWindow.ReadOnly = true;
            this.RTBChatWindow.Size = new System.Drawing.Size(549, 301);
            this.RTBChatWindow.TabIndex = 5;
            this.RTBChatWindow.Text = "";
            this.RTBChatWindow.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RTBChatWindow_LinkClicked);
            // 
            // BuLogout
            // 
            this.BuLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuLogout.ForeColor = System.Drawing.Color.White;
            this.BuLogout.Location = new System.Drawing.Point(12, 10);
            this.BuLogout.Name = "BuLogout";
            this.BuLogout.Size = new System.Drawing.Size(75, 23);
            this.BuLogout.TabIndex = 6;
            this.BuLogout.Text = "Logout";
            this.BuLogout.UseVisualStyleBackColor = false;
            this.BuLogout.Click += new System.EventHandler(this.BuLogout_Click);
            // 
            // BuJoinLobby3
            // 
            this.BuJoinLobby3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuJoinLobby3.ForeColor = System.Drawing.Color.White;
            this.BuJoinLobby3.Location = new System.Drawing.Point(12, 164);
            this.BuJoinLobby3.Name = "BuJoinLobby3";
            this.BuJoinLobby3.Size = new System.Drawing.Size(75, 23);
            this.BuJoinLobby3.TabIndex = 7;
            this.BuJoinLobby3.Text = "Join";
            this.BuJoinLobby3.UseVisualStyleBackColor = false;
            this.BuJoinLobby3.Click += new System.EventHandler(this.BuJoinLobby3_Click);
            // 
            // BuJoinLobby4
            // 
            this.BuJoinLobby4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuJoinLobby4.ForeColor = System.Drawing.Color.White;
            this.BuJoinLobby4.Location = new System.Drawing.Point(12, 193);
            this.BuJoinLobby4.Name = "BuJoinLobby4";
            this.BuJoinLobby4.Size = new System.Drawing.Size(75, 23);
            this.BuJoinLobby4.TabIndex = 8;
            this.BuJoinLobby4.Text = "Join";
            this.BuJoinLobby4.UseVisualStyleBackColor = false;
            this.BuJoinLobby4.Click += new System.EventHandler(this.BuJoinLobby4_Click);
            // 
            // BuFriends
            // 
            this.BuFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuFriends.ForeColor = System.Drawing.Color.White;
            this.BuFriends.Location = new System.Drawing.Point(12, 364);
            this.BuFriends.Name = "BuFriends";
            this.BuFriends.Size = new System.Drawing.Size(75, 23);
            this.BuFriends.TabIndex = 9;
            this.BuFriends.Text = "Friends";
            this.BuFriends.UseVisualStyleBackColor = false;
            this.BuFriends.Click += new System.EventHandler(this.BuFriends_Click);
            // 
            // LaLobby1
            // 
            this.LaLobby1.AutoSize = true;
            this.LaLobby1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LaLobby1.ForeColor = System.Drawing.Color.White;
            this.LaLobby1.Location = new System.Drawing.Point(93, 111);
            this.LaLobby1.Name = "LaLobby1";
            this.LaLobby1.Size = new System.Drawing.Size(45, 13);
            this.LaLobby1.TabIndex = 10;
            this.LaLobby1.Text = "Lobby 1";
            // 
            // LaLobby2
            // 
            this.LaLobby2.AutoSize = true;
            this.LaLobby2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LaLobby2.ForeColor = System.Drawing.Color.White;
            this.LaLobby2.Location = new System.Drawing.Point(93, 140);
            this.LaLobby2.Name = "LaLobby2";
            this.LaLobby2.Size = new System.Drawing.Size(45, 13);
            this.LaLobby2.TabIndex = 11;
            this.LaLobby2.Text = "Lobby 2";
            // 
            // LaLobby3
            // 
            this.LaLobby3.AutoSize = true;
            this.LaLobby3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LaLobby3.ForeColor = System.Drawing.Color.White;
            this.LaLobby3.Location = new System.Drawing.Point(93, 169);
            this.LaLobby3.Name = "LaLobby3";
            this.LaLobby3.Size = new System.Drawing.Size(45, 13);
            this.LaLobby3.TabIndex = 12;
            this.LaLobby3.Text = "Lobby 3";
            // 
            // LaLobby4
            // 
            this.LaLobby4.AutoSize = true;
            this.LaLobby4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LaLobby4.ForeColor = System.Drawing.Color.White;
            this.LaLobby4.Location = new System.Drawing.Point(93, 198);
            this.LaLobby4.Name = "LaLobby4";
            this.LaLobby4.Size = new System.Drawing.Size(45, 13);
            this.LaLobby4.TabIndex = 13;
            this.LaLobby4.Text = "Lobby 4";
            // 
            // TBLobby1Status
            // 
            this.TBLobby1Status.BackColor = System.Drawing.Color.Lime;
            this.TBLobby1Status.ForeColor = System.Drawing.Color.White;
            this.TBLobby1Status.Location = new System.Drawing.Point(225, 108);
            this.TBLobby1Status.Name = "TBLobby1Status";
            this.TBLobby1Status.ReadOnly = true;
            this.TBLobby1Status.Size = new System.Drawing.Size(22, 20);
            this.TBLobby1Status.TabIndex = 14;
            // 
            // TBLobby2Status
            // 
            this.TBLobby2Status.BackColor = System.Drawing.Color.Lime;
            this.TBLobby2Status.ForeColor = System.Drawing.Color.White;
            this.TBLobby2Status.Location = new System.Drawing.Point(225, 137);
            this.TBLobby2Status.Name = "TBLobby2Status";
            this.TBLobby2Status.ReadOnly = true;
            this.TBLobby2Status.Size = new System.Drawing.Size(22, 20);
            this.TBLobby2Status.TabIndex = 15;
            // 
            // TBLobby3Status
            // 
            this.TBLobby3Status.BackColor = System.Drawing.Color.Lime;
            this.TBLobby3Status.ForeColor = System.Drawing.Color.White;
            this.TBLobby3Status.Location = new System.Drawing.Point(225, 166);
            this.TBLobby3Status.Name = "TBLobby3Status";
            this.TBLobby3Status.ReadOnly = true;
            this.TBLobby3Status.Size = new System.Drawing.Size(22, 20);
            this.TBLobby3Status.TabIndex = 16;
            // 
            // TBLobby4Status
            // 
            this.TBLobby4Status.BackColor = System.Drawing.Color.Lime;
            this.TBLobby4Status.ForeColor = System.Drawing.Color.White;
            this.TBLobby4Status.Location = new System.Drawing.Point(225, 195);
            this.TBLobby4Status.Name = "TBLobby4Status";
            this.TBLobby4Status.ReadOnly = true;
            this.TBLobby4Status.Size = new System.Drawing.Size(22, 20);
            this.TBLobby4Status.TabIndex = 17;
            // 
            // LaTitle
            // 
            this.LaTitle.AutoSize = true;
            this.LaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaTitle.ForeColor = System.Drawing.Color.White;
            this.LaTitle.Location = new System.Drawing.Point(247, 10);
            this.LaTitle.Name = "LaTitle";
            this.LaTitle.Size = new System.Drawing.Size(157, 31);
            this.LaTitle.TabIndex = 18;
            this.LaTitle.Text = "Global Chat";
            // 
            // UpdateTick
            // 
            this.UpdateTick.Enabled = true;
            this.UpdateTick.Interval = 500;
            this.UpdateTick.Tick += new System.EventHandler(this.UpdateTick_Tick);
            // 
            // LobbyState
            // 
            this.LobbyState.Enabled = true;
            this.LobbyState.Interval = 1000;
            this.LobbyState.Tick += new System.EventHandler(this.LobbyState_Tick);
            // 
            // BuUsers
            // 
            this.BuUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BuUsers.ForeColor = System.Drawing.Color.White;
            this.BuUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuUsers.Location = new System.Drawing.Point(808, 40);
            this.BuUsers.Name = "BuUsers";
            this.BuUsers.Size = new System.Drawing.Size(75, 23);
            this.BuUsers.TabIndex = 19;
            this.BuUsers.Text = "Users";
            this.BuUsers.UseVisualStyleBackColor = false;
            this.BuUsers.Click += new System.EventHandler(this.BuUsers_Click);
            // 
            // MainChat
            // 
            this.AcceptButton = this.BuSendMessage;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(895, 414);
            this.ControlBox = false;
            this.Controls.Add(this.BuUsers);
            this.Controls.Add(this.LaTitle);
            this.Controls.Add(this.TBLobby4Status);
            this.Controls.Add(this.TBLobby3Status);
            this.Controls.Add(this.TBLobby2Status);
            this.Controls.Add(this.TBLobby1Status);
            this.Controls.Add(this.LaLobby4);
            this.Controls.Add(this.LaLobby3);
            this.Controls.Add(this.LaLobby2);
            this.Controls.Add(this.LaLobby1);
            this.Controls.Add(this.BuFriends);
            this.Controls.Add(this.BuJoinLobby4);
            this.Controls.Add(this.BuJoinLobby3);
            this.Controls.Add(this.BuLogout);
            this.Controls.Add(this.RTBChatWindow);
            this.Controls.Add(this.TBChat);
            this.Controls.Add(this.BuMinimize);
            this.Controls.Add(this.BuJoinLobby1);
            this.Controls.Add(this.BuJoinLobby2);
            this.Controls.Add(this.BuSendMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainChat";
            this.Text = "MainChat";
            this.Load += new System.EventHandler(this.MainChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuSendMessage;
        private System.Windows.Forms.Button BuJoinLobby2;
        private System.Windows.Forms.Button BuJoinLobby1;
        private System.Windows.Forms.Button BuMinimize;
        private System.Windows.Forms.TextBox TBChat;
        private System.Windows.Forms.RichTextBox RTBChatWindow;
        private System.Windows.Forms.Button BuLogout;
        private System.Windows.Forms.Button BuJoinLobby3;
        private System.Windows.Forms.Button BuJoinLobby4;
        private System.Windows.Forms.Button BuFriends;
        private System.Windows.Forms.Label LaLobby1;
        private System.Windows.Forms.Label LaLobby2;
        private System.Windows.Forms.Label LaLobby3;
        private System.Windows.Forms.Label LaLobby4;
        private System.Windows.Forms.TextBox TBLobby1Status;
        private System.Windows.Forms.TextBox TBLobby2Status;
        private System.Windows.Forms.TextBox TBLobby3Status;
        private System.Windows.Forms.TextBox TBLobby4Status;
        private System.Windows.Forms.Label LaTitle;
        private System.Windows.Forms.Timer UpdateTick;
        private System.Windows.Forms.Timer LobbyState;
        private System.Windows.Forms.Button BuUsers;
    }
}