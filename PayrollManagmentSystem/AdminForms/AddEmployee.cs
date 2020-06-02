using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollManagmentSystem.AdminForms
{
    public partial class addEmployee : Form
    {
        db sql;
        
        public addEmployee()
        {
            InitializeComponent();
            sql = new db();
            ErrorLabel.Hide();
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


        // Cancel Button Function
        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (employeeIDTextBox.Text!="Employee ID"|| employeenameTextBox.Text!="Employee Name"||
                emailTextBox.Text !="Email"|| contactTextBox.Text!= "Contact Number"
                    || addressTextBox.Text!="Address"||dobTextBox.Text!="Date Of Birth"
                    || jobtitleTextBox.Text!="Job title"||departmentTextBox.Text!="Department"
                    ||salaryTextBox.Text!="Salary"||startdateTextBox.Text!="Joining Date" )
                {
                DialogResult res = MessageBox.Show("You want to cancel the operation?", "UnSaved Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    changeTheFormPanel(new AdminForms.adminProfile());
                }
                else
                    return;
            }
        }

        // Save Button Function
        private void savepersonalinfoButton_Click(object sender, EventArgs e)
        {
            if (employeeIDTextBox.Text != "Employee ID" && employeenameTextBox.Text != "Employee Name" &&
               emailTextBox.Text != "Email" && contactTextBox.Text != "Contact Number"
                   && addressTextBox.Text != "Address" && dobTextBox.Text != "Date Of Birth"
                   && jobtitleTextBox.Text != "Job title" && departmentTextBox.Text != "Department"
                   && salaryTextBox.Text != "Salary" && startdateTextBox.Text != "Joining Date")
            {
                string emID = employeeIDTextBox.Text;
                string emName = employeenameTextBox.Text;
                string emEmail = emailTextBox.Text;
                string emCon = contactTextBox.Text;
                string emAd = addressTextBox.Text;
                string emDOB = dobTextBox.Text;
                string emJob = jobtitleTextBox.Text;
                string emDep = departmentTextBox.Text;
                string emSal = salaryTextBox.Text;
                string emDate = startdateTextBox.Text;

               if ( sql.InsertEmployee(emID,emName,emEmail,emCon,emAd,emDOB,emJob,emDep,emSal,emDate)==true)
                {
                    MessageBox.Show("Data Insert Successfully", "Data Inserted");
                }
               else
                {
                    MessageBox.Show("Data Insertion Failed", "Failed");
                    changeTheFormPanel(new AdminForms.adminProfile());
                }
            }
            else
            {
                ErrorLabel.Text = "Please Fill all the field";
                ErrorLabel.Show();
            }
        }
        private void employeeIDTextBox_Validated(object sender, EventArgs e)
        {
            iderror.SetError(employeeIDTextBox, null);
        }

        private void employeeIDTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (sql.validateID(employeeIDTextBox.Text) == true)
            {
                e.Cancel = true;
                iderror.SetError(employeeIDTextBox, "ID already exist");
            }
        }
    }
}
