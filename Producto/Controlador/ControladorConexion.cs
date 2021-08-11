using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;

namespace Controlador
{
    //CREACION DE CONTROLADOR PARA LA BASE DE DATOS
    public class ControladorConexion
    {
        public static MySqlConnection Conexion()
        {
            return ModeloConexion.ObtenerConexion();
        }
    }
}
