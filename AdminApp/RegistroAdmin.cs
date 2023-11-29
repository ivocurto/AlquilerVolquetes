using AlquilerVolquetes;
using Clases;
using Newtonsoft.Json;
using System;
using System.IO;
using ClasesManejoBaseDatos;
using Org.BouncyCastle.Asn1.Cms;

namespace AdminApp
{
    public partial class RegistroAdmin : Form
    {
        public List<Admin> listaAdmins;
        string rutaArchivoJson = @"..\..\..\..\AlquilerVolquetes\bin\Debug\net6.0-windows\admins.json";
        public List<Cliente> clientes;
        public RegistroAdmin()
        {
            InitializeComponent();
            MostrarLabel(txtUsuario, lblUsuario);
            MostrarLabel(txtMail, lblMail);
            MostrarLabel(txtClave, lblClave);
            MostrarLabel(txtReClave, lblReClave);
            txtClave.UseSystemPasswordChar = true;
            txtReClave.UseSystemPasswordChar = true;
            listaAdmins = JsonFileManager.LoadFromJsonGeneric<List<Admin>>(rutaArchivoJson);
            if (listaAdmins is null)
            {
                listaAdmins = new List<Admin>();
            }
            clientes = JsonFileManager.LoadFromJsonGeneric<List<Cliente>>("usuarios.json");
            if (clientes is null)
            {
                clientes = new List<Cliente>();
            }
        }


        private void RegistroAdmin_Load(object sender, EventArgs e)
        {
            MostrarLabel(txtUsuario, lblUsuario);
            MostrarLabel(txtMail, lblMail);
            MostrarLabel(txtClave, lblClave);
            MostrarLabel(txtReClave, lblReClave);
        }



        private void RegistroAdmin_FormClosed(object sender, FormClosedEventArgs e)
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


        private void MostrarLabel(TextBox textBox, Label label)
        {
            if (VerificarEstadoTxtBox(textBox.Text)) // Cambio aquí
            {
                label.Visible = true;
            }
            else
            {
                label.Visible = false;
            }
        }

        private bool VerificarEstadoTxtBox(string texto) // Cambio aquí
        {
            return string.IsNullOrWhiteSpace(texto);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            MostrarLabel(txtUsuario, lblUsuario);
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            MostrarLabel(txtClave, lblClave);
        }

        private void txtReClave_TextChanged(object sender, EventArgs e)
        {
            MostrarLabel(txtReClave, lblReClave);
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            MostrarLabel(txtMail, lblMail);
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            string clave = txtClave.Text;
            string reClave = txtReClave.Text;
            string nombre = txtUsuario.Text;
            string mail = txtMail.Text;

            List<string> datosUsuario = ManejoDeValidaciones.CrearListaDeDatos(nombre, clave, mail, reClave);

            if (!ManejoDeValidaciones.ComprobarStringVacio(datosUsuario))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ManejoDeValidaciones.ValidarContraseña(datosUsuario))
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DB.VerificarAtributoEnBD("usuarios", "mail", mail) || DB.VerificarAtributoEnBD("admins", "mail", mail))
            {
                MessageBox.Show("El correo ya está registrado.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DB.VerificarAtributoEnBD("usuarios", "nombre_usuario", nombre) || DB.VerificarAtributoEnBD("admins", "nombre_admin", nombre))
            {
                MessageBox.Show("El nombre de usuario ya existe.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                ModalExito exitoLogin = new ModalExito("REGISTRO EXITOSO");
                DialogResult answer = exitoLogin.ShowDialog();
                if (answer == DialogResult.OK)
                {
                    var admin = new AdminADO(mail, nombre, clave);
                    admin.Add();
                    InicioSesion inicio = new InicioSesion();
                    inicio.Show();
                    this.Hide();
                }
            }
        }

        private void lblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InicioSesion inicio = new InicioSesion();
            inicio.Show();
            this.Hide();
        }

        private void OcultarTextoClave(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = true;
            txtReClave.UseSystemPasswordChar = true;
            this.pbCerrado.Visible = true;
            this.button3.Click -= OcultarTextoClave;
            this.button3.Click += button3_Click;
        }

        private void MostrarTextoClave()
        {
            this.pbCerrado.Visible = false;
            txtReClave.UseSystemPasswordChar = false;
            txtClave.UseSystemPasswordChar = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarTextoClave();
            this.button3.Click -= button3_Click;
            this.button3.Click += OcultarTextoClave;
        }
    }
}