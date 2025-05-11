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
    public partial class Admin_registration : Form
    {
        public Admin_registration()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_dashboard ad = new Admin_dashboard();
            this.Close();
            ad.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
