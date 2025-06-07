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
    public partial class Supplier : Form
    {
        SqlConnection con = new SqlConnection();
        public Supplier()
        {
            InitializeComponent();
            ShowSuppliers();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        Functions Fx = new Functions();
        private void ShowSuppliers()
        {
            string Query = "select * from SupplierTbl";
            DataSet ds = Fx.ShowData(Query);
            SuppliersList.DataSource = ds.Tables[0];
        }
        //SqlConnection con = Fx.getConnection();
        private void SaveBtn_Click(object sender, EventArgs e)
        {

            if (AddressTb.Text == "" || PhoneTb.Text == "" || SupNameTb.Text == "")
            {
                MessageBox.Show("Missing Information...");
            }
            else 
            {
                string Supplier = SupNameTb.Text;
                string Phone = PhoneTb.Text;
                string Address = AddressTb.Text;
                try
                {
                    string query = "insert into SupplierTbl values('" + Supplier + "'," + Phone + ",'" + Address + "')";
                    Fx.SetData(query, "Supplier Added Succesfully...");
                    ShowSuppliers();
                    //SqlCommand cmd = new SqlCommand("insert into SupplierTbl values('" + Supplier + "'," + Phone + ",'" + Address + "')", con);
                    //cmd.CommandText = "insert into prg27,28 values(" + TextBox1.Text + "," + TextBox2.Text + ",'" + TextBox3.Text + "','" + TextBox4.Text + "'," + TextBox5.Text + ")";
                    //cmd.Connection = con;
                    //MessageBox.Show("Data Inserted..!");
                }
                catch(Exception e) 
                {
                    MessageBox.Show(e.Message);
                    //throw;
                }
                //cmd.ExecuteNonQuery();
                
          

            }
                

            //    if (AddressTb.Text == "" || PhoneTb.Text == "" || SupNameTb.Text == "")
            //{
            //    MessageBox.Show("Missing Information..!");
            //}
            //else 
            //{
            //    string Supplier = SupNameTb.Text;
            //    string Phone = PhoneTb.Text;
            //    string Address = AddressTb.Text;

            //    try
            //    {
            //        string Query = "insert into SupplierTbl values('" + Supplier + "'," + Phone + ",'" + Address + "')";
            //        Fx.SetData(Query,"Supplier Inserted..");
            //        ShowSuppliers();
            //    }
            //    catch(Exception Ex)
            //    {
            //        MessageBox.Show(Ex.Message);
            //    }
            //}
           

        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petrolPumpDBDataSet1.SupplierTbl' table. You can move, or remove it, as needed.
            this.supplierTblTableAdapter.Fill(this.petrolPumpDBDataSet1.SupplierTbl);
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\intel\Documents\Visual Studio 2010\Projects\PetrolPump Management System\PetrolPump Management System\PetrolPumpDB.mdf;Integrated Security=True;User Instance=True";
            con.Open();
            //SqlCommand cmd2 = new SqlCommand();
            //cmd2.Connection = con;
            //string Query = "select * from SupplierTbl";
            //cmd2.CommandText = Query;
            //SqlDataAdapter da = new SqlDataAdapter();
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //SuppliersList.DataSource = ds.Tables[0];
           
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.supplierTblTableAdapter.FillBy(this.petrolPumpDBDataSet1.SupplierTbl);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        int Key = 0;
        private void SuppliersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SupNameTb.Text = SuppliersList.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = SuppliersList.SelectedRows[0].Cells[2].Value.ToString();
            AddressTb.Text = SuppliersList.SelectedRows[0].Cells[3].Value.ToString();

            if (SupNameTb.Text == "")
            {
                Key = 0;
            }
            else 
            {
                Key = Convert.ToInt32(SuppliersList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (AddressTb.Text == "" || PhoneTb.Text == "" || SupNameTb.Text == "")
            {
                MessageBox.Show("Missing Information...");
            }
            else
            {
                string Supplier = SupNameTb.Text;
                string Phone = PhoneTb.Text;
                string Address = AddressTb.Text;
                try
                {
                    string query = "update SupplierTbl set SupName='" + Supplier + "', SupPhone=" + Phone + ", SupAdd='" + Address + "' where SupId='" + Key + "' ";
                    Fx.SetData(query, "Supplier Updated Succesfully...");
                    ShowSuppliers();
                    //SqlCommand cmd = new SqlCommand("insert into SupplierTbl values('" + Supplier + "'," + Phone + ",'" + Address + "')", con);
                    //cmd.CommandText = "insert into prg27,28 values(" + TextBox1.Text + "," + TextBox2.Text + ",'" + TextBox3.Text + "','" + TextBox4.Text + "'," + TextBox5.Text + ")";
                    //cmd.Connection = con;
                    //MessageBox.Show("Data Inserted..!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
                //cmd.ExecuteNonQuery();



            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            SupNameTb.Text = "";
            AddressTb.Text = "";
            PhoneTb.Text = "";
        }

        
    }
}
