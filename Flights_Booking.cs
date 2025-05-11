using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trip_Maker_Travel_Management_System_
{
    public partial class Flights_Booking : Form
    {
        Class1 c2 = new Class1();
        public Flights_Booking()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flightName.Text == "" || ticketPrice.Text == "")
            {
                MessageBox.Show("Select a Flight First", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Billing_Details BD = new Billing_Details("Flights", total.Text, flightName.Text, noTicket.Text);
                BD.Show();

            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double number_TICKET = double.Parse(noTicket.Text);
                double Total_bill; //= double.Parse(total.Text);
                Total_bill = number_TICKET * ticket_price;
                total.Text = Total_bill.ToString();
            }
            catch
            {
                MessageBox.Show("Enter The Box Proprly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        double ticket_price;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String Flight_Name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            ticket_price = double.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            flightName.Text = Flight_Name;
            ticketPrice.Text = ticket_price.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String search = Search.Text;
            string querry = "select * from Flights where Destination Like '" + search + "%' ";
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
