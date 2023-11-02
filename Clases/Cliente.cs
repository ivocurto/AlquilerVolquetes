using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente : Usuario
    {
        public List<Pedido> Pedidos { get; set; }
        private string Nombre;
        private string Apellido;
        private string NumeroTelefono;

        public Cliente(string nombreUsuario, string mailUsuario, string claveUsuario)
            : base(nombreUsuario, mailUsuario, claveUsuario)
        {
            Pedidos = new List<Pedido>();
        }
    }
}
