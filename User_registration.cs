using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;


namespace Trip_Maker_Travel_Management_System_
{
    public partial class User_registration : Form
    {



        public User_registration()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (userid.Text == "" || pass.Text == "" || fullname.Text == "" || city.Text == "" || phone.Text == "") { MessageBox.Show("Fill All The Boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    String q = "Insert into Users (userId, pass, full_name, phone_num, city) VALUES ('" + userid.Text + "','" + pass.Text + "','" + fullname.Text + "','" + phone.Text + "','" + city.Text + "');";
                    Class1 c1 = new Class1();
                    c1.setData(q);
                    MessageBox.Show("Acount Succesfully created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { MessageBox.Show("User Id already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
