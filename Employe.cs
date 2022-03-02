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
    public partial class Employe : Form
    {
        public Employe()
        {
            InitializeComponent();
        }
        private int id;
        private void DataEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32 (DataEmployee.SelectedRows[0].Cells[0].Value);
            txtid.Text = DataEmployee.SelectedRows[0].Cells[0].Value.ToString();
           txtname.Text = DataEmployee.SelectedRows[0].Cells[1].Value.ToString();
            txtaddr.Text = DataEmployee.SelectedRows[0].Cells[2].Value.ToString();
            txtphn.Text = DataEmployee.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Employe_Load(object sender, EventArgs e)
        {
            GetEmployee();
        }
        private void GetEmployee()
        {
            MySqlConnection con = new MySqlConnection(function.ConnectionString());

            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM waiters";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            con.Close();
            DataEmployee.DataSource = dt;
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO waiters (Wait_Id, Wait_Name, Wait_Address, Wait_Phone) VALUES(@Wait_Id, @Wait_Name, @Wait_Address, @Wait_Phone)";
            cmd.Parameters.AddWithValue("@Wait_Id", txtid.Text);
            cmd.Parameters.AddWithValue("@Wait_Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Wait_Address", txtaddr.Text);
            cmd.Parameters.AddWithValue("@Wait_Phone", txtphn.Text);
            
            cmd.ExecuteNonQuery();
            con.Close();
             MessageBox.Show("Data successfully inserted.");
            
            GetEmployee();
            ResetFormData();
        }

        private void btnrmv_Click(object sender, EventArgs e)
        {
            if (this.id != 0)
            {
                MySqlConnection con = new MySqlConnection(function.ConnectionString());
                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM waiters WHERE Wait_Id = @Wait_Id";
                cmd.Parameters.AddWithValue("@Wait_Id", this.id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Information is Deleted");
                GetEmployee();
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

        private void btnupd_Click(object sender, EventArgs e)
        {
            if (this.id != 0)
            {
                MySqlConnection con = new MySqlConnection(function.ConnectionString());
                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE waiters SET Wait_Name = @Wait_Name, Wait_Address = @Wait_Address, Wait_Phone = @Wait_Phone Where Wait_Id = @Wait_Id";
                cmd.Parameters.AddWithValue("@Wait_Id", this.id);
                cmd.Parameters.AddWithValue("@Wait_Name", txtname.Text);
                cmd.Parameters.AddWithValue("@Wait_Address", txtaddr.Text);
                cmd.Parameters.AddWithValue("@Wait_Phone", txtphn.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data successfully updated.");
                GetEmployee();
                ResetFormData();
            }
            else
            {
                MessageBox.Show("Select a waiter.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard Ds = new Dashboard();
            this.Hide();
            Ds.Show();
        }
    }
    }

