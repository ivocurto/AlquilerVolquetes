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
    public partial class InicioSesion : Form
    {
        protected static List<Usuario> usuarios = new List<Usuario>();
        protected static Usuario a = new Usuario("a", "francoferrari226@gmail.com", "a");

        public InicioSesion()
        {
            InitializeComponent();
            usuarios.Add(a);
        }

        public InicioSesion(Usuario usuario)
        {
            InitializeComponent();
            usuarios.Add(usuario);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUsuario registro = new RegistroUsuario(usuarios);
            registro.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            string nombreUsuario = txtUsuario.Text;
            string clave = txtClave.Text;

            foreach (var usuario in usuarios)
            {
                if (usuario.NombreUsuario == nombreUsuario && usuario.ClaveUsuario == clave)
                {
                    PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
                    pantallaPrincipal.Show();
                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("Nombre de usuario o clave incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void InicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void InicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
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
    }
}
