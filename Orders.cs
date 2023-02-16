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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }
        private SqlConnection con =
            new SqlConnection(@"Data Source=V-PC;Initial Catalog=Inventory;Integrated Security=True");
        private void loader()
        {
            try
            {
                con.Open();
                string myQuerry = "select * from CustomerTBL";
                SqlDataAdapter da = new SqlDataAdapter(myQuerry, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomerGrid.DataSource = ds.Tables[0];
                con.Close();


            }
            catch(Exception exception)      

            {
                Console.Write(exception);
                throw;

            }
        }

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

                //comboBox1.ValueMember = "ItemName";
                //comboBox1.DataSource = table;

                con.Close();

            }
            catch
            {
                Console.WriteLine();
                throw;
            }

        }

        private void loaderProduct()
        {
            try
            {
                con.Open();
                string myQuerry = "select * from ProductTBL";
                SqlDataAdapter da = new SqlDataAdapter(myQuerry, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductGrid.DataSource = ds.Tables[0];
                con.Close();


            }
            catch (Exception exception)

            {
                Console.Write(exception);
                throw;

            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            loader();
            loaderProduct();
            ItemLoader();

        }

        private void CustomerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIDTXT.Text = CustomerGrid.CurrentRow.Cells[0].Value.ToString();

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                string querry = "select * from ProductTBL where ProCat ='" + comboBox1.SelectedValue.ToString() + "'";

                SqlDataAdapter da = new SqlDataAdapter(querry, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductGrid.DataSource = ds.Tables[0];
                con.Close();

            }
            catch
            {
                Console.WriteLine();
                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
