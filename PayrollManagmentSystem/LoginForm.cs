using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollManagmentSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_MouseEnter(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.FromArgb(20, 164, 179);
            loginBtn.ForeColor = Color.FromArgb(13, 85, 92);
        }

        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.FromArgb(13, 85, 92);
            loginBtn.ForeColor = Color.FromArgb(20, 164, 179);
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_MouseEnter(object sender, EventArgs e)
        {
           if( usernameTextBox.Text == "Username" )
            {
                usernameTextBox.Text = ("");
            }
        }

        private void passwordTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = ("");
            }
        }

        private void usernameTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {
                usernameTextBox.Text = ("Username");
            }
        }
        private void passwordTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = ("Password");
            }
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showpas_Click(object sender, EventArgs e)
        {

        }

        private void showpas_CheckedChanged(object sender, EventArgs e)
        {
             if (showpas.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
             else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
