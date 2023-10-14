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
    public partial class ModalErrorAlRegistrarse : AlquilerVolquetes.CompraExitosa
    {
        string tipoDeError;
        public ModalErrorAlRegistrarse(string error)
        {
            InitializeComponent();
            tipoDeError = error;
        }

        private void ModalErrorAlRegistrarse_Load(object sender, EventArgs e)
        {
            switch (tipoDeError)
            {
                case "claves":
                    lblTipoDeError.Text = "Las contraseñas no coinciden";
                    break;
                case "stringVacio":
                    lblTipoDeError.Text = "Por favor, completa todos los campos";
                    break;
                case "existenciaUsuario":
                    lblTipoDeError.Text = "El nombre de usuario o el correo ya existen";
                    break;
            }
        }
    }
}
