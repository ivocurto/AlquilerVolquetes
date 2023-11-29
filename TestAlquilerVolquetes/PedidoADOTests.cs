using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesManejoBaseDatos;

namespace TestAlquilerVolquetes
{
    [TestClass]
    public class PedidoADOTests
    {
        [TestMethod]
        [DataRow(123, 1, 2, 1, 0, "2023-11-10", "2023-11-17", "123 Main St")]
        [DataRow(456, 2, 3, 2, 1, "2023-11-15", "2023-11-22", "456 Oak St")]
        public void TestAdd(int hashCode, int idUsuario, int volquetesChicos, int volquetesMedianos, int volquetesGrandes, string fechaIngreso, string fechaRegreso, string direccion)
        {
            // Arrange
            PedidoADO pedido = new PedidoADO
            {
                Hash_code = hashCode,
                Id_usuario = idUsuario,
                Volquetes_chicos = volquetesChicos,
                Volquetes_medianos = volquetesMedianos,
                Volquetes_grandes = volquetesGrandes,
                Fecha_ingreso = DateTime.Parse(fechaIngreso),
                Fecha_regreso = DateTime.Parse(fechaRegreso),
                Direccion = direccion
            };

            // Act
            bool result = pedido.Add();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow(123)]
        [DataRow(456)]
        public void TestDelete(int hashCode)
        {
            // Arrange
            PedidoADO pedido = new PedidoADO
            {
                Hash_code = hashCode
            };

            // Act
            bool result = pedido.Delete();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("2023-11-09", true)] // prueba con una fecha en el pasado
        [DataRow("2023-11-20", false)] // prueba con una fecha en el futuro
        public void TestFechaDeRegresoAlcanzada(string fechaRegreso, bool expectedResult)
        {
            // Arrange
            PedidoADO pedido = new PedidoADO
            {
                Fecha_regreso = DateTime.Parse(fechaRegreso)
            };

            // Act
            bool result = pedido.FechaDeRegresoAlcanzada();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}

