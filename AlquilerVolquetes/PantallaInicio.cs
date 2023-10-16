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
        public Usuario usuarioAcutal;
        private Cliente clienteActual;
        private List<Cliente> clientes;
        public PantallaInicio(Usuario usuario)
        {
            InitializeComponent();
            usuarioAcutal = usuario;
            clientes = JsonFileManager.LoadFromJsonGeneric<List<Cliente>>("clientes.json");
            if (clientes is not null ) 
            {
            foreach(Cliente cliente in clientes)
            {
                if(cliente.NombreUsuario == usuarioAcutal.NombreUsuario)
                {
                    clienteActual = cliente;
                    break;
                }
            }

            }
        }

        private void btnAlquilarVolquetes_Click(object sender, EventArgs e)
        {
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal(usuarioAcutal);
            pantallaPrincipal.Show();
            this.Hide();
        }

        private void PantallaInicio_Load(object sender, EventArgs e)
        {

        }

        private void PantallaInicio_FormClosed(object sender, FormClosedEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MisVolquetes misVolquetes;
            if(clienteActual != null)
            {
                 misVolquetes = new MisVolquetes(usuarioAcutal, clienteActual);
            }
            else
            {
                 misVolquetes = new MisVolquetes(usuarioAcutal);
            }
            
            misVolquetes.Show();
        }
    }
}
