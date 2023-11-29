using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class TelefonoLongitudException : Exception
    {
        public TelefonoLongitudException() : base("El número de teléfono debe tener 10 dígitos.")
        {
        }
    }
}
