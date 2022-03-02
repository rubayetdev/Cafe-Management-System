
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(String user)
        {
            InitializeComponent();
            if (user == "Guest")
            {
                btnAdd.Hide();
                btnOut.Hide();
                btnChef.Hide();
                btnOrder.Hide();
                btnEmp.Hide();
            }
            else if(user == "Admin")
            {
                btnAdd.Show();
                
                btnChef.Show();
                btnOrder.Show();
                btnEmp.Show();
            }
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Item ad = new Add_Item ();
            ad.Show();
            this.Hide();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            Employe ep = new Employe();
            ep.Show();
            this.Hide();
        }

        private void btnALL_Click(object sender, EventArgs e)
        {
            All_Item al = new All_Item();
            al.Show();
            this.Hide();
        }

        

        private void btnChef_Click(object sender, EventArgs e)
        {
            Chef cf = new Chef();
            cf.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Cutomer or = new Cutomer();
            or.Show();
            this.Hide();
        }
    }
}
