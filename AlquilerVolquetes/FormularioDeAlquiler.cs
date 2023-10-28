using System.Text.RegularExpressions;
using Clases;

namespace AlquilerVolquetes
{
    public partial class FormularioDeAlquiler : Form
    {
        private List<Volquete> volquetes;
        public Cliente usuarioActual;
        private List<Pedido> listaClientes;
        private string path = "pedidos.json";
        public int precioTotal;
        private Form formPrincipal;

        public FormularioDeAlquiler(List<Volquete> lista, Cliente usuario, Form formularioPrincipal)
        {
            InitializeComponent();
            volquetes = lista;
            usuarioActual = usuario;
            formPrincipal = formularioPrincipal;
            listaClientes = JsonFileManager.LoadFromJsonGeneric<List<Pedido>>(path);
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
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string mail = txtMail.Text;
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            List<string> datosUsuario = ManejoDeValidaciones.CrearListaDeDatos(txtApellido.Text, txtNombre.Text, txtMail.Text, txtDireccion.Text, txtTelefono.Text);
            if (!ManejoDeValidaciones.ComprobarStringVacio(datosUsuario))
            {
                ModalError modal = new ModalError("Por favor, completa todos los campos", "ERROR AL REGISTRARSE");
                DialogResult resultado = modal.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    //
                }
            }
            else if (!ManejoDeValidaciones.IsEmailFormat(mail))
            {
                ModalError clavesDiferentes = new ModalError("Formato de mail inválido", "ERROR AL REGISTRARSE");
                DialogResult resultado = clavesDiferentes.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    txtMail.Text = "";
                }
            }
            else
            {
                Pedido cliente;
                if (listaClientes is null)
                {
                    listaClientes = new List<Pedido>();
                }
                List<Volquete> volquetesInstalar = new List<Volquete>();

                cliente = new Pedido( volquetes, volquetesInstalar, usuarioActual.NombreUsuario);

                

                listaClientes.Add(cliente);

                JsonFileManager.SaveToJsonGeneric<List<Pedido>>(path, listaClientes);
                ModalExito compraExitosa = new ModalExito("COMPRA EXITOSA");
                DialogResult result = compraExitosa.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.Hide();
                    formPrincipal.Show();
                    // llevar al formulario de pago
                }
            }
        }

        private void FormularioDeAlquiler_Load(object sender, EventArgs e)
        {
            txtMail.Text = usuarioActual.MailUsuario;
        }
    }
}
