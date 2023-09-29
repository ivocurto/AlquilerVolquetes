namespace Clases
{
    public class Usuario
    {
        private string nombreUsuario;
        private string mailUsusario;
        private string claveUsuario;

        
        public Usuario(string nombreUsuario, string mailUsusario, string claveUsuario)
        {
            NombreUsuario = nombreUsuario;
            MailUsusario = mailUsusario;
            ClaveUsuario = claveUsuario;
        }

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string MailUsusario { get => mailUsusario; set => mailUsusario = value; }
        public string ClaveUsuario { get => claveUsuario; set => claveUsuario = value; }
    }
}