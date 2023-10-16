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
        InicioSesion inicioSesion;
        public Usuario usuarioAcutal;
        private Cliente clienteActual;
        private List<Cliente> clientes;
        private bool flagPantallaPrincipal = false;
        private bool flagMisVolquetes = false;
        private List<Form> formsAbiertos = new List<Form>();
        private Form inicioS;
        public PantallaInicio(Usuario usuario, Form inicioSesion)
        {
            InitializeComponent();
            inicioS = inicioSesion;
            usuarioAcutal = usuario;
            
            clientes = JsonFileManager.LoadFromJsonGeneric<List<Cliente>>("clientes.json");
            if (clientes is not null)
            {
                foreach (Cliente cliente in clientes)
                {
                    if (cliente.NombreUsuario == usuarioAcutal.NombreUsuario)
                    {
                        clienteActual = cliente;
                        break;
                    }
                }
            }
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PantallaInicio pantallaInicio = new PantallaInicio(usuarioAcutal);
            //pantallaInicio.MdiParent = this;
            //pantallaInicio.Show();
        }

        private void aLQUILARVOLQUETESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flagPantallaPrincipal == false)
            {
                if (flagMisVolquetes == true)
                {
                    misVolquetes.Hide(); ;
                }

                flagPantallaPrincipal = true;
                pantallaPrincipal = new PantallaPrincipal(usuarioAcutal);
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
                if (clienteActual != null)
                {
                    misVolquetes = new MisVolquetes(usuarioAcutal, clienteActual);
                    formsAbiertos.Add(misVolquetes);
                }
                else
                {
                    misVolquetes = new MisVolquetes(usuarioAcutal);
                    formsAbiertos.Add(misVolquetes);
                }
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
