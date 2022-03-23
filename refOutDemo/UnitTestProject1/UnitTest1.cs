using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using refOutDemo;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Person person;
            Person p1 = new Person("A", 1, "B");
            p1.TryParse("Michael,18,Eindhoven", out person);

            Assert.AreEqual("Michael", person.Name);
            Assert.AreEqual(18, person.Age);
            Assert.AreEqual("Eindhoven", person.HomeTown);
        }
    }
}
