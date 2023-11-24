using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlquilerVolquetes;
using Clases;
using ClasesManejoBaseDatos;

namespace AdminApp
{
    public partial class PanelAdmin : Form
    {
        private List<ClasesManejoBaseDatos.UsuarioADO> clientes;
        private List<AdminADO> admins;
        private int indexPedido;
        private Admin adminActual;
        private ClasesManejoBaseDatos.UsuarioADO clienteActual;
        private string rutaArchivoAdmins = @"..\..\..\..\AlquilerVolquetes\bin\Debug\net6.0-windows\admins.json";

        public PanelAdmin(Admin admin)
        {
            InitializeComponent();
            adminActual = admin;
            actualizarPantalla();
        }

        private void PanelAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Desasociar el manejador de eventos FormClosing para evitar llamadas recursivas
            this.FormClosing -= PanelAdmin_FormClosing;

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


        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedItem != null)
            {
                // Muestra un cuadro de diálogo de confirmación
                DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas ELIMINAR a {lstUsuarios.SelectedItem} ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //Cliente cliente = DB.TraerUsuarioLogueado(lstUsuarios.SelectedItem.ToString());
                    //List<PedidoADO> pedidos = DB.Select<PedidoADO>($"SELECT * FROM pedidos_cliente");
                    //devolverAlStockTodosLosPedidosDeUnUsuario(pedidos, cliente.);
                    //DB.Drop("id_usuario", cliente.Id);
                    DB.Drop("usuarios", "nombre_usuario", lstUsuarios.SelectedItem.ToString());
                }

                actualizarPantalla();
            }
            else if (lstAdmins.SelectedItem != null)
            {
                if (adminActual.NombreUsuario != lstAdmins.SelectedItem.ToString())
                {
                    // Muestra un cuadro de diálogo de confirmación
                    DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas ELIMINAR a {lstAdmins.SelectedItem} ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DB.Drop("admins", "nombre_admin", lstAdmins.SelectedItem.ToString());
                    }

                    actualizarPantalla();
                } else {
                    ModalError error = new ModalError("No podes eliminarte a vos mismo", "Error de eliminación");
                    error.Show();
                }
            }
        }

        private void devolverAlStockTodosLosPedidosDeUnUsuario(List<PedidoADO> pedidos, int pedido_hash_code)
        {
            foreach (PedidoADO pedido in pedidos)
            {
                if (pedido.Hash_code == pedido_hash_code)
                {
                    int cantidadVC = pedido.Volquetes_chicos;
                    DB.CambiarCantidadDisponible(1, cantidadVC, true);
                    int cantidadVM = pedido.Volquetes_medianos;
                    DB.CambiarCantidadDisponible(2, cantidadVM, true);
                    int cantidadVG = pedido.Volquetes_grandes;
                    DB.CambiarCantidadDisponible(3, cantidadVG, true);
                }
               
            }
        }

        private void actualizarPantalla()
        {
            admins = DB.GetAdmins();
            clientes = DB.GetUsuarios();
            if (clientes is not null)
            {
                lstUsuarios.Items.Clear();
                foreach (UsuarioADO cliente in clientes)
                {
                    lstUsuarios.Items.Add(cliente.Nombre_usuario);
                }
            }
            if (admins is not null)
            {
                lstAdmins.Items.Clear();
                foreach (AdminADO admin in admins)
                {
                    lstAdmins.Items.Add(admin.Nombre_admin);
                }
            }
        }

        private void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAdmins.ClearSelected();
        }

        private void lstAdmins_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstUsuarios.ClearSelected();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {

            if (lstUsuarios.SelectedItem != null)
            {
                foreach (UsuarioADO cliente in clientes)
                {
                    if (cliente.Nombre_usuario == lstUsuarios.SelectedItem.ToString())
                    {
                        DatosUsuario datosUsuario = new DatosUsuario(cliente);
                        datosUsuario.Show();
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ModalExito exitoLogin = new ModalExito("¿Deseas cerrar sesión?");
            exitoLogin.pictureBox1.Visible = false;
            DialogResult answer = exitoLogin.ShowDialog();
            if (answer == DialogResult.OK)
            {

                InicioSesion inicioS = new InicioSesion();
                inicioS.Show();
                this.Hide();
            }
        }

        private void btnHacerAdmin_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas hacer admin a {lstUsuarios.SelectedItem}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedIndex = lstUsuarios.SelectedIndex;
                    Cliente cliente = DB.TraerUsuarioLogueado(lstUsuarios.SelectedItem.ToString());
                    DB.Insert(cliente.MailUsuario, cliente.NombreUsuario, cliente.ClaveUsuario);
                }
                actualizarPantalla();
            }
        }
    }
}
