using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollManagmentSystem.AdminForms
{
    public partial class adminDelete : Form
    {
        db sql;
        DataTable dt;
        public adminDelete()
        {
            InitializeComponent();
            hideControls();
            dt = new DataTable();
            sql = new db();
        }
        private void hideControls()
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel10.Hide();
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();
            panel7.Hide();
            nameLabel.Hide();
            emailLabel.Hide();
            addLabel.Hide();
            CnLabel.Hide();
            jobLabel.Hide();
            dobLabel.Hide();
            salaryLabel.Hide();
            jDateLabel.Hide();
            departmanrLabel.Hide();
            msg.Hide();
            label2.Hide();
            label4.Hide();
            label7.Hide();
            label5.Hide();
            label15.Hide();
            label13.Hide();
            label9.Hide();
            label11.Hide();
            label6.Hide();


        }
        private void showControls()
        {
            panel1.Show();
            panel2.Show();
            panel3.Show();
            panel4.Show();
            panel10.Show();
            panel11.Show();
            panel12.Show();
            panel13.Show();
            nameLabel.Show();
            emailLabel.Show();
            addLabel.Show();
            CnLabel.Show();
            jobLabel.Show();
            dobLabel.Show();
            salaryLabel.Show();
            jDateLabel.Show();
            departmanrLabel.Show();
            label2.Show();
            label4.Show();
            label7.Show();
            label5.Show();
            label15.Show();
            label13.Show();
            label9.Show();
            label6.Show();
            panel7.Show();
            label11.Show();

        }

        private void employeeIDTextBox_Validated(object sender, EventArgs e)
        {
            iderror.SetError(employeeIDTextBox, null);
        }

        private void employeeIDTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (employeeIDTextBox.Text != "Employee ID")
            {
                if (sql.validateID(employeeIDTextBox.Text) != true)
                {
                    e.Cancel = true;
                    iderror.SetError(employeeIDTextBox, "ID not exist");
                    msg.Text = "ID not exist";
                    msg.Show();
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (employeeIDTextBox.Text != "Employee ID")
            {
                dt = sql.getSearchEmployeeData(employeeIDTextBox.Text);
                employeeIDTextBox.ReadOnly = true;
                searchBtn.Hide();
                msg.Hide();
                nameLabel.Text = dt.Rows[0]["emname"].ToString();
                emailLabel.Text = dt.Rows[0]["ememail"].ToString();
                CnLabel.Text = dt.Rows[0]["emcontact"].ToString();
                addLabel.Text = dt.Rows[0]["emadress"].ToString();
                jobLabel.Text = dt.Rows[0]["emjob"].ToString();
                salaryLabel.Text = dt.Rows[0]["emsalary"].ToString();
                dobLabel.Text = dt.Rows[0]["emdob"].ToString();
                jDateLabel.Text = dt.Rows[0]["emdate"].ToString();
                departmanrLabel.Text = dt.Rows[0]["emdepartment"].ToString();
                showControls();
                msg.Hide();

            }
            else
            {
                msg.Text = "Please Enter ID";
                msg.Show();
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (sql.DelEmployee(employeeIDTextBox.Text))    
                MessageBox.Show("Data Deleted Succssfully");          
            else
                MessageBox.Show("Data Deletation Failed");
        }

        private void employeeIDTextBox_MouseHover(object sender, EventArgs e)
        {
            employeeIDTextBox.Text = "";
        }

        private void employeeIDTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (employeeIDTextBox.Text == "")
            {
                employeeIDTextBox.Text = "Employee ID";
            }
        }

        private void searchBtn_MouseHover(object sender, EventArgs e)
        {
            searchBtn.BackColor = Color.Red;
        }

        private void searchBtn_MouseLeave(object sender, EventArgs e)
        {
            searchBtn.BackColor = Color.DarkSlateGray;
        }
    }
}
