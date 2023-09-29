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
    public partial class RegistroUsuario : Form
    {
        public List<Usuario> listaUsuarios = new List<Usuario>();
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string clave = txtClave.Text;
            string nombre = txtUsuario.Text;
            string mail = txtMail.Text;
            Usuario usuario = new Usuario(nombre, mail, clave);
            InicioSesion inicio = new InicioSesion(usuario);
            inicio.Show();
            this.Hide();
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
        }
    }
}
