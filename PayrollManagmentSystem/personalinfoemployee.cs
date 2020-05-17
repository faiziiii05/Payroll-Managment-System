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
    public partial class personalinfoemployee : Form
    {
        public personalinfoemployee()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void returntoaddemployeepersonalinfoButton_Click(object sender, EventArgs e)
        {
            addemployee add = new addemployee();
            add.Show();
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
