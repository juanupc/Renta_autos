using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Capa_datos
{
    public class conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["conexion"].ToString();
    
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(cadena);
        }
    }
}
