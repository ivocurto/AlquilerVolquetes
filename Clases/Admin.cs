using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Clases
{
    public class Admin : Usuario
    {
        private List<Dictionary<string, object>> historialAcciones;

        public Admin(string nombreUsuario, string mailUsuario, string claveUsuario)
            : base(nombreUsuario, mailUsuario, claveUsuario)
        {
            historialAcciones = new List<Dictionary<string, object>>();
        }

        public void EliminarCliente(List<Cliente> clientes, Cliente cliente)
        {
            if (clientes.Remove(cliente))
            {
                NotificarAccionExitosa("EliminarCliente", cliente.NombreUsuario);
            }
            else
            {
                throw new InvalidOperationException("Error al eliminar el cliente.");
            }
        }

        public void EliminarPedidoCliente(Cliente cliente, int indexPedido)
        {
            if (indexPedido >= 0 && indexPedido < cliente.Pedidos.Count)
            {
                cliente.Pedidos.RemoveAt(indexPedido);
                NotificarAccionExitosa("EliminarPedidoCliente", cliente.NombreUsuario);
            }
            else
            {
                throw new IndexOutOfRangeException("Índice de pedido no válido.");
            }
        }

        public void HacerAdmin(List<Cliente> clientes, Cliente clienteUpgrade, List<Admin> admins)
        {
            if (clientes.Remove(clienteUpgrade))
            {
                Admin admin = new Admin(clienteUpgrade.NombreUsuario, clienteUpgrade.MailUsuario, clienteUpgrade.ClaveUsuario);
                admins.Add(admin);
                NotificarAccionExitosa("HacerAdmin", clienteUpgrade.NombreUsuario);
            }
            else
            {
                throw new InvalidOperationException("Error al hacer admin al cliente.");
            }
        }

        private void NotificarAccionExitosa(string nombreAccion, string usuarioAfectado)
        {
            Console.WriteLine($"Se completó la acción: {nombreAccion} - Usuario afectado: {usuarioAfectado}");

            Dictionary<string, object> registro = new Dictionary<string, object>
            {
                { nombreAccion, new AccionAdmin(DateTime.Now, usuarioAfectado) }
            };
            historialAcciones.Add(registro);
        }
    }
}
