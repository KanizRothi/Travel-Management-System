using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic;
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
    public partial class User_name_change : Form
    { Class1 c2= new Class1 ();
        public User_name_change()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String querry=" UPDATE Users SET userId = '"+newUserid.Text+ "' WHERE userId = '" +prevUserId.Text+"' AND pass = '" +pass.Text+"'"  ;
            c2.setData(querry);
            MessageBox.Show("UserId seccesfully changed","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
