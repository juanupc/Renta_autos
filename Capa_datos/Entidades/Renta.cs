using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_datos.Entidades;

namespace Capa_datos.Entidades
{
    public class Renta
    {
        public int _IdRenta { get; set; }
        public Usuarios _Usuario { get; set; }
        public Vehiculo _Vehiculo { get; set; }
        public DateTime _Fecha_entrega { get; set; }
        public int _Kl_Entrega { get; set; }
        public int _Kl_Recorrido { get; set; }
        public double _Valor_Kl { get; set; }
        public double _Total_pagar { get; set; }
        public double _Descuento { get; set; }
        public DateTime _Fecha_devuelta { get; set; }

    }
}
