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

namespace AdminApp
{
    public partial class PanelAdmin : Form
    {
        private List<Cliente> clientes;
        private int indexPedido;
        public PanelAdmin()
        {
            InitializeComponent();
            clientes = JsonFileManager.LoadFromJsonGeneric<List<Cliente>>("usuarios.json");
            // Enlaza la lista de pedidos al ListBox
            if (clientes is not null)
            {
                foreach (Cliente cliente in clientes)
                {
                    
                    string formato = "";
                    
                        foreach (Pedido pedido in cliente.Pedidos)
                        {
                            
                                formato += pedido.ToString();
                            
                        }
                        
                    lstUsuarios.Items.Add($"USUARIO: {cliente.Nombre.ToUpper()} VOLQUETES A INSTALAR: {formato}");

                    
                }

            }

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
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este pedido?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Encuentra el índice del pedido seleccionado
                    int selectedIndex = lstUsuarios.SelectedIndex;

                    if (selectedIndex >= 0)
                    {
                        // Elimina el pedido seleccionado de la lista
                        clientes.RemoveAt(selectedIndex);

                        // Recorre la lista actualizada para actualizar los IDs de los pedidos
                        for (int i = 0; i < clientes.Count; i++)
                        {
                            //pedidos[i].IdCliente = i;
                        }

                        // Guarda la lista actualizada en el archivo JSON
                        JsonFileManager.SaveToJsonGeneric("pedidos.json", clientes);

                        // Elimina el pedido seleccionado del ListBox
                        lstUsuarios.Items.RemoveAt(selectedIndex);
                    }
                }
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
    }
}
