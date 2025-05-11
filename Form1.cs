using System.Data.SqlClient;

namespace Trip_Maker_Travel_Management_System_
{
    public partial class Form1 : Form
    {
        int n = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Your code here
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_registration ur = new User_registration();
            ur.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            switch (n)
            {
                case 0:
                    String userId = textBox1.Text;
                    String pass = textBox2.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "DATA SOURCE=DESKTOP-JVRKJC0\\SQLEXPRESS; INITIAL CATALOG= master ;INTEGRATED SECURITY=TRUE";
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "select * from Users where userId='" + userId + "' and pass='" + pass + "'";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Close();
                        User_dashboard ud = new User_dashboard();
                        this.Hide();
                        ud.Show();
                    }
                    else
                    {
                        n++;
                    }
                    con.Close();
                    break;

                case 1:
                    userId = textBox1.Text;
                    pass = textBox2.Text;
                    con = new SqlConnection();
                    con.ConnectionString = "DATA SOURCE=DESKTOP-JVRKJC0\\SQLEXPRESS; INITIAL CATALOG= master ;INTEGRATED SECURITY=TRUE";
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "select * from Admins where userId='" + userId + "'and pass='" + pass + "'";
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Close();
                        Admin_dashboard ad = new Admin_dashboard();
                        this.Hide();
                        ad.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                    break;

                default:
                    MessageBox.Show("Invalid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
