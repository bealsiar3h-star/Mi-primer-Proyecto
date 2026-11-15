using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistrictFood
{
    public class Conexion
    {
        // IMPORTANTE: Cambia "TU_SERVIDOR_SQL" por el nombre de tu servidor en SQL Server
        // Ejemplo: "localhost" o "DESKTOP-12345\\SQLEXPRESS"
        private static string cadena =  @"Server=(localdb)\mssqllocaldb; Database=DB_DistrictFood; Integrated Security=True;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }
}
