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
    public class cd_renta : cd_todos, I_Renta
    {
        private string Seleccionar;
        private string Insertar;
        private string Actualizar;
        private string Elimina;
        private string SeleccionarId;

        public cd_renta()
        {
            Seleccionar = "select * from RENTA";
            Insertar = "insert into RENTA values(@IdUsuario,@IdVehiculo,@Fecha_entrega,@Kl_Entrega" +
                ",@Kl_Recorrido,@Valor_Kl,@Descuento,@Total_pagar,@Fecha_devuelta)";
            Actualizar = "update RENTA set Idusuario=@IdUsuario,IdVehiculo=@IdVehiculo,Fecha_entrega=@Fecha_entrega," +
                "Kl_Entrega=@Kl_Entrega" +
                ",Kl_Recorrido=@Kl_Recorrido,Valor_Kl=@Valor_Kl,Descuento=@Descuento,Total_pagar=@Total_pagar,Fecha_devuelta=@Fecha_devuelta";
            Elimina = "delete from Alquileres where IdRenta=@IdRenta";
            SeleccionarId = "BuscarIdCliente";
        }
        public int BuscarUsuario(Usuarios IdUsuario)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdUsuario", IdUsuario));
            return ExecuteNonQueryProcedure(SeleccionarId);

        }

        public int BuscarUsuarioId(int id)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdUsuario", id));
            return ExecuteNonQueryProcedure(SeleccionarId);
        }

        public int BuscarVehiculo(Vehiculo IdVehiculo)
        {
            throw new NotImplementedException();
        }

        public int Editar(Renta entidad)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdRenta", entidad._IdRenta));
            parameters.Add(new SqlParameter("@IdUsuario", entidad._Usuario));
            parameters.Add(new SqlParameter("@IdVehiculo", entidad._Vehiculo));
            parameters.Add(new SqlParameter("@Fecha_entrega", entidad._Fecha_entrega));
            parameters.Add(new SqlParameter("@Kl_Entrega", entidad._Kl_Entrega));
            parameters.Add(new SqlParameter("@Kl_Recorrido", entidad._Kl_Recorrido));
            parameters.Add(new SqlParameter("@Valor_Kl", entidad._Valor_Kl));
            parameters.Add(new SqlParameter("@Descuento", entidad._Descuento));
            parameters.Add(new SqlParameter("@Total_pagar", entidad._Total_pagar));
            parameters.Add(new SqlParameter("@Fecha_devuelta", entidad._Fecha_devuelta));
            return ExecuteNonQuery(Actualizar);
        }

        public int Eliminar(int ID)
        {
            parameters=new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdRenta", ID));
            return ExecuteNonQuery(Elimina);
        }

        public IEnumerable<Renta> GetAll()
        {
            var result_table = ExecuteReader(Seleccionar);
            var rent_list = new List<Renta>();
            foreach (DataRow item in result_table.Rows)
            {
                rent_list.Add(new Renta
                {
                    _IdRenta = int.Parse(item[0].ToString()),
                    _Usuario = new Usuarios { _IdUsuario = int.Parse(item[1].ToString()) },
                    _Vehiculo = new Vehiculo { _IdVehiculo = int.Parse(item[2].ToString()) },
                    _Fecha_entrega = Convert.ToDateTime(item[3].ToString()),
                    _Kl_Entrega = int.Parse(item[4].ToString()),
                    _Kl_Recorrido = int.Parse(item[5].ToString()),
                    _Valor_Kl = double.Parse(item[6].ToString()),
                    _Descuento = double.Parse(item[7].ToString()),
                    _Total_pagar = double.Parse(item[8].ToString()),
                    _Fecha_devuelta = Convert.ToDateTime(item[9].ToString()),
                });
            }
            return rent_list;
        }

        public int Guardar(Renta entidad)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Idusuario", entidad._Usuario));
            parameters.Add(new SqlParameter("@IdVehiculos", entidad._Vehiculo));
            parameters.Add(new SqlParameter("@Fecha_entrega", entidad._Fecha_entrega));
            parameters.Add(new SqlParameter("@Kl_Entrega", entidad._Kl_Entrega));
            parameters.Add(new SqlParameter("@Kl_Recorrido", entidad._Kl_Recorrido));
            parameters.Add(new SqlParameter("@Valor_Kl", entidad._Valor_Kl));
            parameters.Add(new SqlParameter("@Descuento", entidad._Descuento));
            parameters.Add(new SqlParameter("@Total_pagar", entidad._Total_pagar));
            parameters.Add(new SqlParameter("@Fecha_devuelta", entidad._Fecha_devuelta));
            return ExecuteNonQuery(Insertar);
        }
    }
}
