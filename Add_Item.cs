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
    public partial class Add_Item : Form
    {
        public Add_Item()
        {
            InitializeComponent();
        }
        private int id;

        private void Add_Item_Load(object sender, EventArgs e)
        {
            GetItemData();
        }
        private void GetItemData()
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
            ItemData.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO item(Product_Name, Category, Price) VALUES(@Product_Name, @Category, @Price)";
            //cmd.Parameters.AddWithValue("@Product_Id", lbId.Text);
            cmd.Parameters.AddWithValue("@Product_Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Category", txtCate.Text);
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data successfully inserted.");
            GetItemData();
            Reset();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (this.id != 0)
            {
                MySqlConnection con = new MySqlConnection(function.ConnectionString());
                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE item SET Product_Name = @Product_Name, Category = @Category, Price = @Price Where Product_Id = @Product_Id";
                cmd.Parameters.AddWithValue("@Product_Id", this.id);
                cmd.Parameters.AddWithValue("@Product_Name", txtname.Text);
                cmd.Parameters.AddWithValue("@Category", txtCate.Text);
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data successfully updated.");
                GetItemData();
                Reset();
            }
            else
            {
                MessageBox.Show("Select an Item.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnRmv_Click(object sender, EventArgs e)
        {
            if (this.id != 0)
            {
                MySqlConnection con = new MySqlConnection(function.ConnectionString());
                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM item WHERE Product_Id = @Product_Id";
                cmd.Parameters.AddWithValue("@Product_Id", this.id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Information is Deleted");
                GetItemData();
                Reset();
            }
            else
            {
                MessageBox.Show("Select an Item.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            this.id = 0;
            //lbId.Clear();
            txtname.Clear();

            txtPrice.Clear();
        }

        private void ItemData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(ItemData.SelectedRows[0].Cells[0].Value);
            //lbId.Text = ItemData.SelectedRows[0].Cells[0].Value.ToString();
            txtname.Text = ItemData.SelectedRows[0].Cells[1].Value.ToString();
            txtCate.Text = ItemData.SelectedRows[0].Cells[2].Value.ToString();
            txtPrice.Text = ItemData.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard Ds = new Dashboard();
            this.Hide();
            Ds.Show();
        }
    }
}
