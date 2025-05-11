using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trip_Maker_Travel_Management_System_
{
    public partial class User_dashboard : Form
    {
        public User_dashboard()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hotels_Booking booking = new Hotels_Booking();
            booking.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hotels_Booking booking = new Hotels_Booking();
            booking.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Flights_Booking FB = new Flights_Booking();
            FB.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Flights_Booking FB = new Flights_Booking();
            FB.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Trains_Booking TB = new Trains_Booking();
            TB.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Trains_Booking TB = new Trains_Booking();
            TB.Show();


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Bus_Booking BB = new Bus_Booking();
            BB.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Bus_Booking BB = new Bus_Booking();
            BB.Show();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Launch_Booking Lb = new Launch_Booking();
            Lb.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Launch_Booking Lb = new Launch_Booking();
            Lb.Show();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            user_account_settings uas = new user_account_settings();
            uas.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Vouchers vc = new Vouchers();
            vc.Show();
        }
    }
}
