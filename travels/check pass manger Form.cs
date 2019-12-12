using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace travels
{
    public partial class check_pass_manger_Form : Form
    {
        public check_pass_manger_Form()
        {
            InitializeComponent();
        }

        private void check_pass_manger_Form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            string jop = "Manager";
            string name = textBox1.Text;
            Int64 pass = Int64.Parse(maskedTextBox1.Text);
            Int64 password = 0;
            TDB.checkbassword(jop, name, ref password);
            if (pass == password)
            {
                MessageBox.Show("Welcome to Informations of Employee of TW Travel");
                this.Close();
                chosee_employee ce = new chosee_employee();
                ce.Show();
               
            }
            else
            {
                MessageBox.Show("Please Check Your name or Your Password");
            }
        }
    }
}
