using Alquiler

namespace Pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var alumno = new Usuario("Juan Pablo", "Demaio", 2);
            alumno.Add();

            //alumno.Nombre = "Juan Pablo";

            //alumno.Update();

            //var alumnos = alumno.Select();
            DB.Select();
        }
    }
}
