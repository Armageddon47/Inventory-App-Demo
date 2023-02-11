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
    public partial class CustomerManagement : Form
    {
        public CustomerManagement()
        {
            InitializeComponent();
        }
        private SqlConnection con =
            new SqlConnection(@"Data Source=V-PC;Initial Catalog=Inventory;Integrated Security=True");


        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();


            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("insert into CustomerTBL values('" + CustomerIDTXT.Text + "', '" + CustomerNameTXT.Text + "'," +
                                                "'" + CustomerPhoneTXT.Text + "' )", con);
                com.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Added");
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ID Must Be UNIQUE!");
               
            }
            loader();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CustomerIDTXT.Text == "")
            {
                MessageBox.Show("Invalid selection");
            }
            else
            {
                con.Open();
                string myQuerry = "delete from CustomerTBL where CustomerID ='" + CustomerIDTXT.Text + "';";
                SqlCommand com = new SqlCommand(myQuerry, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Customer Removed");
                con.Close();
                loader();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIDTXT.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            CustomerNameTXT.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().TrimEnd();
            CustomerPhoneTXT.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString().TrimEnd();
            /*
             * this.CompareStrings(dr["user_name"].ToString(), UserName.Text)--> dr["user_name"].ToString().Trim()
             */
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            loader();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("update  CustomerTBL set " +
                                                "CustomerName = '" + CustomerNameTXT.Text + "', CustomerPhone ='" + CustomerPhoneTXT.Text + "'" +
                                                " where CustomerID = '" + CustomerIDTXT.Text + "'", con);
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
    }
}
