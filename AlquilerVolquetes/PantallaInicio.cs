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

namespace AlquilerVolquetes
{
    public partial class PantallaInicio : Form
    {
        public Cliente usuarioAcutal;
        private Pedido pedidoActual;
        private List<Pedido> clientes;
        private bool flagHome = false;
        private List<Form> formsAbiertos = new List<Form>();
        private Form inicioS;
        public PantallaInicio(Cliente usuario, Form inicioSesion)
        {
            InitializeComponent();
            abrirFormularioHijo(new Inicio());
            inicioS = inicioSesion;
            usuarioAcutal = usuario;

            clientes = JsonFileManager.LoadFromJsonGeneric<List<Pedido>>("clientes.json");
            if (clientes is not null)
            {
                foreach (Pedido cliente in clientes)
                {
                    if (cliente.Cliente == usuarioAcutal.NombreUsuario)
                    {
                        pedidoActual = cliente;
                        break;
                    }
                }
            }

            if (flagHome == false)
            {
                //home = new Home();
                //home.MdiParent = this;
                //flagHome = true;
                //home.Show();
            }
        }

        private void PantallaInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FormClosing -= PantallaInicio_FormClosing;

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


        private void CerrarFormsAbiertos()
        {
            foreach (Form formAbierto in formsAbiertos)
            {
                if (formAbierto != this)
                {
                    formAbierto.Close();
                }
            }
        }

        private void PantallaInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Inicio());
        }

        private void btnMisVolquetes_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new MisVolquetes(usuarioAcutal));
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new PantallaPrincipal(usuarioAcutal, this));
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            ModalExito exitoLogin = new ModalExito("¿Deseas cerrar sesión?");
            exitoLogin.pictureBox1.Visible = false;
            DialogResult answer = exitoLogin.ShowDialog();
            if (answer == DialogResult.OK)
            {
                inicioS.Show();
                this.Hide();
            }
        }


        private void abrirFormularioHijo(Form formularioHijo)
        {
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioHijo);
            panelContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }


    }
}
