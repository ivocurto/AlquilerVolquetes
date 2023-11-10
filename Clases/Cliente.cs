using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente : Usuario
    {
        private List<Pedido> pedidos;
        private string nombre;
        private string apellido;
        private string numeroTelefono;

        public Cliente(string nombreUsuario, string mailUsuario, string claveUsuario) : base(nombreUsuario, mailUsuario, claveUsuario)
        {
            
        }
        public Cliente(string nombreUsuario, string mailUsuario, string claveUsuario, string nombre, string apellido) : base(nombreUsuario, mailUsuario, claveUsuario)
        {
            this.Pedidos = new List<Pedido>();
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}
