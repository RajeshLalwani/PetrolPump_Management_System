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
    public partial class Machines : Form
    {
        SqlConnection con = new SqlConnection();
        Functions Fx = new Functions();

        public Machines()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Missing Information...");
            }
            else
            {

                try
                {

                    string query = "insert into MachineTbl values('" + textBox1.Text + "','" + comboBox1.Text + "'," + textBox3.Text + ")";
                    Fx.SetData(query, "Machineus Added Succesfully...");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}
