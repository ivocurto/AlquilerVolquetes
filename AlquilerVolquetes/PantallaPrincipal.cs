using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerVolquetes
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        //private void PantallaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    // Mostrar un cuadro de diálogo de confirmación
        //    DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //    // Si el usuario elige "No", cancela el cierre de la aplicación
        //    if (resultado == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //}

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
