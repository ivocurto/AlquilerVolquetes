using Clases;
using ClasesManejoBaseDatos;
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
            //DB.Select<Pedido>($"SELECT * FROM pedidos_cliente WHERE id_usuario = {usuarioActual.Id}");
            //usuarioActual.Pedidos = pedidoActual;
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
                    string text = $"ID: {pedido.Hash_code}";
                    if (pedido.Volquetes_chicos != 0)
                    {
                        text += $" - Volquetes chicos: {pedido.Volquetes_chicos}";
                    }
                    if (pedido.Volquetes_medianos != 0)
                    {
                        text += $" - Volquetes medianos: {pedido.Volquetes_medianos}";
                    }
                    if (pedido.Volquetes_grandes != 0)
                    {
                        text += $" - Volquetes grandes: {pedido.Volquetes_grandes}";
                    }
                    text += $" - Fecha entrega: {pedido.Fecha_ingreso.ToShortDateString()} - Fecha retiro: {pedido.Fecha_regreso.ToShortDateString()} - Dirección: {pedido.Direccion}";

                    lstEnviando.Items.Add(text);
                }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this.Load += new EventHandler(MisVolquetes_Load);
        }
    }
}