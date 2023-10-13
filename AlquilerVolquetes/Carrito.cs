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
        
        public Carrito(List<Volquete> lista)
        {
            InitializeComponent();
            this.MinimizeBox = false;
            volquetes = lista;
            
            MostrarListaCarrito();

        }

        private void MostrarListaCarrito()
        {
            lstProductosEnCarrito.Items.Clear();
            int precioTotal = 0;
            foreach (var volquete in volquetes)
            {
                
                string producto = "";
                string formato;
                int precio = 0;
                switch (volquete.Id)
                {
                    case 0:
                        producto = "VOLQUETE CHICO";
                        break;
                    case 1:
                        producto = "VOLQUETE MEDIANO";
                        break;
                    case 2:
                        producto = "VOLQUETE GRANDE";
                        
                        break;
                }
                precio = volquete.PrecioUnitario;
                //lstProductos.Items.Add($"{clave.Key}, {productosSumados[clave.Key]}");
                formato = volquete.ToString();
                precioTotal += precio * volquete.Cantidad;
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
            lstProductosEnCarrito.Items.Clear();
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
                    FormularioDeAlquiler formularioDeAlquiler = new FormularioDeAlquiler(volquetes);
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
                MessageBox.Show("Debe agregar por lo menos un produto al carrito para alquilar", "Carrito vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }
    }
}
