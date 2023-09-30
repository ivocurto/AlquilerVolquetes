using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class VolqueteDisponible : Volquete
    {
        private string ultimaVezAlquilado;
        public VolqueteDisponible(float capacidad, string sedeActual, string ultimaVezAlquilado) : base(capacidad, sedeActual)
        {
            this.UltimaVezAlquilado = ultimaVezAlquilado;
        }

        public string UltimaVezAlquilado { get => ultimaVezAlquilado; set => ultimaVezAlquilado = value; }
    }
}
