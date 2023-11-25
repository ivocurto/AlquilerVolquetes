using System.Text.RegularExpressions;
using System.Windows.Forms;
using Clases;
using ClasesManejoBaseDatos;
using MySqlX.XDevAPI;

namespace AlquilerVolquetes
{
    public partial class FormularioDeAlquiler : Form
    {
        private List<Volquete> volquetes;
        public Cliente usuarioActual;
        private List<Pedido> pedidos;
        private string path = "pedidos.json";
        public int precioTotal;
        private Form formPrincipal;
        private FechaActual fechaActual = new FechaActual();
        private List<int> idsPedidos;

        public FormularioDeAlquiler(List<Volquete> lista, Cliente usuario, Form formularioPrincipal)
        {
            InitializeComponent();
            volquetes = lista;
            usuarioActual = usuario;
            formPrincipal = formularioPrincipal;
            dtpEntrega.Value = fechaActual.fechaActual;
            dtpDevolucion.Value = fechaActual + 3;
            dtpDevolucion.MinDate = dtpDevolucion.Value;
            dtpDevolucion.MaxDate = dtpEntrega.Value.AddDays(14);
            dtpEntrega.MinDate = dtpEntrega.Value;
            pedidos = JsonFileManager.LoadFromJsonGeneric<List<Pedido>>(path);
            idsPedidos = JsonFileManager.LoadFromJsonGeneric<List<int>>("idsPedidos.json");
            if (idsPedidos is null)
            {
                idsPedidos = new List<int>();

                MostrarProductosAComprar();
            }
            foreach (Volquete volquete in volquetes)
            {
                dataGridView1.Rows.Add(volquete.MedidaVolquete, volquete.Cantidad, $"${volquete.PrecioUnitario}");
            }
        }

        private void MostrarProductosAComprar()
        {
            string formatoTotal = "";
            bool flag = false;
            precioTotal = 0;
            int diasDeAlquiler = (dtpDevolucion.Value.Date - dtpEntrega.Value.Date).Days;

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
                    precioTotal += precio * volquete.Cantidad * diasDeAlquiler;
                }
            }
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
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            List<string> datosUsuario = ManejoDeValidaciones.CrearListaDeDatos(txtDireccion.Text, txtTelefono.Text);                //List<string> datosUsuario = ManejoDeValidaciones.CrearListaDeDatos(txtApellido.Text, txtNombre.Text, txtMail.Text, txtDireccion.Text, txtTelefono.Text);
            if (!ManejoDeValidaciones.ComprobarStringVacio(datosUsuario))
            {
                ModalError modal = new ModalError("Por favor, completa todos los campos", "ERROR AL REGISTRARSE");
                modal.ShowDialog();
            }
            else
            {
                Pedido pedido;
                if (pedidos is null)
                {
                    pedidos = new List<Pedido>();
                }
                List<Volquete> volquetesInstalar = new List<Volquete>();

                DateTime fechaEntrega = dtpEntrega.Value;
                DateTime fechaDevolucion = dtpDevolucion.Value;
                pedido = new Pedido(volquetes, volquetesInstalar, usuarioActual.NombreUsuario, fechaDevolucion, fechaEntrega);
                pedido.GenerarIdPedido(idsPedidos);

                if (pedidos.Count > 1)
                {
                    pedido.Index = pedidos.Count() - 1;
                }
                else
                {
                    pedido.Index = 0;
                }

                foreach (Volquete volquete in pedido.VolquetesPedidos)
                {
                    volquete.Identificador = pedido.IdPedido;
                }
                var pedidoADO = new PedidoADO(pedido.IdPedido, usuarioActual.Id, volquetes[0].Cantidad, volquetes[1].Cantidad, volquetes[2].Cantidad, fechaEntrega, fechaDevolucion, direccion);
                DB.CambiarCantidadDisponible(volquetes[0].Id + 1, volquetes[0].Cantidad, false);
                DB.CambiarCantidadDisponible(volquetes[1].Id + 1, volquetes[1].Cantidad, false);
                DB.CambiarCantidadDisponible(volquetes[2].Id + 1, volquetes[2].Cantidad, false);
                DB.ActualizarAtributoUsuario(usuarioActual.MailUsuario, "telefono", telefono);
                pedidoADO.Add();
               
                ModalExito compraExitosa = new ModalExito("COMPRA EXITOSA");
                DialogResult result = compraExitosa.ShowDialog();

                if (result == DialogResult.OK)
                {
                    PantallaInicio pantallaInicio = new PantallaInicio(usuarioActual, this);
                    pantallaInicio.Show();
                    this.Hide();
                    // llevar al formulario de pago
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtpEntrega_ValueChanged_1(object sender, EventArgs e)
        {

            dtpDevolucion.MinDate = dtpEntrega.Value.AddDays(3);
            dtpDevolucion.MaxDate = dtpEntrega.Value.AddDays(14);
            MostrarProductosAComprar();

        }



        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void dtpDevolucion_ValueChanged(object sender, EventArgs e)
        {
            MostrarProductosAComprar();
        }

        private void lblTituloFormularioDePago_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
