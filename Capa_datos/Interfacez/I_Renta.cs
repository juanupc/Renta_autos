using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_datos.Entidades;
namespace Capa_datos.Interfacez
{
    public interface I_Renta:I_Generica<Renta>
    {
        int BuscarUsuarioId(int id);
    }
}
