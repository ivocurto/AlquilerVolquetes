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
    public partial class FormularioDeAlquiler : Form
    {
        private Dictionary<int, int> diccionarioCarrito;
        int precioVChico;
        int precioVMediano;
        int precioVGrande;
        string formatoTotal;
        int precioTotal;
        public FormularioDeAlquiler(Dictionary<int, int> dict, int precioVC, int precioVM, int precioVG)
        {
            InitializeComponent();
            diccionarioCarrito = dict;
            precioVChico = precioVC;
            precioVMediano = precioVM;
            precioVGrande = precioVG;
            MostrarProductosAComprar();
        }

        private void MostrarProductosAComprar()
        {
            bool flag = false;
            foreach (var clave in diccionarioCarrito)
            {
                int idEnLista = clave.Key;
                int cantidad = clave.Value;
                string producto = "";
                string formato;

                int precio = 0;
                switch (idEnLista)
                {
                    case 0:
                        producto = "volquete(s) chico(s)";
                        precio = precioVChico;
                        break;
                    case 1:
                        producto = "volquete(s) mediano(s)";
                        precio = precioVMediano;
                        break;
                    case 2:
                        producto = "volquete(s) grande(s)";
                        precio = precioVGrande;
                        break;
                }
                if (flag == false)
                {
                    formato = $"{cantidad} {producto} por ${precio * cantidad}";
                    formatoTotal = formato;
                    flag = true;
                }
                else
                {
                    formato = $"{cantidad} {producto} por ${precio * cantidad}";
                    formatoTotal = $"{formatoTotal}, {formato}";
                }


                precioTotal += precio * cantidad;
            }

            this.lblProductos.Text = $"Usted va a comprar {formatoTotal}.";
            this.lblTotal.Text = $"PRECIO TOTAL: ${precioTotal}";
        }

        private void FormularioDeAlquiler_FormClosed(object sender, FormClosedEventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
            this.Hide();
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            CompraExitosa compraExitosa = new CompraExitosa();
            DialogResult result = compraExitosa.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Hide();
                MisVolquetes misVolquetes = new MisVolquetes();
                misVolquetes.Show();
                // llevar al formulario de pago
            }
            
        }
    }
}
