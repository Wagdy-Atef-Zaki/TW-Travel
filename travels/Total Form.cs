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
    public partial class Total_Form : Form
    {
        public Total_Form()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void progToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            check_pass_manger_Form ccc = new check_pass_manger_Form();
            ccc.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_pass_Form cf = new change_pass_Form();
            cf.Show();
        }

        private void newProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void editProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editprogram ep = new editprogram();
            ep.Show();
        }

        private void deleteProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletprogram dp = new deletprogram();
            dp.Show();
        }

        private void allProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allprog ap = new allprog();
            ap.Show();
        }

        private void newToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inserttransporttools it = new inserttransporttools();
            it.Show();
        }

        private void editToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edittransporttools et = new edittransporttools();
            et.Show();
        }

        private void deleteToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delettransporttools dt = new delettransporttools();
            dt.Show();
        }

        private void allToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alltool at = new alltool();
            at.Show();
        }

        private void jkkkkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertcustomer ic = new insertcustomer();
            ic.Show();
        }

        private void editCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editcustomer ec = new editcustomer();
            ec.Show();
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletcustomer dc = new deletcustomer();
            dc.Show();
        }

        private void allcustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allcust ac = new allcust();
            ac.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Total_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
