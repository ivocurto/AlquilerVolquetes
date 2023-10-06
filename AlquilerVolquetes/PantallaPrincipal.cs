using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using static System.Windows.Forms.DataFormats;

namespace AlquilerVolquetes
{
    public partial class PantallaPrincipal : Form
    {
        //LISTA CARRITO
        //LISTA CARRITO
        int precioVChico = 800;
        int precioVMediano = 1600;
        int precioVGrande = 2400;
        private Dictionary<int, int> productosSumados = new Dictionary<int, int>();
        private Dictionary<int, int> productosEnElCarrito = new Dictionary<int, int>();

        private void Sumar_Al_Carrito(object sender, EventArgs e, int id)
        {
            if (!productosSumados.ContainsKey(id))
            {
                productosSumados.Add(id, 1); // Agrega el producto con la cantidad 1
            }
            else
            {
                productosSumados[id]++; // Le suma 1 a la cantidad del producto con el ID dado
            }

            // Actualizar la lista de productos en el carrito
            ActualizarListaCarrito();
        }

        private void ActualizarListaCarrito()
        {
            lstProductos.Items.Clear();
            int precioTotal = 0;
            foreach (var clave in productosSumados)
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
                lstProductos.Items.Add(formato);
            }
            if (precioTotal == 0)
            {
                this.lblPrecioTotal.Text = "  TOTAL:  0";
            }
            else
            {
                this.lblPrecioTotal.Text = $"TOTAL: ${precioTotal}";
            }
        }


        private void Restar_Al_Carrito(object sender, EventArgs e, int id)
        {
            if (productosSumados.ContainsKey(id))
            {
                productosSumados[id]--; // Le resta 1 a la cantidad
                if (productosSumados[id] == 0)
                {
                    productosSumados.Remove(id); // Si la cantidad llega a 0, elimina el producto del carrito
                }

                ActualizarListaCarrito(); // Actualizar la lista de productos en el carrito
            }
        }


        //

        //Iniciar formulario
        public PantallaPrincipal()
        {
            InitializeComponent();

        }

        //Cerrar formulario
        private void PantallaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<Form> formulariosACerrar = new List<Form>();

            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario != this)
                {
                    formulariosACerrar.Add(formulario);
                }
            }

            foreach (Form formulario in formulariosACerrar)
            {
                formulario.Close();
            }


        }
        //Chico
        private void btnAgregarVolqueteChico_Click(object sender, EventArgs e)
        {
            this.lblCantidadVolqueteChico.Text = Incrementar_Label(sender, e, 0, this.lblCantidadVolqueteChico.Text);
            this.lblPrecioChico.Text = ($"${int.Parse(this.lblCantidadVolqueteChico.Text) * precioVChico}");


        }
        private void btnRestarVolqueteChico_Click(object sender, EventArgs e)
        {
            this.lblCantidadVolqueteChico.Text = Decrementar_Label(sender, e, 0, this.lblCantidadVolqueteChico.Text);
            this.lblPrecioChico.Text = ($"${int.Parse(this.lblCantidadVolqueteChico.Text) * precioVChico}");

        }

        //Mediano
        private void btnAgregarVolqueteMediano_Click(object sender, EventArgs e)
        {
            this.lblCantidadVolqueteMediano.Text = Incrementar_Label(sender, e, 1, this.lblCantidadVolqueteMediano.Text);
            this.lblPrecioMediano.Text = ($"${int.Parse(this.lblCantidadVolqueteMediano.Text) * precioVMediano}");

        }
        private void btnRestarVolqueteMediano_Click(object sender, EventArgs e)
        {
            this.lblCantidadVolqueteMediano.Text = Decrementar_Label(sender, e, 1, this.lblCantidadVolqueteMediano.Text);
            this.lblPrecioMediano.Text = ($"${int.Parse(this.lblCantidadVolqueteMediano.Text) * precioVMediano}");
        }
        //Grande
        private void btnAgregarVolqueteGrande_Click(object sender, EventArgs e)
        {
            this.lblCantidadVolqueteGrande.Text = Incrementar_Label(sender, e, 2, this.lblCantidadVolqueteGrande.Text);
            this.lblPrecioGrande.Text = ($"${int.Parse(this.lblCantidadVolqueteGrande.Text) * precioVGrande}");

        }
        private void btnRestarVolqueteGrande_Click(object sender, EventArgs e)
        {

            this.lblCantidadVolqueteGrande.Text = Decrementar_Label(sender, e, 2, this.lblCantidadVolqueteGrande.Text);
            this.lblPrecioGrande.Text = ($"${int.Parse(this.lblCantidadVolqueteGrande.Text) * precioVGrande}");

        }

        private string Incrementar_Label(object sender, EventArgs e, int id, string label)
        {
            int valor = int.Parse(label);
            if (valor < 8)
            {
                valor++;
                Sumar_Al_Carrito(sender, e, id);
            }

            return ($"{valor}");
        }

        private string Decrementar_Label(object sender, EventArgs e, int id, string label)
        {
            int valor = int.Parse(label);
            if (valor > 0)
            {
                valor--;
                Restar_Al_Carrito(sender, e, id);
            }

            return ($"{valor}");
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPrecioTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            Carrito carrito = new Carrito(productosEnElCarrito, precioVChico, precioVMediano, precioVGrande);
            DialogResult result = carrito.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Hide();
                // llevar al formulario de pago
            }
        }

        private void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            foreach (var clave in productosSumados)
            {
                int id = clave.Key;
                int cant = clave.Value;
                if (!productosEnElCarrito.ContainsKey(id))
                {
                    productosEnElCarrito.Add(id, cant); // Agrega el producto con la cantidad
                }
                else
                {
                    productosEnElCarrito[id] += cant; // Le suma 1 a la cantidad del producto con el ID dado
                }
                productosSumados.Remove(id);
                lstProductos.Items.Clear();
            }
        }
    }
}
