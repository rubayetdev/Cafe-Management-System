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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnsrch_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();

            cmd.CommandText = "select* from item where Product_Name='" + textBox1.Text.Trim() + "' or Category= '" + textBox1.Text.Trim() + "' or Product_Name LIKE '%" + textBox1.Text.Trim() + "%' ";
            
                cmd.ExecuteNonQuery();
                con.Close();
                GetItemData();
                
            
            //cmd.CommandText = "select* from item where Category='" + textBox1.Text.Trim() + "'";
           //cmd.CommandText = "select* from item where Product_Name like '%" + textBox1.Text.Trim() + "%'";
            

        }

        private void Search_Load(object sender, EventArgs e)
        {
            GetItemData();
            

            }
            
            private void GetItemData()

            {
                MySqlConnection con = new MySqlConnection(function.ConnectionString());
                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM item where Product_Name='" + textBox1.Text.Trim() + "' or Category= '" + textBox1.Text.Trim() + "' or Product_Name LIKE '%" + textBox1.Text.Trim() + "%' ";
                MySqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sdr);
                con.Close();
                dataGridView1.DataSource = dt;

                
            
            //cmd.CommandText = "select* from item where Category='" + textBox1.Text.Trim() + "'";
            //cmd.CommandText = "select* from item where Product_Name like '%" + textBox1.Text.Trim() + "%'";
            
            }

        

          private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard Ds = new Dashboard();
            this.Hide();
            Ds.Show();
        }
    }
    }
    

