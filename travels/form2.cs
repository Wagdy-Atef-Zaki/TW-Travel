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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            TRAVELDB TDB = new TRAVELDB();
            try
            {
               
                string progname = textBox1.Text;
                string datebegin = textBox2.Text;
                string dateend = textBox3.Text;
                string programs = textBox4.Text;
                Int64 travelernum = Int64.Parse(maskedTextBox1.Text);
                string hotel = comboBox1.Text.ToString();
                double cost = double.Parse(maskedTextBox2.Text);
                TDB.insertprogram(progname, datebegin, dateend, programs, travelernum, hotel, cost);
                MessageBox.Show("Saved successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("You have something missed !!! Please be sure that  all fields is complete");
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = "";
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            Form2 ff = new Form2();
                ff.Refresh();
       
             
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            textBox3.Text = dateTimePicker2.Value.ToString("dd/MM/yyyy");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
