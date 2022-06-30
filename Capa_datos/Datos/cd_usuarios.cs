using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_datos.Entidades;
using Capa_datos.Interfacez;
using System.Data;
using System.Data.SqlClient;

namespace Capa_datos.Datos
{
    public class cd_usuarios : cd_todos, I_Usuarios
    {
        private string Seleccionar;
        private string Insertar;
        private string Actualizar;
        private string Elimina;

        public cd_usuarios()
        {
            Seleccionar = "select * from USUARIOS";
            Insertar = "insert into USUARIOS values(@Documento,@NombreCompleto,@TipoAfiliacion)";
            Actualizar = "update USUARIOS ser Documento=@Documento,NombreCompleto=@NombreCompleto,TipoAfiliacion=@TipoAfiliacion where IdUsuario=@IdUsuario";
            Elimina = "delete from USUARIOS where IdUsuario=@IdUsuario";

        }
        public int Editar(Usuarios entidad)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdUsuario", entidad._IdUsuario));
            parameters.Add(new SqlParameter("@Documento", entidad._Documento));
            parameters.Add(new SqlParameter("@NombreCompleto", entidad._NombreCompleto));
            parameters.Add(new SqlParameter("@TipoAfiliacion", entidad._TipoAfiliacion));
            return ExecuteNonQuery(Actualizar);
        }

        public int Eliminar(int ID)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdUsuario", ID));
            return ExecuteNonQuery(Elimina);
        }

        public IEnumerable<Usuarios> GetAll()
        {
            var result_tables = ExecuteReader(Seleccionar);
            var user_list = new List<Usuarios>();
            foreach (DataRow item in result_tables.Rows)
            {
                user_list.Add(new Usuarios
                {
                    _IdUsuario = int.Parse(item[0].ToString()),
                    _Documento = item[1].ToString(),
                    _NombreCompleto = item[2].ToString(),
                    _TipoAfiliacion = item[3].ToString(),
                });
            }
            return user_list;
        }

        public int Guardar(Usuarios entidad)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Documento", entidad._Documento));
            parameters.Add(new SqlParameter("@NombreCompleto", entidad._NombreCompleto));
            parameters.Add(new SqlParameter("@TipoAfiliacion", entidad._TipoAfiliacion));
            return ExecuteNonQuery(Insertar);
        }
    }
}
