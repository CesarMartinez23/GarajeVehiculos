using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias Utilizadas
using MySql.Data.MySqlClient;

namespace Vehiculos
{
    class Vehiculo
    {
        public int _idCar { get; set; }
        public string _brandCar { get; set; }
        public string _modelCar { get; set; }
        public string _yearCar { get; set; }
        public string _colorCar { get; set; }
        public string _typeCar { get; set; }

        //Intanciar la clase CRUD
        private CRUD crud = new CRUD();

        //Metodo para retornar los registros de la Tabla Vehiculo
        public MySqlDataReader getAllVehiculos()
        {
            string query = "SELECT idCar, brandCar, modelCar, yearCar, colorCar, typeCar FROM vehiculo";

            //Llamado al metodo select de la clase CRUD, para extraer los datos de la tabla de una BD.
            return crud.select(query);
        }
    }
}
