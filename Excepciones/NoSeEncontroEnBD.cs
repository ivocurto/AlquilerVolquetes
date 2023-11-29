namespace Excepciones
{
    public class NoSeEncontroEnBD : Exception
    {
        Object objectoError;

        public NoSeEncontroEnBD(string mensaje, Object objetoError):base(mensaje)
        {
            this.objectoError = objetoError;
        }

        public Object Error
        {
            get { return objectoError; }
        }
    }
}
