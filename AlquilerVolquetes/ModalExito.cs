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
    public partial class ModalExito : Form
    {
        string tituloModal;
        public ModalExito(string titulo)
        {
            InitializeComponent();
            tituloModal = titulo;
        }

        private void ModalExitoLogin_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = tituloModal;
        }

        private void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
