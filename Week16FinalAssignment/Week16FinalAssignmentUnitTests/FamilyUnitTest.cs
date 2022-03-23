using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Week16FinalAssignment;

namespace Week16FinalAssignmentUnitTests
{
    [TestClass]
    public class FamilyUnitTest
    {
        [TestMethod]
        public void TestAddingFamily()
        {
            //Arrange
            FamilyManager familyManager = new FamilyManager();

            //Act
            Family family = new Family("Duijkers");
            bool add = familyManager.Add(family);
            Family get = familyManager.Get(family);

            //Assert
            Assert.IsTrue(add);
        }

        [TestMethod]
        public void TestAddingPerson()
        {
            //Arrange
            FamilyManager familyManager = new FamilyManager();

            //Act
            Family family = new Family("Duijkers");
            familyManager.Add(family);
            bool parent = familyManager.AddPerson(familyManager.Get(family), new Parent("daan", "duijkers", new DateTime(1995, 11, 8, 0, 0, 0), "511963", "secret", "Lavendelheide 10", "Venray"));
            bool child = familyManager.AddPerson(familyManager.Get(family), new Parent("daan", "duijkers", new DateTime(1995, 11, 8, 0, 0, 0), "511963", "secret", "Lavendelheide 10", "Venray"));

            //Assert
            Assert.IsTrue(parent);
            Assert.IsTrue(child);
        }

        [TestMethod]
        public void TestFamilyApproval()
        {
            //Arrange
            FamilyManager familyManager = new FamilyManager();

            //Act
            Family family = new Family("Duijkers");
            bool add = familyManager.Add(family);
            Family get = familyManager.Get(family);
            bool approval = familyManager.Approval(get, "approved");

            //Assert
            Assert.AreEqual(get.Status, "approved");
        }

        [TestMethod]
        public void TestAddingMoreThan4MembersToFamily ()
        {
            //Arrange
            FamilyManager familyManager = new FamilyManager();

            //Act
            Family family = new Family("Duijkers");
            familyManager.Add(family);
            bool parent = familyManager.AddPerson(familyManager.Get(family), new Parent("daan", "duijkers", new DateTime(1995, 11, 8, 0, 0, 0), "511963", "secret", "Lavendelheide 10", "Venray"));
            bool child = familyManager.AddPerson(familyManager.Get(family), new Parent("daan", "duijkers", new DateTime(1995, 11, 8, 0, 0, 0), "511963", "secret", "Lavendelheide 10", "Venray"));
            bool parent2 = familyManager.AddPerson(familyManager.Get(family), new Parent("daan", "duijkers", new DateTime(1995, 11, 8, 0, 0, 0), "511963", "secret", "Lavendelheide 10", "Venray"));
            bool child2 = familyManager.AddPerson(familyManager.Get(family), new Parent("daan", "duijkers", new DateTime(1995, 11, 8, 0, 0, 0), "511963", "secret", "Lavendelheide 10", "Venray"));
            bool fail = familyManager.AddPerson(familyManager.Get(family), new Parent("daan", "duijkers", new DateTime(1995, 11, 8, 0, 0, 0), "511963", "secret", "Lavendelheide 10", "Venray"));

            //Assert
            Assert.IsFalse(fail);
        }
    }
}