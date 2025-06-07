using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PetrolPump_Management_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Staff obj = new Staff();
            obj.Show();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Supplier obj = new Supplier();
            obj.Show();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Fuels obj = new Fuels();
            obj.Show();
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Machines obj = new Machines();
            obj.Show();
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Billing obj = new Billing();
            obj.Show();
          
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
            this.Close();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Staff obj = new Staff();
            obj.Show();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Supplier obj = new Supplier();
            obj.Show();
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Fuels obj = new Fuels();
            obj.Show();
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Machines obj = new Machines();
            obj.Show();
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Billing obj = new Billing();
            obj.Show();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            
        }
    }
}
