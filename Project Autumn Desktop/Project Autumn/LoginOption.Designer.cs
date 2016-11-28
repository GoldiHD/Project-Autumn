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
            this.TBIPAddress.Location = new System.Drawing.Point(36, 60);
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
            // LoginOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(485, 399);
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
    }
}