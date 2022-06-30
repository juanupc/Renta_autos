using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_datos.Interfacez
{
    public interface I_Generica <Entidad> where Entidad : class
    {
        int Guardar(Entidad entidad);
        int Editar(Entidad entidad);
        int Eliminar(int ID);
        IEnumerable<Entidad> GetAll();
    }
}
