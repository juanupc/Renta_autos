using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Capa_presentacion.Validacion
{
    public class V_Datos
    {
        private ValidationContext context;
        private List<ValidationResult> resultados;
        private bool validacion;
        private string mensaje;
        public V_Datos(object instace)
        {
            context = new ValidationContext(instace);
            resultados = new List<ValidationResult>();
            validacion = Validator.TryValidateObject(instace, context, resultados, true);
        }
        public bool validated()
        {
            if (validacion == false)
            {
                foreach (ValidationResult item in resultados)
                {
                    mensaje += item.ErrorMessage + "\n";
                }
                System.Windows.Forms.MessageBox.Show(mensaje);
            }
            return validacion;
        }
    }

}
