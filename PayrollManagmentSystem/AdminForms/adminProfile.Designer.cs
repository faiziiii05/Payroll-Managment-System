namespace PayrollManagmentSystem.AdminForms
{
    partial class adminProfile
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
            this.profileLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passhowLabel = new System.Windows.Forms.Label();
            this.usernamehowLabel = new System.Windows.Forms.Label();
            this.nameshowLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLabel.ForeColor = System.Drawing.Color.Red;
            this.profileLabel.Location = new System.Drawing.Point(93, 38);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(134, 24);
            this.profileLabel.TabIndex = 0;
            this.profileLabel.Text = "Admin Profile";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(47, 132);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 22);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(47, 164);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(92, 22);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(47, 205);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(90, 22);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // passhowLabel
            // 
            this.passhowLabel.AutoSize = true;
            this.passhowLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passhowLabel.ForeColor = System.Drawing.Color.White;
            this.passhowLabel.Location = new System.Drawing.Point(253, 205);
            this.passhowLabel.Name = "passhowLabel";
            this.passhowLabel.Size = new System.Drawing.Size(53, 21);
            this.passhowLabel.TabIndex = 6;
            this.passhowLabel.Text = "label4";
            // 
            // usernamehowLabel
            // 
            this.usernamehowLabel.AutoSize = true;
            this.usernamehowLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamehowLabel.ForeColor = System.Drawing.Color.White;
            this.usernamehowLabel.Location = new System.Drawing.Point(253, 164);
            this.usernamehowLabel.Name = "usernamehowLabel";
            this.usernamehowLabel.Size = new System.Drawing.Size(53, 21);
            this.usernamehowLabel.TabIndex = 5;
            this.usernamehowLabel.Text = "label5";
            // 
            // nameshowLabel
            // 
            this.nameshowLabel.AutoSize = true;
            this.nameshowLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameshowLabel.ForeColor = System.Drawing.Color.White;
            this.nameshowLabel.Location = new System.Drawing.Point(253, 132);
            this.nameshowLabel.Name = "nameshowLabel";
            this.nameshowLabel.Size = new System.Drawing.Size(53, 21);
            this.nameshowLabel.TabIndex = 4;
            this.nameshowLabel.Text = "label6";
            // 
            // adminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.passhowLabel);
            this.Controls.Add(this.usernamehowLabel);
            this.Controls.Add(this.nameshowLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.profileLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminProfile";
            this.Text = "adminProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label passhowLabel;
        private System.Windows.Forms.Label usernamehowLabel;
        private System.Windows.Forms.Label nameshowLabel;
    }
}