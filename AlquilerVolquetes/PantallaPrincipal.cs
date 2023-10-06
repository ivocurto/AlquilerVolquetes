using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Nodes;
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
        private List<Volquete> volquetes = new List<Volquete>();
        private Volquete volqueteChico = new Volquete(0, "VOLQUETE CHICO", 800);
        private Volquete volqueteMediano = new Volquete(1, "VOLQUETE MEDIANO", 1600);
        private Volquete volqueteGrande = new Volquete(2, "VOLQUETE GRANDE", 2400);

        public PantallaPrincipal()
        {
            InitializeComponent();
            volquetes.Add(volqueteChico);
            volquetes.Add(volqueteMediano);
            volquetes.Add(volqueteGrande);
            lstProductos.DrawMode = DrawMode.OwnerDrawFixed;
            this.lblPrecioChico.Text = ($"${precioVChico}");
            this.lblPrecioMediano.Text = ($"${precioVMediano}");
            this.lblPrecioGrande.Text = ($"${precioVGrande}");

        }

        private void Sumar_Al_Carrito(object sender, EventArgs e, int id)
        {
            
            if (volquetes[id].Cantidad == 0)
            {
                volquetes[id].Cantidad = 1; // Agrega el producto con la cantidad 1
            }
            else
            {
                volquetes[id].Cantidad++; // Le suma 1 a la cantidad del producto con el ID dado
            }

            // Actualizar la lista de productos en el carrito
            ActualizarListaCarrito();
            
        }

        private void ActualizarListaCarrito()
        {
            lstProductos.Items.Clear();
            int precioTotal = 0;
            foreach (Volquete volquete in volquetes)
            {
               if (volquete.Cantidad != 0)
                {
                    string formato;
                    formato = $"{volquete.Cantidad} {volquete.MedidaVolquete} ${volquete.PrecioUnitario * volquete.Cantidad}";
                    precioTotal += volquete.PrecioUnitario * volquete.Cantidad;
                    lstProductos.Items.Add(formato);
                }
                
                
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
            if (volquetes[id].Cantidad > 0)
            {
                volquetes[id].Cantidad--; // Le resta 1 a la cantidad
                

                ActualizarListaCarrito(); // Actualizar la lista de productos en el carrito
            }
        }


        //

        //Iniciar formulario
        

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
                lblCantidadVolqueteChico.Text = "0";
                lblCantidadVolqueteMediano.Text = "0";
                lblCantidadVolqueteGrande.Text = "0";
                lblPrecioTotal.Text = "   TOTAL: $0";

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Carrito carrito = new Carrito(productosEnElCarrito, precioVChico, precioVMediano, precioVGrande);
            DialogResult result = carrito.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Hide();
            }
        }

        private void btnSumarVC_Click(object sender, EventArgs e)
        {
            this.lblCantidadVolqueteChico.Text = Incrementar_Label(sender, e, 0, this.lblCantidadVolqueteChico.Text);
        }

        private void btnSumarVM_Click(object sender, EventArgs e)
        {
            this.lblCantidadVolqueteMediano.Text = Incrementar_Label(sender, e, 1, this.lblCantidadVolqueteMediano.Text);
        }

        private void btnSumarVG_Click(object sender, EventArgs e)
        {
            this.lblCantidadVolqueteGrande.Text = Incrementar_Label(sender, e, 2, this.lblCantidadVolqueteGrande.Text);
        }

        private void btnRestarVC_Click(object sender, EventArgs e)
        {
            this.lblCantidadVolqueteChico.Text = Decrementar_Label(sender, e, 0, this.lblCantidadVolqueteChico.Text);
        }

        private void btnRestarVM_Click(object sender, EventArgs e)
        {
            this.lblCantidadVolqueteMediano.Text = Decrementar_Label(sender, e, 1, this.lblCantidadVolqueteMediano.Text);

        }

        private void btnRestarVG_Click(object sender, EventArgs e)
        {
            this.lblCantidadVolqueteGrande.Text = Decrementar_Label(sender, e, 2, this.lblCantidadVolqueteGrande.Text);

        }

        private void lblCantidadVolqueteGrande_Click(object sender, EventArgs e)
        {

        }

        private void lblPrecioGrande_Click(object sender, EventArgs e)
        {
        }

        private void lstProductos_DrawItem(object sender, DrawItemEventArgs e)
        {
            lstProductos.ItemHeight = 30;
            int paddingVertical = 6; // Ajusta la cantidad de espaciado vertical deseado

            if (e.Index >= 0)
            {
                e.DrawBackground();

                // Obtén el texto del elemento.
                string itemText = lstProductos.Items[e.Index].ToString();

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
                    e.Graphics.DrawString(itemText, lstProductos.Font, brush, textBounds);
                }
            }
        }



    }
}
