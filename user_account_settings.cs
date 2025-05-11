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
    public partial class user_account_settings : Form
    {
        public user_account_settings()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_name_change usc = new User_name_change();
            usc.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserId_Paschange up = new UserId_Paschange();
            up.Show();
        }
    }
}
