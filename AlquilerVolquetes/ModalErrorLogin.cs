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
    public partial class ModalErrorLogin : AlquilerVolquetes.CompraExitosa
    {
        string tipoDeError;
        public ModalErrorLogin(string error)
        {
            InitializeComponent();
            tipoDeError = error;
        }

        private void ModalErrorLogin_Load(object sender, EventArgs e)
        {
            switch (tipoDeError)
            {
                case "ususarioIncorrecto":
                    lblTipoDeError.Text = "Nombre de usuario o clave incorrectos";
                    break;
            }
        }
    }
}
