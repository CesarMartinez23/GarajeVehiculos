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
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string connectionString = "";

            MySqlConnection con;

            try
            {
                //Definir string de conexion
                connectionString = @"Server=localhost;Database=vehiculos;Uid=root;Pwd=; SSL MODE= None";
                con = new MySqlConnection(connectionString); //Creamos la conexion a la BD
                con.Open(); //Iniciar la conexcion a la BD

                MetroFramework.MetroMessageBox.Show(this, "Se establecio conexion a la Base de Datos, correctamente!", "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            catch (Exception Ex)
            {
                MetroFramework.MetroMessageBox.Show(this, Ex.Message, "EXCEPCION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
