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

namespace Cafe_Management_System
{
    public partial class Cutomer : Form
    {
        public Cutomer()
        {
            InitializeComponent();
        }

        private void Cutomer_Load(object sender, EventArgs e)
        {
            AllItem();
        }
        private void AllItem()
        {
            MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM item";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            con.Close();
            ItemView.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO customer(Customers_Name, Customers_Phone) VALUES(@Customers_Name, @Customers_Phone)";
            //cmd.Parameters.AddWithValue("@Product_Id", lbId.Text);
            cmd.Parameters.AddWithValue("@Customers_Name", CusName.Text);
            cmd.Parameters.AddWithValue("@Customers_Phone", CusPhn.Text);

            cmd.ExecuteNonQuery();
            //Customer();
            con.Close();
            //ResetData();
            Order ff = new Order();
            ff.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // Order gf = new Order();
            //gf.Show();
           // this.Hide();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
