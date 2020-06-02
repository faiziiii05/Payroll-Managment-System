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
namespace PayrollManagmentSystem.AdminForms
{
    public partial class adminProfile : Form
    {
        MySqlConnection connection;
        MySqlDataAdapter adapter;
        private static string userN, passW;
        public adminProfile()
        {
            InitializeComponent();
            string myconn = "SERVER=localhost;" + "DATABASE=payrollmanagmentsystem;" + "USERNAME=root;" + "PASSWORD=root;";
            connection = new MySqlConnection(myconn);
            DataTable dt = new DataTable();
            dt = getProfileInfo(userN, passW);
            showProfileInfo(dt);
        }
        public adminProfile(string user, string pass)
        {
            InitializeComponent();
            string myconn = "SERVER=localhost;" + "DATABASE=payrollmanagmentsystem;" + "USERNAME=root;" + "PASSWORD=root;";
            connection = new MySqlConnection(myconn);
            DataTable dt = new DataTable();
            userN = user;
            passW = pass;
            dt = getProfileInfo(user, pass);
            showProfileInfo(dt);
        }

        private void showProfileInfo(DataTable dt)
        {
            nameshowLabel.Text = dt.Rows[0]["name"].ToString();
            usernamehowLabel.Text =dt.Rows[0]["username"].ToString();
            passhowLabel.Text = dt.Rows[0]["password"].ToString();

        }

        /*DATABASE FUNCTIONS*/
        private DataTable getProfileInfo(string user, string pass)
        {
            string query = "SELECT * FROM `admin` WHERE username=\'" + user + "\' AND PASSWORD=\'" + pass + "\';";
            this.connection.Open();
            adapter = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            this.connection.Close();
            return dt;

        }
     
    }
}

