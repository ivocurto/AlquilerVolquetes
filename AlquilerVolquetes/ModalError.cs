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
    public partial class ModalError : AlquilerVolquetes.ModalExito
    {
        string tipoDeError;

        public ModalError(string error, string titulo) : base(titulo)
        {
            InitializeComponent();
            tipoDeError = error;
        }

        private void ModalErrorLogin_Load(object sender, EventArgs e)
        {
            lblTipoDeError.Text = tipoDeError;
        }
    }
}
