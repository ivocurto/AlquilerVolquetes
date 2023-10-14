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
    public partial class Carrito : Form
    {
        private List<Volquete> volquetes;
        public Usuario usuarioActual;

        public Carrito(List<Volquete> lista, Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            this.MinimizeBox = false;
            volquetes = lista;

            MostrarListaCarrito();

        }

        private void MostrarListaCarrito()
        {
            lstProductosEnCarrito.Items.Clear();
            int precioTotal = 0;
            foreach (Volquete volquete in volquetes)
            {
                if (volquete.Cantidad != 0)
                {
                    string producto = "";
                    string formato;
                    int precio;
                    precio = volquete.PrecioUnitario;
                    //lstProductos.Items.Add($"{clave.Key}, {productosSumados[clave.Key]}");
                    formato = volquete.ToString();
                    precioTotal += precio * volquete.Cantidad;
                    lstProductosEnCarrito.Items.Add(formato);
                }
            }
            if (precioTotal == 0)
            {
                this.lblPrecioTotalEnCarrito.Text = "  TOTAL:  $0";
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
            foreach (Volquete volquete in volquetes)
            {
                volquete.Cantidad = 0;
            }
                MostrarListaCarrito();
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (var volquete in volquetes)
            {
                int cant = volquete.Cantidad;
                if (cant > 0)
                {
                    FormularioDeAlquiler formularioDeAlquiler = new FormularioDeAlquiler(volquetes, usuarioActual);
                    formularioDeAlquiler.Show();
                    this.DialogResult = DialogResult.OK;
                    // Cierra el formulario de diálogo.
                    this.Close();
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                ModalCarritoVacio carritoVacio = new ModalCarritoVacio();
                DialogResult answer = carritoVacio.ShowDialog();
                if (answer == DialogResult.OK)
                {
                    this.Close();
                }
            }



        }
    }
}

