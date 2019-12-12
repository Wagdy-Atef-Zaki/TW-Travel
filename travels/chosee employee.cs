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
    public partial class chosee_employee : Form
    {
        public chosee_employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertemployee ii = new insertemployee();
            ii.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Editemployee ee = new Editemployee();
            ee.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DeleteEmployee1 dd = new DeleteEmployee1();
            dd.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
            this.Close();
        }

        private void chosee_employee_Load(object sender, EventArgs e)
        {

        }
    }
}
