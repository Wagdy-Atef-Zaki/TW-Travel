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
    public partial class insertcustomer : Form
    {
        public insertcustomer()
        {
            InitializeComponent();
        }

        #region MyRegion
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        #endregion
        private void insertcustomer_Load(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            DataTable dt = TDB.comboboxfill();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = dt.Columns[1].ToString();
            comboBox2.ValueMember = dt.Columns[0].ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             TRAVELDB TDB = new TRAVELDB();
            try
            {
          
            string name = textBox1.Text;
            string country = comboBox1.Text.ToString();
            string address = textBox3.Text;
            string sort = "";
            if (radioButton1.Checked == true)
            {
                sort = "single";
               
            }
            else if (radioButton2.Checked == true)
            {
                sort = "program";
                
            }
            Int64 idcard = Int64.Parse(maskedTextBox1.Text);
            Int64 phone = Int64.Parse(maskedTextBox2.Text);
            string email = textBox6.Text;
            
            Int64 tranid = int.Parse(comboBox2.SelectedValue.ToString()); 
            TDB.insertcustomer(name, country, address, sort, idcard, phone, email, tranid);
                MessageBox.Show("saved Successfully");
            }
            catch(Exception)
            {
                 MessageBox.Show("You have something missed !!! Please be sure that  all fields is complete");
            }
            textBox1.Clear();
            comboBox1.Text = "";
            textBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            textBox6.Clear();
            comboBox2.Text = "";
            insertcustomer iii = new insertcustomer();
            iii.Refresh();
           


        }

        #region MyRegion
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            //label7.Hide();
            //comboBox2.Hide();
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            //label7.Show();
            //comboBox2.Show();
        }
        
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
