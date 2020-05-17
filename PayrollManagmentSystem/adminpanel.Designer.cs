namespace PayrollManagmentSystem
{
    partial class adminpanel
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
            this.adminpaneltextbox = new System.Windows.Forms.TextBox();
            this.removeeployeeButton1 = new System.Windows.Forms.Button();
            this.topHeaderPanel = new System.Windows.Forms.Panel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.NameSystem = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.searchemployeebutton1 = new System.Windows.Forms.Button();
            this.addemployeebutton1 = new System.Windows.Forms.Button();
            this.logoPicstureBox = new System.Windows.Forms.PictureBox();
            this.passwordPictureBox = new System.Windows.Forms.PictureBox();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.crossPictureBox = new System.Windows.Forms.PictureBox();
            this.topHeaderPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicstureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // adminpaneltextbox
            // 
            this.adminpaneltextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.adminpaneltextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminpaneltextbox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminpaneltextbox.ForeColor = System.Drawing.Color.White;
            this.adminpaneltextbox.Location = new System.Drawing.Point(190, 23);
            this.adminpaneltextbox.Name = "adminpaneltextbox";
            this.adminpaneltextbox.Size = new System.Drawing.Size(136, 25);
            this.adminpaneltextbox.TabIndex = 18;
            this.adminpaneltextbox.Text = "Admin Panel";
            // 
            // removeeployeeButton1
            // 
            this.removeeployeeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeeployeeButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeeployeeButton1.ForeColor = System.Drawing.Color.White;
            this.removeeployeeButton1.Location = new System.Drawing.Point(12, 305);
            this.removeeployeeButton1.Name = "removeeployeeButton1";
            this.removeeployeeButton1.Size = new System.Drawing.Size(114, 59);
            this.removeeployeeButton1.TabIndex = 25;
            this.removeeployeeButton1.Text = "Remove Employee";
            this.removeeployeeButton1.UseVisualStyleBackColor = false;
            this.removeeployeeButton1.Click += new System.EventHandler(this.removeeployeeButton1_Click);
            // 
            // topHeaderPanel
            // 
            this.topHeaderPanel.Controls.Add(this.adminpaneltextbox);
            this.topHeaderPanel.Controls.Add(this.minimizePictureBox);
            this.topHeaderPanel.Controls.Add(this.crossPictureBox);
            this.topHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.topHeaderPanel.Name = "topHeaderPanel";
            this.topHeaderPanel.Size = new System.Drawing.Size(610, 64);
            this.topHeaderPanel.TabIndex = 12;
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
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.LeftPanel.Controls.Add(this.addemployeebutton1);
            this.LeftPanel.Controls.Add(this.searchemployeebutton1);
            this.LeftPanel.Controls.Add(this.removeeployeeButton1);
            this.LeftPanel.Controls.Add(this.NameSystem);
            this.LeftPanel.Controls.Add(this.logoPicstureBox);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(140, 450);
            this.LeftPanel.TabIndex = 11;
            // 
            // NameSystem
            // 
            this.NameSystem.AutoSize = true;
            this.NameSystem.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSystem.ForeColor = System.Drawing.Color.White;
            this.NameSystem.Location = new System.Drawing.Point(12, 92);
            this.NameSystem.Name = "NameSystem";
            this.NameSystem.Size = new System.Drawing.Size(114, 27);
            this.NameSystem.TabIndex = 3;
            this.NameSystem.Text = "Akatsuki";
            this.NameSystem.Click += new System.EventHandler(this.NameSystem_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.MainPanel.Controls.Add(this.passwordPictureBox);
            this.MainPanel.Controls.Add(this.userPictureBox);
            this.MainPanel.Controls.Add(this.topHeaderPanel);
            this.MainPanel.Controls.Add(this.loginLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(610, 450);
            this.MainPanel.TabIndex = 12;
            // 
            // searchemployeebutton1
            // 
            this.searchemployeebutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchemployeebutton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchemployeebutton1.ForeColor = System.Drawing.Color.White;
            this.searchemployeebutton1.Location = new System.Drawing.Point(12, 149);
            this.searchemployeebutton1.Name = "searchemployeebutton1";
            this.searchemployeebutton1.Size = new System.Drawing.Size(114, 59);
            this.searchemployeebutton1.TabIndex = 26;
            this.searchemployeebutton1.Text = "Search Employee";
            this.searchemployeebutton1.UseVisualStyleBackColor = false;
            this.searchemployeebutton1.Click += new System.EventHandler(this.searchemployeebutton1_Click);
            // 
            // addemployeebutton1
            // 
            this.addemployeebutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addemployeebutton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemployeebutton1.ForeColor = System.Drawing.Color.White;
            this.addemployeebutton1.Location = new System.Drawing.Point(12, 227);
            this.addemployeebutton1.Name = "addemployeebutton1";
            this.addemployeebutton1.Size = new System.Drawing.Size(114, 59);
            this.addemployeebutton1.TabIndex = 27;
            this.addemployeebutton1.Text = "Add Employee";
            this.addemployeebutton1.UseVisualStyleBackColor = false;
            this.addemployeebutton1.Click += new System.EventHandler(this.addemployeebutton1_Click);
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
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.Image = global::PayrollManagmentSystem.Properties.Resources.minimize;
            this.minimizePictureBox.Location = new System.Drawing.Point(522, 17);
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
            this.crossPictureBox.Location = new System.Drawing.Point(560, 17);
            this.crossPictureBox.Name = "crossPictureBox";
            this.crossPictureBox.Size = new System.Drawing.Size(32, 29);
            this.crossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.crossPictureBox.TabIndex = 4;
            this.crossPictureBox.TabStop = false;
            this.crossPictureBox.Click += new System.EventHandler(this.crossPictureBox_Click);
            // 
            // adminpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.MainPanel);
            this.Name = "adminpanel";
            this.Text = "adminpanel";
            this.topHeaderPanel.ResumeLayout(false);
            this.topHeaderPanel.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicstureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox adminpaneltextbox;
        private System.Windows.Forms.Button removeeployeeButton1;
        private System.Windows.Forms.Panel topHeaderPanel;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private System.Windows.Forms.PictureBox crossPictureBox;
        private System.Windows.Forms.PictureBox passwordPictureBox;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label NameSystem;
        private System.Windows.Forms.PictureBox logoPicstureBox;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button addemployeebutton1;
        private System.Windows.Forms.Button searchemployeebutton1;
    }
}