﻿using Clases;
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
        public Usuario usuarioAcutal;
        private bool flagPantallaPrincipal = false;
        public PantallaInicio(Usuario usuario)
        {
            usuarioAcutal = usuario;
            InitializeComponent();
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
                pantallaPrincipal = new PantallaPrincipal(usuarioAcutal);
                pantallaPrincipal.MdiParent = this;
                pantallaPrincipal.Show();
                flagPantallaPrincipal = true;
            } else
            {
                pantallaPrincipal.Show();
            }
            
        }

        private void PantallaInicio_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnAlquilarVolquetes_Click_1(object sender, EventArgs e)
        {

        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }
    }
}
