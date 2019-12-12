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
    public partial class alltool : Form
    {
        public alltool()
        {
            InitializeComponent();
        }

        private void alltool_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelDataSet7.TransportToolsTB' table. You can move, or remove it, as needed.
            this.transportToolsTBTableAdapter.Fill(this.travelDataSet7.TransportToolsTB);

        }
    }
}
