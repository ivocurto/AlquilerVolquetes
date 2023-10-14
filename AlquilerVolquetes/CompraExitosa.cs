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
    public partial class CompraExitosa : Form
    {
        public CompraExitosa()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            // Cierra el formulario de diálogo.
            this.Close();

        }

        private void CompraExitosa_Load(object sender, EventArgs e)
        {
            // Configura el tamaño del formulario
            this.Width = 570;
            this.Height = 288;
            // Aparezca siempre centrado:
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
