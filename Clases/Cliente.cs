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
        private int? NumeroTelefono;

        //public Cliente(string nombreUsuario, string mailUsuario, string claveUsuario, string nombre, string apellido) : base(id, nombreUsuario, mailUsuario, claveUsuario)
        //{
        //    this.Pedidos = new List<Pedido>();
        //    this.Nombre = nombre;
        //    this.Apellido = apellido;
        //}

        public Cliente(int id, string nombre, string apellido, string mail, int? telefono, string nombre_usuario, string clave) : base(id, nombre_usuario, mail, clave)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        public override void ConsutarEstado()
        {
            throw new NotImplementedException();
        }       

        public List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }

}
