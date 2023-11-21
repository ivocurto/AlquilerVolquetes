using ManejoDataBase;
namespace PruebasDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var usuario = new Usuario("Juan Pablo", "Demaio", "juampi.demaio@gmail.com", null, "juampidm", "juampidm");
            //usuario.Add();

            //var pedido = new Pedido(987986, 16, 1, 2, null, DateTime.Today, DateTime.Today.AddDays(7));
            //pedido.Add();
            //alumno.Nombre = "Juan Pablo";
            //DB.Drop("hash_code", 456789);
            //alumno.Update();

            //var alumnos = alumno.Select();

            DB.Select("usuarios");
            Console.WriteLine("*****************************************");
            //DB.ActualizarAtributoUsuario("juampi.demaio@gmail.com", "nombre_usuario", "pepinodemaio");
            DB.ActualizarAtributoUsuario("juampi.demaio@gmail.com", "clave", "pepinodemaio");
            //DB.Select<Usuario>("SELECT `id`, `nombre`, `apellido`, `mail`, `telefono`, `nombre_usuario`, `clave` FROM `usuarios` WHERE id= 2;");
            Console.WriteLine("*****************************************");
            //DB.Drop(usuario.Mail);
            DB.Select("pedidos_cliente");
        }
    }
}
