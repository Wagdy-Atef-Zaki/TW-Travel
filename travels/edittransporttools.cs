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
    public partial class edittransporttools : Form
    {
        public edittransporttools()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            DataTable dt = TDB.comboboxshowpprogg();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = dt.Columns[1].ToString();
            comboBox2.ValueMember = dt.Columns[0].ToString();


            TDB.tripnumber(comboBox3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            try
            {
                string type = comboBox4.Text;
                
                string grade = comboBox1.Text.ToString();
                string takingoff = textBox1.Text;
                string arrival = textBox2.Text;
                double cost = double.Parse(maskedTextBox1.Text);
                Int64 tripnum = Int64.Parse(comboBox3.Text.ToString());
                string system = comboBox5.Text;
               
                string direction = textBox7.Text;
                Int64 progid = Int64.Parse(comboBox2.SelectedValue.ToString());
                TDB.updatetransporttools(type, grade, takingoff, arrival, cost, tripnum, system, direction, progid);
                MessageBox.Show("data edited Successful");
            }
            catch (Exception)
            { MessageBox.Show("Try Again"); }
            comboBox3.Text = "";
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Clear();
            maskedTextBox1.Text = "";
         
            textBox7.Text="";
            comboBox2.Text = "";
            comboBox5.Text = "";
            comboBox4.Text = "";

            edittransporttools ee = new edittransporttools();
            ee.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            Int64 tripnumber = Int64.Parse(comboBox3.Text.ToString());
            string type = "";

            string grade = "";
            string timeoff = "";
            string timearrival ="";
            double cost = 0;
            string tripsystem = "";
            string direction = "";
            Int64 progid=0;
            TDB.returntools(tripnumber, ref type, ref grade, ref timeoff, ref timearrival, ref cost, ref tripsystem, ref direction,ref progid);
            comboBox4.Text = type;
            comboBox5.Text = tripsystem;
            textBox1.Text= timeoff;
            textBox2.Text = timearrival;
            maskedTextBox1.Text = cost.ToString();
            comboBox1.Text = grade;
            textBox7.Text = direction;
            comboBox2.SelectedValue= progid;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            textBox2.Text = dateTimePicker2.Value.ToString("dd/MM/yyyy");

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
