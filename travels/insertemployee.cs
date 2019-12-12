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
    public partial class insertemployee : Form
    {
        public insertemployee()
        {
            InitializeComponent();
        }

        #region MyRegion
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void insertemployee_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        } 
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
           
            TRAVELDB TDB = new TRAVELDB();
            try
            {
                string name = txtname.Text;
                string address = txtaddress.Text;
                string mail = txtemail.Text;
                string qualification = txtqualifications.Text;
                Int64 pass = Int64.Parse(maskedTextBox5.Text);
                string jop = comboBox3.Text.ToString();
                Int64 workhours = Int64.Parse(comboBox4.Text.ToString());
                Int64 vacation = Int64.Parse(comboBox5.Text.ToString());
                double salary = double.Parse(maskedTextBox3.Text);
                Int64 idcard = Int64.Parse(maskedTextBox1.Text);
                string gender = comboBox1.Text.ToString();
                Int64 phone = Int64.Parse(maskedTextBox2.Text);
                Int64 age = Int64.Parse(maskedTextBox4.Text);
                string statue = comboBox2.Text.ToString();
                //var photo = pictureBox1.Image;
                TDB.insertemployee(name, jop, workhours, vacation, pass, salary, idcard, gender, address, phone, age, qualification, statue, mail);//+image
                MessageBox.Show("saved Successfully");
            }
            catch (Exception)
            { MessageBox.Show("You have something missed !!! Please be sure that  all fields is complete"); }
            txtname.Text = "";
            txtaddress.Text = "";
            txtqualifications.Clear();
            txtemail.Text = "";
            maskedTextBox5.Clear();
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            maskedTextBox3.Clear();
            maskedTextBox1.Clear();
            comboBox1.Text = "";
            maskedTextBox2.Clear();
            maskedTextBox4.Clear();
            comboBox2.Text = "";
            insertemployee ii = new insertemployee();
            ii.Refresh();
           
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        //    }
        //}

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            chosee_employee cc = new chosee_employee();
            cc.Show();
           
        }
    }
}
