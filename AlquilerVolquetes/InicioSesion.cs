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
        string filePath2 = "ultimaSesion2.json";
        private DataContainer data;
        private AdminContainer data2;
        private Size previousSize;
        private Point previousLocation;
        private List<PedidoADO> pedidos;
        public InicioSesion()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            data = JsonFileManager.LoadFromJsonGeneric<DataContainer>(filePath);
            data2 = JsonFileManager.LoadFromJsonGeneric<AdminContainer>(filePath2);
            pedidos = DB.GetPedidos();
            foreach (PedidoADO pedido in pedidos)
            {
                if (pedido.FechaDeRegresoAlcanzada())
                {
                    DB.Drop("hash_code", pedido.Hash_code);
                    int cantidadVC = pedido.Volquetes_chicos;
                    DB.CambiarCantidadDisponible(1, cantidadVC, true);
                    int cantidadVM = pedido.Volquetes_medianos;
                    DB.CambiarCantidadDisponible(2, cantidadVM, true);
                    int cantidadVG = pedido.Volquetes_grandes;
                    DB.CambiarCantidadDisponible(3, cantidadVG, true);
                }
            }
            if (data != null && data.CheckboxValue == true)
            {
                txtUsuario.Text = data.UserObject.NombreUsuario;
                txtClave.Text = data.UserObject.ClaveUsuario;
                cbAutoLogin.Checked = true;
            }
            else if (data2 != null && data2.CheckboxValue == true)
            {
                txtUsuario.Text = data2.AdminObject.NombreUsuario;
                txtClave.Text = data2.AdminObject.ClaveUsuario;
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
                    JsonFileManager.SaveToJsonGeneric<AdminContainer>(filePath2, null);
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
                    data2 = new AdminContainer(admin, checkbox);
                    JsonFileManager.SaveToJsonGeneric<AdminContainer>(filePath2, data2);
                    JsonFileManager.SaveToJsonGeneric<DataContainer>(filePath, null);
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
