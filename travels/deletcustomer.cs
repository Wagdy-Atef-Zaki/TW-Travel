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
    public partial class deletcustomer : Form
    {
        public deletcustomer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
          

        //}

        private void deletcustomer_Load(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            DataTable dt = TDB.comboboxdelete();
            comboBox1.DataSource =dt;
            comboBox1.DisplayMember = dt.Columns[1].ToString();
            comboBox1.ValueMember = dt.Columns[0].ToString();
        }

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
          TRAVELDB TDB = new TRAVELDB();
          try
          {
              Int64 id = Int64.Parse(comboBox1.SelectedValue.ToString());

              TDB.deletcustomer(id);
              MessageBox.Show("successful delete");
          }
          catch (Exception)
          { MessageBox.Show("Try Again"); }


            DataTable dt = TDB.comboboxdelete();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = dt.Columns[1].ToString();
            comboBox1.ValueMember = dt.Columns[0].ToString();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
