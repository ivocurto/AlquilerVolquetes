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
using ClasesManejoBaseDatos;

namespace AlquilerVolquetes
{
    public partial class InicioSesion : Form
    {
        private bool checkbox;
        string filePath = "ultimaSesion.json";
        private DataContainer data;
        private Size previousSize;
        private Point previousLocation;

        public InicioSesion()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            data = JsonFileManager.LoadFromJsonGeneric<DataContainer>(filePath);

            if (data != null && data.CheckboxValue == true)
            {
                MessageBox.Show("at1a");
                if (data.UserObject != null)
                {
                    txtUsuario.Text = data.UserObject.NombreUsuario;
                    txtClave.Text = data.UserObject.ClaveUsuario;

                } else if (data.AdminObject != null)
                {
                    MessageBox.Show("ata");
                    txtUsuario.Text = data.AdminObject.NombreUsuario;
                    txtClave.Text = data.AdminObject.ClaveUsuario;
                }
                cbAutoLogin.Checked = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            previousSize = this.Size;
            previousLocation = this.Location;
            RegistroUsuario registro = new RegistroUsuario();
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
            var cliente = DB.TraerUsuarioLogueado(nombreUsuario, clave);
            var admin = DB.TraerAdminLogueado(nombreUsuario, clave);
            if (cliente != null)
            {
                ModalExito exitoLogin = new ModalExito("INICIO DE SESIÓN EXITOSO");

                DialogResult answer = exitoLogin.ShowDialog();
                if (answer == DialogResult.OK || answer == DialogResult.Cancel)
                {
                    data = new DataContainer(checkbox, cliente);
                    JsonFileManager.SaveToJsonGeneric<DataContainer>(filePath, data);
                    PantallaInicio pantallaInicio = new PantallaInicio(cliente, this);
                    previousSize = this.Size;
                    previousLocation = this.Location;
                    MantenerPantallaCompleta(this, pantallaInicio, previousSize, previousLocation);
                    pantallaInicio.Show();
                    this.Hide();
                    return;
                }
            } else if (admin != null)
            {
                ModalExito exitoLogin = new ModalExito("INICIO DE SESIÓN EXITOSO");

                DialogResult answer = exitoLogin.ShowDialog();
                if (answer == DialogResult.OK || answer == DialogResult.Cancel)
                {
                    data = new DataContainer(admin, checkbox);
                    JsonFileManager.SaveToJsonGeneric<DataContainer>(filePath, data);
                    PanelAdmin panelAdmin = new PanelAdmin(admin);
                    panelAdmin.Show();
                    this.Hide();
                    return;
                }
            } else
            {
                ModalError ususarioIncorrecto = new ModalError("Nombre de usuario o clave incorrectos", "ERROR AL INICIAR SESIÓN");
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
