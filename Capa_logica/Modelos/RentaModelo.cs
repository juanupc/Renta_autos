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
    public class RentaModelo
    {
        private int _IdRenta;
        private Usuarios _Usuario;
        private Vehiculo _Vehiculo;
        private DateTime _Fecha_entrega;
        private int _Kl_Entrega;
        private int _Kl_Recorrido;
        private double _Valor_Kl;
        private double _Descuento;
        private double _Total_pagar;
        private DateTime _Fecha_devuelta;

        private List<RentaModelo> listaRenta;

        private I_Renta RentaRepositorio;

        public Entidad_Estado estado { private get; set; }
        public int IdRenta { get => _IdRenta; set => _IdRenta = value; }
        [Required]
        [StringLength(maximumLength: 40, MinimumLength = 4)]
        public Usuarios Usuario { get => _Usuario; set => _Usuario = value; }
        [Required]
        [StringLength(maximumLength: 40, MinimumLength = 4)]
        public Vehiculo Vehiculo { get => _Vehiculo; set => _Vehiculo = value; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Fecha_entrega { get => _Fecha_entrega; set => _Fecha_entrega = value; }
        [Required]
        [RegularExpression("([0-9]+)", ErrorMessage = "Los espacios de kilometros deden ser solo numeros y sin simbolos especiales")]
        public int Kl_Entrega { get => _Kl_Entrega; set => _Kl_Entrega = value; }
        [Required]
        [RegularExpression("([0-9]+)", ErrorMessage = "Los espacios de kilometros deden ser solo numeros y sin simbolos especiales")]
        public int Kl_Recorrido { get => _Kl_Recorrido; set => _Kl_Recorrido = value; }
        [Required]
        [StringLength(maximumLength: 15, MinimumLength = 3)]
        public double Valor_Kl { get => _Valor_Kl; set => _Valor_Kl = value; }
        [Required]
        [StringLength(maximumLength: 15, MinimumLength = 3)]
        public double Descuento { get => _Descuento; set => _Descuento = value; }
        public double Total_pagar { get => _Total_pagar; set => _Total_pagar = value; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Fecha_devuelta { get => _Fecha_devuelta; set => _Fecha_devuelta = value; }

        public RentaModelo()
        {
            RentaRepositorio = new cd_renta();
        }
        public string GuardarCambio()
        {
            string mensaje = null;
            try
            {
                var usuarioalquilermodelo = new Usuarios();
                var rentadatomodelo = new Renta();
                rentadatomodelo._IdRenta = IdRenta;
                rentadatomodelo._Usuario = Usuario;
                rentadatomodelo._Vehiculo = Vehiculo;
                rentadatomodelo._Fecha_entrega = Fecha_entrega;
                rentadatomodelo._Kl_Entrega = Kl_Entrega;
                rentadatomodelo._Kl_Recorrido = Kl_Recorrido;
                rentadatomodelo._Valor_Kl = Valor_Kl;
                rentadatomodelo._Descuento = Descuento;
                rentadatomodelo._Total_pagar = Total_pagar;
                rentadatomodelo._Fecha_devuelta = Fecha_devuelta;

                switch (estado)
                {
                    case Entidad_Estado.Agregado:
                        RentaRepositorio.Guardar(rentadatomodelo);
                        mensaje = "Renta Guardada Correctamente";
                        break;
                    case Entidad_Estado.Editado:
                        RentaRepositorio.Editar(rentadatomodelo);
                        mensaje = "Renta Actualizada Correctamente";
                        break;
                    case Entidad_Estado.Eliminado:
                        RentaRepositorio.Eliminar(IdRenta);
                        mensaje = "Alquiler Eliminado Correctamente";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
            }
            return mensaje;
        }
        
        public List<RentaModelo> GetAll()
        {
            var usuariodatomodelo = RentaRepositorio.GetAll();
            listaRenta = new List<RentaModelo>();
            foreach (Renta item in usuariodatomodelo)
            {
                listaRenta.Add(new RentaModelo 
                {
                    IdRenta = item._IdRenta,
                    Usuario = item._Usuario,
                    Vehiculo = item._Vehiculo,
                    Fecha_entrega = item._Fecha_entrega,
                    Kl_Entrega = item._Kl_Entrega,
                    Kl_Recorrido = item._Kl_Recorrido,
                    Valor_Kl = item._Valor_Kl,
                    Descuento = item._Descuento,
                    Total_pagar = item._Total_pagar,
                    Fecha_devuelta = item._Fecha_devuelta

                });
            }
            return listaRenta;
        }
        public Renta BuscarClienteExistente(int IdUsuario)
        {
            var rentadatomodelo = RentaRepositorio.GetAll();
            var rentausuario = new Renta();
            foreach (var item in rentadatomodelo)
            {
                if (item._Usuario._IdUsuario == IdUsuario)
                {
                    string mensaje = "Existe un cliente";
                    return rentausuario;
                }
            }
            return null;
        }
        public double AplicarDescuento(double descuento)
        {
            descuento = _Total_pagar / 1.15;
            return descuento;
        }
        public IEnumerable<RentaModelo> busqueda(string filtro)
        {
            return listaRenta.FindAll(e => e._Vehiculo.ToString().Contains(filtro) || e.IdRenta.ToString().Contains(filtro));
        }
    }
}
