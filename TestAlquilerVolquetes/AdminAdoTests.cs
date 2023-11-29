using ClasesManejoBaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlquilerVolquetes
{
    [TestClass]
    public class AdminADOTests
    {
        [TestMethod]
        [DataRow("admin@gmail.com", "Admin", "papafrita123")]
        public void TestAdd(string mail, string nombreAdmin, string clave)
        {
            // Arrange
            AdminADO admin = new AdminADO
            {
                Mail = mail,
                Nombre_admin = nombreAdmin,
                Clave = clave
            };

            // Act
            bool result = admin.Add();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow(1)] 
        public void TestDelete(int adminId)
        {
            // Arrange
            AdminADO admin = new AdminADO
            {
                Id = adminId
            };

            // Act
            bool result = admin.Delete();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestSelect()
        {
            // Arrange
            AdminADO admin = new AdminADO();

            // Act
            var result = admin.Select();

            // Assert
            Assert.IsNotNull(result);
            
        }

        [TestMethod]
        [DataRow(4)] 
        public void TestUpdate(int adminId)
        {
            // Arrange
            AdminADO admin = new AdminADO
            {
                Id = adminId,
            };

            // Act
            bool result = admin.Update();

            // Assert
            Assert.IsTrue(result);
        }
    }
}
