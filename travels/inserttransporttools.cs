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
    public partial class inserttransporttools : Form
    {
        public inserttransporttools()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
           
        //}

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void inserttransporttools_Load(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            DataTable dt = TDB.comboboxshowpprogg();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember=dt.Columns[1].ToString();
            comboBox2.ValueMember=dt.Columns[0].ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
            TRAVELDB TDB = new TRAVELDB();
            try
            {
            string type = "";
            if (radioButton1.Checked == true)
            {
                type = "flight";
            }
            else if (radioButton2.Checked == true)
            {
                type = "Transport Land";
            }
            string grade = comboBox1.Text.ToString();
            string takingoff = textBox1.Text;
            string arrival = textBox2.Text;
            double cost = double.Parse(maskedTextBox1.Text);
            Int64 tripnum = Int64.Parse(maskedTextBox2.Text);
            string system = "";
            if (checkBox1.Checked == false)
            {
                system = "Go and Return";
            }
            else if (checkBox1.Checked == true)
            {
                system = "Go Only";
            }
            string durationn = textBox7.Text;
            Int64 progid = Int64.Parse(comboBox2.SelectedValue.ToString());

            TDB.inserttransportools(type, grade, takingoff, arrival, cost, tripnum, system, textBox7.Text, progid);
                MessageBox.Show("saved Successfully");
            }
            catch(Exception)
            { MessageBox.Show("You have something missed !!! Please be sure that  all fields is complete");}
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.Text = "";
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            checkBox1.Checked = false;
            textBox7.Clear();
            comboBox2.Text = "";
            textBox1.Clear();
            textBox2.Clear();
            inserttransporttools tt = new inserttransporttools();
            tt.Refresh();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            textBox2.Text = dateTimePicker2.Value.ToString("dd/MM/yyyy");
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
