using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace PetrolPump_Management_System
{
    class Functions
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\intel\Documents\Visual Studio 2010\Projects\PetrolPump Management System\PetrolPump Management System\PetrolPumpDB.mdf;Integrated Security=True;User Instance=True";
            return con;
        }

        //Function to Display Data From DataBase
        public DataSet ShowData(string Query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = Query;
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

      

        //Function to Insert Data into DataBase
        public void SetData(String Query, String Msg)
        {
            SqlConnection con = getConnection(); 
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = Query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(Msg,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

    }
}
