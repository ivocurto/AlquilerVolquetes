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
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;





namespace AlquilerVolquetes
{
    public partial class InicioSesion : Form
    {


        protected static List<Usuario> usuarios = new List<Usuario>();
        protected static Usuario a = new Usuario("a", "francoferrari226@gmail.com", "a");

        string rutaArchivoJson = "../../../archivos_datos/usuarios.json";
        public InicioSesion()
        {
            InitializeComponent();


            try
            {
                string json = File.ReadAllText(rutaArchivoJson);

                usuarios = JsonConvert.DeserializeObject<List<Usuario>>(json);

            }
            catch (Exception ex)
            {

                string json = JsonConvert.SerializeObject(usuarios);
                File.WriteAllText(rutaArchivoJson, json);
            }
        }

        public InicioSesion(Usuario usuario)
        {
            InitializeComponent();

            if (File.Exists(rutaArchivoJson))
            {
                string json = File.ReadAllText(rutaArchivoJson);
                usuarios = JsonConvert.DeserializeObject<List<Usuario>>(json);
            }

            usuarios.Add(usuario);

            string jsonUsuarios = JsonConvert.SerializeObject(usuarios);
            File.WriteAllText(rutaArchivoJson, jsonUsuarios);
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
                    PantallaInicio pantallaInicio = new PantallaInicio();
                    pantallaInicio.Show();
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
