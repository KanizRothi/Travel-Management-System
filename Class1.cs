using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trip_Maker_Travel_Management_System_
{
    public class Class1
    {

        public SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "DATA SOURCE=DESKTOP-JVRKJC0\\SQLEXPRESS; INITIAL CATALOG= master ;INTEGRATED SECURITY=TRUE";
            return con;

        }
        public void setData(string querry)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = querry;
            cmd.ExecuteNonQuery();
            con.Close();

        }

       /* public void getDgridview(String qr, DV )
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = q;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
           DV.DataSource = dt;
        }*/

        public void getData(string querry)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = querry;
            SqlDataAdapter da= new SqlDataAdapter(cmd); 
            DataSet ds= new DataSet();
            da.Fill(ds); 

            con.Close ();
        }










    }
}
