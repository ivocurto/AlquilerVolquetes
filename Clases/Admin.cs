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

        public Admin(int id, string nombreUsuario, string mailUsuario, string claveUsuario)
            : base(id, nombreUsuario, mailUsuario, claveUsuario)
        {
            //historialAcciones = JsonFileManager.LoadFromJsonGeneric<List<Dictionary<string, string>>>("historialAdmin.json") ?? new List<Dictionary<string, string>>();

        }
        public override void ConsutarEstado()
        {
            throw new NotImplementedException();
        }

        public void VerEstado(Admin admin)
        {
            return;
       
        }

        //public List<Cliente> EliminarCliente(List<Cliente> clientes, string nombreCliente)
        //{
        //    foreach(Cliente cliente in clientes)
        //    {
                
        //        if (cliente.NombreUsuario == nombreCliente )
        //        {
        //            clientes.Remove(cliente);
        //            NotificarAccionExitosa("EliminarCliente", cliente.NombreUsuario);
        //            GuardarHistorial();
        //            return clientes;
        //        }
        //        else
        //        {
        //           // throw new InvalidOperationException("Error al eliminar el cliente.");
        //        }
        //    }
           
        //    return clientes;
        //}

        //public void EliminarPedidoCliente(Cliente cliente, int indexPedido)
        //{
        //    if (indexPedido >= 0 && indexPedido < cliente.Pedidos.Count)
        //    {
        //        cliente.Pedidos.RemoveAt(indexPedido);
        //        NotificarAccionExitosa("EliminarPedidoCliente", cliente.NombreUsuario);
        //        GuardarHistorial();
        //    }
        //    else
        //    {
        //        throw new IndexOutOfRangeException("Índice de pedido no válido.");
        //    }
        //}

        //public List<Admin> AgregarAdmin(List<Cliente> clientes, List<Admin> admins, string nombreCliente)
        //{
        //    Cliente clienteUpgrade;
        //    foreach(Cliente cliente in clientes)
        //    {
        //        if(nombreCliente == cliente.NombreUsuario)
        //        {
        //            clienteUpgrade = cliente;
        //            Admin admin = new Admin(clienteUpgrade.NombreUsuario, clienteUpgrade.MailUsuario, clienteUpgrade.ClaveUsuario);
        //            admins.Add(admin);
        //            NotificarAccionExitosa("HacerAdmin", clienteUpgrade.NombreUsuario);
        //            GuardarHistorial();
        //            return admins;
                    
                    
        //        }
        //    }
        //    return admins;


        //}

        //private void NotificarAccionExitosa(string nombreAccion, string usuarioAfectado)
        //{
        //    Dictionary<string, string> registro = new Dictionary<string, string>
        //    {
        //        { nombreAccion, $"Realizada por: {this.nombreUsuario} -- Usuario afectado: {usuarioAfectado} -- Fecha de realizacion de la acción {DateTime.Now}" }
        //    };
        //    historialAcciones.Add(registro);
        //    GuardarHistorial();
        //}

        //private void GuardarHistorial()
        //{
        //    JsonFileManager.SaveToJsonGeneric("historialAdmin.json", historialAcciones);
        //}


    }
}
