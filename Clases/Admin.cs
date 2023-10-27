using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Admin : Usuario
    {
        public Admin(string nombreUsuario, string mailUsuario, string claveUsuario)
            : base(nombreUsuario, mailUsuario, claveUsuario)
        {
        }

        public bool EliminarCliente(List<Cliente> clientes, Cliente cliente)
        {
            return clientes.Remove(cliente);
        }
    }
}
