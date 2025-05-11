using System;

using System.Data;
using System.Data.SqlClient;


namespace Trip_Maker_Travel_Management_System_
{
    public partial class Hotel_Manage : Form
    {
        public Hotel_Manage()
        {
            InitializeComponent();
        }

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







        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String query = "select * from Hotels";
            getDatagrid_data(query);
            hotelName.Text = "";
            address.Text = ""; price.Text = ""; phone.Text = ""; destination.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            String query = "select * from Hotels where HotelName Like '" + Search.Text + "%' ";
            getDatagrid_data(query);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String Hotel_Name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            double pernight_price = double.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            address.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            destination.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            phone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            hotelName.Text = Hotel_Name;
            price.Text = pernight_price.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String querry = "DELETE FROM Trains WHERE HotelName='" + hotelName.Text + "'";
                c2.setData(querry);
                MessageBox.Show("Succesfully Removed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String querry = "UPDATE Hotels SET PricePerNight= " + decimal.Parse(price.Text) + ", Phone='" + phone.Text + "',Hotel_Address='" + address.Text + "',Destination='" + destination.Text + "' WHERE HotelName='" + hotelName.Text + "'";
                c2.setData(querry);
                MessageBox.Show("Succesfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                String querry = "INSERT INTO Hotels (HotelName, Hotel_Address, Destination, Phone, PricePerNight) VALUES ('" + hotelName.Text + "', '" + address.Text + "','" + destination.Text + "','" + phone.Text + "'," + decimal.Parse(price.Text) + ")";
                c2.setData(querry);
                MessageBox.Show("Succesfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }
    }
}
