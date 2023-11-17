using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerVolquetes
{
    public partial class DatosUsuario : Form
    {
        private Cliente clienteAcual;
        private Admin adminActual;
        private List<Cliente> clientes = new List<Cliente>();

        public DatosUsuario(Cliente cliente, List<Cliente> listaClientes)
        {
            InitializeComponent();
            clienteAcual = cliente;
            clientes = listaClientes;
        }

        public DatosUsuario(Admin admin)
        {
            InitializeComponent();
            adminActual = admin;
        }

        private void DatosUsuario_Load(object sender, EventArgs e)
        {
            if (clienteAcual == null)
            {
                lblNombreCliente.Text = adminActual.NombreUsuario;
            }
            else
            {
                lblNombreCliente.Text = clienteAcual.NombreUsuario;

                if (clienteAcual.Pedidos is not null)
                {
                    lstDatos.Items.Clear();

                    foreach (Pedido pedido in clienteAcual.Pedidos)
                    {
                        // Agrega el ID con formato a la lista
                        lstDatos.Items.Add($"ID del pedido: {pedido.IdPedido}");

                        // Agrega cada volquete a la lista con formato
                        foreach (Volquete volquete in pedido.VolquetesPedidos)
                        {
                            if (volquete.Cantidad > 0)
                            {
                                lstDatos.Items.Add($"    {volquete.ToString()}");
                            }
                        }

                        // Agrega un elemento en blanco para separar pedidos
                        lstDatos.Items.Add("");
                    }
                }
            }
        }

        private void btnBorrarPedido_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstDatos.SelectedIndex;

            if (selectedIndex >= 0)
            {
                string selectedText = lstDatos.Items[selectedIndex].ToString();

                Match pedidoMatch = Regex.Match(selectedText, @"ID del pedido: (\d+)");

                Action<string> processTextDelegate = null;

                if (pedidoMatch.Success)
                {
                    processTextDelegate = ProcesarPedido;
                }
                else
                {
                    processTextDelegate = ProcesarVolquete;
                }

                processTextDelegate?.Invoke(selectedText);
            }
        }

        private void ProcesarPedido(string selectedText)
        {
            // Lógica para procesar un pedido
            string idPedido = Regex.Match(selectedText, @"ID del pedido: (\d+)").Groups[1].Value;

            if (int.TryParse(idPedido, out int idPedidoNumerico))
            {
                int indexCliente = clientes.FindIndex(c => c == clienteAcual);

                if (indexCliente >= 0)
                {
                    // Remueve el pedido del cliente actual
                    clienteAcual.Pedidos.RemoveAll(p => p.IdPedido == idPedidoNumerico);

                    // Actualiza el cliente en la lista de clientes
                    clientes[indexCliente] = clienteAcual;

                    // Guarda la lista actualizada en el archivo JSON
                    JsonFileManager.SaveToJsonGeneric<List<Cliente>>("usuarios.json", clientes);

                    // Recarga los datos en el formulario
                    DatosUsuario_Load(null, null);
                }
            }
        }

        private void ProcesarVolquete(string selectedText)
        {
            // Lógica para procesar un volquete
            string pattern = @"(\d+)\s+(.+?)\s+POR\s+\$(\d+)\s+(\d+)";
            Match match = Regex.Match(selectedText, pattern);

            if (match.Success)
            {
                string medidaVolquete = match.Groups[2].Value.ToUpper();
                int identificador = int.Parse(match.Groups[4].Value);

                foreach (Pedido pedido in clienteAcual.Pedidos)
                {
                    if (pedido.IdPedido == identificador)
                    {
                        foreach (Volquete volquete in pedido.VolquetesPedidos)
                        {
                            if (volquete.MedidaVolquete == medidaVolquete)
                            {
                                volquete.Cantidad--;
                            }
                        }
                    }
                }

                int indexCliente = clientes.FindIndex(c => c == clienteAcual);

                if (indexCliente >= 0)
                {
                    clientes[indexCliente] = clienteAcual;

                    JsonFileManager.SaveToJsonGeneric<List<Cliente>>("usuarios.json", clientes);
                    DatosUsuario_Load(null, null);
                }
            }
        }
    }
}
