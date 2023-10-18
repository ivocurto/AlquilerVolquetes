using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ClienteActual
    {
        private static List<Cliente> clienteActual;

        public static List<Cliente> ObtenerCliente()
        {
            return clienteActual;
        }

        public static void EstablecerCliente(List<Cliente> cliente)
        {
            clienteActual = cliente;
        }
    }
}
