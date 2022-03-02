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
    public partial class AddItem : Form
    {
        

        public AddItem()
        {
            InitializeComponent();
        }

        
        private void AddItem_Load(object sender, EventArgs e)
        {
            GetItemData();
        }
        
        private void GetItemData()
        {
            MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM items";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            con.Close();
            ItemDataGridView.DataSource = dt;
        }
        
    
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO items(product_name, category, price) VALUES(@product_name, @category, @price)";
            cmd.Parameters.AddWithValue("@product_name", txtItem.Text);
            cmd.Parameters.AddWithValue("@category", txtCata.Text);
            cmd.Parameters.AddWithValue("@price", txtPrice.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data successfully inserted.");
        }
        private void ItemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtItem.Text = ItemDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtCata.Text = ItemDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtPrice.Text = ItemDataGridView.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}

