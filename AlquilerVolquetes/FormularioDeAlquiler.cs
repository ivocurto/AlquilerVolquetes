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
        public Usuario usuarioActual;
        private List<Cliente> listaClientes;
        private string path = "pedidos.json";
        public int precioTotal;
        
        public FormularioDeAlquiler(List<Volquete> lista, Usuario usuario)
        {
            InitializeComponent();
            volquetes = lista;
            usuarioActual = usuario;
            listaClientes = JsonFileManager.LoadFromJsonGeneric<List<Cliente>>(path);
            
            MostrarProductosAComprar();
        }

        private void MostrarProductosAComprar()
        {
            string formatoTotal = "";
            bool flag = false;
            precioTotal = 0;
            foreach (Volquete volquete in volquetes)
            {
                if (volquete.Cantidad > 0)
                {
                    string producto = "";


                    int precio = 0;
                    producto = volquete.ToString().ToLower();
                    precio = volquete.PrecioUnitario;
                    if (flag == false)
                    {
                        formatoTotal = producto;
                        flag = true;
                    }
                    else
                    {
                        formatoTotal = $"{formatoTotal}, {producto}";
                    }


                    precioTotal += precio * volquete.Cantidad;
                }

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
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal(usuarioActual);
            pantallaPrincipal.Show();
            this.Hide();
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            if (listaClientes is null)
            {
                listaClientes = new List<Cliente>();
            }

            
                cliente = new Cliente(usuarioActual.NombreUsuario, usuarioActual.MailUsusario, usuarioActual.ClaveUsuario, usuarioActual.Rol, volquetes, volquetes, txtDireccion.Text, txtTelefono.Text, precioTotal);

                if (listaClientes.Count > 1)
                {
                    cliente.IdCliente = listaClientes.Count()-1;
                }
                else
                {
                    cliente.IdCliente = 0;
                }

                listaClientes.Add(cliente);
            
           

            JsonFileManager.SaveToJsonGeneric<List<Cliente>>(path, listaClientes);
            CompraExitosa compraExitosa = new CompraExitosa();
            DialogResult result = compraExitosa.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Hide();
                MisVolquetes misVolquetes = new MisVolquetes(usuarioActual, cliente);
                misVolquetes.Show();
                // llevar al formulario de pago
            }

        }

        private void FormularioDeAlquiler_Load(object sender, EventArgs e)
        {
            txtMail.Text = usuarioActual.MailUsusario;
        }
    }
}
