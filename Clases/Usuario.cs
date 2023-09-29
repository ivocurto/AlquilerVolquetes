namespace Clases
{
    public class Ususario
    {
        private string NombreUsuario;
        private string MailUsusario;
        private string ClaveUsuario;

        public Ususario(string nombreUsuario, string mailUsusario, string claveUsuario)
        {
            NombreUsuario1 = nombreUsuario;
            MailUsusario1 = mailUsusario;
            ClaveUsuario1 = claveUsuario;
        }

        public string NombreUsuario1 { get => NombreUsuario; set => NombreUsuario = value; }
        public string MailUsusario1 { get => MailUsusario; set => MailUsusario = value; }
        public string ClaveUsuario1 { get => ClaveUsuario; set => ClaveUsuario = value; }
    }
}