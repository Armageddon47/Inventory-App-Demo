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
    public partial class UserManager : Form
    {
        public UserManager()
        {
            InitializeComponent();
        }
        
        private SqlConnection con =
            new SqlConnection(@"Data Source=V-PC;Initial Catalog=Inventory;Integrated Security=True");
        

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loader()
        {
            try
            {
                con.Open();
                string myQuerry = "select * from UserTBL";
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
                SqlCommand com = new SqlCommand("insert into UserTBL values('" + UserTXT.Text + "', '" + FullnameTXT.Text + "'," +
                                                "'" + PasswordTXT.Text + "', '" + PhoneTXT.Text + "' )", con);
                com.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
                con.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            loader();

        }

        private void UserManager_Load(object sender, EventArgs e)
        {
           
                loader();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            UserTXT.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FullnameTXT.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            PasswordTXT.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            PhoneTXT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //UserTXT.Text = dataGridView1.SelectedRows[1].Cells[1].Value.ToString();
            //FullnameTXT.Text = dataGridView1.SelectedRows[1].Cells[2].Value.ToString();
            //PasswordTXT.Text = dataGridView1.SelectedRows[1].Cells[3].Value.ToString();
            //PhoneTXT.Text = dataGridView1.SelectedRows[1].Cells[4].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (UserTXT.Text== "")
            {
                MessageBox.Show("Invalid selection");
            }
            else
            {
                con.Open();
                string myQuerry = "delete from UserTBL where Uphone ='" + PhoneTXT.Text + "';";
                SqlCommand com = new SqlCommand(myQuerry, con);
                com.ExecuteNonQuery();
                MessageBox.Show("User Removed");
                con.Close();
                loader();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("update  UserTBL set Uname = '" + UserTXT.Text + "', Ufullname ='" + FullnameTXT.Text + "', Upassword =" +
                                                "'" + PasswordTXT.Text + "' where Uphone = '" + PhoneTXT.Text + "'", con);
                com.ExecuteNonQuery();
                MessageBox.Show("User Edited");
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
