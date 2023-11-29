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
        [DataRow("Volquete_chico", 9, 1)] 
        public void TestAdd(string producto, int cantidadDisponible, int cantidadAlquilados)
        {
           
            Stock stock = new Stock(producto, cantidadDisponible, cantidadAlquilados);

            
            bool result = stock.Add();

            
            Assert.IsTrue(result);
        }

   
    }
}
