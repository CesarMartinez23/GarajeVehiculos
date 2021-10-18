using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias Utilizadas
using MySql.Data.MySqlClient;

namespace Vehiculos
{
    class CRUD
    {
        //Instanciar la clase Connection de la BD
        private Connection connetion = new Connection();

        //Metodo para selecionar los registros de la tabla de la BD
        public MySqlDataReader select(string query)
        {
            MySqlDataReader dataReader;

            //Utilizar command de la clase Connection
            connetion.command = new MySqlCommand(query, connetion.openConnection());
            dataReader = connetion.command.ExecuteReader();
            return dataReader;
        }
    }
}

