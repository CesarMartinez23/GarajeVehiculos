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
            metroTabControl.TabPages.Add(tabNewVehiculo);
            metroTabControl.TabPages.Remove(tabRegistrosVehiculos);

            metroTabControl.TabPages[0].Text = "EDITAR VEHICULO";
            controlsEnable();

            TextBoxIdCar.ReadOnly = true;
            TextBoxIdCar.Visible = true;
            metroLabelIdCar.Visible = true;
            metroLinkNuevoVehiculo.Visible = false;

            //Pasar los valores del DataGridView hacia los texbox
            TextBoxIdCar.Text = dataGridViewRegistrosVehiculos.CurrentRow.Cells[0].Value.ToString();
            TextBoxBrandCar.Text = dataGridViewRegistrosVehiculos.CurrentRow.Cells[1].Value.ToString();
            TextBoxModelCar.Text = dataGridViewRegistrosVehiculos.CurrentRow.Cells[2].Value.ToString();
            TextBoxYearCar.Text = dataGridViewRegistrosVehiculos.CurrentRow.Cells[3].Value.ToString();
            TextBoxColorCar.Text = dataGridViewRegistrosVehiculos.CurrentRow.Cells[4].Value.ToString();
            TextBoxTypeCard.Text = dataGridViewRegistrosVehiculos.CurrentRow.Cells[5].Value.ToString();

            action = "edit";

            TextBoxBrandCar.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (TextBoxBrandCar.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe ingresar un dato en el campo Marca: !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxBrandCar.Focus();
            }
            else if (TextBoxModelCar.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe ingresar un dato en el campo Modelo: !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxModelCar.Focus();
            }
            else if (TextBoxYearCar.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe ingresar un dato en el campo Año: !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxYearCar.Focus();
            }
            else if (TextBoxColorCar.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe ingresar un dato en el campo Color: !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxColorCar.Focus();
            }
            else if (TextBoxTypeCard.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe ingresar un dato en el campo Tipo: !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxTypeCard.Focus();
            }
            else
            {

            
            Vehiculo vehiculo = new Vehiculo();

            //Evaluar la accion a realizar.
            if(action == "edit")
            {
                vehiculo._idCar = Convert.ToInt32(TextBoxIdCar.Text);
            }

            vehiculo._brandCar = TextBoxBrandCar.Text;
            vehiculo._modelCar = TextBoxModelCar.Text;
            vehiculo._yearCar = TextBoxYearCar.Text;
            vehiculo._colorCar = TextBoxColorCar.Text;
            vehiculo._typeCar = TextBoxTypeCard.Text;

            string messageGuardar = "¿Estas seguro que deseas guardar los datos del Vehiculo?";
            if(MetroFramework.MetroMessageBox.Show(this , messageGuardar, "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Llamar al metodo Guardar
                if (vehiculo.newEditVehiculo(action))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos del vehiculo se han guardado correctamente!", "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos del vehiculo no se han guardado correctamente!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clearControls();
                controlsDisable();
                fillDataGridView();

                metroTabControl.TabPages.Remove(tabNewVehiculo);
                metroTabControl.TabPages.Add(tabRegistrosVehiculos);
                metroTabControl.TabPages[0].Text = "Lista de Vehiculos";

            }

            }

        }

        private void metroLinkNuevoVehiculo_Click(object sender, EventArgs e)
        {
            metroTabControl.TabPages.Add(tabNewVehiculo);
            metroTabControl.TabPages.Remove(tabRegistrosVehiculos);


            TextBoxIdCar.Visible = false;
            metroLabelIdCar.Visible = false;
            metroLinkNuevoVehiculo.Visible = false;

            TextBoxBrandCar.Focus();
            action = "new";
            controlsEnable();
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

        private void edit_Click(object sender, EventArgs e)
        {
            metroTabControl.TabPages.Add(tabNewVehiculo);
            metroTabControl.TabPages.Remove(tabRegistrosVehiculos);

            metroTabControl.TabPages[0].Text = "EDITAR VEHICULO";
            controlsEnable();

            TextBoxIdCar.ReadOnly = true;
            TextBoxIdCar.Visible = true;
            metroLabelIdCar.Visible = true;

            //Pasar los valores del DataGridView hacia los texbox
            TextBoxIdCar.Text = dataGridViewRegistrosVehiculos.CurrentRow.Cells[0].Value.ToString();
            TextBoxBrandCar.Text = dataGridViewRegistrosVehiculos.CurrentRow.Cells[1].Value.ToString();
            TextBoxModelCar.Text = dataGridViewRegistrosVehiculos.CurrentRow.Cells[2].Value.ToString();
            TextBoxYearCar.Text = dataGridViewRegistrosVehiculos.CurrentRow.Cells[3].Value.ToString();
            TextBoxColorCar.Text = dataGridViewRegistrosVehiculos.CurrentRow.Cells[4].Value.ToString();
            TextBoxTypeCard.Text = dataGridViewRegistrosVehiculos.CurrentRow.Cells[5].Value.ToString();

            action = "edit";

            TextBoxBrandCar.Focus();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            string messageDelete = "¿Estas seguro que deseas eliminar el registro del Vehiculo?";
            if (MetroFramework.MetroMessageBox.Show(this, messageDelete, "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Vehiculo vehiculo = new Vehiculo();
                vehiculo._idCar = Convert.ToInt32(dataGridViewRegistrosVehiculos.CurrentRow.Cells[0].Value);

                //Llamando al metodo delete.
                if (vehiculo.deleteVehiculo())
                {
                    MetroFramework.MetroMessageBox.Show(this, "El registro del vehiculo se ha eliminado correctamente!", "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Actualizar el DataGridView
                    fillDataGridView();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "El registro del vehiculo no se ha podido eliminado correctamente!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
