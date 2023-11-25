using Clases;
using ClasesManejoBaseDatos;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerVolquetes
{
    public partial class MisVolquetes : Form
    {
        private List<PedidoADO> pedidoActual;
        public Cliente usuarioActual;
        private bool esCliente;
        public MisVolquetes(Cliente usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            pedidoActual = DB.GetPedidosByIdUsuario(usuario.Id);
            this.Load += new EventHandler(MisVolquetes_Load);
        }

        private void lstEnviando_DrawItem(object sender, DrawItemEventArgs e)
        {
            lstEnviando.ItemHeight = 30;
            int paddingVertical = 6; // Ajusta la cantidad de espaciado vertical deseado

            if (e.Index >= 0)
            {
                e.DrawBackground();

                // Obtén el texto del elemento.
                string itemText = lstEnviando.Items[e.Index].ToString();

                // Establece un color de fondo alternativo para cada elemento.
                Color backColor = e.Index % 2 == 0 ? Color.LightGray : Color.White;
                using (Brush brush = new SolidBrush(backColor))
                {
                    e.Graphics.FillRectangle(brush, e.Bounds);
                }

                // Ajusta el rectángulo de dibujo para incluir el espaciado vertical.
                Rectangle textBounds = new Rectangle(
                    e.Bounds.Left,
                    e.Bounds.Top + paddingVertical,
                    e.Bounds.Width,
                    e.Bounds.Height - paddingVertical
                );

                // Establece el color de texto.
                using (Brush brush = new SolidBrush(Color.Black))
                {
                    e.Graphics.DrawString(itemText, lstEnviando.Font, brush, textBounds);
                }
            }
        }

        private void MisVolquetes_Load(object sender, EventArgs e)
        {

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this.Load += new EventHandler(MisVolquetes_Load);
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            UsuarioADO user = new UsuarioADO();
            user = DB.TraerClienteLogueado(usuarioActual.NombreUsuario);
            
            DatosUsuario datosUsuario = new DatosUsuario(user);
            datosUsuario.Show();
        }
    }
}