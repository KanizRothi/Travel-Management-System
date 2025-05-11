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
    public partial class UserId_Paschange : Form
    {
        Class1 c2 = new Class1();
        public UserId_Paschange()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String querry = " UPDATE Users SET pass = '" + newPassword.Text + "' WHERE userId = '" + UserId.Text + "' AND pass = '" + pass.Text + "'";
            c2.setData(querry);
            MessageBox.Show("Password seccesfully changed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
