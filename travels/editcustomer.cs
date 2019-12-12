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
    public partial class editcustomer : Form
    {
        public editcustomer()
        {
            InitializeComponent();
        }

        #region MyRegion
        //private void button2_Click(object sender, EventArgs e)
        //{

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        } 
        #endregion

        private void editcustomer_Load(object sender, EventArgs e)
        {
            TRAVELDB TDB=new TRAVELDB ();
            DataTable dtt = TDB.comboboxedit();
            comboBox5.DataSource = dtt;
            comboBox5.DisplayMember=dtt.Columns[1].ToString();
            comboBox5.ValueMember=dtt.Columns[0].ToString();

            DataTable dt = TDB.comboboxfill();
            comboBox4.DataSource = dt;
            comboBox4.DisplayMember = dt.Columns[1].ToString();
            comboBox4.ValueMember = dt.Columns[0].ToString();
        }

      

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
            comboBox4.Hide();
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox4.Show();

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            try
            {
                string name = comboBox5.Text;
                string country = comboBox6.Text;
                string address = textBox2.Text;
                string sort = "";
                if (radioButton4.Checked == true)
                { sort = "single"; }
                else if (radioButton3.Checked == true)
                { sort = "program"; }
                Int64 idcard = Int64.Parse(maskedTextBox4.Text);
                Int64 phone = Int64.Parse(maskedTextBox3.Text);
                string email = textBox1.Text;
                Int64 tranid = Int64.Parse(comboBox4.SelectedValue.ToString());
                TDB.updatecustomer(name, country, address, sort, idcard, phone, email, tranid);
                MessageBox.Show("data edited Successful");
            }
            catch (Exception)
            { MessageBox.Show("Try Again"); }
            comboBox5.Text = "";
            comboBox6.Text = "";
            textBox2.Text="";
            radioButton4.Checked = false;
            radioButton3.Checked = false;
            maskedTextBox4.Text = "";
            maskedTextBox3.Text = "";
            textBox1.Text = "";
            comboBox4.Text = "";
            editcustomer eee = new editcustomer();
            eee.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            string name = comboBox5.Text.ToString(); 
            string country = "";
            string address = "";
            string sort = "";
            Int64 idcard = 0;
            Int64 phone = 0;
            string email = "";
            Int64 trainid = 0;
            TDB.returndata(name,ref country,ref address,ref sort,ref idcard,ref phone,ref email,ref trainid);
            comboBox6.Text = country;
            textBox2.Text = address;
            if (sort == "Single")
            {
                radioButton4.Checked = true;
            }
            else if (sort == "Program")
            {
                radioButton3.Checked = true;
            }
            maskedTextBox4.Text = idcard.ToString();
            maskedTextBox3.Text = phone.ToString();
            textBox1.Text = email;
            comboBox4.SelectedValue = trainid.ToString();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
