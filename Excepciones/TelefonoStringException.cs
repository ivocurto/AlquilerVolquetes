using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class TelefonoStringException : Exception
    {
        public TelefonoStringException() : base("No se puede ingresar un texto como número de teléfono.")
        {
        }
    }
}
