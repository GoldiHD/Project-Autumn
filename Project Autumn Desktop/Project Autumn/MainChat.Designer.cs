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
            this.BuSendMessage = new System.Windows.Forms.Button();
            this.BuJoinLobby2 = new System.Windows.Forms.Button();
            this.BuJoinLobby1 = new System.Windows.Forms.Button();
            this.BuMinimize = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RTBChatWindow = new System.Windows.Forms.RichTextBox();
            this.BuLogout = new System.Windows.Forms.Button();
            this.BuJoinLobby3 = new System.Windows.Forms.Button();
            this.BuJoinLobby4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BuSendMessage
            // 
            this.BuSendMessage.Location = new System.Drawing.Point(12, 366);
            this.BuSendMessage.Name = "BuSendMessage";
            this.BuSendMessage.Size = new System.Drawing.Size(75, 23);
            this.BuSendMessage.TabIndex = 0;
            this.BuSendMessage.Text = "Send";
            this.BuSendMessage.UseVisualStyleBackColor = true;
            this.BuSendMessage.Click += new System.EventHandler(this.BuSendMessage_Click);
            // 
            // BuJoinLobby2
            // 
            this.BuJoinLobby2.Location = new System.Drawing.Point(12, 135);
            this.BuJoinLobby2.Name = "BuJoinLobby2";
            this.BuJoinLobby2.Size = new System.Drawing.Size(75, 23);
            this.BuJoinLobby2.TabIndex = 1;
            this.BuJoinLobby2.Text = "Join";
            this.BuJoinLobby2.UseVisualStyleBackColor = true;
            this.BuJoinLobby2.Click += new System.EventHandler(this.BuJoinLobby2_Click);
            // 
            // BuJoinLobby1
            // 
            this.BuJoinLobby1.Location = new System.Drawing.Point(12, 106);
            this.BuJoinLobby1.Name = "BuJoinLobby1";
            this.BuJoinLobby1.Size = new System.Drawing.Size(75, 23);
            this.BuJoinLobby1.TabIndex = 2;
            this.BuJoinLobby1.Text = "Join";
            this.BuJoinLobby1.UseVisualStyleBackColor = true;
            this.BuJoinLobby1.Click += new System.EventHandler(this.BuJoinLobby1_Click);
            // 
            // BuMinimize
            // 
            this.BuMinimize.Location = new System.Drawing.Point(719, 10);
            this.BuMinimize.Name = "BuMinimize";
            this.BuMinimize.Size = new System.Drawing.Size(75, 23);
            this.BuMinimize.TabIndex = 3;
            this.BuMinimize.Text = "_";
            this.BuMinimize.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 368);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(549, 20);
            this.textBox1.TabIndex = 4;
            // 
            // RTBChatWindow
            // 
            this.RTBChatWindow.Location = new System.Drawing.Point(152, 12);
            this.RTBChatWindow.Name = "RTBChatWindow";
            this.RTBChatWindow.ReadOnly = true;
            this.RTBChatWindow.Size = new System.Drawing.Size(549, 350);
            this.RTBChatWindow.TabIndex = 5;
            this.RTBChatWindow.Text = "";
            // 
            // BuLogout
            // 
            this.BuLogout.Location = new System.Drawing.Point(12, 10);
            this.BuLogout.Name = "BuLogout";
            this.BuLogout.Size = new System.Drawing.Size(75, 23);
            this.BuLogout.TabIndex = 6;
            this.BuLogout.Text = "Logout";
            this.BuLogout.UseVisualStyleBackColor = true;
            this.BuLogout.Click += new System.EventHandler(this.BuLogout_Click);
            // 
            // BuJoinLobby3
            // 
            this.BuJoinLobby3.Location = new System.Drawing.Point(12, 164);
            this.BuJoinLobby3.Name = "BuJoinLobby3";
            this.BuJoinLobby3.Size = new System.Drawing.Size(75, 23);
            this.BuJoinLobby3.TabIndex = 7;
            this.BuJoinLobby3.Text = "Join";
            this.BuJoinLobby3.UseVisualStyleBackColor = true;
            this.BuJoinLobby3.Click += new System.EventHandler(this.BuJoinLobby3_Click);
            // 
            // BuJoinLobby4
            // 
            this.BuJoinLobby4.Location = new System.Drawing.Point(12, 193);
            this.BuJoinLobby4.Name = "BuJoinLobby4";
            this.BuJoinLobby4.Size = new System.Drawing.Size(75, 23);
            this.BuJoinLobby4.TabIndex = 8;
            this.BuJoinLobby4.Text = "Join";
            this.BuJoinLobby4.UseVisualStyleBackColor = true;
            this.BuJoinLobby4.Click += new System.EventHandler(this.BuJoinLobby4_Click);
            // 
            // MainChat
            // 
            this.AcceptButton = this.BuSendMessage;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 414);
            this.Controls.Add(this.BuJoinLobby4);
            this.Controls.Add(this.BuJoinLobby3);
            this.Controls.Add(this.BuLogout);
            this.Controls.Add(this.RTBChatWindow);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BuMinimize);
            this.Controls.Add(this.BuJoinLobby1);
            this.Controls.Add(this.BuJoinLobby2);
            this.Controls.Add(this.BuSendMessage);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox RTBChatWindow;
        private System.Windows.Forms.Button BuLogout;
        private System.Windows.Forms.Button BuJoinLobby3;
        private System.Windows.Forms.Button BuJoinLobby4;
    }
}