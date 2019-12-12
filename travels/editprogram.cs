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
    public partial class editprogram : Form
    {
        public editprogram()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            TDB.showprogmethod(comboBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

  #region MyRegion
		      private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            try
            {
                string name = comboBox2.Text.ToString();
                string datebegin = textBox1.Text;
                string dateend = textBox2.Text;
                string programs = textBox4.Text;
                Int64 travelernum = Int64.Parse(maskedTextBox1.Text);
                string hotel = comboBox1.Text.ToString();
                Int64 cost = Int64.Parse(maskedTextBox2.Text);
                TDB.updateprogram(name, datebegin, dateend, programs, travelernum, hotel, cost);
                MessageBox.Show("Editting Data Successed");
            }
            catch (Exception)
            { MessageBox.Show("Try Again"); }
            comboBox2.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            maskedTextBox1.Text = "";
            comboBox1.Text = "";
            maskedTextBox2.Text = "";
            editprogram ed = new editprogram();
            ed.Refresh();

        }

    
	#endregion     

        private void button2_Click(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            string name = comboBox2.Text.ToString();
            string datebegin = "";
            string dateend = "";
            string programms = "";
            Int64 travelernum = 0;
            string hotel = "";
            double cost = 0;
            TDB.showdatainedit(name,ref datebegin,ref dateend,ref programms,ref travelernum,ref hotel,ref cost);
            textBox1.Text = datebegin.ToString();
            textBox2.Text = dateend.ToString();
            textBox4.Text = programms;
            maskedTextBox1.Text = travelernum.ToString();
            comboBox1.SelectedText = hotel;
            maskedTextBox2.Text = cost.ToString();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            textBox2.Text = dateTimePicker2.Value.ToString("dd/MM/yyyys");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
