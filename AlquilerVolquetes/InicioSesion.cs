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
        public Usuario usuarioAcutal;
        private bool checkbox;
        string filePath = "ultimaSesion.json";
        string rutaArchivoJson = "usuarios.json";
        private DataContainer data;

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

            try
            {
                string datajson = File.ReadAllText(filePath);
                data = JsonConvert.DeserializeObject<DataContainer>(datajson);

                if (data.CheckboxValue == true)
                {
                    txtUsuario.Text = data.UserObject.NombreUsuario;
                    txtClave.Text = data.UserObject.ClaveUsuario;
                    cbAutoLogin.Checked = true;
                }
            }
            catch (Exception ex)
            {
                string datajson = JsonConvert.SerializeObject(data);
                File.WriteAllText(filePath, datajson);
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
            usuario.IndexUsuario = usuarios.Count() - 1;

            string jsonUsuarios = JsonConvert.SerializeObject(usuarios);
            File.WriteAllText(rutaArchivoJson, jsonUsuarios);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUsuario registro = new RegistroUsuario(usuarios);
            registro.Show();
            this.Hide();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string clave = txtClave.Text;
            Usuario usuarioAcutal = null;

            foreach (var usuario in usuarios)
            {
                if (usuario.NombreUsuario == nombreUsuario && usuario.ClaveUsuario == clave)
                {
                    usuarioAcutal = usuario;
                    break; // Salir del bucle
                }
            }

            if (usuarioAcutal != null)
            {
                // Usuario válido
                ModalExitoLogin exitoLogin = new ModalExitoLogin("login");
                DialogResult answer = exitoLogin.ShowDialog();

                if (answer == DialogResult.OK)
                {
                    data = new DataContainer(checkbox, usuarioAcutal);
                    string jsonString = JsonConvert.SerializeObject(data);
                    File.WriteAllText(filePath, jsonString);

                    PantallaInicio pantallaInicio = new PantallaInicio(usuarioAcutal);
                    pantallaInicio.Show();
                    this.Hide();
                }
            }
            else
            {
                ModalErrorLogin ususarioIncorrecto = new ModalErrorLogin("ususarioIncorrecto");
                DialogResult result = ususarioIncorrecto.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtClave.Text = "";
                    txtUsuario.Text = "";
                }
            }
        }

        private void cbAutoLogin_CheckedChanged(object sender, EventArgs e)
        {
            checkbox = cbAutoLogin.Checked;

        }

        private void InicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
