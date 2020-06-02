namespace PayrollManagmentSystem
{
    partial class adminForm
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.NameSystem = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.crossPictureBox = new System.Windows.Forms.PictureBox();
            this.signoutBtn = new System.Windows.Forms.Button();
            this.DelEmployee = new System.Windows.Forms.Button();
            this.SearchEmployee = new System.Windows.Forms.Button();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.logoPicstureBox = new System.Windows.Forms.PictureBox();
            this.leftPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicstureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.signoutBtn);
            this.leftPanel.Controls.Add(this.DelEmployee);
            this.leftPanel.Controls.Add(this.SearchEmployee);
            this.leftPanel.Controls.Add(this.AddEmployee);
            this.leftPanel.Controls.Add(this.profileBtn);
            this.leftPanel.Controls.Add(this.NameSystem);
            this.leftPanel.Controls.Add(this.logoPicstureBox);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(232, 550);
            this.leftPanel.TabIndex = 0;
            // 
            // NameSystem
            // 
            this.NameSystem.AutoSize = true;
            this.NameSystem.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSystem.ForeColor = System.Drawing.Color.White;
            this.NameSystem.Location = new System.Drawing.Point(54, 105);
            this.NameSystem.Name = "NameSystem";
            this.NameSystem.Size = new System.Drawing.Size(114, 27);
            this.NameSystem.TabIndex = 34;
            this.NameSystem.Text = "Akatsuki";
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.AdminLabel);
            this.topPanel.Controls.Add(this.minimizePictureBox);
            this.topPanel.Controls.Add(this.crossPictureBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(232, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(668, 55);
            this.topPanel.TabIndex = 0;
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel.ForeColor = System.Drawing.Color.White;
            this.AdminLabel.Location = new System.Drawing.Point(57, 12);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(110, 36);
            this.AdminLabel.TabIndex = 0;
            this.AdminLabel.Text = "Admin";
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.ForeColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(232, 55);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(668, 495);
            this.mainPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PayrollManagmentSystem.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.Image = global::PayrollManagmentSystem.Properties.Resources.minimize;
            this.minimizePictureBox.Location = new System.Drawing.Point(586, 3);
            this.minimizePictureBox.Name = "minimizePictureBox";
            this.minimizePictureBox.Size = new System.Drawing.Size(32, 29);
            this.minimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizePictureBox.TabIndex = 38;
            this.minimizePictureBox.TabStop = false;
            this.minimizePictureBox.Click += new System.EventHandler(this.minimizePictureBox_Click);
            // 
            // crossPictureBox
            // 
            this.crossPictureBox.Image = global::PayrollManagmentSystem.Properties.Resources.cross;
            this.crossPictureBox.Location = new System.Drawing.Point(624, 3);
            this.crossPictureBox.Name = "crossPictureBox";
            this.crossPictureBox.Size = new System.Drawing.Size(32, 29);
            this.crossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.crossPictureBox.TabIndex = 37;
            this.crossPictureBox.TabStop = false;
            this.crossPictureBox.Click += new System.EventHandler(this.crossPictureBox_Click);
            // 
            // signoutBtn
            // 
            this.signoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.signoutBtn.FlatAppearance.BorderSize = 0;
            this.signoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signoutBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signoutBtn.ForeColor = System.Drawing.Color.White;
            this.signoutBtn.Image = global::PayrollManagmentSystem.Properties.Resources.outsign;
            this.signoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signoutBtn.Location = new System.Drawing.Point(3, 412);
            this.signoutBtn.Name = "signoutBtn";
            this.signoutBtn.Size = new System.Drawing.Size(229, 49);
            this.signoutBtn.TabIndex = 45;
            this.signoutBtn.Text = "SIGN OUT";
            this.signoutBtn.UseVisualStyleBackColor = false;
            this.signoutBtn.Click += new System.EventHandler(this.signoutBtn_Click);
            // 
            // DelEmployee
            // 
            this.DelEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.DelEmployee.FlatAppearance.BorderSize = 0;
            this.DelEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelEmployee.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelEmployee.ForeColor = System.Drawing.Color.White;
            this.DelEmployee.Image = global::PayrollManagmentSystem.Properties.Resources.removesign;
            this.DelEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DelEmployee.Location = new System.Drawing.Point(3, 344);
            this.DelEmployee.Name = "DelEmployee";
            this.DelEmployee.Size = new System.Drawing.Size(229, 49);
            this.DelEmployee.TabIndex = 44;
            this.DelEmployee.Text = "REMOVE";
            this.DelEmployee.UseVisualStyleBackColor = false;
            this.DelEmployee.Click += new System.EventHandler(this.DelEmployee_Click);
            // 
            // SearchEmployee
            // 
            this.SearchEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.SearchEmployee.FlatAppearance.BorderSize = 0;
            this.SearchEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchEmployee.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEmployee.ForeColor = System.Drawing.Color.White;
            this.SearchEmployee.Image = global::PayrollManagmentSystem.Properties.Resources.searchuser;
            this.SearchEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchEmployee.Location = new System.Drawing.Point(3, 269);
            this.SearchEmployee.Name = "SearchEmployee";
            this.SearchEmployee.Size = new System.Drawing.Size(226, 49);
            this.SearchEmployee.TabIndex = 43;
            this.SearchEmployee.Text = "SEARCH";
            this.SearchEmployee.UseVisualStyleBackColor = false;
            this.SearchEmployee.Click += new System.EventHandler(this.SearchEmployee_Click);
            // 
            // AddEmployee
            // 
            this.AddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.AddEmployee.FlatAppearance.BorderSize = 0;
            this.AddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployee.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee.ForeColor = System.Drawing.Color.White;
            this.AddEmployee.Image = global::PayrollManagmentSystem.Properties.Resources.adduser;
            this.AddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddEmployee.Location = new System.Drawing.Point(3, 200);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(232, 49);
            this.AddEmployee.TabIndex = 42;
            this.AddEmployee.Text = "ADD EMPLOYEE";
            this.AddEmployee.UseVisualStyleBackColor = false;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.Image = global::PayrollManagmentSystem.Properties.Resources.asddsa;
            this.profileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.Location = new System.Drawing.Point(3, 143);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(229, 41);
            this.profileBtn.TabIndex = 41;
            this.profileBtn.Text = "PROFILE";
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // logoPicstureBox
            // 
            this.logoPicstureBox.Image = global::PayrollManagmentSystem.Properties.Resources._44c500d63004afab3b23ca608fc760ea;
            this.logoPicstureBox.Location = new System.Drawing.Point(30, 19);
            this.logoPicstureBox.Name = "logoPicstureBox";
            this.logoPicstureBox.Size = new System.Drawing.Size(138, 83);
            this.logoPicstureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicstureBox.TabIndex = 33;
            this.logoPicstureBox.TabStop = false;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminpanel";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicstureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private System.Windows.Forms.PictureBox crossPictureBox;
        private System.Windows.Forms.Label NameSystem;
        private System.Windows.Forms.PictureBox logoPicstureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Button DelEmployee;
        private System.Windows.Forms.Button SearchEmployee;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button signoutBtn;
    }
}