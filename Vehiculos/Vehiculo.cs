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

        //Metodo para insertar o editar un registro de la BD.
        public bool newEditVehiculo(string action)
        {
            if(action == "new")
            {
                //Insertar datos en la BD.
                string query = "INSERT INTO vehiculo(brandCar, modelCar, yearCar, colorCar, typeCar)" +
                    "VALUES ('"+ _brandCar +"', '"+ _modelCar + "','" + _yearCar + "','" + _colorCar + "','" + _typeCar +"')";
                //Llamado al metodo executeQuery de la Clase CRUD
                crud.executeQuery(query);
                return true;
            }
            else if(action == "edit")
            {
                //Editar datos en la BD.
                string query = "UPDATE vehiculo SET "
                    + "brandCar='" + _brandCar + "',"
                    + "modelCar='" + _modelCar + "',"
                    + "yearCar='" + _yearCar + "',"
                    + "colorCar='" + _colorCar + "',"
                    + "typeCar='" + _typeCar + "'"
                    + "WHERE "
                    + "idCar='" + _idCar + "'";
                //Llamado al metodo executeQuery de la Clase CRUD
                crud.executeQuery(query);
                return true;
            }
            return false;
        }

        //Metodo para eliminar los registros de nuestra tabla de la BD.
        public Boolean deleteVehiculo()
        {
            string query = "DELETE FROM vehiculo WHERE idCar='" + _idCar + "'";
            crud.executeQuery(query);
            return true;
        }
    }
}
