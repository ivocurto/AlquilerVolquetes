using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente : Usuario
    {
        private string direccion;
        private string telefono;
        private List<Volquete> carrito;


        public Cliente(string nombreUsuario, string mailUsuario, string claveUsuario, string direccion, string telefono, List<Volquete> carrito)
            : base(nombreUsuario, mailUsuario, claveUsuario)
        {
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Carrito = carrito;
        }

        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public List<Volquete> Carrito { get => carrito; set => carrito = value; }
    }
}
