using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel.Com2Interop;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trip_Maker_Travel_Management_System_
{
    public partial class Hotels_Booking : Form
    {


        Class1 c2 = new Class1();




        public Hotels_Booking()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

       /* private void button2_Click(object sender, EventArgs e)
        {
            if (hotelNme.Text == "" || price.Text == "")
            {
                MessageBox.Show("Select a Hotel First", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                Billing_Details BD = new Billing_Details("Hotel", total.Text,hotelNme.Text,noNight.Text);
                BD.Show();
              
            }
        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String search = Search.Text;
            string querry = "select * from Hotels where Destination Like '" + search + "%' ";
            SqlConnection con = c2.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = querry;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;




        }


        double price_pernight;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String Hotel_Name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            price_pernight = double.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            hotelNme.Text = Hotel_Name;
            price.Text = price_pernight.ToString();


        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (hotelNme.Text == "" || price.Text == "")
            {
                MessageBox.Show("Select a Hotel First", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                Billing_Details BD = new Billing_Details("Hotel", total.Text, hotelNme.Text, noNight.Text);
                BD.Show();

            }
        }





        public void noNight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double number_Night = double.Parse(noNight.Text);
                double Total_bill; //= double.Parse(total.Text);
                Total_bill = number_Night * price_pernight;
                total.Text = Total_bill.ToString();
            }
            catch
            {
                MessageBox.Show("Enter The Box Proprly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
