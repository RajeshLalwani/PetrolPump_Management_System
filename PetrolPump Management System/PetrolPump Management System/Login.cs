using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PetrolPump_Management_System
{

    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection();
        public Login()
        {
            InitializeComponent();
        }

        Functions Fx = new Functions();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Missing Information...");
            }
            else
            {
                
                try
                {

                    string query = "insert into Login values('" + textBox1.Text + "'," + textBox2.Text + ")";
                    Fx.SetData(query, "Logged in Succesfully...");                  
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                   
                }
         



            }


           
           
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\intel\Documents\Visual Studio 2010\Projects\PetrolPump Management System\PetrolPump Management System\PetrolPumpDB.mdf;Integrated Security=True;User Instance=True";
            con.Open();
        }
    }
}
