namespace PayrollManagmentSystem
{
    partial class addemployee
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
            this.addbutton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.passwordPanelLine = new System.Windows.Forms.Panel();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.usernamePanelaLine = new System.Windows.Forms.Panel();
            this.employeenameTextBox = new System.Windows.Forms.TextBox();
            this.topHeaderPanel = new System.Windows.Forms.Panel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.NameSystem = new System.Windows.Forms.Label();
            this.personalinfobutton = new System.Windows.Forms.Button();
            this.jobinfobutton = new System.Windows.Forms.Button();
            this.passwordPictureBox = new System.Windows.Forms.PictureBox();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.crossPictureBox = new System.Windows.Forms.PictureBox();
            this.logoPicstureBox = new System.Windows.Forms.PictureBox();
            this.addemployeetextbox = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.topHeaderPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicstureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.MainPanel.Controls.Add(this.jobinfobutton);
            this.MainPanel.Controls.Add(this.personalinfobutton);
            this.MainPanel.Controls.Add(this.addbutton);
            this.MainPanel.Controls.Add(this.ErrorLabel);
            this.MainPanel.Controls.Add(this.passwordPanelLine);
            this.MainPanel.Controls.Add(this.employeeIDTextBox);
            this.MainPanel.Controls.Add(this.usernamePanelaLine);
            this.MainPanel.Controls.Add(this.passwordPictureBox);
            this.MainPanel.Controls.Add(this.employeenameTextBox);
            this.MainPanel.Controls.Add(this.userPictureBox);
            this.MainPanel.Controls.Add(this.topHeaderPanel);
            this.MainPanel.Controls.Add(this.loginLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(129, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(478, 450);
            this.MainPanel.TabIndex = 10;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // addbutton
            // 
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbutton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.Location = new System.Drawing.Point(74, 354);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(359, 37);
            this.addbutton.TabIndex = 25;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(68, 241);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(112, 31);
            this.ErrorLabel.TabIndex = 24;
            this.ErrorLabel.Text = "Message:";
            this.ErrorLabel.Click += new System.EventHandler(this.ErrorLabel_Click);
            // 
            // passwordPanelLine
            // 
            this.passwordPanelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordPanelLine.ForeColor = System.Drawing.Color.White;
            this.passwordPanelLine.Location = new System.Drawing.Point(74, 217);
            this.passwordPanelLine.Name = "passwordPanelLine";
            this.passwordPanelLine.Size = new System.Drawing.Size(359, 2);
            this.passwordPanelLine.TabIndex = 20;
            this.passwordPanelLine.Paint += new System.Windows.Forms.PaintEventHandler(this.passwordPanelLine_Paint);
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.employeeIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeIDTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDTextBox.ForeColor = System.Drawing.Color.White;
            this.employeeIDTextBox.Location = new System.Drawing.Point(125, 183);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(309, 25);
            this.employeeIDTextBox.TabIndex = 19;
            this.employeeIDTextBox.Text = "Employee ID";
            this.employeeIDTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // usernamePanelaLine
            // 
            this.usernamePanelaLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernamePanelaLine.ForeColor = System.Drawing.Color.White;
            this.usernamePanelaLine.Location = new System.Drawing.Point(74, 125);
            this.usernamePanelaLine.Name = "usernamePanelaLine";
            this.usernamePanelaLine.Size = new System.Drawing.Size(359, 2);
            this.usernamePanelaLine.TabIndex = 17;
            this.usernamePanelaLine.Paint += new System.Windows.Forms.PaintEventHandler(this.usernamePanelaLine_Paint);
            // 
            // employeenameTextBox
            // 
            this.employeenameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.employeenameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeenameTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeenameTextBox.ForeColor = System.Drawing.Color.White;
            this.employeenameTextBox.Location = new System.Drawing.Point(125, 94);
            this.employeenameTextBox.Name = "employeenameTextBox";
            this.employeenameTextBox.Size = new System.Drawing.Size(309, 25);
            this.employeenameTextBox.TabIndex = 16;
            this.employeenameTextBox.Text = "Employee Name";
            this.employeenameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // topHeaderPanel
            // 
            this.topHeaderPanel.Controls.Add(this.addemployeetextbox);
            this.topHeaderPanel.Controls.Add(this.minimizePictureBox);
            this.topHeaderPanel.Controls.Add(this.crossPictureBox);
            this.topHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.topHeaderPanel.Name = "topHeaderPanel";
            this.topHeaderPanel.Size = new System.Drawing.Size(478, 64);
            this.topHeaderPanel.TabIndex = 12;
            this.topHeaderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topHeaderPanel_Paint);
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
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.LeftPanel.Controls.Add(this.NameSystem);
            this.LeftPanel.Controls.Add(this.logoPicstureBox);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(129, 450);
            this.LeftPanel.TabIndex = 9;
            this.LeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftPanel_Paint);
            // 
            // NameSystem
            // 
            this.NameSystem.AutoSize = true;
            this.NameSystem.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSystem.ForeColor = System.Drawing.Color.White;
            this.NameSystem.Location = new System.Drawing.Point(12, 94);
            this.NameSystem.Name = "NameSystem";
            this.NameSystem.Size = new System.Drawing.Size(114, 27);
            this.NameSystem.TabIndex = 3;
            this.NameSystem.Text = "Akatsuki";
            this.NameSystem.Click += new System.EventHandler(this.NameSystem_Click);
            // 
            // personalinfobutton
            // 
            this.personalinfobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personalinfobutton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalinfobutton.ForeColor = System.Drawing.Color.White;
            this.personalinfobutton.Location = new System.Drawing.Point(74, 275);
            this.personalinfobutton.Name = "personalinfobutton";
            this.personalinfobutton.Size = new System.Drawing.Size(165, 37);
            this.personalinfobutton.TabIndex = 26;
            this.personalinfobutton.Text = "Personal Info";
            this.personalinfobutton.UseVisualStyleBackColor = false;
            this.personalinfobutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // jobinfobutton
            // 
            this.jobinfobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jobinfobutton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobinfobutton.ForeColor = System.Drawing.Color.White;
            this.jobinfobutton.Location = new System.Drawing.Point(269, 275);
            this.jobinfobutton.Name = "jobinfobutton";
            this.jobinfobutton.Size = new System.Drawing.Size(165, 37);
            this.jobinfobutton.TabIndex = 27;
            this.jobinfobutton.Text = "Job Info";
            this.jobinfobutton.UseVisualStyleBackColor = false;
            this.jobinfobutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // passwordPictureBox
            // 
            this.passwordPictureBox.Image = global::PayrollManagmentSystem.Properties.Resources.password;
            this.passwordPictureBox.Location = new System.Drawing.Point(74, 171);
            this.passwordPictureBox.Name = "passwordPictureBox";
            this.passwordPictureBox.Size = new System.Drawing.Size(45, 37);
            this.passwordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordPictureBox.TabIndex = 18;
            this.passwordPictureBox.TabStop = false;
            this.passwordPictureBox.Click += new System.EventHandler(this.passwordPictureBox_Click);
            // 
            // userPictureBox
            // 
            this.userPictureBox.Image = global::PayrollManagmentSystem.Properties.Resources.user;
            this.userPictureBox.Location = new System.Drawing.Point(74, 82);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(45, 37);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 15;
            this.userPictureBox.TabStop = false;
            this.userPictureBox.Click += new System.EventHandler(this.userPictureBox_Click);
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.Image = global::PayrollManagmentSystem.Properties.Resources.minimize;
            this.minimizePictureBox.Location = new System.Drawing.Point(364, 12);
            this.minimizePictureBox.Name = "minimizePictureBox";
            this.minimizePictureBox.Size = new System.Drawing.Size(32, 29);
            this.minimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizePictureBox.TabIndex = 5;
            this.minimizePictureBox.TabStop = false;
            this.minimizePictureBox.Click += new System.EventHandler(this.minimizePictureBox_Click);
            // 
            // crossPictureBox
            // 
            this.crossPictureBox.Image = global::PayrollManagmentSystem.Properties.Resources.cross;
            this.crossPictureBox.Location = new System.Drawing.Point(402, 12);
            this.crossPictureBox.Name = "crossPictureBox";
            this.crossPictureBox.Size = new System.Drawing.Size(32, 29);
            this.crossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.crossPictureBox.TabIndex = 4;
            this.crossPictureBox.TabStop = false;
            this.crossPictureBox.Click += new System.EventHandler(this.crossPictureBox_Click);
            // 
            // logoPicstureBox
            // 
            this.logoPicstureBox.Image = global::PayrollManagmentSystem.Properties.Resources._44c500d63004afab3b23ca608fc760ea;
            this.logoPicstureBox.Location = new System.Drawing.Point(12, 12);
            this.logoPicstureBox.Name = "logoPicstureBox";
            this.logoPicstureBox.Size = new System.Drawing.Size(102, 67);
            this.logoPicstureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicstureBox.TabIndex = 2;
            this.logoPicstureBox.TabStop = false;
            this.logoPicstureBox.Click += new System.EventHandler(this.logoPicstureBox_Click);
            // 
            // addemployeetextbox
            // 
            this.addemployeetextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.addemployeetextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addemployeetextbox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemployeetextbox.ForeColor = System.Drawing.Color.White;
            this.addemployeetextbox.Location = new System.Drawing.Point(10, 23);
            this.addemployeetextbox.Name = "addemployeetextbox";
            this.addemployeetextbox.Size = new System.Drawing.Size(229, 25);
            this.addemployeetextbox.TabIndex = 28;
            this.addemployeetextbox.Text = "Add Employee";
            // 
            // addemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "addemployee";
            this.Text = "addemployee";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.topHeaderPanel.ResumeLayout(false);
            this.topHeaderPanel.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicstureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Panel passwordPanelLine;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.Panel usernamePanelaLine;
        private System.Windows.Forms.TextBox employeenameTextBox;
        private System.Windows.Forms.Panel topHeaderPanel;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private System.Windows.Forms.PictureBox crossPictureBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label NameSystem;
        private System.Windows.Forms.PictureBox logoPicstureBox;
        private System.Windows.Forms.Button jobinfobutton;
        private System.Windows.Forms.Button personalinfobutton;
        private System.Windows.Forms.PictureBox passwordPictureBox;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.TextBox addemployeetextbox;
    }
}