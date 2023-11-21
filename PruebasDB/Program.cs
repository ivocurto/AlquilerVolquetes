using ManejoDataBase;
namespace PruebasDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var usuario = new Usuario("Juan Pablo", "Demaio", "juampi.demaio@gmail.com", null, "juampidm", "juampidm");
            usuario.Add();

            //alumno.Nombre = "Juan Pablo";

            //alumno.Update();

            //var alumnos = alumno.Select();

            DB.Select("usuarios");
            Console.WriteLine("*****************************************");
            //DB.Select<Usuario>("SELECT `id`, `nombre`, `apellido`, `mail`, `telefono`, `nombre_usuario`, `clave` FROM `usuarios` WHERE id= 2;");
            Console.WriteLine("*****************************************");
            //DB.Drop(usuario.Mail);
            DB.Select("usuarios");
        }
    }
}
