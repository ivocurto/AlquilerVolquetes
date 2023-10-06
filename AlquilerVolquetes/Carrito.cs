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
    public partial class Carrito : Form
    {
        private Dictionary<int, int> diccionarioCarrito;
        private int precioVChico;
        private int precioVMediano;
        private int precioVGrande;
        public Carrito(Dictionary<int, int> dict, int precioC, int precioM, int precioG)
        {
            InitializeComponent();
            this.MinimizeBox = false;
            diccionarioCarrito = dict;
            precioVChico = precioC;
            precioVMediano = precioM;
            precioVGrande = precioG;
            MostrarListaCarrito();

        }

        private void MostrarListaCarrito()
        {
            lstProductosEnCarrito.Items.Clear();
            int precioTotal = 0;
            foreach (var clave in diccionarioCarrito)
            {
                int idEnLista = clave.Key;
                string producto = "";
                string formato;
                int precio = 0;
                switch (idEnLista)
                {
                    case 0:
                        producto = "VOLQUETE CHICO";
                        precio = precioVChico;
                        break;
                    case 1:
                        producto = "VOLQUETE MEDIANO";
                        precio = precioVMediano;
                        break;
                    case 2:
                        producto = "VOLQUETE GRANDE";
                        precio = precioVGrande;
                        break;
                }
                int cantidad = clave.Value;
                //lstProductos.Items.Add($"{clave.Key}, {productosSumados[clave.Key]}");
                formato = $"{cantidad} {producto} ${precio * cantidad}";
                precioTotal += precio * cantidad;
                lstProductosEnCarrito.Items.Add(formato);
            }
            if (precioTotal == 0)
            {
                this.lblPrecioTotalEnCarrito.Text = "  TOTAL:  0";
            }
            else
            {
                this.lblPrecioTotalEnCarrito.Text = $"TOTAL: ${precioTotal}";
            }
        }


        private void btnCerrarCarrito_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            diccionarioCarrito.Clear();
            MostrarListaCarrito();
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            FormularioDeAlquiler formularioDeAlquiler = new FormularioDeAlquiler(diccionarioCarrito, precioVChico, precioVMediano, precioVGrande);
            formularioDeAlquiler.Show();
            this.DialogResult = DialogResult.OK;
            // Cierra el formulario de diálogo.
            this.Close();

        }
    }
}
