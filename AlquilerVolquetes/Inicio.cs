using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace AlquilerVolquetes
{
    public partial class Inicio : Form
    {

        public Inicio(Cliente cliente)
        {
            InitializeComponent();
            lblBienvenido.Text= $"BIENVENIDO/A {cliente.Nombre.ToUpper()}";
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
