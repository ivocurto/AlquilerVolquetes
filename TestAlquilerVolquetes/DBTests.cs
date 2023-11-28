using ClasesManejoBaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlquilerVolquetes
{
    [TestClass]
    public class DBTests
    {

        [TestMethod]
        [DataRow("usuarios")]
        [DataRow("pedidos_cliente")]
        [DataRow("stock")]
        public void SelectTest(string tabla)
        {
            // Arrange - No se necesita en este caso

            // Act
            Action action = () => DB.Select(tabla);

            // Assert
            Assert.ThrowsException<Exception>(action);
        }

        [TestMethod]
        [DataRow("SELECT * FROM usuarios")]
        [DataRow("SELECT * FROM pedidos_cliente")]
        [DataRow("SELECT * FROM stock")]
        public void SelectGenericTest(string query)
        {
            // Arrange - No se necesita en este caso

            // Act
            var result = DB.Select<object>(query);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(List<object>));
            // Asegúrate de ajustar el tipo de objeto según lo que esperas que devuelva el método
        }

        [TestMethod]
        [DataRow(1)]
        public void GetPedidosByIdUsuarioTest(int idUsuario)
        {
            // Arrange - No se necesita en este caso

            // Act
            var result = DB.GetPedidosByIdUsuario(idUsuario);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(List<PedidoADO>));
        }

        [TestMethod]
        public void GetPedidosTest()
        {
            // Arrange - No se necesita en este caso

            // Act
            var result = DB.GetPedidos();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(List<PedidoADO>));
        }


        [TestMethod]
        public void TestGetAdmins()
        {
            // Arrange
            // Puedes insertar algunos datos de prueba en la base de datos antes de ejecutar esta prueba

            // Act
            var admins = DB.GetAdmins();

            // Assert
            Assert.IsNotNull(admins);
            Assert.IsTrue(admins.Count > 0);
            // Puedes agregar más aserciones según la estructura esperada de tus datos
        }

        [TestMethod]
        public void TestGetUsuarios()
        {
            // Arrange
            // Puedes insertar algunos datos de prueba en la base de datos antes de ejecutar esta prueba

            // Act
            var usuarios = DB.GetUsuarios();

            // Assert
            Assert.IsNotNull(usuarios);
            Assert.IsTrue(usuarios.Count > 0);
            // Puedes agregar más aserciones según la estructura esperada de tus datos
        }

        [TestMethod]
        [DataRow("pedidos_cliente", "hash_code", 123)]
        [DataRow("admins", "id", 1)]
        [DataRow("usuarios", "id", 1)]
        public void TestDropWithAtributoAndValue(string tabla, string atributo, int atributoIngresado)
        {
            // Act
            DB.Drop(atributo, atributoIngresado);

            // Assert
            // Agrega aserciones según tus necesidades
            // Verifica que los datos se hayan eliminado correctamente
        }

        [TestMethod]
        [DataRow("pedidos_cliente", "mail", "test@mail.com")]
        [DataRow("admins", "nombre_admin", "admin123")]
        [DataRow("usuarios", "nombre", "John")]
        public void TestDropWithAtributoAndStringValue(string tabla, string atributo, string atributoIngresado)
        {
            
            DB.Drop(tabla, atributo, atributoIngresado);

            
        }
    }

}
