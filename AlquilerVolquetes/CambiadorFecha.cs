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
using ClasesManejoBaseDatos;

namespace AlquilerVolquetes
{
    public partial class CambiadorFecha : Form
    {
        private PedidoADO pedidoSeleccionado;
        private DateTime fechaVieja;
        private DateTime fechaNueva;
        private TimeSpan diferencia;
        private int diasDeDiferencia;
        private MisVolquetes MisVolquetes;

        public CambiadorFecha(PedidoADO pedido, MisVolquetes misVolquetes)
        {
            InitializeComponent();
            pedidoSeleccionado = pedido;
            dtpDevolucion.Value = pedidoSeleccionado.Fecha_regreso.AddDays(1);
            fechaVieja = pedidoSeleccionado.Fecha_regreso;
            dtpDevolucion.MinDate = pedidoSeleccionado.Fecha_regreso.AddDays(1);
            try
            {
                dtpDevolucion.MaxDate = DateTime.Today.AddDays(14);
            }
            catch (Exception ex)
            {
                dtpDevolucion.MaxDate = pedidoSeleccionado.Fecha_regreso.AddDays(14);   
            }
            
            MisVolquetes = misVolquetes;
            MostrarPrecio();
        }

        private void btnCambiarFecha_Click(object sender, EventArgs e)
        {
            MostrarPrecio();
            int precio = CalcularPrecio();
            ModalExito exitoLogin = new ModalExito($"¿Pagar por ${precio}?");
            exitoLogin.pictureBox1.Visible = false;
            DialogResult answer = exitoLogin.ShowDialog();
            if (answer == DialogResult.OK)
            {
                DB.ActualizarFechaPedido(pedidoSeleccionado.Hash_code, "fecha_regreso", fechaNueva);
                ModalExito ok = new ModalExito("Pago realizado con éxito");
                ok.ShowDialog();
                this.Hide();
                MisVolquetes.actualizarPantalla();
            }
        }

        private int CalcularPrecio()
        {
            fechaNueva = dtpDevolucion.Value;
            diferencia = fechaNueva - fechaVieja;
            diasDeDiferencia = diferencia.Days;
            int precioVolquetesChicos = pedidoSeleccionado.Volquetes_chicos * 800;
            int precioVolquetesMedianos = pedidoSeleccionado.Volquetes_medianos * 1600;
            int precioVolquetesGrandes = pedidoSeleccionado.Volquetes_grandes * 2400;
            return (diasDeDiferencia * (precioVolquetesChicos + precioVolquetesMedianos + precioVolquetesGrandes));
        }

        private void dtpDevolucion_ValueChanged(object sender, EventArgs e)
        {
            MostrarPrecio();
        }

        private void MostrarPrecio()
        {
            fechaNueva = dtpDevolucion.Value;
            diferencia = fechaNueva - fechaVieja;
            diasDeDiferencia = diferencia.Days;
            if (diasDeDiferencia < 15)
            {
                lblTotal.Text = $"PRECIO: ${CalcularPrecio()}";
            }
        }
    }
}
