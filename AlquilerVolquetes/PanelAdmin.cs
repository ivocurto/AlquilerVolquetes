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
            admins = DB.GetAdmins();
            clientes = DB.GetUsuarios();
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

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            // Verifica si se seleccionó un pedido en el ListBox
            if (lstUsuarios.SelectedItem != null)
            {
                // Muestra un cuadro de diálogo de confirmación
                DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas hacer admin a {lstUsuarios.SelectedItem} ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Encuentra el índice del pedido seleccionado
                    int selectedIndex = lstUsuarios.SelectedIndex;

                    if (selectedIndex >= 0)
                    {
                        //admins = adminActual.AgregarAdmin(clientes, admins, lstUsuarios.SelectedItem.ToString());
                        //clientes = adminActual.EliminarCliente(clientes, lstUsuarios.SelectedItem.ToString());********************************************
                    }
                }

                PanelAdmin_Load(sender, e);
            }
        }

        private void PanelAdmin_Load(object sender, EventArgs e)
        {
            if (clientes is not null)
            {
                lstUsuarios.Items.Clear();
                foreach (ClasesManejoBaseDatos.UsuarioADO cliente in clientes)
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

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedItem != null)
            {
                // Muestra un cuadro de diálogo de confirmación
                DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas ELIMINAR a {lstUsuarios.SelectedItem} ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Encuentra el índice del pedido seleccionado
                    int selectedIndex = lstUsuarios.SelectedIndex;

                    if (selectedIndex >= 0)
                    {

                        //clientes = adminActual.EliminarCliente(clientes, lstUsuarios.SelectedItem.ToString()); ********************************************


                    }

                }

                PanelAdmin_Load(sender, e);
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
            if (lstAdmins.SelectedItem != null)
            {
                foreach (AdminADO admin in admins)
                {
                    if (admin.Nombre_admin == lstAdmins.SelectedItem)
                    {
                        DatosUsuario datosUsuario = new DatosUsuario(admin);
                        datosUsuario.Show();
                    }
                }
            }

            if (lstUsuarios.SelectedItem != null)
            {
                foreach (ClasesManejoBaseDatos.UsuarioADO cliente in clientes)
                {
                    if (cliente.Nombre_usuario == lstUsuarios.SelectedItem)
                    {
                        DatosUsuario datosUsuario = new DatosUsuario(cliente);
                        datosUsuario.Show();
                    }
                }
            }
        }
    }
}
