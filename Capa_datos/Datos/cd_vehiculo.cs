using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_datos.Entidades;
using Capa_datos.Interfacez;

namespace Capa_datos.Datos
{
    public class cd_vehiculo : cd_todos, I_vehiculos
    {
        private string Seleccionar;
        private string Insertar;
        private string Actualizar;
        private string Elimina;
        
        public cd_vehiculo()
        {
            Seleccionar = "select * from VEHICULO";
            Insertar = "insert into VEHICULO values(@Placa,@Marca,@Kl_Inicial)";
            Actualizar = "update VEHICULO set Placa=@Placa,Marca=@Marca,Kl_Inicial=@Kl_Inicial where IdVehiculo=@IdVehiculo";
            Elimina = "delete from VEHICULO where IdVehiculo=@IdVehiculo";
        }


        public int Editar(Vehiculo entidad)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdVehiculo", entidad._IdVehiculo));
            parameters.Add(new SqlParameter("@Placa", entidad._Placa));
            parameters.Add(new SqlParameter("@Kl_Inicial", entidad._Kl_Inicial));
            return ExecuteNonQuery(Actualizar);
        }

        public int Eliminar(int ID)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdVehiculo", ID));
            return ExecuteNonQuery(Elimina);
        }

        public IEnumerable<Vehiculo> GetAll()
        {
            var result_tables = ExecuteReader(Seleccionar);
            var cars_list = new List<Vehiculo>();
            foreach (DataRow item in result_tables.Rows)
            {
                cars_list.Add(new Vehiculo
                {
                    _IdVehiculo = int.Parse(item[0].ToString()),
                    _Placa = item[1].ToString(),
                    _Marca = item[2].ToString(),
                    _Kl_Inicial = item[3].ToString(),
                });
            }
            return cars_list;
        }

        public int Guardar(Vehiculo entidad)
        {

            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Placa", entidad._Placa));
            parameters.Add(new SqlParameter("@Marca", entidad._Marca));
            parameters.Add(new SqlParameter("@Kl_Inicial", entidad._Kl_Inicial));
            return ExecuteNonQuery(Insertar);
        }
    }
}
