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
                        //aca va el logueado correctamente
                        ModalExitoLogin exitoLogin = new ModalExitoLogin("login");
                        DialogResult answer = exitoLogin.ShowDialog();
                        if (answer == DialogResult.OK)
                        {
                            data = new DataContainer(checkbox, usuario);
                            string jsonString = JsonConvert.SerializeObject(data);
                        

                            File.WriteAllText(filePath, jsonString);
                            usuarioAcutal = usuario;
                            PantallaInicio pantallaInicio = new PantallaInicio(usuarioAcutal);
                            pantallaInicio.Show();
                            this.Hide();
                            return;
                        }

                    }
                }
                ModalErrorLogin ususarioIncorrecto = new ModalErrorLogin("ususarioIncorrecto");
                DialogResult result = ususarioIncorrecto.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtClave.Text = "";
                    txtUsuario.Text = "";
                }
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

            private void cbAutoLogin_CheckedChanged(object sender, EventArgs e)
            {
                checkbox = cbAutoLogin.Checked;

            }
        }
    }
