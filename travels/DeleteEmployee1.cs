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
    public partial class DeleteEmployee1 : Form
    {
        public DeleteEmployee1()
        {
            InitializeComponent();
        }

        private void DeleteEmployee1_Load(object sender, EventArgs e)
        {
             TRAVELDB TDB = new TRAVELDB();
          
            DataTable dt = TDB.comboboxshowempname();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember=dt.Columns[1].ToString();
            comboBox1.ValueMember = dt.Columns[0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            try
            {
                string name = comboBox1.Text.ToString();
                TDB.deleteemp(name);
                MessageBox.Show("successful delete");
            }
            catch (Exception)
            { MessageBox.Show("Try Again"); }
            DataTable dt = TDB.comboboxshowempname();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = dt.Columns[1].ToString();
            comboBox1.ValueMember = dt.Columns[0].ToString();
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            chosee_employee cc = new chosee_employee();
            cc.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
