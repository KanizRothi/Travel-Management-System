using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trip_Maker_Travel_Management_System_
{
    public partial class Sales_Payment : Form
    {


        public void getDatagrid_data(String q)
        {
            Class1 c2 = new Class1();
            SqlConnection con = c2.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = q;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }





        public Sales_Payment()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String query = "select * from Payment";
            getDatagrid_data(query);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            String query = "select * from Payment  where Product_Name Like '" + Search.Text + "%' ";
            getDatagrid_data(query);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
