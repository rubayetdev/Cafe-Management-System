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
using PagedList;

namespace Cafe_Management_System
{
    public partial class Payment : Form
    {
        private string Date;
        public Payment()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("M/dd/yyyy");
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            Bill();
            Customer();
            Price();
            lbDate.Text = Date;
            YourOrder();
            
        }
        private void Bill()
        {
            MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Bill_No FROM payment";
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtBil.Text = sdr.GetValue(0).ToString();
                
            }
            
        }
        private void Customer()
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

            }
        }
        private void Price()
        {
            MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT sum(Total_Price) as Total_Price From orderitem AS ord WHERE ord.Customer_Id= '" + Cus.Text.Trim() + "'";
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtPrice.Text = sdr.GetValue(0).ToString();

            }
        }
        private void YourOrder()
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
            Order.DataSource = dt;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(function.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO payment(Customer_Id, Payment_Type, Number, Price) VALUES(@Customer_Id, @Payment_Type, @Number, @Price)";
            //cmd.CommandText = "SELECT SUM(Total_Price) as Price FROM customer as cu, orderitem as ord WHERE cu.Customer_Id = '" + Cus.Text.Trim() + "'; ";
            cmd.Parameters.AddWithValue("@Customer_Id", Cus.Text);
            cmd.Parameters.AddWithValue("@Payment_Type", type.Text);
            cmd.Parameters.AddWithValue("@Number", num.Text);
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
            //cmd.Parameters.AddWithValue("@Order_Id", OrderSL.Text);
            //cmd.Parameters.AddWithValue("@Quantity", numeric.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Bill Paid Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Customer();
            /*MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtTo.Text = sdr.GetValue(0).ToString();
            }*/
            con.Close();
            ResetData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ResetData();
        }
        private void ResetData()
        {
            //Cus.Clear();
            //num.Clear();
            //price.Clear();

        }
        Bitmap bmp;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("BUBT CAFE", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(350,10));
            e.Graphics.DrawString("Thank you for visiting!", new Font("Arial", 16, FontStyle.Italic), Brushes.Black, new Point(300, 1000));
            e.Graphics.DrawString("Rupnagar, Mirpur-2, Dhaka-1216, Bangladesh ", new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new Point(250,50));
            e.Graphics.DrawString("Phone: 4803-6351, 4803-6352, 4803-6353", new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new Point(280, 80));
            e.Graphics.DrawString("Bill No: " +txtBil.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 160));
            e.Graphics.DrawString("Customer Id: "+Cus.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(300, 160));
            e.Graphics.DrawString("Payment By: "+type.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 900));
            e.Graphics.DrawString("Number: "+num.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(300, 900));
            e.Graphics.DrawString("Total Price: "+txtPrice.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(500, 900));
            e.Graphics.DrawString("Date: " + lbDate.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 160));
            e.Graphics.DrawImage(bmp,0,100);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int height = Order.Height;
            Order.Height = Order.RowCount * Order.RowTemplate.Height * 3;
            bmp = new Bitmap(Order.Width, Order.Height);
            Order.DrawToBitmap(bmp, new Rectangle(0, 100, Order.Width, Order.Height));
            Order.Height = height;

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        
    }
}
