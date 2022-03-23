using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using threeDemo;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ThreeStaff treeStaff = new ThreeStaff();

            Employee e1 = new Employee("A", Job.CEO);
            Employee e2 = new Employee("B", Job.PM);
            Employee e3 = new Employee("C", Job.PM);
            Employee e4 = new Employee("D", Job.DJ);

            treeStaff.Add(e1, null);
            treeStaff.Add(e2, e1);
            treeStaff.Add(e3, e1);
            treeStaff.Add(e4, e2);

            NodeEmployee node = treeStaff.GetNodeEmployee("D", Job.DJ);
            Assert.AreEqual(e4.Name, node.Employee.Name);
            Assert.AreEqual(e4.JobPosition, node.Employee.JobPosition);
        }
    }
}
