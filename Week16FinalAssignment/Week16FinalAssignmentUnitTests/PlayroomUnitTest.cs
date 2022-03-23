using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Week16FinalAssignment;

namespace Week16FinalAssignmentUnitTests
{
    [TestClass]
    public class PlayroomUnitTest
    {
        [TestMethod]
        public void TestAddingProductsToPlayroom()
        {
            //Arrange
            PlayroomManager playroomManager = new PlayroomManager();

            //Act
            Playroom playroom = new Playroom(10, new ShoppingCenter("Avido", "Lavendelheide 10"));
            playroomManager.Add(playroom);
            bool addProduct = playroomManager.AddProduct(playroom, new Drink("cola", 2, "drink", 2), 10);
            Playroom get = playroomManager.Get(playroom);

            //Assert
            Assert.AreEqual("cola", get.Products[0].Products[0].ProductInfo.Name);
            Assert.AreEqual("drink", get.Products[0].Products[0].ProductInfo.Type);
            Assert.AreEqual(10, get.Products[0].Products.Count);
            Assert.AreEqual(2, get.Products[0].Products[0].ProductInfo.Price);
        }

        [TestMethod]
        public void TestAddingMoreProductsToExistingProductsInPlayrooms()
        {
            //Arrange
            PlayroomManager playroomManager = new PlayroomManager();

            //Act
            Playroom playroom = new Playroom(10, new ShoppingCenter("Avido", "Lavendelheide 10"));
            playroomManager.Add(playroom);
            bool addProduct = playroomManager.AddProduct(playroom, new Drink("cola", 2, "drink", 2), 10);
            playroomManager.AddProduct(playroom, new Drink("cola", 2, "drink", 2), 10);
            Playroom get = playroomManager.Get(playroom);

            //Assert
            Assert.AreEqual(20, get.Products[0].Products.Count);
        }
    }
}