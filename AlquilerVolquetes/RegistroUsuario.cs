using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerVolquetes
{
    public partial class RegistroUsuario : Form
    {

        private Size previousSize;
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
            string mail = txtCorreo.Text;

            List<string> datosUsuario = CrearListaDeDatosDeUsuario(clave, nombre, mail, reClave);

            if (!ComprobarStringVacio(datosUsuario))
            {
                ModalError modal = new ModalError("Por favor, completa todos los campos", "ERROR AL REGISTRARSE");
                DialogResult result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //
                }
            }
            else if (!ValidarContraseña(datosUsuario))
            {
                ModalError modal = new ModalError("Las contraseñas no coinciden", "ERROR AL REGISTRARSE");
                DialogResult result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtClave.Text = "";
                    txtReClave.Text = "";
                }
            }
            else if (!ComprobarExistenciaUsuario(datosUsuario, listaUsuarios))
            {
                ModalError modal = new ModalError("El nombre de usuario o el correo ya existen", "ERROR AL REGISTRARSE");
                DialogResult result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtCorreo.Text = "";
                    txtUsuario.Text = "";
                    txtClave.Text = "";
                    txtReClave.Text = "";
                }
            }
            else if (!IsEmailFormat(mail))
            {
                ModalError modal = new ModalError("Formato de mail inválido", "ERROR AL REGISTRARSE");
                DialogResult result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtCorreo.Text = "";
                }
            }
            else
            {
                ModalExito exitoLogin = new ModalExito("REGISTRO EXITOSO");
                DialogResult answer = exitoLogin.ShowDialog();
                if (answer == DialogResult.OK)
                {
                    Usuario usuario = new Usuario(nombre, mail, clave, ERolUsuario.Usuario);
                    listaUsuarios.Add(usuario);
                    InicioSesion inicio = new InicioSesion(usuario);
                    inicio.Show();
                    this.Hide();
                }

            }
        }


        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

            MostrarLabel(txtUsuario, lblUsusario);
            MostrarLabel(txtClave, lblClave);
            MostrarLabel(txtCorreo, lblCorreo);
            MostrarLabel(txtReClave, lblReClave);
        }

        private void MostrarLabel(TextBox textBox, Label label)
        {
            if (VerificarEstadoTxtBox(textBox))
            {
                label.Visible = true;
            }
            else
            {
                label.Visible = false;
            }
        }

        private bool VerificarEstadoTxtBox(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
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

        private bool ComprobarExistenciaUsuario(List<string> lista, List<Usuario> listaUsuarios)
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
            previousSize = this.Size;
            InicioSesion inicio = new InicioSesion();
            inicio.Size = previousSize;
            inicio.Show();
            this.Hide();
        }
        private static bool IsEmailFormat(string input)
        {
            // Utilizamos una expresión regular para verificar el formato de correo electrónico.
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(input, emailPattern);
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            MostrarLabel(txtCorreo, lblCorreo);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void lblUsusario_Click(object sender, EventArgs e)
        {
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            MostrarLabel(txtUsuario, lblUsusario);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void lblClave_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MostrarLabel(txtClave, lblClave);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MostrarLabel(txtReClave, lblReClave);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
        }
    }
}
