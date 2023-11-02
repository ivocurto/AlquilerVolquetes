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
using AdminApp;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using Microsoft.Win32;

namespace AlquilerVolquetes
{
    public partial class InicioSesion : Form
    {

        protected static List<Cliente> usuarios = new List<Cliente>();
        protected static List<Admin> admins = new List<Admin>();
        public Cliente usuarioAcutal;
        private bool checkbox;
        string filePath = "ultimaSesion.json";
        string rutaArchivoJson = "usuarios.json";
        string rutaArchivoJsonAdmin = "admins.json";
        private DataContainer data;
        private Size previousSize;
        private Point previousLocation;

        public InicioSesion()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            usuarios = JsonFileManager.LoadFromJsonGeneric<List<Cliente>>(rutaArchivoJson);
            data = JsonFileManager.LoadFromJsonGeneric<DataContainer>(filePath);

            if (data != null && data.CheckboxValue == true)
            {
                txtUsuario.Text = data.UserObject.NombreUsuario;
                txtClave.Text = data.UserObject.ClaveUsuario;
                cbAutoLogin.Checked = true;
            }
        }

        public InicioSesion(Cliente usuario)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            usuarios = JsonFileManager.LoadFromJsonGeneric<List<Cliente>>(rutaArchivoJson);
            if (usuarios is null)
            {
                usuarios = new List<Cliente>();
            }
            usuarios.Add(usuario);
            usuario.IndexUsuario = usuarios.Count() - 1;

            JsonFileManager.SaveToJson(rutaArchivoJson, usuarios);
        }

        public InicioSesion(Admin admin)
        {
            InitializeComponent();

            admins = JsonFileManager.LoadFromJsonGeneric<List<Admin>>(rutaArchivoJsonAdmin);
            admins.Add(admin);
            admin.IndexUsuario = admins.Count() - 1;

            JsonFileManager.SaveToJson(rutaArchivoJson, usuarios);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            previousSize = this.Size;
            previousLocation = this.Location;
            if (usuarios is null)
            {
                usuarios = new List<Cliente>();
            }
            RegistroUsuario registro = new RegistroUsuario(usuarios);
            MantenerPantallaCompleta(this, registro, previousSize, previousLocation);
            registro.Show();
            this.Hide();
        }

        public static void MantenerPantallaCompleta(Form form, Form nextForm, Size previousSize, Point previousLocation)
        {
            if (form.WindowState == FormWindowState.Maximized)
            {
                nextForm.WindowState = FormWindowState.Maximized;

            }
            else
            {
                nextForm.Location = previousLocation;
                nextForm.Size = previousSize;
            }
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
                    ModalExito exitoLogin = new ModalExito("INICIO DE SESIÓN EXITOSO");

                    DialogResult answer = exitoLogin.ShowDialog();
                    if (answer == DialogResult.OK || answer == DialogResult.Cancel)
                    {
                        data = new DataContainer(checkbox, usuario);
                        JsonFileManager.SaveToJsonGeneric<DataContainer>(filePath, data);
                        usuarioAcutal = usuario;
                        usuarioAcutal = usuario;
                        PantallaInicio pantallaInicio = new PantallaInicio(usuarioAcutal, this);
                        previousSize = this.Size;
                        previousLocation = this.Location;
                        MantenerPantallaCompleta(this, pantallaInicio, previousSize, previousLocation);
                        pantallaInicio.Show();
                        this.Hide();
                        return;
                    }

                }
                foreach (var admin in admins)
                {
                    if (admin.NombreUsuario == nombreUsuario && admin.ClaveUsuario == clave)
                    {
                        ModalExito exitoLogin = new ModalExito("INICIO DE SESIÓN EXITOSO");

                        DialogResult answer = exitoLogin.ShowDialog();
                        if (answer == DialogResult.OK)
                        {
                            data = new DataContainer(checkbox, usuario);
                            JsonFileManager.SaveToJsonGeneric<DataContainer>(filePath, data);
                            usuarioAcutal = usuario;


                            PanelAdmin panelAdmin = new PanelAdmin();
                            panelAdmin.Show();
                            this.Hide();
                            return;



                        }

                    }
                }
            }
            ModalError ususarioIncorrecto = new ModalError("Nombre de usuario o clave incorrectos", "ERROR AL INICIAR SESIÓN");
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

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            lblUsusario.Visible = false;
            lblClave.Visible = false;
            MostrarLabel(txtUsuario, lblUsusario);
            MostrarLabel(txtClave, lblClave);
        }

        private void txtClave_TextChanged_1(object sender, EventArgs e)
        {
            MostrarLabel(txtClave, lblClave);
        }

        private void txtUsuario_TextChanged_1(object sender, EventArgs e)
        {
            MostrarLabel(txtUsuario, lblUsusario);
        }

        private void MostrarLabel(System.Windows.Forms.TextBox textBox, System.Windows.Forms.Label label)
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

        private bool VerificarEstadoTxtBox(System.Windows.Forms.TextBox textBox)
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

        private void InicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FormClosing -= InicioSesion_FormClosing;

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
