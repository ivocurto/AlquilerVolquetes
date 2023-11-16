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
                        lstDatos.Items.Add($"ID del pedido: {pedido.IdPedido}");

                        foreach (Volquete volquete in pedido.VolquetesPedidos)
                        {
                            if (volquete.Cantidad > 0)
                            {
                                lstDatos.Items.Add($"    {volquete.ToString()}");
                            }

                        }

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

                Match match = Regex.Match(selectedText, @"ID del pedido: (\d+)");

                if (match.Success)
                {
                    string idPedido = match.Groups[1].Value;

                    if (int.TryParse(idPedido, out int idPedidoNumerico))
                    {
                        int indexCliente = clientes.FindIndex(c => c == clienteAcual);

                        if (indexCliente >= 0)
                        {
                            clienteAcual.Pedidos.RemoveAll(p => p.IdPedido == idPedidoNumerico);

                            clientes[indexCliente] = clienteAcual;

                            JsonFileManager.SaveToJsonGeneric<List<Cliente>>("usuarios.json", clientes);
                            DatosUsuario_Load(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un ID de pedido para borrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
