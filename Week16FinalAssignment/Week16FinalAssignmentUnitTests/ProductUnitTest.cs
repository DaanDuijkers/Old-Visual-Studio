using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Week16FinalAssignment;

namespace Week16FinalAssignmentUnitTests
{
    [TestClass]
    public class ProductUnitTest
    {
        [TestMethod]
        public void TestAddingProduct()
        {
            //Arrange
            ProductManager productManager = new ProductManager();

            //Act
            bool add = productManager.Add(new Product("Cookies", 1, "Snack"));

            //Assert
            Assert.IsTrue(add);
        }

        [TestMethod]
        public void TestAddingTheSameProduct()
        {
            //Arrange
            ProductManager productManager = new ProductManager();

            //Act
            bool add = productManager.Add(new Product("Cookies", 1, "Snack"));
            bool same = productManager.Add(new Product("Cookies", 1, "Snack"));

            //Assert
            Assert.IsTrue(add);
            Assert.IsFalse(same);
        }
    }
}