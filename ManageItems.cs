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
    public partial class ManageItems : Form
    {
        public ManageItems()
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
                string myQuerry = "select * from ItemsTBL";
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

        private void ManageItems_Load(object sender, EventArgs e)
        {
            loader();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand com =
                    new SqlCommand("insert into ItemsTBL values('" + ItemsIDTXT.Text + "', '" + ItemsNameTXT.Text + "')", con);
                com.ExecuteNonQuery();
                MessageBox.Show("Items Successfully Added");
                con.Close();
            }
            catch (Exception)
            {
                Console.WriteLine();
                throw;
            }
            loader();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ItemsIDTXT.Text == "")
            {
                MessageBox.Show("Invalid selection");
            }
            else
            {
                con.Open();
                string myQuerry = "delete from ItemsTBL where ItemID ='" + ItemsIDTXT.Text + "';";
                SqlCommand com = new SqlCommand(myQuerry, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Item Removed");
                con.Close();
                loader();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemsIDTXT.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ItemsNameTXT.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("update  ItemsTBL set " +
                                                "ItemName = '" + ItemsNameTXT.Text + "'  where ItemID = '" + ItemsIDTXT.Text + "'", con);
                com.ExecuteNonQuery();
                MessageBox.Show("Item Modified");
                con.Close();
            }
            catch 
            {
                MessageBox.Show("INVALID MOVE");
            }
            loader();
        }
    }
}

