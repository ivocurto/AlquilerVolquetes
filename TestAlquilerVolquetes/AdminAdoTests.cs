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
        [DataRow("admin@example.com", "AdminName", "AdminPassword")]
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
        [DataRow(1)] // Assuming 1 is a valid ID for deletion
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
            // Add more assertions based on the expected behavior of your Select method
        }

        [TestMethod]
        [DataRow(1)] // Assuming 1 is a valid ID for updating
        public void TestUpdate(int adminId)
        {
            // Arrange
            AdminADO admin = new AdminADO
            {
                Id = adminId,
                // Set other properties accordingly for a valid update scenario
            };

            // Act
            bool result = admin.Update();

            // Assert
            Assert.IsTrue(result);
        }
    }
}
