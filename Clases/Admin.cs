using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clases
{
    public class Admin : Usuario
    {
        private List<Dictionary<string, string>> historialAcciones;

        public Admin(string nombreUsuario, string mailUsuario, string claveUsuario)
            : base(nombreUsuario, mailUsuario, claveUsuario)
        {
            historialAcciones = JsonFileManager.LoadFromJsonGeneric<List<Dictionary<string, string>>>("historialAdmin.json") ?? new List<Dictionary<string, string>>();
        }

        public void EliminarCliente(List<Cliente> clientes, Cliente cliente)
        {
            if (clientes.Remove(cliente))
            {
                NotificarAccionExitosa("EliminarCliente", cliente.NombreUsuario);
                GuardarHistorial();
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
                GuardarHistorial();
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
                GuardarHistorial();
            }
            else
            {
                throw new InvalidOperationException("Error al hacer admin al cliente.");
            }
        }

        private void NotificarAccionExitosa(string nombreAccion, string usuarioAfectado)
        {
            Console.WriteLine($"Se completó la acción: {nombreAccion} - Usuario afectado: {usuarioAfectado}");

            Dictionary<string, string> registro = new Dictionary<string, string>
            {
                { nombreAccion, $"Realizada por: {this.nombreUsuario} -- Usuario afectado: {usuarioAfectado} -- Fecha de realizacion de la acción {DateTime.Now}" }
            };
            historialAcciones.Add(registro);
        }

        private void GuardarHistorial()
        {
            JsonFileManager.SaveToJsonGeneric("historialAdmin.json", historialAcciones);
        }
    }
}
