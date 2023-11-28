using ClasesManejoBaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlquilerVolquetes
{
    [TestClass]
    public class StockTests
    {
        [TestMethod]
        [DataRow("ProductA", 50, 10)] // Adjust values based on your test case
        public void TestAdd(string producto, int cantidadDisponible, int cantidadAlquilados)
        {
            // Arrange
            Stock stock = new Stock(producto, cantidadDisponible, cantidadAlquilados);

            // Act
            bool result = stock.Add();

            // Assert
            Assert.IsTrue(result);
        }

   
    }
}
