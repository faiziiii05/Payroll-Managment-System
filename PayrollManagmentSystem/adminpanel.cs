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
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
        }

        private void NameSystem_Click(object sender, EventArgs e)
        {

        }

        private void searchemployeebutton1_Click(object sender, EventArgs e)
        {
            searchemployee search = new searchemployee();
            search.Show();
        }

        private void addemployeebutton1_Click(object sender, EventArgs e)
        {
            addemployee add = new addemployee();
            add.Show();
        }

        private void removeeployeeButton1_Click(object sender, EventArgs e)
        {
            removeemployee remove = new removeemployee();
            remove.Show();
        }

        private void minimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void crossPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
