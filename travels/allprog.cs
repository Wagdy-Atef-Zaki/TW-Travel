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
    public partial class allprog : Form
    {
        public allprog()
        {
            InitializeComponent();
        }

        private void allprog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelDataSet8.ProgrammTravelTB' table. You can move, or remove it, as needed.
            this.programmTravelTBTableAdapter.Fill(this.travelDataSet8.ProgrammTravelTB);

        }
    }
}
