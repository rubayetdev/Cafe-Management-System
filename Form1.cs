using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cafe_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cutomer ds = new Cutomer();
            ds.Show();
            this.Hide();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if(txtSing.Text == "BUBT" && txtPass.Text == "NIR")
         
            {
                Dashboard ds = new Dashboard("Admin");
                ds.Show();
                this.Hide();
            }

            else
            {
               // MessageBox.Show("Hi", "Waring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Have a relex!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = (checkBox1.Checked ? char.MinValue : '*');
        
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
