using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Trip_Maker_Travel_Management_System_
{
   
    public partial class Bkash_Payment : Form
    {
        Class1 c2 = new Class1();
        int n;
        String f_name, email, phone, kyc, Product_nam, Num, total;
        double t_Bill;
        public Bkash_Payment(String voucher_code, double bill, String Total,String name,String em,String phn,String Kyc,String product,String number)
        {
           
            if (voucher_code !="")
            {
                n = 0;
                InitializeComponent();
                amount.Text = "Amount: " + bill.ToString() + " TK";
                t_Bill= bill;
            }
            else
            {
                n = 1;
                InitializeComponent();
                amount.Text = "Amount: " + Total + " TK";
                t_Bill=double.Parse(Total);

            }
            f_name = name;
            email=em; phone = phn; kyc = Kyc;Product_nam=product;Num = number;    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Bkash_Payment_Load(object sender, EventArgs e)
        {

        }


        public void insert()
        {

            String query = "INSERT INTO Payment (Product_Name, Product_Quantity, Customer_Name, Customer_Email, Customer_Phone, customer_verification, Total_Bill)\r\nVALUES ('" + Product_nam + "'," + int.Parse(Num) + ",'" + f_name + "','" + email + "','" + phone + "','" + kyc + "'," + t_Bill + ") ";
            c2.setData(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           insert();

            if (checkBox1.Checked)
            {
                if (textBox1.Text != "" && Pin.Text != "")
                {
                    this.Hide();
                    MessageBox.Show("Payment Succesfull!","Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                   
                    Rating rt= new Rating();
                    rt.Show();

                }
                else
                {
                    MessageBox.Show("Enter Account Number and Pin ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Agrree To The Terms ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            String qty = Num;
            string Name_of_product = Product_nam;

            string customerName = f_name;
            string Email = email;
            string Phone = phone;
            string nid = kyc;
            double amount = t_Bill;

            Font font = new Font("Arial", 12, FontStyle.Regular);
            Brush brush = Brushes.Black;

            // Define starting point
            float x = 10;
            float y = 10;

            // Print each data item
            e.Graphics.DrawString("Invoice : Trip Maker", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(x, y));
            y += 50; 

            e.Graphics.DrawString("Product Name: "+ Name_of_product, font, brush, new PointF(x, y));
            y += 50;

            e.Graphics.DrawString("Quantity: " +qty+ "x", font, brush, new PointF(x, y));
            y += 50;
 

            e.Graphics.DrawString($"Customer Name: {customerName}", font, brush, new PointF(x, y));
            y += 50; 

            e.Graphics.DrawString($"Email: {Email}", font, brush, new PointF(x, y));
            y += 50; 

            e.Graphics.DrawString($"Phone: {Phone}", font, brush, new PointF(x, y));
            y += 50; 

            e.Graphics.DrawString($"NID: {nid}", font, brush, new PointF(x, y));
            y += 250;
           
                e.Graphics.DrawString("Paid Amount: " + amount.ToString() + " TK", font, brush, new PointF(x, y));
            
           
        }


    }
}