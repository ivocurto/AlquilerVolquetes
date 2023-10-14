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
        public List<Usuario> listaUsuarios;
        public RegistroUsuario(List<Usuario> lista)
        {
            InitializeComponent();
            listaUsuarios = lista;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string clave = txtClave.Text;
            string reClave = txtReClave.Text;
            string nombre = txtUsuario.Text;
            string mail = txtMail.Text;

            List<string> datosUsuario = CrearListaDeDatosDeUsuario(clave, nombre, mail, reClave);

            if (!ComprobarStringVacio(datosUsuario))
            {
                ModalErrorAlRegistrarse clavesDiferentes = new ModalErrorAlRegistrarse("stringVacio");
                DialogResult result = clavesDiferentes.ShowDialog();
            }
            else if (!ValidarContraseña(datosUsuario))
            {
                ModalErrorAlRegistrarse clavesDiferentes = new ModalErrorAlRegistrarse("claves");
                DialogResult result = clavesDiferentes.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtClave.Text = "";
                    txtReClave.Text = "";
                }
            }
            else if (!ComprobarExistenciaUsuario(datosUsuario))
            {
                ModalErrorAlRegistrarse clavesDiferentes = new ModalErrorAlRegistrarse("existenciaUsuario");
                DialogResult result = clavesDiferentes.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtMail.Text = "";
                    txtUsuario.Text = "";
                    txtClave.Text = "";
                    txtReClave.Text = "";
                }
            }
            else
            {
                ModalExitoLogin exitoLogin = new ModalExitoLogin("register");
                DialogResult answer = exitoLogin.ShowDialog();
                if (answer == DialogResult.OK)
                {
                    Usuario usuario = new Usuario(nombre, mail, clave);
                    listaUsuarios.Add(usuario);
                    InicioSesion inicio = new InicioSesion(usuario);
                    inicio.Show();
                    this.Hide();
                }
                
            }
        }


        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
        }

        private List<string> CrearListaDeDatosDeUsuario(string clave, string nombre, string mail, string reClave)
        {
            List<string> datos = new List<string>();
            datos.Add(nombre);
            datos.Add(clave);
            datos.Add(mail);
            datos.Add(reClave);
            return datos;
        }

        private bool ValidarContraseña(List<string> datos)
        {

            if (datos[1] == datos[3])
            {
                return true;
            }
            return false;
        }

        private bool ComprobarStringVacio(List<string> lista)
        {

            foreach (string s in lista)
            {
                if (s == "" || s == null)
                {
                    return false;
                }
            }
            return true;
        }

        private bool ComprobarExistenciaUsuario(List<string> lista)
        {

            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.NombreUsuario == lista[0] || usuario.MailUsusario == lista[2])
                {
                    return false;
                }
            }

            return true;
        }

        private void RegistroUsuario_FormClosed(object sender, FormClosedEventArgs e)
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

        private void lblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InicioSesion inicio = new InicioSesion();
            inicio.Show();
            this.Hide();
        }

    }
}
