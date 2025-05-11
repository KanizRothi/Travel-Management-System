using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trip_Maker_Travel_Management_System_
{
    public partial class Billing_Details : Form
    {
        public double payment;
        Hotels_Booking HT = new Hotels_Booking();
        Flights_Booking Flights = new Flights_Booking();



        public Billing_Details()
        {
            InitializeComponent();

        }
        public Billing_Details(String bookingType, String total, String product, String qty)
        {
            InitializeComponent();
            if (bookingType == "Hotel")
            {
                Total.Text = total;
                totalbill.Text = "Total Payable Bill: " + total;
                Product_label.Text = product;
                qty_x.Text = qty;

            }
            else if (bookingType == "Flights")
            {
                Total.Text = total;
                totalbill.Text = "Total Payable Bill: " + total;
                Product_label.Text = product;
                qty_x.Text = qty;
            }
            else if (bookingType == "Trains")
            {
                Total.Text = total;
                totalbill.Text = "Total Payable Bill: " + total;
                Product_label.Text = product;
                qty_x.Text = qty;
            }
            else if (bookingType == "Bus")
            {
                Total.Text = total;
                totalbill.Text = "Total Payable Bill: " + total;
                Product_label.Text = product;
                qty_x.Text = qty;
            }
            else if (bookingType == "Launch")
            {

                Total.Text = total;
                totalbill.Text = "Total Payable Bill: " + total;
                Product_label.Text = product;
                qty_x.Text = qty;

            }

        }


        private void label13_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Billing_Details_Load(object sender, EventArgs e)
        {

        }

        private void Total_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (voucher.Text == "")
                {
                    VoucherD.Text = "Voucher discount:";
                }
                else if (voucher.Text == "MyTrip" || voucher.Text == "mytrip" || voucher.Text == "MYTRIP")
                {


                    VoucherD.Text = "Voucher Discount: 15% ";


                    if (double.TryParse(Total.Text, out double total_Bill))
                    {

                        total_Bill *= 0.85;
                        payment = total_Bill;


                        totalbill.Text = "Total Payable Bill: " + total_Bill.ToString() + "TK";
                    }
                    else
                    {

                        MessageBox.Show("Invalid total bill format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    MessageBox.Show("No Such Vouchers Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch { }
        }


        public void pictureBox1_Click(object sender, EventArgs e)
        {
            Bkash_Payment bkashPayment = new Bkash_Payment(voucher.Text, payment, Total.Text, name.Text, email.Text, phone_number.Text, nid.Text, Product_label.Text, qty_x.Text);
            bkashPayment.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
