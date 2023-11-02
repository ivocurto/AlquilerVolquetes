using Clases;
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
        private List<Pedido> pedidoActual;
        public Cliente usuarioActual;
        private bool esCliente;
        private List<Pedido> pedidos;
        public MisVolquetes(Cliente usuario)
        {
            InitializeComponent();

            usuarioActual = usuario;
            this.Activated += new EventHandler(MisVolquetes_Activated); // Suscribir al evento Activated
        }
        private void MisVolquetes_Activated(object sender, EventArgs e)
        {
            //pedidos = JsonFileManager.LoadFromJsonGeneric<List<Pedido>>("pedidos.json");
            pedidoActual = usuarioActual.Pedidos;
            //if (pedidos is not null)
            //{
            //    foreach (Pedido pedido in pedidos)
            //    {
            //        if (pedido.Cliente == usuarioActual.NombreUsuario)
            //        {
            //            pedidoActual.Add(pedido);
            //        }
            //    }

            //}

            esCliente = false;
            if (pedidoActual is not null)
            {
                esCliente = true;
            }
            if (esCliente == true)
            {
                lstEnviando.Items.Clear();
                foreach (Pedido pedido in pedidoActual)
                {
                    foreach (Volquete volquete in pedido.VolquetesPedidos)
                    {
                        if (volquete.Cantidad != 0)
                        {
                            lstEnviando.Items.Add(volquete);
                        }
                    }
                    foreach (Volquete volquete in pedido.VolquetesInstalados)
                    {
                        if (volquete.Cantidad != 0)
                        {
                            lstColocados.Items.Add(volquete);
                        }
                    }
                }
            }
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
    }
}