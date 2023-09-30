using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Sede
    {
        private string nombreSede;
        private int stockEnSede;


        public Sede(string nombreSede, int stockEnSede)
        {
            this.NombreSede = nombreSede;
            this.StockEnSede = stockEnSede;
        }

        public string NombreSede { get => nombreSede; set => nombreSede = value; }
        public int StockEnSede { get => stockEnSede; set => stockEnSede = value; }
    }
}
