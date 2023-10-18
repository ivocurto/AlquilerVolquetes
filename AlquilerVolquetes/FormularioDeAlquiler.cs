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
        private List<Pedido> listaPedidos;
        private string path = "pedidos.json";
        public int precioTotal;
        private Form formPrincipal;
        private List<Pedido> pedidosDelCliente;

        public FormularioDeAlquiler(List<Volquete> lista, Usuario usuario, Form formularioPrincipal)
        {
            InitializeComponent();
            volquetes = lista;
            usuarioActual = usuario;
            formPrincipal = formularioPrincipal;
            listaPedidos = JsonFileManager.LoadFromJsonGeneric<List<Pedido>>(path);
            pedidosDelCliente = ClienteActual.ObtenerCliente();
            if (listaPedidos == null)
            {
                listaPedidos = new List<Pedido>();
            }

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

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            Pedido pedido;
            if (listaPedidos is null)
            {
                listaPedidos = new List<Pedido>();
            }

            pedido = new Pedido(usuarioActual.NombreUsuario, usuarioActual.MailUsusario, usuarioActual.ClaveUsuario, usuarioActual.Rol, volquetes, volquetes, txtDireccion.Text, txtTelefono.Text, precioTotal);

            if (listaPedidos.Count > 1)
            {
                pedido.IdCliente = listaPedidos.Count() - 1;
            }
            else
            {
                pedido.IdCliente = 0;
            }

            listaPedidos.Add(pedido);

            JsonFileManager.SaveToJsonGeneric<List<Pedido>>(path, listaPedidos);
            CompraExitosa compraExitosa = new CompraExitosa();
            DialogResult result = compraExitosa.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (listaPedidos == null || listaPedidos.Count == 0)
                {
                    // Realiza alguna acción o muestra un mensaje de error si es necesario.
                    MessageBox.Show("La lista de pedidos está vacía o es nula.");
                } else
                {
                    MessageBox.Show("La lista de pedidos esta llena.");
                }
                this.Hide();
                formPrincipal.Show();
                // llevar al formulario de pago
            }

        }

        private void FormularioDeAlquiler_Load(object sender, EventArgs e)
        {
            txtMail.Text = usuarioActual.MailUsusario;
        }
    }
}
