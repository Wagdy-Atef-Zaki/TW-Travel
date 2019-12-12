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
    public partial class dellprog : Form
    {
        public dellprog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            Int64 id = Int64.Parse(comboBox1.SelectedValue.ToString());
            TDB.deelprog(id, comboBox2);
        }

        private void dellprog_Load(object sender, EventArgs e)
        {
             TRAVELDB TDB = new TRAVELDB();
            DataTable dt =TDB.combooprog();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember=dt.Columns[1].ToString();
            comboBox1.ValueMember = dt.Columns[0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            Int64 id = Int64.Parse(comboBox1.SelectedValue.ToString());
            TDB.deelpp(id);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            deletprogram dp = new deletprogram();
            dp.Show();
        }
    }
}
