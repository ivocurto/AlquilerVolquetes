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
    public partial class ModalExitoLogin : AlquilerVolquetes.CompraExitosa
    {
        string tipoDeFormulario;
        public ModalExitoLogin(string formulario)
        {
            InitializeComponent();
            tipoDeFormulario = formulario;
        }

        private void ModalExitoLogin_Load(object sender, EventArgs e)
        {
            switch (tipoDeFormulario)
            {
                case "login":
                    lblCompraExitosa.Text = "INICIO DE SESIÓN EXITOSO";
                    break;
                case "register":
                    lblCompraExitosa.Text = "REGISTRO EXITOSO";
                    break;
            }
        }
    }
}
