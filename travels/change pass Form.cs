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
    public partial class change_pass_Form : Form
    {
        public change_pass_Form()
        {
            InitializeComponent();
        }

        #region MyRegion
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            maskedTextBox3.Hide();
            label7.Hide();
            button6.Hide();
          
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
            maskedTextBox4.Hide();
            label8.Hide();
            button8.Hide();
           
        }
        #endregion

        private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox2.Hide();
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            string jop = "Manager";
            string name = textBox1.Text;
            Int64 password = 0;
            Int64 pass=Int64.Parse(maskedTextBox1.Text);
            TDB.okpassword(jop,name ,ref password);
            if(pass==password)
            {
                maskedTextBox3.Show();
                label7.Show();
                button6.Show();
               
               
                
            }
            else
            {
                MessageBox.Show("Try Again");
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            Int64 passsword = Int64.Parse(maskedTextBox3.Text);
            TDB.updatepass(passsword);
            MessageBox.Show("Change was successful");
            maskedTextBox3.Hide();
            label7.Hide();
            button6.Hide();
           
            maskedTextBox3.Clear();
            textBox1.Clear();
            maskedTextBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            string jop = "Secretary";
            string name = textBox2.Text;
            Int64 password = 0;
            Int64 pass = Int64.Parse(maskedTextBox2.Text);
            TDB.okpassword(jop, name, ref password);
            if (pass == password)
            {
                maskedTextBox4.Show();
                label8.Show();
                button8.Show();
               


            }
            else
            {
                MessageBox.Show("Try Again");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            Int64 passsword = Int64.Parse(maskedTextBox4.Text);
            TDB.updatepass(passsword);
            MessageBox.Show("Change was successful");
            maskedTextBox4.Hide();
            label8.Hide();
            button8.Hide();
            
            maskedTextBox4.Clear();
            textBox2.Clear();
            maskedTextBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
