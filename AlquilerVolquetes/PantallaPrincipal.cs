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
    public partial class PantallaPrincipal : Form
    {
        //LISTA CARRITO
        private Dictionary<int, int> productosSumados = new Dictionary<int, int>();

        private void Sumar_Al_Carrito(object sender, EventArgs e, int id)
        {
            if (!productosSumados.ContainsKey(id))
            {
                productosSumados.Add(id, 1); // Agrega el producto con ID 1 y cantidad 1
            } else {
                productosSumados[id]++; // Le suma 1 a la cantida
            }
            
            foreach (var clave in productosSumados)
            {
                int idEnLista = clave.Key;
                string producto  = "";
                switch (idEnLista)
                {
                    case 0:
                        producto = "Volquete chico";
                        break;
                    case 1:
                        producto = "Volquete mediano";
                        break;
                    case 2:
                        producto = "Volquete mediano";
                        break;
                }
                int idProducto = idEnLista;
                int cantidad = clave.Value;
                string formato = $"{producto} {idProducto}x {cantidad}";
                lstProductos.Items.Add(formato);
            }
        }

        private void Restar_Al_Carrito(object sender, EventArgs e, int id)
        {
            if (productosSumados.ContainsKey(id))
            {
                productosSumados[id]--; // Le resta 1 a la cantidad
                foreach (var clave in productosSumados)
                {
                    int idEnLista = clave.Key;
                    string producto = "";
                    switch (idEnLista)
                    {
                        case 0:
                            producto = "Volquete chico";
                            break;
                        case 1:
                            producto = "Volquete mediano";
                            break;
                        case 2:
                            producto = "Volquete mediano";
                            break;
                    }
                    int idProducto = idEnLista;
                    int cantidad = clave.Value;
                    string formato = $"{producto} {idProducto}x {cantidad}";
                    lstProductos.Items.Add(formato);
                }
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
            this.lblPrecioChico.Text = ($"${int.Parse(this.lblCantidadVolqueteChico.Text) * 800}");


        }
        private void btnRestarVolqueteChico_Click(object sender, EventArgs e)
        {
            this.lblCantidadVolqueteChico.Text = Decrementar_Label(sender, e, 0, this.lblCantidadVolqueteChico.Text);
            this.lblPrecioChico.Text = ($"${int.Parse(this.lblCantidadVolqueteChico.Text) * 800}");

        }

        //Mediano
        private void btnAgregarVolqueteMediano_Click(object sender, EventArgs e)
        {
            this.lblCantidadVolqueteMediano.Text = Incrementar_Label(sender, e, 1, this.lblCantidadVolqueteMediano.Text);
            this.lblPrecioMediano.Text = ($"${int.Parse(this.lblCantidadVolqueteMediano.Text) * 1200}");

        }
        private void btnRestarVolqueteMediano_Click(object sender, EventArgs e)
        {
            this.lblCantidadVolqueteMediano.Text = Decrementar_Label(sender, e, 1, this.lblCantidadVolqueteMediano.Text);
            this.lblPrecioMediano.Text = ($"${int.Parse(this.lblCantidadVolqueteMediano.Text) * 1200}");
        }
        //Grande
        private void btnAgregarVolqueteGrande_Click(object sender, EventArgs e)
        {
            this.lblCantidadVolqueteGrande.Text = Incrementar_Label(sender, e, 2, this.lblCantidadVolqueteGrande.Text);
            this.lblPrecioGrande.Text = ($"${int.Parse(this.lblCantidadVolqueteGrande.Text) * 1600}");

        }
        private void btnRestarVolqueteGrande_Click(object sender, EventArgs e)
        {

            this.lblCantidadVolqueteGrande.Text = Decrementar_Label(sender, e, 2, this.lblCantidadVolqueteGrande.Text);
            this.lblPrecioGrande.Text = ($"${int.Parse(this.lblCantidadVolqueteGrande.Text) * 1600}");

        }

        private string Incrementar_Label(object sender, EventArgs e, int id, string label)
        {
            int valor = int.Parse(label);
            if (valor < 8) {
                valor++;
                Sumar_Al_Carrito(sender, e, 0);
            }

            return ($"{valor}");
        }

        private string Decrementar_Label(object sender, EventArgs e, int id, string label)
        {
            int valor = int.Parse(label);
            if (valor > 0) {
                valor--;
                Restar_Al_Carrito(sender, e, 0);
            }

            return ($"{valor}");
        }
    }
}
