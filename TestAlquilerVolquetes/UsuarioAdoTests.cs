using ClasesManejoBaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlquilerVolquetes
{
    [TestClass]
    public class UsuarioADOTests
    {
        [TestMethod]
        [DataRow("Franco", "Ferrari", "soydios@gmail.com", 1134325533, "fran53", "soydiosiosi")]
        public void TestAdd(string nombre, string apellido, string mail, int telefono, string nombreUsuario, string clave)
        {
            // Arrange
            UsuarioADO usuario = new UsuarioADO
            {
                Nombre = nombre,
                Apellido = apellido,
                Mail = mail,
                Telefono = telefono,
                Nombre_usuario = nombreUsuario,
                Clave = clave
            };

            // Act
            bool result = usuario.Add();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("soydios@gmail.com")] 
        public void TestDelete(string mail)
        {
            // Arrange
            UsuarioADO usuario = new UsuarioADO
            {
                Mail = mail
            };

            // Act
            bool result = usuario.Delete();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestSelect()
        {
            // Arrange
            UsuarioADO usuario = new UsuarioADO();

            // Act
            var result = usuario.Select();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [DataRow(1, "Franco", "Ferrari", "soydios@gmail.com", 1134325533, "fran53", "soydiosiosi")]
        public void TestUpdate(int id, string nombre, string apellido, string mail, int telefono, string nombreUsuario, string clave)
        {
            // Arrange
            UsuarioADO usuario = new UsuarioADO
            {
                Id = id,
                Nombre = nombre,
                Apellido = apellido,
                Mail = mail,
                Telefono = telefono,
                Nombre_usuario = nombreUsuario,
                Clave = clave
            };

            // Act
            bool result = usuario.Update();

            // Assert
            Assert.IsTrue(result);
        }
    }
}
