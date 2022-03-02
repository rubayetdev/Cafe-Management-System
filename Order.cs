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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        private int id;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {
            AllItem();
            Customer();
            CusId();
            PodId();
            Price();
            Search();


            //Total();
        }

        /*private void Total()
        {


            MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT sum(Total_Price) as Total_Price From orderitem AS ord WHERE ord.Customer_Id= '" + Cus.Text.Trim() + "'";
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                label9.Text = sdr.GetValue(0).ToString();

            }

        }*/



        private void Search()
        {

            MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();

            cmd.CommandText = "select* from item where Product_Name='" + textBox1.Text.Trim() + "' or Category= '" + textBox1.Text.Trim() + "' or Product_Name LIKE '%" + textBox1.Text.Trim() + "%' ";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(sdr);
            con.Close();
            ItemView.DataSource = dt;
           
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
        private void Customer()
        {
            MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Order_Id, Customer_Id, Product_Id, Product_Name, Quantity, Total_Price FROM orderitem Where Customer_Id = '" + Cus.Text.Trim() + "'";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            con.Close();
            OrderView.DataSource = dt;
        }
        private void CusId()
        {
            MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Customer_Id FROM customer";
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Cus.Text = sdr.GetValue(0).ToString();
               // lbName.Text = sdr.GetValue(0).ToString();
            }
            
            //ResetData();
        }
        private void PodId()
        {
            MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Customers_Name FROM customer Where Customer_Id ='" + Cus.Text.Trim() + "' ";
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                lbName.Text = sdr.GetValue(0).ToString();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            /*MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO customer(Customers_Name, Customers_Phone) VALUES(@Customers_Name, @Customers_Phone)";
            //cmd.Parameters.AddWithValue("@Product_Id", lbId.Text);
            cmd.Parameters.AddWithValue("@Customers_Name", CusName.Text);
            cmd.Parameters.AddWithValue("@Customers_Phone", CusPhn.Text);
            
            cmd.ExecuteNonQuery();
            Customer();
            con.Close();
            //ResetData();*/
            
        }
        private void Price()
        {
          MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Order_Id FROM orderitem ";
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                OrderSL.Text = sdr.GetValue(0).ToString();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO orderitem(Product_Id, Customer_Id, Quantity, Total_Price) VALUES(@Product_Id, @Customer_Id, @Quantity, @Total_Price)";
            //cmd.CommandText = "SELECT SUM(Total_Price) as Price FROM customer as cu, orderitem as ord WHERE cu.Customer_Id = '" + Cus.Text.Trim() + "'; ";
            cmd.Parameters.AddWithValue("@Product_Id", ProId.Text);
            cmd.Parameters.AddWithValue("@Product_Name", txtItem.Text);
            cmd.Parameters.AddWithValue("@Customer_Id", Cus.Text);
            cmd.Parameters.AddWithValue("@Total_Price", txtPrice.Text);
            //cmd.Parameters.AddWithValue("@Order_Id", OrderSL.Text);
            cmd.Parameters.AddWithValue("@Quantity", numeric.Text);


            cmd.ExecuteNonQuery();







            MySqlConnection con2 = new MySqlConnection(function.ConnectionString());
            con2.Open();
            MySqlCommand cmd2;
            cmd2 = con2.CreateCommand();
            cmd2.CommandText = "SELECT sum(Total_Price) as Total_Price From orderitem AS ord WHERE ord.Customer_Id= '" + Cus.Text.Trim() + "'";
            MySqlDataReader sdr = cmd2.ExecuteReader();
            while (sdr.Read())
            {
                label9.Text = sdr.GetValue(0).ToString();

            }

            Customer();
            /*MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtTo.Text = sdr.GetValue(0).ToString();
            }*/
            con.Close();
            ResetData();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Product_Name FROM item Where Product_Id ='" + ProId.Text.Trim() + "' ";
            
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtItem.Text = sdr.GetValue(0).ToString();
               
            }
            /*MySqlConnection con2 = new MySqlConnection(function.ConnectionString());
            con2.Open();
            MySqlCommand cmd2;
            cmd2 = con2.CreateCommand();
            cmd2.CommandText = "SELECT Price FROM item Where Product_Id ='" + ProId.Text.Trim() + "' ";

            MySqlDataReader sdr2 = cmd2.ExecuteReader();
            while (sdr2.Read())
            {
                txtPrice.Text = sdr2.GetValue(0).ToString();

            }*/
        }

        private void OrderView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Customer_Id, Product_Id, Product_Name, Quantity, Price
            id = Convert.ToInt32(OrderView.SelectedRows[0].Cells[0].Value);
            OrderSL.Text= OrderView.SelectedRows[0].Cells[0].Value.ToString();
            Cus.Text = OrderView.SelectedRows[0].Cells[1].Value.ToString();
            ProId.Text = OrderView.SelectedRows[0].Cells[2].Value.ToString();
            txtItem.Text = OrderView.SelectedRows[0].Cells[3].Value.ToString();
            numeric.Text = OrderView.SelectedRows[0].Cells[4].Value.ToString();
            txtPrice.Text = OrderView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            //cmd.CommandText = "SELECT Product_Name FROM item Where Product_Id ='" + ProId.Text.Trim() + "' ";
            cmd.CommandText = "SELECT (Price*'" + numeric.Text + "') as Total_Price FROM item as i, orderitem WHERE i.Product_Name = '" + txtItem.Text+ "'  ";
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
            //    txtItem.Text = sdr.GetValue(0).ToString();
                txtPrice.Text = sdr.GetValue(0).ToString();
            }


        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetData();
        }
        private void ResetData()
        {
            this.id = 0;
            //Cus.Refresh();
            //CusPhn.Clear();
            ProId.Clear();
            txtItem.Clear();
            txtPrice.Clear();
            numeric.Clear();

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (this.id != 0)
            {
                MySqlConnection con = new MySqlConnection(function.ConnectionString());
                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE orderitem SET  Product_Id = @Product_Id, Product_Name = @Product_Name, Quantity = @Quantity, Total_Price = @Total_Price Where Order_Id = @Order_Id";
                cmd.Parameters.AddWithValue("@Order_Id", this.id);
                //cmd.Parameters.AddWithValue("@Customer_Id", Cus.Text);
                cmd.Parameters.AddWithValue("@Product_Id", ProId.Text);
                cmd.Parameters.AddWithValue("@Product_Name", txtItem.Text);
                cmd.Parameters.AddWithValue("@Quantity", numeric.Text);
                cmd.Parameters.AddWithValue("@Total_Price", txtPrice.Text);
                cmd.ExecuteNonQuery();

                MySqlConnection con2 = new MySqlConnection(function.ConnectionString());
                con2.Open();
                MySqlCommand cmd2;
                cmd2 = con2.CreateCommand();
                cmd2.CommandText = "SELECT sum(Total_Price) as Total_Price From orderitem AS ord WHERE ord.Customer_Id= '" + Cus.Text.Trim() + "'";
                MySqlDataReader sdr = cmd2.ExecuteReader();
                while (sdr.Read())
                {
                    label9.Text = sdr.GetValue(0).ToString();

                }
                con.Close();
                MessageBox.Show("Data successfully updated.");
                Customer();
                ResetData();
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
                cmd.CommandText = "DELETE FROM orderitem WHERE Order_Id = @Order_Id";
                cmd.Parameters.AddWithValue("@Order_Id", this.id);
                cmd.ExecuteNonQuery();
                MySqlConnection con2 = new MySqlConnection(function.ConnectionString());
                con2.Open();
                MySqlCommand cmd2;
                cmd2 = con2.CreateCommand();
                cmd2.CommandText = "SELECT sum(Total_Price) as Total_Price From orderitem AS ord WHERE ord.Customer_Id= '" + Cus.Text.Trim() + "'";
                MySqlDataReader sdr = cmd2.ExecuteReader();
                while (sdr.Read())
                {
                    label9.Text = sdr.GetValue(0).ToString();

                }
                con.Close();
                MessageBox.Show("Information is Deleted");
                Customer();
                ResetData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment pa = new Payment();
            pa.Show();
            this.Hide();
        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_Click(object sender, EventArgs e)
        {
           /*(float.Parse(numeric.Text)*float.Parse(textBox1.Text)).ToString();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();

            cmd.CommandText = "select* from item where Product_Name='" + textBox1.Text.Trim() + "' or Category= '" + textBox1.Text.Trim() + "' or Product_Name LIKE '%" + textBox1.Text.Trim() + "%' ";

            cmd.ExecuteNonQuery();
            con.Close();
            Search();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
