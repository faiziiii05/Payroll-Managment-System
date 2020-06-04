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
                    changeTheFormPanel(new AdminForms.adminProfile());
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

        private void employeeIDTextBox_MouseHover(object sender, EventArgs e)
        {
            employeeIDTextBox.Text = "";
        }

        private void employeeIDTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (employeeIDTextBox.Text == "")
            {
                employeeIDTextBox.Text = "EmployeeID";
            }
        }

        private void employeenameTextBox_MouseHover(object sender, EventArgs e)
        {
            employeenameTextBox.Text = "";
        }

        private void employeenameTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (employeenameTextBox.Text == "")
            {
                employeenameTextBox.Text = "Employee Name";
            }
        }

        private void emailTextBox_MouseHover(object sender, EventArgs e)
        {
            emailTextBox.Text = "";
        }

        private void emailTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                emailTextBox.Text = "Email";
            }
        }

        private void contactTextBox_MouseHover(object sender, EventArgs e)
        {
            contactTextBox.Text = "";
        }

        private void contactTextBox_MouseLeave(object sender, EventArgs e)
        {
            if(contactTextBox.Text == "")
            {
                contactTextBox.Text = "Contact Number";
            }
        }

        private void addressTextBox_MouseHover(object sender, EventArgs e)
        {
            addressTextBox.Text = "";
        }

        private void addressTextBox_MouseLeave(object sender, EventArgs e)
        {
            if(addressTextBox.Text == "")
            {
                addressTextBox.Text = "Address";
            }
        }

        private void dobTextBox_MouseHover(object sender, EventArgs e)
        {
            dobTextBox.Text = "";
        }

        private void dobTextBox_MouseLeave(object sender, EventArgs e)
        {
            if(dobTextBox.Text == "")
            {
                dobTextBox.Text = "Date Of Birth";
            }
        }

        private void jobtitleTextBox_MouseHover(object sender, EventArgs e)
        {
            jobtitleTextBox.Text = "";
        }

        private void jobtitleTextBox_MouseLeave(object sender, EventArgs e)
        {
            if(jobtitleTextBox.Text == "")
            {
                jobtitleTextBox.Text = "Job Title";
            }
        }

        private void departmentTextBox_MouseHover(object sender, EventArgs e)
        {
            departmentTextBox.Text = "";
        }

        private void departmentTextBox_MouseLeave(object sender, EventArgs e)
        {
            if(departmentTextBox.Text == "")
            {
                departmentTextBox.Text = "Department";
            }
        }

        private void salaryTextBox_MouseHover(object sender, EventArgs e)
        {
            salaryTextBox.Text = "";
        }

        private void salaryTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (salaryTextBox.Text == "")
            {
                salaryTextBox.Text = "Salary"; 
            }
        }

        private void startdateTextBox_MouseHover(object sender, EventArgs e)
        {
            startdateTextBox.Text = "";
        }

        private void startdateTextBox_MouseLeave(object sender, EventArgs e)
        {
            if(startdateTextBox.Text == "")
            {
                startdateTextBox.Text = "Joinig Date";
            }
        }

        private void savepersonalinfoButton_MouseHover(object sender, EventArgs e)
        {
            savepersonalinfoButton.BackColor = Color.Red;
        }

        private void savepersonalinfoButton_MouseLeave(object sender, EventArgs e)
        {
            savepersonalinfoButton.BackColor = Color.DarkSlateGray;
        }

        private void CancelButton_MouseHover(object sender, EventArgs e)
        {
            CancelButton.BackColor = Color.Red;
        }

        private void CancelButton_MouseLeave(object sender, EventArgs e)
        {
            CancelButton.BackColor = Color.DarkSlateGray;
        }
    }
}
