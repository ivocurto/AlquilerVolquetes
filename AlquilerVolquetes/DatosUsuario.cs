using Clases;
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
    public partial class DatosUsuario : Form
    {
        private Cliente clienteAcual;
        private Admin adminActual;
        public DatosUsuario(Cliente cliente)
        {
            InitializeComponent();
            clienteAcual = cliente;
        }

        public DatosUsuario(Admin admin)
        {
            InitializeComponent();
            adminActual = admin;
        }

        private void DatosUsuario_Load(object sender, EventArgs e)
        {
            if (clienteAcual == null)
            {
                lblNombreCliente.Text = adminActual.NombreUsuario;
            }
            else
            {
                lblNombreCliente.Text = clienteAcual.NombreUsuario;
            }
        }
    }
}
