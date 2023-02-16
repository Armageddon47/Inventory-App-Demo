using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_App_Demo
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void loader()
        {
            try
            {
                con.Open();
                string myQuerry = "select * from ProductTBL";
                SqlDataAdapter da = new SqlDataAdapter(myQuerry, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();


            }
            catch
            {

            }
        }

        private SqlConnection con =
            new SqlConnection(@"Data Source=V-PC;Initial Catalog=Inventory;Integrated Security=True");
        void ItemLoader()
        {
            string querry = "select * from ItemsTBL";
            SqlCommand com = new SqlCommand(querry, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                DataTable table = new DataTable();
                table.Columns.Add("ItemName", typeof(string));
                reader = com.ExecuteReader();
                table.Load(reader);
                comboBox1.ValueMember = "ItemName";
                comboBox1.DataSource = table;

                comboBox2.ValueMember = "ItemName";
                comboBox2.DataSource = table;

                con.Close();

            }
            catch 
            {
                Console.WriteLine();
                throw;
            }

        }
        void SearchLoader()
        {
            
            try
            {
                
                con.Open();
                string querry = "select * from ProductTBL where ProCat ='" + comboBox2.SelectedValue.ToString() + "'";

                SqlDataAdapter da = new SqlDataAdapter(querry, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();

            }
                catch
                {
                    Console.WriteLine();
                    throw;
                }


            }
        private void Products_Load(object sender, EventArgs e)
        {
            ItemLoader();
            loader();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("insert into ProductTBL values('" + ProductIDTXT.Text + "', '" + ProductNameTXT.Text + "'," +
                                                "'" + QuantityTXT.Text + "','" + PriceTXT.Text + "','" + DescriptionTXT.Text + "','" + comboBox1.SelectedValue.ToString() + "' )", con);
                com.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added");
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ID Must Be UNIQUE!");

            }

            loader();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("update  ProductTBL set " +
                                                "ProName = '" + ProductNameTXT.Text + "', ProQ ='" + QuantityTXT.Text + "' " +
                                                ", ProPrice ='" + PriceTXT.Text + "' , ProDesc ='" + DescriptionTXT.Text + "' " +
                                                ", ProCat ='" + comboBox1.SelectedValue + "' where ProID = '" + ProductIDTXT.Text + "'", con);
                com.ExecuteNonQuery();
                MessageBox.Show("Customer Modified");
                con.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            loader();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ProductIDTXT.Text == "")
            {
                MessageBox.Show("Invalid selection");
            }
            else
            {
                con.Open();
                string myQuerry = "delete from ProductTBL where ProID ='" + ProductIDTXT.Text + "';";
                SqlCommand com = new SqlCommand(myQuerry, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Product Removed");
                con.Close();
                loader();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductIDTXT.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ProductNameTXT.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            QuantityTXT.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            PriceTXT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            DescriptionTXT.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox1.SelectedValue= dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SearchLoader();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            loader();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
