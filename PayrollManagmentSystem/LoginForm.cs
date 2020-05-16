using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Authentication;

namespace PayrollManagmentSystem
{
    public partial class LoginForm : Form
    {
        MySqlConnection connection;
        DataSet ds;
        MySqlDataAdapter adapter;
        public LoginForm()
        {
            InitializeComponent();
            string myconn = "SERVER=localhost;" + "DATABASE=payrollmanagmentsystem;" + "USERNAME=root;" + "PASSWORD=root;";
            connection = new MySqlConnection(myconn);
            ErrorLabel.Hide();
            ErrorLabel.Text = "";
        }

        private void loginBtn_MouseEnter(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.FromArgb(20, 164, 179);
            loginBtn.ForeColor = Color.FromArgb(13, 85, 92);
        }

        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.FromArgb(13, 85, 92);
            loginBtn.ForeColor = Color.White;
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
                passwordTextBox.PasswordChar = '*';
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
                passwordTextBox.PasswordChar = '\0';
            }
        }


        private void showpas_CheckedChanged(object sender, EventArgs e)
        {
             if (showpas.Checked)
            {
                passwordTextBox.PasswordChar='\0';
            }
            else
            {
                if (passwordTextBox.Text == "")
                {
                    passwordTextBox.Text = ("Password");
                    passwordTextBox.PasswordChar = '\0';
                }
                else if (passwordTextBox.Text=="Password")
                {
                    passwordTextBox.PasswordChar = '\0';
                }
                else if (passwordTextBox.Text != "")
                {
                    passwordTextBox.PasswordChar = '*';
                }

            }
        }

        private void crossPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Username" || passwordTextBox.Text == "Password")
            {
                ErrorLabel.Text = "Please Fill the fields";
                ErrorLabel.Show();

            }
            else if (!(StaffRadio.Checked || adminRadio.Checked))
            {
                ErrorLabel.Text = "Please Select Role";
                ErrorLabel.Show();
            }
            // Fill Later
            if (StaffRadio.Checked)
            {

            }
            if (adminRadio.Checked)
            {
                try
                {
                    string validateQuery = "SELECT * FROM `admin` WHERE username=\'" + usernameTextBox.Text + "\' AND PASSWORD=\'" + passwordTextBox.Text + "\';";
                    connection.Open();
                    adapter = new MySqlDataAdapter(validateQuery, connection);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    int rows = ds.Tables[0].Rows.Count;
                    connection.Close();
                    if (rows==1)
                    {
                        // Admin Form Show
                        MessageBox.Show("Here");
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                }
        }
    }
}
