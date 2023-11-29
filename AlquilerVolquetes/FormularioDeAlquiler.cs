using System.Text.RegularExpressions;
using System.Windows.Forms;
using Clases;
using ClasesManejoBaseDatos;
using Excepciones;
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

            try
            {
                ValidarCampos(telefono, direccion);

                Pedido pedido = CrearPedido();
                GuardarPedidoEnBaseDeDatos(pedido);

                ModalExito compraExitosa = new ModalExito("COMPRA EXITOSA");
                DialogResult result = compraExitosa.ShowDialog();

                if (result == DialogResult.OK)
                {
                    PantallaInicio pantallaInicio = new PantallaInicio(usuarioActual);
                    this.Hide();
                    pantallaInicio.Show();
                }
            }
            catch (ModalErrorException ex)
            {
                ModalError modal = new ModalError(ex.Message, "ERROR AL INGRESAR DATOS");
                modal.ShowDialog();
            }
            catch (TelefonoStringException ex)
            {
                ModalError modal = new ModalError(ex.Message, "ERROR AL INGRESAR DATOS");
                modal.ShowDialog();
            }
            catch (TelefonoLongitudException ex)
            {
                ModalError modal = new ModalError(ex.Message, "ERROR AL INGRESAR DATOS");
                modal.ShowDialog();
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ValidarCampos(string telefono, string direccion)
        {
            List<string> datosUsuario = ManejoDeValidaciones.CrearListaDeDatos(direccion, telefono);

            if (!ManejoDeValidaciones.ComprobarStringVacio(datosUsuario))
            {
                throw new ModalErrorException("Por favor, completa todos los campos");
            }
            if (!EsNumero(telefono))
            {
                throw new TelefonoStringException();
            }
            if (telefono.Length != 10)
            {
                throw new TelefonoLongitudException();
            }
        }

        private bool EsNumero(string texto)
        {
            return int.TryParse(texto, out _);
        }

        private Pedido CrearPedido()
        {
            Pedido pedido = new Pedido(volquetes, new List<Volquete>(), usuarioActual.NombreUsuario, dtpDevolucion.Value, dtpEntrega.Value);
            pedido.GenerarIdPedido(idsPedidos);

            // Resto del código para configurar el pedido

            return pedido;
        }

        private void GuardarPedidoEnBaseDeDatos(Pedido pedido)
        {
            PedidoADO pedidoADO = new PedidoADO(pedido.IdPedido, usuarioActual.Id, volquetes[0].Cantidad, volquetes[1].Cantidad, volquetes[2].Cantidad, dtpEntrega.Value, dtpDevolucion.Value, txtDireccion.Text);

            // Resto del código para guardar el pedido en la base de datos

            // Actualizar disponibilidad y atributos en la base de datos
            DB.CambiarCantidadDisponible(volquetes[0].Id + 1, volquetes[0].Cantidad, false);
            DB.CambiarCantidadDisponible(volquetes[1].Id + 1, volquetes[1].Cantidad, false);
            DB.CambiarCantidadDisponible(volquetes[2].Id + 1, volquetes[2].Cantidad, false);
            DB.ActualizarAtributoUsuario(usuarioActual.MailUsuario, "telefono", txtTelefono.Text);

            // Agregar el pedido a la base de datos
            pedidoADO.Add();
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


    }

}
