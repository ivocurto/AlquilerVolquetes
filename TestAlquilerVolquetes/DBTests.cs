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

            // Act
            var result = DB.Select<object>(query);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(List<object>));
        }

        [TestMethod]
        [DataRow(1)]
        public void GetPedidosByIdUsuarioTest(int idUsuario)
        {
            // Act
            var result = DB.GetPedidosByIdUsuario(idUsuario);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(List<PedidoADO>));
        }

        [TestMethod]
        public void GetPedidosTest()
        {

            // Act
            var result = DB.GetPedidos();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(List<PedidoADO>));
        }


        [TestMethod]
        public void TestGetAdmins()
        {
            

            // Act
            var admins = DB.GetAdmins();

            // Assert
            Assert.IsNotNull(admins);
            Assert.IsTrue(admins.Count > 0);
        }

        [TestMethod]
        public void TestGetUsuarios()
        {

            // Act
            var usuarios = DB.GetUsuarios();

            // Assert
            Assert.IsNotNull(usuarios);
            Assert.IsTrue(usuarios.Count > 0);
        }

        [TestMethod]
        [DataRow("pedidos_cliente", "hash_code", 123)]
        [DataRow("admins", "id", 1)]
        [DataRow("usuarios", "id", 1)]
        public void TestDropWithAtributoAndValue(string tabla, string atributo, int atributoIngresado)
        {
            // Act
            DB.Drop(atributo, atributoIngresado);

            
            
        }

        [TestMethod]
        [DataRow("pedidos_cliente", "mail", "ivo@gmail.com")]
        [DataRow("admins", "nombre_admin", "pepinodemaio123")]
        [DataRow("usuarios", "nombre", "GERMAN")]
        public void TestDropWithAtributoAndStringValue(string tabla, string atributo, string atributoIngresado)
        {
            
            DB.Drop(tabla, atributo, atributoIngresado);

            
        }
    }

}
