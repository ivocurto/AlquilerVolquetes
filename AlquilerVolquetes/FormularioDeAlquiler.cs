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
        private List<Volquete> volquetes;
        string formatoTotal;
        int precioTotal;
        public FormularioDeAlquiler(List<Volquete> lista)
        {
            InitializeComponent();
            volquetes = lista;
            
            MostrarProductosAComprar();
        }

        private void MostrarProductosAComprar()
        {
            string formatoTotal = "";
            bool flag = false;
            int precioTotal = 0;
            foreach (var volquete in volquetes)
            {
                
                string producto = "";
                string formato;
                

                int precio = 0;
                switch (volquete.Id)
                {
                    case 0:
                        producto = "volquete(s) chico(s)";
                        
                        break;
                    case 1:
                        producto = "volquete(s) mediano(s)";
                        
                        break;
                    case 2:
                        producto = "volquete(s) grande(s)";
                        
                        break;

                }
                precio = volquete.PrecioUnitario;
                if (flag == false)
                {
                    formato = volquete.ToString();
                    formatoTotal = formato;
                    flag = true;
                }
                else
                {
                    formato = volquete.ToString();
                    formatoTotal = $"{formatoTotal}, {formato}";
                }


                precioTotal += precio * volquete.Cantidad;
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
