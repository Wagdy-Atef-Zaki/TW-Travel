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
    public partial class delettransporttools : Form
    {
        public delettransporttools()
        {
            InitializeComponent();
        }

        #region MyRegion
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        } 
        #endregion

        private void delettransporttools_Load(object sender, EventArgs e)
        {

            TRAVELDB TDB = new TRAVELDB();
            TDB.tripnumbermethod(comboBox1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            TRAVELDB TDB = new TRAVELDB();
            delttool de = new delttool();
            de.Show();
            this.Close();
            try
            {
                string type = "";
                if (radioButton1.Checked == true)
                {
                    type = "flight";
                }
                else if (radioButton2.Checked == true)
                {
                    type = "transportland";
                }
                Int64 tripnum = Int64.Parse(comboBox1.Text.ToString());
                TDB.deletetransporttools(type, tripnum);
                MessageBox.Show("successful delete");
            }
            catch (Exception)
            { MessageBox.Show("Try Again"); }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            TDB.tripnumbermethod(comboBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
           
        //}
    }
}
