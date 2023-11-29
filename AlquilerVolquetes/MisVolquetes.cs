using Clases;
using ClasesManejoBaseDatos;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerVolquetes
{
    public partial class MisVolquetes : Form
    {
        private List<PedidoADO> pedidoActual;
        public Cliente usuarioActual;
        public MisVolquetes(Cliente usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            this.Load += new EventHandler(MisVolquetes_Load);
            actualizarPantalla();
        }

        private void MisVolquetes_Load(object sender, EventArgs e)
        {
            actualizarPantalla();
        }

        private void btnDevolverVolquete_Click(object sender, EventArgs e)
        {
            if (lstEnviando.SelectedIndex >= 0)
            {
                ModalExito borrar = new ModalExito("¿ELIMINAR?");
                borrar.pictureBox1.Visible = false;
                DialogResult answer = borrar.ShowDialog();
                if (answer == DialogResult.OK)
                {
                    DevolverSinPreguntar(null, null);
                    btnDevolverVolquete.Click -= btnDevolverVolquete_Click;
                    btnDevolverVolquete.Click += DevolverSinPreguntar;
                }
            }
        }

        private void ProcesarPedido(string selectedText)
        {
            string idPedido = Regex.Match(selectedText, @"ID del pedido: (\d+)").Groups[1].Value;

            if (int.TryParse(idPedido, out int pedido_hash_code))
            {
                foreach (PedidoADO pedido in pedidoActual)
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

        private void DevolverSinPreguntar(object sender, EventArgs e)
        {
            int selectedIndex = lstEnviando.SelectedIndex;

            if (selectedIndex >= 0)
            {
                string selectedText = lstEnviando.Items[selectedIndex].ToString();

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

        public void actualizarPantalla()
        {
            pedidoActual = DB.GetPedidosByIdUsuario(usuarioActual.Id);
            lstEnviando.Items.Clear();
            foreach (PedidoADO pedido in pedidoActual)
            {
                lstEnviando.Items.Add($" Dirección: {pedido.Direccion} - Fecha entrega: {pedido.Fecha_ingreso.ToShortDateString()} - Fecha Retiro: {pedido.Fecha_regreso.ToShortDateString()}                                                                                                                                                   ID del pedido: {pedido.Hash_code}");

                if (pedido.Volquetes_chicos != 0)
                {
                    lstEnviando.Items.Add($"       Volquetes chicos: {pedido.Volquetes_chicos}                                                                                                                                                                                                                                                    {pedido.Hash_code}");
                }
                if (pedido.Volquetes_medianos != 0)
                {
                    lstEnviando.Items.Add($"       Volquetes medianos: {pedido.Volquetes_medianos}                                                                                                                                                                                                                                                 {pedido.Hash_code}");
                }
                if (pedido.Volquetes_grandes != 0)
                {
                    lstEnviando.Items.Add($"       Volquetes grandes: {pedido.Volquetes_grandes}                                                                                                                                                                                                                                                       {pedido.Hash_code}");
                }

                lstEnviando.Items.Add("");
            }
        }

        private void btnCambiarFecha_Click(object sender, EventArgs e)
        {
            if (lstEnviando.SelectedItem != null)
            {
                string idPedido = Regex.Match(lstEnviando.SelectedItem.ToString(), @"ID del pedido: (\d+)").Groups[1].Value;
                if (int.TryParse(idPedido, out int pedido_hash_code))
                {
                    foreach (PedidoADO pedido in pedidoActual)
                    {
                        if (pedido.Hash_code == pedido_hash_code)
                        {
                            CambiadorFecha cambiadorFecha = new CambiadorFecha(pedido, this);
                            cambiadorFecha.Show();

                        }
                    }

                    actualizarPantalla();
                }

            }
        }
    }
}