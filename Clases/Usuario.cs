namespace Clases
{
    public class Usuario
    {
        private string nombreUsuario;
        private string mailUsusario;
        private string claveUsuario;
        private int indexUsuario;
        private ERolUsuario rol;

        
        public Usuario(string nombreUsuario, string mailUsusario, string claveUsuario, ERolUsuario rol)
        {
            NombreUsuario = nombreUsuario;
            MailUsusario = mailUsusario;
            ClaveUsuario = claveUsuario;
            Rol = rol;
        }

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string MailUsusario { get => mailUsusario; set => mailUsusario = value; }
        public string ClaveUsuario { get => claveUsuario; set => claveUsuario = value; }
        public int IndexUsuario { get => indexUsuario; set => indexUsuario = value; }
        public ERolUsuario Rol { get => rol; set => rol = value; }
    }
}