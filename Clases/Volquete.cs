using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{

    public class Volquete
    {
        private float capacidad;
        private string sedeActual;

        public Volquete(float capacidad, string sedeActual)
        {
            this.Capacidad = capacidad;
            this.SedeActual = sedeActual;
        }

        public float Capacidad { get => capacidad; set => capacidad = value; }
        public string SedeActual { get => sedeActual; set => sedeActual = value; }
    }
}
