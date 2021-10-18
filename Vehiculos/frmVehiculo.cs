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

            fillDataGridView();
            controlsDisable();
        }

        public void fillDataGridView()
        {
            //Instancia de la clase Vehiculo
            Vehiculo vehiculo = new Vehiculo();

            clearDataGridView();

            dataGridViewRegistrosVehiculos.Columns.Add("idCar", "N.");
            dataGridViewRegistrosVehiculos.Columns.Add("brandCar", "Marca");
            dataGridViewRegistrosVehiculos.Columns.Add("modelCar", "Modelo");
            dataGridViewRegistrosVehiculos.Columns.Add("yearCar", "Año");
            dataGridViewRegistrosVehiculos.Columns.Add("colorCar", "Color");
            dataGridViewRegistrosVehiculos.Columns.Add("typeCar", "Categoria del Vehiculo");

            //Llamado al metodo getVehiculos
            MySqlDataReader dataReader = vehiculo.getAllVehiculos();

            //Leer el resulatdo y mostrarlo en el DataGridView
            while (dataReader.Read())
            {
                dataGridViewRegistrosVehiculos.Rows.Add(
               dataReader.GetValue(0),
               dataReader.GetValue(1),
               dataReader.GetValue(2),
               dataReader.GetValue(3),
               dataReader.GetValue(4),
               dataReader.GetValue(5));
            }
        }

        //Vaciar los registros del DataGridView
        private void clearDataGridView()
        {
            dataGridViewRegistrosVehiculos.Columns.Clear();
            dataGridViewRegistrosVehiculos.Rows.Clear();
        }

        //Desabilitar la vista de los TextBox
        public void controlsDisable()
        {
            TextBoxIdCar.Enabled = false;
            TextBoxBrandCar.Enabled = false;
            TextBoxModelCar.Enabled = false;
            TextBoxYearCar.Enabled = false;
            TextBoxColorCar.Enabled = false;
            TextBoxTypeCard.Enabled = false;
        }

        //Habilita la vista de los TextBox
        public void controlsEnable()
        {
            TextBoxIdCar.Enabled = true;
            TextBoxBrandCar.Enabled = true;
            TextBoxModelCar.Enabled = true;
            TextBoxYearCar.Enabled = true;
            TextBoxColorCar.Enabled = true;
            TextBoxTypeCard.Enabled = true;
        }

        //Limpiar contenido de los TexBox
        public void clearControls()
        {
            TextBoxIdCar.Text = "";
            TextBoxBrandCar.Text = "";
            TextBoxModelCar.Text = "";
            TextBoxYearCar.Text = "";
            TextBoxColorCar.Text = "";
            TextBoxTypeCard.Text = "";
        }

        private void dataGridViewRegistrosVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            metroTabControl.TabPages.Remove(tabRegistrosVehiculos);
            metroTabControl.TabPages.Add(tabNewVehiculo);
            metroTabControl.TabPages[0].Text = "EDITAR VEHICULO";

            action = "edit";
            controlsEnable();

            TextBoxIdCar.Visible = true;
            TextBoxIdCar.ReadOnly= true;
            metroLabelIdCar.Visible = true;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void metroLinkNuevoVehiculo_Click(object sender, EventArgs e)
        {
            metroTabControl.TabPages.Add(tabNewVehiculo);
            metroTabControl.TabPages.Remove(tabRegistrosVehiculos);


            TextBoxIdCar.Visible = false;
            metroLabelIdCar.Visible = false;

            TextBoxBrandCar.Focus();
            action = "new";
            controlsDisable();
            clearControls();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            string messageexit = "¿Estas seguro que deseas irte del Garaje de Cesar Martinez?";
            if(MetroFramework.MetroMessageBox.Show(this, messageexit, "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string messagecancelar = "¿Estas seguro que deseas cancelar el registro del Vehiculo?";
            if (MetroFramework.MetroMessageBox.Show(this, messagecancelar, "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearControls();
                controlsDisable();

                metroTabControl.TabPages.Add(tabRegistrosVehiculos);
                metroTabControl.TabPages.Remove(tabNewVehiculo);

                metroTabControl.TabPages[0].Text = "VEHICULOS REGISTRADOS";
            }
            
        }
    }
}
