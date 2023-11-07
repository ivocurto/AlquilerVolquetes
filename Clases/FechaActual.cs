using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class FechaActual
    {
        public static DateTime ObtenerFechaActual()
        {
            return DateTime.Now;
        }

        public static string ObtenerFechaActualConFormato()
        {
            return DateTime.Now.ToString("dd/MM/yy");
        }
    }
}
