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

namespace AdminApp
{
    public partial class PanelAdmin : Form
    {
        private List<Cliente> clientes;
        private List<Admin> admins;
        private int indexPedido;
        private Admin adminActual;
        private Cliente clienteActual;
        private string rutaArchivoAdmins = @"..\..\..\..\AlquilerVolquetes\bin\Debug\net6.0-windows\admins.json";

        public PanelAdmin(Admin admin)
        {
            InitializeComponent();
            adminActual = admin;
            clientes = JsonFileManager.LoadFromJsonGeneric<List<Cliente>>("usuarios.json");
            admins = JsonFileManager.LoadFromJsonGeneric<List<Admin>>(rutaArchivoAdmins);
            // Enlaza la lista de pedidos al ListBox
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
                        clientes = adminActual.EliminarCliente(clientes, lstUsuarios.SelectedItem.ToString());
                    }
                }
                JsonFileManager.SaveToJsonGeneric<List<Cliente>>("usuarios.json", clientes);
                JsonFileManager.SaveToJsonGeneric<List<Admin>>(rutaArchivoAdmins, admins);

                PanelAdmin_Load(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (lstUsuarios.SelectedItem != null)
            //{
            //    DialogResult result = MessageBox.Show("¿Desea aceptar el pedido?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (result == DialogResult.Yes)
            //    {
            //        int selectedIndex = lstUsuarios.SelectedIndex;

            //        if (selectedIndex >= 0)
            //        {
            //            clientes[selectedIndex].VolquetesInstalados = clientes[selectedIndex].VolquetesPedidos;

            //            clientes[selectedIndex].VolquetesPedidos = new List<Volquete>();


            //            JsonFileManager.SaveToJsonGeneric("pedidos.json", clientes);

            //            lstUsuarios.Items.RemoveAt(selectedIndex);
            //        }
            //    }
            //}
        }

        private void PanelAdmin_Load(object sender, EventArgs e)
        {
            if (clientes is not null)
            {
                lstUsuarios.Items.Clear();
                foreach (Cliente cliente in clientes)
                {

                    string formato = "";

                    foreach (Pedido pedido in cliente.Pedidos)
                    {

                        formato += pedido.ToString();

                    }

                    //lstUsuarios.Items.Add($"USUARIO: {cliente.Nombre.ToUpper()} VOLQUETES A INSTALAR: {formato}");
                    lstUsuarios.Items.Add(cliente.NombreUsuario);


                }

            }
            if (admins is not null)
            {
                lstAdmins.Items.Clear();
                foreach (Admin adminn in admins)
                {



                    //lstUsuarios.Items.Add($"USUARIO: {cliente.Nombre.ToUpper()} VOLQUETES A INSTALAR: {formato}");
                    lstAdmins.Items.Add(adminn.NombreUsuario);


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

                        clientes = adminActual.EliminarCliente(clientes, lstUsuarios.SelectedItem.ToString());


                    }

                }
                JsonFileManager.SaveToJsonGeneric<List<Cliente>>("usuarios.json", clientes);

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
                foreach (Admin admin in admins)
                {
                    if (admin.NombreUsuario == lstAdmins.SelectedItem)
                    {
                        DatosUsuario datosUsuario = new DatosUsuario(admin);
                        datosUsuario.Show();

                    }
                }
            }


            if (lstUsuarios.SelectedItem != null)
            {
                foreach (Cliente cliente in clientes)
                {
                    if (cliente.NombreUsuario == lstUsuarios.SelectedItem)
                    {
                        DatosUsuario datosUsuario = new DatosUsuario(cliente, clientes);
                        datosUsuario.Show();
                    }
                }

            }



        }
    }
}
