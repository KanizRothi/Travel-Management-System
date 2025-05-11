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
    public partial class Trains_Booking : Form
    {
        Class1 c2 = new Class1();
        public Trains_Booking()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (trainName.Text == "" || ticketPrice.Text == "")
            {
                MessageBox.Show("Select a Train First", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Billing_Details BD = new Billing_Details("Trains",total.Text, trainName.Text, noTicket.Text);
                BD.Show();

            }
        }

        private void noTicket_TextChanged(object sender, EventArgs e)
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
                MessageBox.Show("Enter The Box Properly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        double ticket_price;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String Train_Name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            ticket_price = double.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            trainName.Text = Train_Name;
            ticketPrice.Text = ticket_price.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String search = Search.Text;
            string querry = "select * from Trains where Destination Like '" + search + "%' ";
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
    }
}
