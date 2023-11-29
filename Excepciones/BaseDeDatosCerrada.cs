using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class BaseDeDatosCerrada : Exception
    {
        public string mensaje;
        public BaseDeDatosCerrada()
        {
            this.mensaje = "No se pudo acceder a la base de datos. Ábrala y reinicie el programa para continuar.";
        }
    }
}
