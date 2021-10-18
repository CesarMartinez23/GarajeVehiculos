using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehiculos
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTest frmtest = new frmTest();
            frmtest.MdiParent = this;
            frmtest.Show();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehiculo frmvehiculo = new frmVehiculo();
            frmvehiculo.MdiParent = this;
            frmvehiculo.Show();
        }
    }
}
