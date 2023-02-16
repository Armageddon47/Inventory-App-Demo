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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection con =
            new SqlConnection(@"Data Source=V-PC;Initial Catalog=Inventory;Integrated Security=True");



        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                passwordTXT.UseSystemPasswordChar = true;
            else
                passwordTXT.UseSystemPasswordChar = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sqlDataAdapter =
                new SqlDataAdapter(
                    "select Count(*) from UserTBL where Uname = '" + UserTXT.Text + "' and Upassword = '" +
                    passwordTXT.Text + "'", con);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                ManageItems test = new ManageItems();
                test.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Wrrong user or password");
            }
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
