namespace Clases
{
    public abstract class Usuario
    {
        private int id;
        protected string nombreUsuario;
        protected string mailUsuario;
        protected string claveUsuario;

        public Usuario(int id, string nombreUsuario, string mailUsuario, string claveUsuario)
        {
            Id = id;
            NombreUsuario = nombreUsuario;
            MailUsuario = mailUsuario;
            ClaveUsuario = claveUsuario;
            
        }

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string MailUsuario { get => mailUsuario; set => mailUsuario = value; }
        public string ClaveUsuario { get => claveUsuario; set => claveUsuario = value; }
        public int Id { get => id; set => id = value; }

        public abstract void ConsutarEstado();
    }

    
}