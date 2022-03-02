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
    public partial class All_Item : Form
    {
        public All_Item()
        {
            InitializeComponent();
        }

        private void All_Item_Load(object sender, EventArgs e)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            Dashboard Ds = new Dashboard();
            this.Hide();
            Ds.Show();
        }

        private void ItemData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsrch_Click(object sender, EventArgs e)
        {
            Search cs = new Search();
            this.Hide();
            cs.Show();
        }
    }
}
