namespace PayrollManagmentSystem
{
    partial class LoginForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.topHeaderPanel = new System.Windows.Forms.Panel();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.crossPictureBox = new System.Windows.Forms.PictureBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.adminRadio = new System.Windows.Forms.RadioButton();
            this.StaffRadio = new System.Windows.Forms.RadioButton();
            this.roleLabel = new System.Windows.Forms.Label();
            this.passwordPanelLine = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernamePanelaLine = new System.Windows.Forms.Panel();
            this.passwordPictureBox = new System.Windows.Forms.PictureBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.NameSystem = new System.Windows.Forms.Label();
            this.logoPicstureBox = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.topHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicstureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.topHeaderPanel);
            this.MainPanel.Controls.Add(this.loginBtn);
            this.MainPanel.Controls.Add(this.ErrorLabel);
            this.MainPanel.Controls.Add(this.adminRadio);
            this.MainPanel.Controls.Add(this.StaffRadio);
            this.MainPanel.Controls.Add(this.roleLabel);
            this.MainPanel.Controls.Add(this.passwordPanelLine);
            this.MainPanel.Controls.Add(this.passwordTextBox);
            this.MainPanel.Controls.Add(this.usernamePanelaLine);
            this.MainPanel.Controls.Add(this.passwordPictureBox);
            this.MainPanel.Controls.Add(this.usernameTextBox);
            this.MainPanel.Controls.Add(this.userPictureBox);
            this.MainPanel.Controls.Add(this.loginLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(164, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(636, 500);
            this.MainPanel.TabIndex = 4;
            // 
            // topHeaderPanel
            // 
            this.topHeaderPanel.Controls.Add(this.minimizePictureBox);
            this.topHeaderPanel.Controls.Add(this.crossPictureBox);
            this.topHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.topHeaderPanel.Name = "topHeaderPanel";
            this.topHeaderPanel.Size = new System.Drawing.Size(636, 64);
            this.topHeaderPanel.TabIndex = 12;
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.Image = global::PayrollManagmentSystem.Properties.Resources.minimize;
            this.minimizePictureBox.Location = new System.Drawing.Point(563, 3);
            this.minimizePictureBox.Name = "minimizePictureBox";
            this.minimizePictureBox.Size = new System.Drawing.Size(32, 29);
            this.minimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizePictureBox.TabIndex = 5;
            this.minimizePictureBox.TabStop = false;
            // 
            // crossPictureBox
            // 
            this.crossPictureBox.Image = global::PayrollManagmentSystem.Properties.Resources.cross;
            this.crossPictureBox.Location = new System.Drawing.Point(601, 3);
            this.crossPictureBox.Name = "crossPictureBox";
            this.crossPictureBox.Size = new System.Drawing.Size(32, 29);
            this.crossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.crossPictureBox.TabIndex = 4;
            this.crossPictureBox.TabStop = false;
            // 
            // loginBtn
            // 
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(105, 370);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(359, 37);
            this.loginBtn.TabIndex = 11;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.MouseEnter += new System.EventHandler(this.loginBtn_MouseEnter);
            this.loginBtn.MouseLeave += new System.EventHandler(this.loginBtn_MouseLeave);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(99, 309);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(112, 31);
            this.ErrorLabel.TabIndex = 10;
            this.ErrorLabel.Text = "Message:";
            // 
            // adminRadio
            // 
            this.adminRadio.AutoSize = true;
            this.adminRadio.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRadio.ForeColor = System.Drawing.Color.White;
            this.adminRadio.Location = new System.Drawing.Point(344, 261);
            this.adminRadio.Name = "adminRadio";
            this.adminRadio.Size = new System.Drawing.Size(87, 28);
            this.adminRadio.TabIndex = 9;
            this.adminRadio.TabStop = true;
            this.adminRadio.Text = "Admin";
            this.adminRadio.UseVisualStyleBackColor = true;
            // 
            // StaffRadio
            // 
            this.StaffRadio.AutoSize = true;
            this.StaffRadio.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffRadio.ForeColor = System.Drawing.Color.White;
            this.StaffRadio.Location = new System.Drawing.Point(233, 261);
            this.StaffRadio.Name = "StaffRadio";
            this.StaffRadio.Size = new System.Drawing.Size(72, 28);
            this.StaffRadio.TabIndex = 8;
            this.StaffRadio.TabStop = true;
            this.StaffRadio.Text = "Staff";
            this.StaffRadio.UseVisualStyleBackColor = true;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.ForeColor = System.Drawing.Color.Red;
            this.roleLabel.Location = new System.Drawing.Point(108, 257);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(72, 31);
            this.roleLabel.TabIndex = 7;
            this.roleLabel.Text = "Role:";
            // 
            // passwordPanelLine
            // 
            this.passwordPanelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordPanelLine.ForeColor = System.Drawing.Color.White;
            this.passwordPanelLine.Location = new System.Drawing.Point(105, 232);
            this.passwordPanelLine.Name = "passwordPanelLine";
            this.passwordPanelLine.Size = new System.Drawing.Size(359, 2);
            this.passwordPanelLine.TabIndex = 6;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(155, 198);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(309, 25);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.Text = "Password";
            // 
            // usernamePanelaLine
            // 
            this.usernamePanelaLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernamePanelaLine.ForeColor = System.Drawing.Color.White;
            this.usernamePanelaLine.Location = new System.Drawing.Point(105, 143);
            this.usernamePanelaLine.Name = "usernamePanelaLine";
            this.usernamePanelaLine.Size = new System.Drawing.Size(359, 2);
            this.usernamePanelaLine.TabIndex = 3;
            // 
            // passwordPictureBox
            // 
            this.passwordPictureBox.Image = global::PayrollManagmentSystem.Properties.Resources.password;
            this.passwordPictureBox.Location = new System.Drawing.Point(104, 189);
            this.passwordPictureBox.Name = "passwordPictureBox";
            this.passwordPictureBox.Size = new System.Drawing.Size(45, 37);
            this.passwordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordPictureBox.TabIndex = 4;
            this.passwordPictureBox.TabStop = false;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.White;
            this.usernameTextBox.Location = new System.Drawing.Point(155, 109);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(309, 25);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.Text = "Username";
            // 
            // userPictureBox
            // 
            this.userPictureBox.Image = global::PayrollManagmentSystem.Properties.Resources.user;
            this.userPictureBox.Location = new System.Drawing.Point(104, 100);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(45, 37);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 1;
            this.userPictureBox.TabStop = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(190, 17);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(82, 31);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.NameSystem);
            this.LeftPanel.Controls.Add(this.logoPicstureBox);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(164, 500);
            this.LeftPanel.TabIndex = 3;
            // 
            // NameSystem
            // 
            this.NameSystem.AutoSize = true;
            this.NameSystem.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSystem.ForeColor = System.Drawing.Color.White;
            this.NameSystem.Location = new System.Drawing.Point(12, 246);
            this.NameSystem.Name = "NameSystem";
            this.NameSystem.Size = new System.Drawing.Size(141, 27);
            this.NameSystem.TabIndex = 3;
            this.NameSystem.Text = "Hidden Leaf";
            // 
            // logoPicstureBox
            // 
            this.logoPicstureBox.Image = global::PayrollManagmentSystem.Properties.Resources.cross;
            this.logoPicstureBox.Location = new System.Drawing.Point(27, 159);
            this.logoPicstureBox.Name = "logoPicstureBox";
            this.logoPicstureBox.Size = new System.Drawing.Size(102, 75);
            this.logoPicstureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicstureBox.TabIndex = 2;
            this.logoPicstureBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.topHeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicstureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel topHeaderPanel;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private System.Windows.Forms.PictureBox crossPictureBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.RadioButton adminRadio;
        private System.Windows.Forms.RadioButton StaffRadio;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Panel passwordPanelLine;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Panel usernamePanelaLine;
        private System.Windows.Forms.PictureBox passwordPictureBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label NameSystem;
        private System.Windows.Forms.PictureBox logoPicstureBox;
    }
}