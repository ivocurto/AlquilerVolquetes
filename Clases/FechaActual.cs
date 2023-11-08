using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class FechaActual
    {
        public DateTime fechaActual;

        public FechaActual()
        {
            fechaActual = DateTime.Now;
        }

        public string ObtenerFechaActualConFormato()
        {
            return fechaActual.ToString("dd/MM/yy");
        }

        public static FechaActual ObtenerInstancia()
        {
            return new FechaActual();
        }

        public static DateTime operator +(FechaActual fecha, int diasASumar)
        {
            return fecha.fechaActual.AddDays(diasASumar);
        }
    }
}
