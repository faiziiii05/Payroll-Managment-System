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
namespace PayrollManagmentSystem
{
    public partial class adminForm : Form
    {
        MySqlConnection connection;
        DataSet ds;
        DataTable dt;
        MySqlDataAdapter adapter;
        private string user, pass;
        public adminForm()
        {
            InitializeComponent();
            string myconn = "SERVER=localhost;" + "DATABASE=payrollmanagmentsystem;" + "USERNAME=root;" + "PASSWORD=root;";
            connection = new MySqlConnection(myconn);
            changeTheFormPanel(new AdminForms.adminProfile(user, pass));
        }
        public adminForm(string username, string password)
        {
            InitializeComponent();
            string myconn = "SERVER=localhost;" + "DATABASE=payrollmanagmentsystem;" + "USERNAME=root;" + "PASSWORD=root;";
            connection = new MySqlConnection(myconn);
            user = username;
            pass = password;
            changeTheFormPanel(new AdminForms.adminProfile(username, password));

        }

        private void changeTheFormPanel(object form)
        {
            Form obj = form as Form;
            obj.Dock = DockStyle.Fill;
            obj.TopLevel = false;
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(obj);
            obj.Show();
        }
        private void NameSystem_Click(object sender, EventArgs e)
        {

        }

      

        private void minimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void crossPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (leftPanel.Width == 232)
            {
                logoPicstureBox.Hide();
                NameSystem.Hide();
                leftPanel.Width = 61;
            }
            else
            {
                logoPicstureBox.Show();
                NameSystem.Show();
                leftPanel.Width = 232;
            }
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            changeTheFormPanel(new AdminForms.adminProfile(user,pass));
        }

        private void SearchEmployee_Click(object sender, EventArgs e)
        {
            changeTheFormPanel(new AdminForms.adminSearch());
        }

        private void DelEmployee_Click(object sender, EventArgs e)
        {
            changeTheFormPanel(new AdminForms.adminDelete());
        }

        private void signoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm obj = new LoginForm();
            obj.Show();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            changeTheFormPanel(new AdminForms.addEmployee());
        }
    }
}
