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
    public partial class Editemployee : Form
    {
        public Editemployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        //private void panel2_Paint(object sender, PaintEventArgs e)
        //{

        //}

        private void Editemployee_Load(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
          
            DataTable dt = TDB.comboboxshowempname();
            comboBox7.DataSource = dt;
            comboBox7.DisplayMember=dt.Columns[1].ToString();
            comboBox7.ValueMember=dt.Columns[0].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            string name = comboBox7.Text.ToString();
            string jop = "";
            Int64 workhours = 0;
            Int64 vacations = 0;
            Int64 passward = 0;                     //image
            double salary = 0;
            Int64 idcard = 0;
            string gender = "";
            string address = "";
            Int64 phone = 0;
            Int64 age = 0;
            string qualification = "";
            string statue = "";
            string email = "";
            TDB.showinformation( name,ref jop,ref workhours,ref vacations,ref passward,ref salary,ref idcard,ref gender,ref address,ref phone,ref age,ref qualification,ref statue,ref email);
            maskedTextBox6.Text = passward.ToString();
            comboBox10.Text = jop;
            comboBox9.Text = workhours.ToString();
            comboBox8.Text = vacations.ToString();
            maskedTextBox8.Text = salary.ToString();
            maskedTextBox10.Text = idcard.ToString();
            comboBox12.Text = gender;
            textBox3.Text = address;
            maskedTextBox9.Text = phone.ToString();
            maskedTextBox7.Text = age.ToString();
            textBox2.Text = qualification;
            comboBox11.Text = statue;
            textBox1.Text = email;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            try
            {
                Int64 id = Int64.Parse(comboBox7.SelectedValue.ToString());
                Int64 pass = Int64.Parse(maskedTextBox6.Text);
                string jop = comboBox10.Text.ToString();
                Int64 workhours = Int64.Parse(comboBox9.Text.ToString());
                Int64 vacation = Int64.Parse(comboBox8.Text.ToString());
                double salary = double.Parse(maskedTextBox8.Text);
                Int64 idcard = Int64.Parse(maskedTextBox10.Text);
                string gender = comboBox12.Text.ToString();
                string address = textBox3.Text;
                Int64 phone = Int64.Parse(maskedTextBox9.Text);
                Int64 age = Int64.Parse(maskedTextBox7.Text);
                string quallification = textBox2.Text;
                string statue = comboBox11.Text.ToString();
                string mail = textBox1.Text;
                var photo = pictureBox1.Image;
                TDB.updateemp(id, jop, workhours, vacation, pass, salary, idcard, gender, address, phone, age, quallification, statue, mail);//+image
                MessageBox.Show("Data Edited Successful");
            }
            catch (Exception)
            { MessageBox.Show("Try Again"); }
            comboBox7.Text = "";
            maskedTextBox6.Clear();
            comboBox10.Text = "";
            comboBox9.Text = "";
            comboBox8.Text = "";
            maskedTextBox8.Clear();
            maskedTextBox10.Clear();
            comboBox12.Text = "";
            textBox3.Clear();
            maskedTextBox9.Clear();
            maskedTextBox7.Clear();
            textBox2.Clear();
            comboBox11.Text = "";
            textBox1.Clear();

            Editemployee em = new Editemployee();
            em.Refresh();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            chosee_employee cc = new chosee_employee();
            cc.Show();
           
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        //    }
        //}

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
