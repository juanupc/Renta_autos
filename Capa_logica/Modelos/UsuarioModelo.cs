using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_datos.Datos;
using Capa_datos.Entidades;
using Capa_datos.Interfacez;
using Capa_logica.Modelos;
using Capa_logica.Valor;
using System.ComponentModel.DataAnnotations;
namespace Capa_logica.Modelos
{
    public class UsuarioModelo
    {
        private int idusuario_;
        private string documento_;
        private string nombrecompleto_;
        private string tipoAfiliacion_;
        private I_Usuarios usuariorepositorio;

        public Entidad_Estado estado {private get; set; }
        private List<UsuarioModelo> listausuario;

        public int Idusuario_ { get => idusuario_; set => idusuario_ = value; }
        
        [Required]
        [RegularExpression("([0-9]+)", ErrorMessage = "El espacio de documentos no puede tener letras ni simbolos especiales")]
        public string Documento_ { get => documento_; set => documento_ = value; }
        [Required]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "el campo 'Nombre' deben ser solo letras")]
        [StringLength(maximumLength: 40, MinimumLength = 4)]
        public string NombreCompleto_ { get => nombrecompleto_; set => nombrecompleto_ = value; }
        [Required]
        [RegularExpression("[(Ocasional),(Contrato)]+$", ErrorMessage = "el campo 'tipo afiliacion' deben ser solo letras")]
        [StringLength(maximumLength: 9, MinimumLength = 8)]
        public string TipoAfiliacion_ { get => tipoAfiliacion_; set => tipoAfiliacion_ = value; }

        public UsuarioModelo()
        {
            usuariorepositorio = new cd_usuarios();
        }
        public string GuardarCambio()
        {
            string mensaje = null;
            try
            {
                var usuariodatomodelo = new Usuarios();
                usuariodatomodelo._IdUsuario = idusuario_;
                usuariodatomodelo._Documento = documento_;
                usuariodatomodelo._NombreCompleto = nombrecompleto_;
                usuariodatomodelo._TipoAfiliacion = tipoAfiliacion_;
                switch (estado)
                {
                    case Entidad_Estado.Agregado:
                        usuariorepositorio.Guardar(usuariodatomodelo);
                        mensaje = "Cliente Guardado Correctamente";
                        break;
                    case Entidad_Estado.Editado:
                        usuariorepositorio.Editar(usuariodatomodelo);
                        mensaje = "Cliente Editado Correctamente";
                        break;
                    case Entidad_Estado.Eliminado:
                        usuariorepositorio.Eliminar(Idusuario_);
                        mensaje = "Cliente Eliminado Correctamente";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
            }
            return mensaje;
        }

        public List<UsuarioModelo> GetAll()
        {
            var usuariodatomodelo = usuariorepositorio.GetAll();
            listausuario = new List<UsuarioModelo>();
            foreach (Usuarios item in usuariodatomodelo)
            {
                listausuario.Add(new UsuarioModelo
                {
                    idusuario_ = item._IdUsuario,
                    documento_ = item._Documento,
                    nombrecompleto_ = item._NombreCompleto,
                    tipoAfiliacion_= item._TipoAfiliacion
                });
            }
            return listausuario;
        }

        public Usuarios BuscarPorIdCliente(int Idusuario)
        {
            var usuariodatomodelo = usuariorepositorio.GetAll();
            var Usuarios = new Usuarios();
            foreach (var item in usuariodatomodelo)
            {
                if (item._IdUsuario == Idusuario)
                {
                    Usuarios._IdUsuario = item._IdUsuario;
                    Usuarios._Documento = item._Documento;
                    Usuarios._NombreCompleto = item._NombreCompleto;
                    Usuarios._TipoAfiliacion = item._TipoAfiliacion;
                    return Usuarios;
                }

            }
            return null;

        }

        public IEnumerable<UsuarioModelo> BuscarClientes(string filtro)
        {
            return listausuario.FindAll(e => e.idusuario_.ToString().Contains(filtro) || e.NombreCompleto_.ToString().Contains(filtro));
        }

    }
}
