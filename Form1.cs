using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_App_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

      

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
    }
}
