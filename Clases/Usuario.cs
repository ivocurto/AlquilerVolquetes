namespace Clases
{
    public abstract class Usuario
    {
        protected string nombreUsuario;
        protected string mailUsuario;
        protected string claveUsuario;
        protected int indexUsuario;

        public Usuario(string nombreUsuario, string mailUsuario, string claveUsuario)
        {
            NombreUsuario = nombreUsuario;
            MailUsuario = mailUsuario;
            ClaveUsuario = claveUsuario;
            
        }

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string MailUsuario { get => mailUsuario; set => mailUsuario = value; }
        public string ClaveUsuario { get => claveUsuario; set => claveUsuario = value; }
        public int IndexUsuario { get => indexUsuario; set => indexUsuario = value; }
    }

}