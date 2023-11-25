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
using ClasesManejoBaseDatos;
using Org.BouncyCastle.Asn1.Cms;
using MySqlX.XDevAPI;

namespace AlquilerVolquetes
{
    public partial class DatosUsuario : Form
    {
        private UsuarioADO clienteAcual;
        private AdminADO adminActual;
        private List<PedidoADO> pedidos;

        public DatosUsuario(UsuarioADO cliente)
        {
            InitializeComponent();
            clienteAcual = cliente;
            pedidos = DB.GetPedidosByIdUsuario(clienteAcual.Id);
        }

        public DatosUsuario(AdminADO admin)
        {
            InitializeComponent();
            adminActual = admin;
        }

        private void DatosUsuario_Load(object sender, EventArgs e)
        {
            if (clienteAcual == null)
            {
                lblNombreCliente.Text = adminActual.Nombre_admin;
            }
            else
            {
                lblNombreCliente.Text = clienteAcual.Nombre_usuario;

                actualizarPantalla();
            }
        }

        private void ProcesarPedido(string selectedText)
        {
            string idPedido = Regex.Match(selectedText, @"ID del pedido: (\d+)").Groups[1].Value;

            if (int.TryParse(idPedido, out int pedido_hash_code))
            {
                foreach (PedidoADO pedido in pedidos)
                {
                    if (pedido.Hash_code == pedido_hash_code)
                    {
                        int cantidadVC = pedido.Volquetes_chicos;
                        DB.CambiarCantidadDisponible(1, cantidadVC, true);
                        int cantidadVM = pedido.Volquetes_medianos;
                        DB.CambiarCantidadDisponible(2, cantidadVM, true);
                        int cantidadVG = pedido.Volquetes_grandes;
                        DB.CambiarCantidadDisponible(3, cantidadVG, true);
                    }
                }
                DB.Drop("hash_code", pedido_hash_code);

                actualizarPantalla();
            }
        }

        private void actualizarPantalla()
        {
            pedidos = DB.GetPedidosByIdUsuario(clienteAcual.Id);
            if (pedidos is not null)
            {
                lstDatos.Items.Clear();

                foreach (PedidoADO pedido in pedidos)
                {
                    lstDatos.Items.Add($" Dirección: {pedido.Direccion} - Fecha entrega: {pedido.Fecha_ingreso.ToShortDateString()} - Fecha Retiro: {pedido.Fecha_regreso.ToShortDateString()}                                                   ID del pedido: {pedido.Hash_code}");

                    if (pedido.Volquetes_chicos != 0)
                    {
                        lstDatos.Items.Add($"    Volquetes chicos: {pedido.Volquetes_chicos}                                                                                                                                                     {pedido.Hash_code}");
                    }
                    if (pedido.Volquetes_medianos != 0)
                    {
                        lstDatos.Items.Add($"    Volquetes medianos: {pedido.Volquetes_medianos}                                                                                                                                   {pedido.Hash_code}");
                    }
                    if (pedido.Volquetes_grandes != 0)
                    {
                        lstDatos.Items.Add($"    Volquetes grandes: {pedido.Volquetes_grandes}                                                                                                                                 {pedido.Hash_code}");
                    }

                    lstDatos.Items.Add("");
                }
            }
        }

        private void ProcesarVolquete(string selectedText)
        {
            // Lógica para procesar un volquete
            string pattern = @"Volquetes (chicos|medianos|grandes):\s+(\d+)\s+(\d+)";
            MatchCollection matches = Regex.Matches(selectedText, pattern);

            foreach (Match match in matches)
            {
                string tipoVolquete = match.Groups[1].Value.ToLower();
                int cantidad = int.Parse(match.Groups[2].Value);
                int pedido_hash_code = int.Parse(match.Groups[3].Value);

                // Actualiza la existencia del tipo de volquete en el pedido
                switch (tipoVolquete)
                {
                    case "chicos":
                        DB.ActualizarCantidadVolquetes(pedido_hash_code, "volquetes_chicos", cantidad - 1);
                        DB.CambiarCantidadDisponible(1, 1, true);
                        break;
                    case "medianos":
                        DB.ActualizarCantidadVolquetes(pedido_hash_code, "volquetes_medianos", cantidad - 1);
                        DB.CambiarCantidadDisponible(2, 1, true);
                        break;
                    case "grandes":
                        DB.ActualizarCantidadVolquetes(pedido_hash_code, "volquetes_grandes", cantidad - 1);
                        DB.CambiarCantidadDisponible(3, 1, true);
                        break;
                }
            }
            actualizarPantalla();
        }

        private void btnBorrarPedido_Click_1(object sender, EventArgs e)
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
    }
}
