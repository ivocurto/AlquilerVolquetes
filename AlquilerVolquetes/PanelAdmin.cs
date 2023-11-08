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
        private List<Pedido> pedidos;
        private int indexPedido;
        public PanelAdmin()
        {
            InitializeComponent();
            pedidos = JsonFileManager.LoadFromJsonGeneric<List<Pedido>>("pedidos.json");
            // Enlaza la lista de pedidos al ListBox
            if(pedidos is not null)
            {
                foreach (Pedido pedido in pedidos)
                {
                    indexPedido = pedido.IdPedido;
                    string formato = "";
                    if (pedido.VolquetesPedidos.Count() > 0)
                    {
                        foreach (Volquete volquete in pedido.VolquetesPedidos)
                        {
                            if (volquete.Cantidad != 0)
                            {
                                formato += volquete.ToString() + " - ";
                            }
                        }
                        lstPedidosTotales.Items.Add($"USUARIO: {pedido.Cliente.ToUpper()} VOLQUETES A INSTALAR: {formato}");

                    }
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
            if (lstPedidosTotales.SelectedItem != null)
            {
                // Muestra un cuadro de diálogo de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este pedido?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Encuentra el índice del pedido seleccionado
                    int selectedIndex = lstPedidosTotales.SelectedIndex;

                    if (selectedIndex >= 0)
                    {
                        // Elimina el pedido seleccionado de la lista
                        pedidos.RemoveAt(selectedIndex);

                        // Recorre la lista actualizada para actualizar los IDs de los pedidos
                        for (int i = 0; i < pedidos.Count; i++)
                        {
                            //pedidos[i].IdCliente = i;
                        }

                        // Guarda la lista actualizada en el archivo JSON
                        JsonFileManager.SaveToJsonGeneric("pedidos.json", pedidos);

                        // Elimina el pedido seleccionado del ListBox
                        lstPedidosTotales.Items.RemoveAt(selectedIndex);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstPedidosTotales.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("¿Desea aceptar el pedido?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedIndex = lstPedidosTotales.SelectedIndex;

                    if (selectedIndex >= 0)
                    {
                        pedidos[selectedIndex].VolquetesInstalados = pedidos[selectedIndex].VolquetesPedidos;

                        pedidos[selectedIndex].VolquetesPedidos = new List<Volquete>();


                        JsonFileManager.SaveToJsonGeneric("pedidos.json", pedidos);

                        lstPedidosTotales.Items.RemoveAt(selectedIndex);
                    }
                }
            }
        }
    }
}
