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
    public partial class delttool : Form
    {
        public delttool()
        {
            InitializeComponent();
        }

        private void delttool_Load(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            DataTable dt = TDB.method();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember=dt.Columns[0].ToString();
            comboBox1.ValueMember = dt.Columns[1].ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            Int64 id = Int64.Parse(comboBox1.SelectedValue.ToString());
            TDB.deelcusttol(id,comboBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            Int64 id = Int64.Parse(comboBox1.SelectedValue.ToString());
            TDB.deel(id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            delettransporttools de = new delettransporttools();
            de.Show();
        }
    }
}
