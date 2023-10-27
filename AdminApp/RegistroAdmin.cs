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
        public RegistroAdmin()
        {
            InitializeComponent();




            listaAdmins = new List<Admin>();
            try
            {




                string json = File.ReadAllText(rutaArchivoJson);

                listaAdmins = JsonConvert.DeserializeObject<List<Admin>>(json);

            }
            catch (Exception ex)
            {

                string json = JsonConvert.SerializeObject(listaAdmins);
                File.WriteAllText(rutaArchivoJson, json);
            }
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
                MessageBox.Show("Por favor, completa todos los campos.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ValidarContraseña(datosUsuario))
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ComprobarExistenciaUsuario(datosUsuario))
            {
                MessageBox.Show("El nombre de usuario o el correo ya existen.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Admin usuario = new Admin(nombre, mail, clave);

                if (listaAdmins == null)
                {
                    listaAdmins = new List<Admin>();
                }

                listaAdmins.Add(usuario);
                usuario.IndexUsuario = listaAdmins.Count() - 1;

                string jsonUsuarios = JsonConvert.SerializeObject(listaAdmins);
                File.WriteAllText(rutaArchivoJson, jsonUsuarios);
                ModalExito exitoLogin = new ModalExito("REGISTRO EXITOSO");
                DialogResult answer = exitoLogin.ShowDialog();
                if (answer == DialogResult.OK)
                {
                    InicioSesion inicio = new InicioSesion(usuario);
                    inicio.Show();
                    this.Hide();
                }
            }
        }


        private void RegistroAdmin_Load(object sender, EventArgs e)
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
            if (listaAdmins != null)
            {
                foreach (Usuario usuario in listaAdmins)
                {
                    if (usuario.NombreUsuario == lista[0] || usuario.MailUsuario == lista[2])
                    {
                        return false;
                    }
                }

            }

            return true;
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
            InicioSesion inicio = new InicioSesion();
            inicio.Show();
            this.Hide();
        }
    }
}