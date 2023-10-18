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
        PantallaPrincipal pantallaPrincipal;
        MisVolquetes misVolquetes;
        Home home;
        InicioSesion inicioSesion;
        public Usuario usuarioAcutal;
        private Pedido pedidoActual;
        private List<Pedido> clientes;
        private bool flagPantallaPrincipal = false;
        private bool flagMisVolquetes = false;
        private bool flagHome = false;
        private List<Form> formsAbiertos = new List<Form>();
        private Form inicioS;
        Button dummyButton = new Button();
        public PantallaInicio(Usuario usuario, Form inicioSesion)
        {
            InitializeComponent();
            inicioS = inicioSesion;
            usuarioAcutal = usuario;

            clientes = JsonFileManager.LoadFromJsonGeneric<List<Pedido>>("clientes.json");
            if (clientes is not null)
            {
                foreach (Pedido cliente in clientes)
                {
                    if (cliente.NombreUsuario == usuarioAcutal.NombreUsuario)
                    {
                        pedidoActual = cliente;
                        break;
                    }
                }
            }

            if (flagHome == false)
            {
                home = new Home();
                home.MdiParent = this;
                flagHome = true;
                home.Show();
            }
        }

        public PantallaInicio(Usuario usuario, Form inicioSesion, bool abrirMisVolquetes)
        {
            InitializeComponent();
            inicioS = inicioSesion;
            usuarioAcutal = usuario;

            clientes = JsonFileManager.LoadFromJsonGeneric<List<Pedido>>("clientes.json");
            if (clientes is not null)
            {
                foreach (Pedido cliente in clientes)
                {
                    if (cliente.NombreUsuario == usuarioAcutal.NombreUsuario)
                    {
                        pedidoActual = cliente;
                        break;
                    }
                }
            }
            if (abrirMisVolquetes == true)
            {
                mISVOLQUETESToolStripMenuItem_Click(dummyButton, EventArgs.Empty);
            }
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EsconderForms();

            home.Show();
        }

        public void aLQUILARVOLQUETESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flagPantallaPrincipal == false)
            {
                if (flagMisVolquetes == true)
                {
                    misVolquetes.Hide(); ;
                }

                flagPantallaPrincipal = true;
                pantallaPrincipal = new PantallaPrincipal(usuarioAcutal, this);
                pantallaPrincipal.MdiParent = this;
                formsAbiertos.Add(pantallaPrincipal);
                pantallaPrincipal.Show();
            }
            else
            {

                EsconderForms();
                pantallaPrincipal.Show();
            }

        }

        private void mISVOLQUETESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flagMisVolquetes == false)
            {
                flagMisVolquetes = true;
                misVolquetes = new MisVolquetes(usuarioAcutal);
                formsAbiertos.Add(misVolquetes);
                misVolquetes.MdiParent = this;
                misVolquetes.Show();
            }
            else
            {
                EsconderForms();
                misVolquetes.Show();
            }
        }
        private void cERRARSESIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inicioS.Show();
            this.Hide();
        }

        private void PantallaInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Desasociar el manejador de eventos FormClosing para evitar llamadas recursivas
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


        private void EsconderForms()
        {
            foreach (Form formAbierto in formsAbiertos)
            {
                formAbierto.Hide();
            }
        }

    }
}
