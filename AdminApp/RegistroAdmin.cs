using AlquilerVolquetes;
using Clases;
using Newtonsoft.Json;
using System;
using System.IO;

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




            listaAdmins = JsonFileManager.LoadFromJsonGeneric<List<Admin>>(rutaArchivoJson);
            if(listaAdmins is null )
            {
                listaAdmins = new List<Admin>();
            }
            clientes = JsonFileManager.LoadFromJsonGeneric<List<Cliente>>("usuarios.json");
            if( clientes is null)
            {
                clientes = new List<Cliente>();
            }
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string clave = txtClave.Text;
            string reClave = txtReClave.Text;
            string nombre = txtUsuario.Text;
            string mail = txtMail.Text;

            List<string> datosUsuario = ManejoDeValidaciones.CrearListaDeDatos(nombre,clave , mail, reClave);

            if (!ManejoDeValidaciones.ComprobarStringVacio(datosUsuario))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ManejoDeValidaciones.ValidarContraseña(datosUsuario))
            {
               MessageBox.Show("Las contraseñas no coinciden.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ManejoDeValidaciones.ComprobarExistenciaUsuario(datosUsuario, clientes))
            {
                MessageBox.Show("El nombre de usuario o el correo ya existen.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!ManejoDeValidaciones.ComprobarExistenciaAdmin(datosUsuario, listaAdmins))
            {
                MessageBox.Show("El nombre de usuario o el correo ya existen.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                
                ModalExito exitoLogin = new ModalExito("REGISTRO EXITOSO");
                DialogResult answer = exitoLogin.ShowDialog();
                if (answer == DialogResult.OK)
                {
                    Admin usuario = new Admin(nombre, mail, clave);
                    listaAdmins.Add(usuario);
                    JsonFileManager.SaveToJsonGeneric<List<Admin>>(rutaArchivoJson, listaAdmins);
                    InicioSesion inicio = new InicioSesion(listaAdmins);
                    inicio.Show();
                    this.Hide();
                }
            }
        }


        private void RegistroAdmin_Load(object sender, EventArgs e)
        {
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

        private void lblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InicioSesion inicio = new InicioSesion(listaAdmins);
            inicio.Show();
            this.Hide();
        }
    }
}