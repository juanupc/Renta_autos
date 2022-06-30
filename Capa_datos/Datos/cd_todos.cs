using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Capa_datos.Datos
{
    public abstract class cd_todos:conexion
    {
        protected List<SqlParameter> parameters;
        protected int ExecuteNonQuery(string Sql)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = Sql;
                    cmd.CommandType = CommandType.Text;
                    foreach (SqlParameter item in parameters)
                    {
                        cmd.Parameters.Add(item);
                    }
                    int result = cmd.ExecuteNonQuery();
                    parameters.Clear();
                    return result;

                }
            }
        }
        protected DataTable ExecuteReader(string sql)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    using (var table = new DataTable())
                    {
                       table.Load(reader);
                       reader.Dispose();
                       return table;
                    }
                }
            }
        }
        protected int ExecuteNonQueryProcedure(string sql)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach(SqlParameter item in parameters)
                    {
                        cmd.Parameters.Add(item);
                    }
                    int result = cmd.ExecuteNonQuery();
                    parameters.Clear();
                    return result;
                }
            }
        }

    }
}
