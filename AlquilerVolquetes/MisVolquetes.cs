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
    public partial class MisVolquetes : Form
    {
        public Usuario usuarioActual;
        public Cliente cliente;
        private bool esCliente;
        public MisVolquetes(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            esCliente = false;
        }
        public MisVolquetes(Usuario usuario, Cliente clientee)
        {
            InitializeComponent();
            usuarioActual = usuario;
            cliente = clientee;
            esCliente = true;
        }


    }
}
