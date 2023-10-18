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
        private List<Cliente> clientes = new List<Cliente>();
        public Usuario usuarioAcutal;
        public List<Cliente> clienteActual;
        private bool checkbox;
        string filePath = "ultimaSesion.json";
        string rutaArchivoJson = "usuarios.json";
        private DataContainer data;

        public InicioSesion()
        {
            InitializeComponent();
            usuarios = JsonFileManager.LoadFromJson<Usuario>(rutaArchivoJson);
            clientes = JsonFileManager.LoadFromJsonGeneric<List<Cliente>>("pedidos.json");

            data = JsonFileManager.LoadFromJsonGeneric<DataContainer>(filePath);

            if (data.CheckboxValue == true)
            {
                txtUsuario.Text = data.UserObject.NombreUsuario;
                txtClave.Text = data.UserObject.ClaveUsuario;
                cbAutoLogin.Checked = true;
            }
        }

        public InicioSesion(Usuario usuario)
         {
            InitializeComponent();

            usuarios = JsonFileManager.LoadFromJson<Usuario>(rutaArchivoJson);
            usuarios.Add(usuario);
            usuario.IndexUsuario = usuarios.Count() - 1;

            JsonFileManager.SaveToJson(rutaArchivoJson, usuarios);
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
                    //string jsonString = JsonConvert.SerializeObject(data);
                        JsonFileManager.SaveToJsonGeneric<DataContainer>(filePath, data);

                            
                            usuarioAcutal = usuario;
                            foreach(Cliente cliente in clientes)
                        {
                            if(cliente.MailUsusario == usuario.MailUsusario)
                            {
                                clienteActual.Add(cliente);
                            }


                        }
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

        private void cbAutoLogin_CheckedChanged(object sender, EventArgs e)
        {
            checkbox = cbAutoLogin.Checked;

        }

        private void InicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
