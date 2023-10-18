using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ClienteActual
    {
        private static List<Pedido> clienteActual;

        public static List<Pedido> ObtenerCliente()
        {
            return clienteActual;
        }

        public static void EstablecerCliente(List<Pedido> cliente)
        {
            clienteActual = cliente;
        }
    }
}
