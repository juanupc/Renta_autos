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
    public class VehiculoModelo
    {
        private int idVehiculo_;
        private string placa_;
        private string marca_;
        private string Kl_Inicial_;

        private List<VehiculoModelo> listavehiculo;
        private I_vehiculos vehiculorepositorio;

        public Entidad_Estado estado { private get; set; }
        public int IdVehiculo { get => idVehiculo_; set => idVehiculo_ = value; }
        [Required]
        [StringLength(maximumLength: 40, MinimumLength = 4)]
        public string Placa { get => placa_; set => placa_ = value; }
        [Required]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "el campo 'Marca' debe ser solo letra")]
        [StringLength(maximumLength: 50, MinimumLength = 4)]
        public string Marca { get => marca_; set => marca_ = value; }
        [Required]
        [RegularExpression("([0-9]+)", ErrorMessage = "el campo 'Kilometraje' debe ser solo Numero Sin Espacios Ni Puntos")]
        [StringLength(maximumLength: 40, MinimumLength = 4)]
        public string Kl_Inicial { get => Kl_Inicial_; set => Kl_Inicial_ = value; }

        public VehiculoModelo()
        {
            vehiculorepositorio = new cd_vehiculo();
        }

        public string GuardarCambio()
        {
            string mensaje = null;
            try
            {
                var vehiculodatomodelo = new Vehiculo();
                vehiculodatomodelo._IdVehiculo = IdVehiculo;
                vehiculodatomodelo._Placa = Placa;
                vehiculodatomodelo._Marca = Marca;
                vehiculodatomodelo._Kl_Inicial = Kl_Inicial;
                switch (estado)
                {
                    case Entidad_Estado.Agregado:
                        vehiculorepositorio.Guardar(vehiculodatomodelo);
                        mensaje = "Vehiculo Registrado Correctamente";
                        break;
                    case Entidad_Estado.Editado:
                        vehiculorepositorio.Editar(vehiculodatomodelo);
                        mensaje = "Vehiculo Editado Correctamente";
                        break;
                    case Entidad_Estado.Eliminado:
                        vehiculorepositorio.Eliminar(IdVehiculo);
                        mensaje = "Vehiculo Eliminado Correctamente";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
            }
            return mensaje;
        }
        public List<VehiculoModelo> GetAll()
        {
            var vehiculodatomodelo = vehiculorepositorio.GetAll();
            listavehiculo = new List<VehiculoModelo>();
            foreach (Vehiculo item in vehiculodatomodelo)
            {
                listavehiculo.Add(new VehiculoModelo
                {
                    idVehiculo_ = item._IdVehiculo,
                    placa_ = item._Placa,
                    marca_ = item._Marca,
                    Kl_Inicial_ = item._Kl_Inicial
                });
            }
            return listavehiculo;
        }
        public Vehiculo BuscarPorIdVehiculo(int IdVehiculo)
        {
            var vehiculodatomodelo = vehiculorepositorio.GetAll();
            var Vehiculo = new Vehiculo();
            foreach (var item in vehiculodatomodelo)
            {
                if (item._IdVehiculo == IdVehiculo)
                {
                    Vehiculo._IdVehiculo = item._IdVehiculo;
                    Vehiculo._Placa = item._Placa;
                    return Vehiculo;
                }
            }
            return null;
        }
        public IEnumerable<VehiculoModelo> busqueda(string filtro)
        {
            return listavehiculo.FindAll(e => e.idVehiculo_.ToString().Contains(filtro) || e.marca_.ToString().Contains(filtro));
        }
    }
}
