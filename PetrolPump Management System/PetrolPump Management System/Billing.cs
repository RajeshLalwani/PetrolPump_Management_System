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
    public partial class Billing : Form
    {
        SqlConnection con = new SqlConnection();
        public Billing()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        Functions Fx = new Functions();

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Missing Information...");
            }
            else
            {

                try
                {

                    string query = "insert into BillingTbl values('" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox1.Text + "'," + textBox3.Text + ")";
                    Fx.SetData(query, "Bill Added Succesfully...");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }


        }
    }
}
