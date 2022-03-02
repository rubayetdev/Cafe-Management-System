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
    public partial class Chef : Form
    {
        public Chef()
        {
            InitializeComponent();
        }
        private int id;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Chef_Load(object sender, EventArgs e)
        {
            GetChef();
        }
        private void GetChef()
        {
            MySqlConnection con = new MySqlConnection(function.ConnectionString());

            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM chef";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            con.Close();
            DataChef.DataSource = dt;
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO chef (Chef_ID, Chef_Name, Chef_Address, Chef_Phone) VALUES(@Chef_ID, @Chef_Name, @Chef_Address, @Chef_Phone)";
            cmd.Parameters.AddWithValue("@Chef_Id", txtid.Text);
            cmd.Parameters.AddWithValue("@Chef_Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Chef_Address", txtaddr.Text);
            cmd.Parameters.AddWithValue("@Chef_Phone", txtphn.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data successfully inserted.");

            GetChef();
            ResetFormData();
        }

        private void btnupd_Click(object sender, EventArgs e)
        {
            if (this.id != 0)
            {
                MySqlConnection con = new MySqlConnection(function.ConnectionString());
                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE chef SET Chef_Name = @Chef_Name, Chef_Address = @Chef_Address, Chef_Phone = @Chef_Phone Where Chef_ID = @Chef_ID";
                cmd.Parameters.AddWithValue("@Chef_ID", this.id);
                cmd.Parameters.AddWithValue("@Chef_Name", txtname.Text);
                cmd.Parameters.AddWithValue("@Chef_Address", txtaddr.Text);
                cmd.Parameters.AddWithValue("@Chef_Phone", txtphn.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data successfully updated.");
                GetChef();
                ResetFormData();
            }
            else
            {
                MessageBox.Show("Select a waiter.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnrmv_Click(object sender, EventArgs e)
        {
            if (this.id != 0)
            {
                MySqlConnection con = new MySqlConnection(function.ConnectionString());
                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM chef WHERE Chef_ID = @Chef_ID";
                cmd.Parameters.AddWithValue("@Chef_ID", this.id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Information is Deleted");
                GetChef();
                ResetFormData();
            }
            else
            {
                MessageBox.Show("Select a waiter.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnrst_Click(object sender, EventArgs e)
        {
            ResetFormData();
        }
        private void ResetFormData()
        {
            this.id = 0;
            txtid.Clear();
            txtname.Clear();
            txtaddr.Clear();
            txtphn.Clear();

        }

        private void DataChef_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                id = Convert.ToInt32(DataChef.SelectedRows[0].Cells[0].Value);
                txtid.Text = DataChef.SelectedRows[0].Cells[0].Value.ToString();
                txtname.Text = DataChef.SelectedRows[0].Cells[1].Value.ToString();
                txtaddr.Text = DataChef.SelectedRows[0].Cells[2].Value.ToString();
                txtphn.Text = DataChef.SelectedRows[0].Cells[3].Value.ToString();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard Ds = new Dashboard();
            this.Hide();
            Ds.Show();
        }
    }
}
