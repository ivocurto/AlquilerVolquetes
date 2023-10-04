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
    public partial class PantallaPrincipal : Form
    {

        public PantallaPrincipal()
        {
            InitializeComponent();

        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void PantallaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void PantallaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
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
        //Chico
        private void btnVolqueteChico_Click(object sender, EventArgs e)
        {

            this.lblCantidadVolqueteChico.Text = Incrementar_Label(this.lblCantidadVolqueteChico.Text);
            this.lblPrecioChico.Text = ($"${int.Parse(this.lblCantidadVolqueteChico.Text) * 800}");

        }
        private void btnRestarVolqueteChico_Click(object sender, EventArgs e)
        {
            this.lblCantidadVolqueteChico.Text = Decrementar_Label(this.lblCantidadVolqueteChico.Text);
            this.lblPrecioChico.Text = ($"${int.Parse(this.lblCantidadVolqueteChico.Text) * 800}");

        }

        //Mediano
        private void btnAgregarVolqueteMediano_Click(object sender, EventArgs e)
        {
            this.lblCantidadVolqueteMediano.Text = Incrementar_Label(this.lblCantidadVolqueteMediano.Text);
            this.lblPrecioMediano.Text = ($"${int.Parse(this.lblCantidadVolqueteMediano.Text) * 1200}");

        }
        private void btnRestarVolqueteMediano_Click(object sender, EventArgs e)
        {
            this.lblCantidadVolqueteMediano.Text = Decrementar_Label(this.lblCantidadVolqueteMediano.Text);
            this.lblPrecioMediano.Text = ($"${int.Parse(this.lblCantidadVolqueteMediano.Text) * 1200}");
        }
        //Grande
        private void btnAgregarVolqueteGrande_Click(object sender, EventArgs e)
        {
            this.lblCantidadVolqueteGrande.Text = Incrementar_Label(this.lblCantidadVolqueteGrande.Text);
            this.lblPrecioGrande.Text = ($"${int.Parse(this.lblCantidadVolqueteGrande.Text) * 1600}");

        }
        private void btnRestarVolqueteGrande_Click(object sender, EventArgs e)
        {

            this.lblCantidadVolqueteGrande.Text = Decrementar_Label(this.lblCantidadVolqueteGrande.Text);
            this.lblPrecioGrande.Text = ($"${int.Parse(this.lblCantidadVolqueteGrande.Text) * 1600}");

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private string Incrementar_Label(string label)
        {
            int valor = int.Parse(label);
            if (valor < 8) { valor++; }

            return ($"{valor}");
        }

        private string Decrementar_Label(string label)
        {
            int valor = int.Parse(label);
            if (valor > 0) { valor--; }

            return ($"{valor}");
        }


    }
}
