using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Admin : Usuario
    {
        private string rol;

        public Admin(string nombreUsuario, string mailUsusario, string claveUsuario, string rol)
            : base(nombreUsuario, mailUsusario, claveUsuario)
        {
            Rol = rol;
        }

        public string Rol { get => rol; set => rol = value; }
    }
}
