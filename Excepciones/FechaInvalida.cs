using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class FechaInvalida : Exception
    {
        public FechaInvalida() : base("La fecha de devolución no puede ser anterior a la fecha de entrega.")
        {
        }

        public static void ValidarFechas(DateTime minDate, DateTime maxDate)
        {
            if (maxDate < minDate)
            {
                throw new FechaInvalida();
            }
        }
    }
}
