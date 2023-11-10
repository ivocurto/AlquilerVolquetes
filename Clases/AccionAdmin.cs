using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class AccionAdmin
    {
       
        private DateTime fechaAccion;
        private string usuarioAfectado;

        public AccionAdmin(DateTime fechaAccion, string usuarioAfectado)
        {
            this.FechaAccion = fechaAccion;
            this.UsuarioAfectado = usuarioAfectado;
        }

        public DateTime FechaAccion { get => fechaAccion; set => fechaAccion = value; }
        public string UsuarioAfectado { get => usuarioAfectado; set => usuarioAfectado = value; }
    }
}
