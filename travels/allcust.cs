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
    public partial class allcust : Form
    {
        public allcust()
        {
            InitializeComponent();
        }

        private void allcust_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelDataSet11.TransportToolsTB' table. You can move, or remove it, as needed.
            this.transportToolsTBTableAdapter.Fill(this.travelDataSet11.TransportToolsTB);
            // TODO: This line of code loads data into the 'travelDataSet11.CustomerTB' table. You can move, or remove it, as needed.
            this.customerTBTableAdapter.Fill(this.travelDataSet11.CustomerTB);

        }
    }
}
