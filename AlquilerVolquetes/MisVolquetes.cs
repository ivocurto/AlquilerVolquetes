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
        public Usuario usuarioActual;
        public Cliente cliente;
        private bool esCliente;
        public MisVolquetes(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            esCliente = false;
        }
        public MisVolquetes(Usuario usuario, Cliente clientee)
        {
            InitializeComponent();
            usuarioActual = usuario;
            cliente = clientee;
            esCliente = true;
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
            if (esCliente == true)
            {
                foreach (Volquete volquete in cliente.VolquetesPedidos)
                {
                    lstColocados.Items.Add(volquete);
                }

            }
        }

        private void MisVolquetes_Shown(object sender, EventArgs e)
        {
            if (esCliente == true)
            {
                foreach (Volquete volquete in cliente.VolquetesPedidos)
                {
                    lstColocados.Items.Add(volquete);
                }

            }
        }
    }
}
