namespace PayrollManagmentSystem.AdminForms
{
    partial class AddEmployee
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.NameSystem = new System.Windows.Forms.Label();
            this.logoPicstureBox = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.topHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossPictureBox)).BeginInit();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicstureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.topHeaderPanel);
            this.MainPanel.Controls.Add(this.loginLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(164, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(636, 500);
            this.MainPanel.TabIndex = 8;
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
            this.LeftPanel.TabIndex = 7;
            // 
            // NameSystem
            // 
            this.NameSystem.AutoSize = true;
            this.NameSystem.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSystem.ForeColor = System.Drawing.Color.White;
            this.NameSystem.Location = new System.Drawing.Point(22, 97);
            this.NameSystem.Name = "NameSystem";
            this.NameSystem.Size = new System.Drawing.Size(114, 27);
            this.NameSystem.TabIndex = 3;
            this.NameSystem.Text = "Akatsuki";
            // 
            // logoPicstureBox
            // 
            this.logoPicstureBox.Image = global::PayrollManagmentSystem.Properties.Resources._44c500d63004afab3b23ca608fc760ea;
            this.logoPicstureBox.Location = new System.Drawing.Point(27, 12);
            this.logoPicstureBox.Name = "logoPicstureBox";
            this.logoPicstureBox.Size = new System.Drawing.Size(102, 75);
            this.logoPicstureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicstureBox.TabIndex = 2;
            this.logoPicstureBox.TabStop = false;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.topHeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossPictureBox)).EndInit();
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
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label NameSystem;
        private System.Windows.Forms.PictureBox logoPicstureBox;
    }
}