using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Week12Assignment;

namespace Week12AssignmentUnitTest
{
    [TestClass]
    public class PersonUnitTest
    {
        [TestMethod]
        public void TestAdd ()
        {
            PersonManager personManager = new PersonManager();

            Person test = new Person("psn", "student", "daan", "duijkers", "CB03", "daanduijkers@gmail.com");

            Assert.AreEqual("psn", test.PSN);
            Assert.AreEqual("student", test.Type);
            Assert.AreEqual("daan", test.FirstName);
            Assert.AreEqual("duijkers", test.LastName);
            Assert.AreEqual("CB03", test.ClassName);
            Assert.AreEqual("daanduijkers@gmail.com", test.Email);
        }

        [TestMethod]
        public void TestAddTrueFalse()
        {
            PersonManager personManager = new PersonManager();

            bool test1 = personManager.Add(new Person("psn", "student", "daan", "duijkers", "CD03", "daanduijkers@gmail.com"));
            bool test2 = personManager.Add(new Person("psn", "student", "daan", "duijkers", "CD03", "daanduijkers@gmail.com"));

            Assert.IsTrue(test1);
            Assert.IsFalse(test2);
        }

        [TestMethod]
        public void TestEdit()
        {
            PersonManager personManager = new PersonManager();

            Person person1 = new Person("psn", "student", "daan", "duijkers", "CD03", "daanduijkers@gmail.com");
            personManager.Add(person1);
            Person person2 = new Person("psn", "teacher", "test", "test", "CB02", "test@gmail.com");
            bool test2 = personManager.Edit(person1, person2);

            Assert.IsTrue(test2);
            Assert.AreEqual("psn", person2.PSN);
            Assert.AreEqual("teacher", person2.Type);
            Assert.AreEqual("test", person2.FirstName);
            Assert.AreEqual("test", person2.LastName);
            Assert.AreEqual("CB02", person2.ClassName);
            Assert.AreEqual("test@gmail.com", person2.Email);
        }

        [TestMethod]
        public void TestRemove ()
        {
            PersonManager personManager = new PersonManager();

            Person person = new Person("psn", "student", "daan", "duijkers", "CD03", "daanduijkers@gmail.com");

            personManager.Add(person);
            Assert.AreEqual(1, personManager.GetAll().Count);

            personManager.Remove(person);
            Assert.AreEqual(0, personManager.GetAll().Count);
        }
    }
}