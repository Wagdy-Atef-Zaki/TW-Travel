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
    public partial class deletprogram : Form
    {
        public deletprogram()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            TRAVELDB TDB = new TRAVELDB();
            DataTable dt = TDB.comboboxshowprog();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = dt.Columns[1].ToString();
            comboBox1.ValueMember = dt.Columns[0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            dellprog dd = new dellprog();
            dd.Show();
            this.Close();
            TRAVELDB TDB = new TRAVELDB();
            try

            {

            Int64 id = Int64.Parse(comboBox1.SelectedValue.ToString());
            TDB.deleteprogram(id);
           // MessageBox.Show("successful delete");
            }
            catch(Exception)
            {MessageBox.Show("Try Again");}
            comboBox1.Text = "";
            deletprogram del = new deletprogram();
            del.Refresh();
        }
    }
}
