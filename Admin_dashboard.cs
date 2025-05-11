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
    public partial class Admin_dashboard : Form
    {
        public Admin_dashboard()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_registration admin_Registration = new Admin_registration();
            this.Hide();
            admin_Registration.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hotel_Manage HM = new Hotel_Manage();
            HM.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Flights MF = new Manage_Flights();
            MF.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_Train MT = new Manage_Train();
            MT.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manage_BUS MB = new Manage_BUS();
            MB.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manage_Launch ML = new Manage_Launch();
            ML.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Registered_Accounts RA = new Registered_Accounts();
            RA.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sales_Payment sp = new Sales_Payment();
            sp.Show();
        }
    }
}
