using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Librerias Utilizadas
using MySql.Data.MySqlClient;

namespace Vehiculos
{
    public partial class frmVehiculo : MetroFramework.Forms.MetroForm
    {
        private string action = "";
        public frmVehiculo()
        {
            InitializeComponent();
        }

        private void frmVehiculo_Load(object sender, EventArgs e)
        {
            metroTabControl.TabPages.Remove(tabNewVehiculo);
        }

        public void fillDataGridView()
        {

        }

        public void controlsDisable()
        {

        }
    }
}
