using System.Text.RegularExpressions;
using Clases;

namespace AlquilerVolquetes
{

    public partial class FormularioDeAlquiler : Form
    {
        private List<Volquete> volquetes;
        public Usuario usuarioActual;
        private List<Pedido> listaClientes;
        private string path = "pedidos.json";
        public int precioTotal;
        private Form formPrincipal;

        public FormularioDeAlquiler(List<Volquete> lista, Usuario usuario, Form formularioPrincipal)
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
            List<string> datosUsuario = CrearListaDeDatosDeUsuario(apellido, nombre, mail, direccion, telefono);
            if (!ComprobarStringVacio(datosUsuario))
            {
                ModalError modal = new ModalError("Por favor, completa todos los campos", "ERROR AL REGISTRARSE");
                DialogResult resultado = modal.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    //
                }
            }
            else if (!IsEmailFormat(mail))
            {
                ModalError clavesDiferentes = new ModalError("Formato de mail inválido", "ERROR AL REGISTRARSE");
                DialogResult resultado = clavesDiferentes.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    txtMail.Text = "";
                }
            } else
            {
                Pedido cliente;
                if (listaClientes is null)
                {
                    listaClientes = new List<Pedido>();
                }

                cliente = new Pedido(usuarioActual.NombreUsuario, usuarioActual.MailUsusario, usuarioActual.ClaveUsuario, usuarioActual.Rol, volquetes, volquetes, txtDireccion.Text, txtTelefono.Text, precioTotal);

                if (listaClientes.Count > 1)
                {
                    cliente.IdCliente = listaClientes.Count() - 1;
                }
                else
                {
                    cliente.IdCliente = 0;
                }

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
            txtMail.Text = usuarioActual.MailUsusario;
        }
        private static bool IsEmailFormat(string input)
        {
            // Utilizamos una expresión regular para verificar el formato de correo electrónico.
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(input, emailPattern);
        }
        private bool ComprobarStringVacio(List<string> lista)
        {

            foreach (string s in lista)
            {
                if (s == "" || s == null)
                {
                    return false;
                }
            }
            return true;
        }

        private List<string> CrearListaDeDatosDeUsuario(string apellido, string nombre, string mail, string direccion, string telefono)
        {
            List<string> datos = new List<string>();
            datos.Add(apellido);
            datos.Add(nombre);
            datos.Add(mail);
            datos.Add(direccion);
            datos.Add(telefono);
            return datos;
        }
    }
}
