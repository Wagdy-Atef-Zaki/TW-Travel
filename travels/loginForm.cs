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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            try
            {
                string jop = "";
                if (radioButton1.Checked == true)
                {
                    jop = "Manager";
                }
                else
                {
                    jop = "Secretary";
                }
                string name = textBox1.Text;
                Int64 pass = Int64.Parse(maskedTextBox1.Text);
                Int64 password = 0;
                TDB.checkbassword(jop, name, ref password);
                if (pass == password)
                {
                    MessageBox.Show("Welcome to TW Travel");
                    loginForm ll = new loginForm();
                    ll.Hide();

                    Total_Form TF = new Total_Form();
                    TF.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please Check Your name or Your Password");
                }
            }
            catch (Exception)
            { MessageBox.Show("Enter The Login Name And Login Bassword"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
