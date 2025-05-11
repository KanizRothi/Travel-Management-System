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
    public partial class Manage_Train : Form
    {

        Class1 c2 = new Class1();
        public void getDatagrid_data(String q)
        {
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







        public Manage_Train()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String query = "select * from Trains";
            getDatagrid_data(query);
            trainName.Text = "";
            from.Text = ""; ticketPrice.Text = ""; phone.Text = ""; to.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String query = "select * from Trains where TrainName Like '" + Search.Text + "%' ";
            getDatagrid_data(query);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String querry = "DELETE FROM Trains WHERE TrainName='" + trainName.Text + "'";
                c2.setData(querry);
                MessageBox.Show("Succesfully Removed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String Train_Name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            double ticket_price = double.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            from.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            to.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            phone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            trainName.Text = Train_Name;
            ticketPrice.Text = ticket_price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String querry = "INSERT INTO Trains (TrainName, Departure, Destination, Phone, TicketPrice) VALUES ('" + trainName.Text + "', '" + from.Text + "','" + to.Text + "','" + phone.Text + "'," + decimal.Parse(ticketPrice.Text) + ")";
                c2.setData(querry);
                MessageBox.Show("Succesfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                String querry = "UPDATE Trains SET TicketPrice= " + decimal.Parse(ticketPrice.Text) + ", Phone='" + phone.Text + "',Departure='" + from.Text + "',Destination='" + to.Text + "' WHERE TrainName='" + trainName.Text + "'";
                c2.setData(querry);
                MessageBox.Show("Succesfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }
    }
}
