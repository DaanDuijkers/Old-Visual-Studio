using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Week12Assignment;

namespace Week12AssignmentUnitTest
{
    [TestClass]
    public class WorkshopUnitTest
    {
        [TestMethod]
        public void TestAdd()
        {
            Person teacher = new Person("psn", "student", "daan", "duijkers", "CB03", "daanduijkers@gmail.com");
            Workshop workshop = new BuildingWorkshop("test", "bla, bla, bla...", "INBUILDING", 100, new DateTime(2022, 1, 1), teacher, "lavendelheide 10", "1");

            Assert.AreEqual("test", workshop.Name);
            Assert.AreEqual("bla, bla, bla...", workshop.Description);
            Assert.AreEqual("INBUILDING", workshop.Type);
            Assert.AreEqual(100, workshop.Seats.Count);
            Assert.AreEqual(Convert.ToDateTime("1-1-2022"), workshop.Date);
            Assert.AreEqual(teacher, workshop.Teacher);
            Assert.AreEqual("lavendelheide 10", ((BuildingWorkshop)workshop).Address);
            Assert.AreEqual("1", ((BuildingWorkshop)workshop).Room);
        }

        [TestMethod]
        public void TestOnline()
        {
            Person teacher = new Person("psn", "student", "daan", "duijkers", "CB03", "daanduijkers@gmail.com");
            Workshop workshop = new OnlineWorkshop("test", "bla, bla, bla...", "INBUILDING", 100, new DateTime(2022, 1, 1), teacher, "www.test.com");

            Assert.AreEqual("test", workshop.Name);
            Assert.AreEqual("bla, bla, bla...", workshop.Description);
            Assert.AreEqual("INBUILDING", workshop.Type);
            Assert.AreEqual(100, workshop.Seats.Count);
            Assert.AreEqual(Convert.ToDateTime("1-1-2022"), workshop.Date);
            Assert.AreEqual(teacher, workshop.Teacher);
            Assert.AreEqual("www.test.com", ((OnlineWorkshop)workshop).URL);
        }

        [TestMethod]
        public void TestStart()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            PersonManager personManager = new PersonManager();

            Person teacher = new Person("psn", "Teacher", "daan", "duijkers", "CB03", "daanduijkers@gmail.com");
            personManager.Add(teacher);

            Workshop workshop = new BuildingWorkshop("test", "bla, bla, bla...", "INBUILDING", 100, new DateTime(2022, 1, 1), teacher, "lavendelheide 10", "1");
            Response add = workshopManager.Add(workshop);
            bool start = workshopManager.Start(workshop);

            Assert.AreEqual(Response.Success, add);
            Assert.IsTrue(start);
        }

        [TestMethod]
        public void TestResponce()
        {
            WorkshopManager workshopManager = new WorkshopManager();

            Person person = new Person("psn", "Student", "daan", "duijkers", "CB03", "daanduijkers@gmail.com");
            Workshop workshop = new BuildingWorkshop("test", "bla, bla, bla...", "INBUILDING", 100, new DateTime(2022, 1, 1), person, "lavendelheide 10", "1");
            Response add = workshopManager.Add(workshop);
            Assert.AreEqual(Response.NoTeacher, add);

            person = new Person("psn", "Teacher", "daan", "duijkers", "CB03", "daanduijkers@gmail.com");
            workshop = new BuildingWorkshop("test", "bla, bla, bla...", "INBUILDING", 100, new DateTime(2020, 1, 1), person, "lavendelheide 10", "1");
            add = workshopManager.Add(workshop);
            Assert.AreEqual(Response.PastCurrentTime, add);

            workshop = new BuildingWorkshop("test", "bla, bla, bla...", "INBUILDING", 0, new DateTime(2022, 1, 1), person, "lavendelheide 10", "1");
            add = workshopManager.Add(workshop);
            Assert.AreEqual(Response.NoEmptySlots, add);
        }

        [TestMethod]
        public void TestRemove()
        {
            WorkshopManager workshopManager = new WorkshopManager();

            Person person = new Person("psn", "Teacher", "daan", "duijkers", "CB03", "daanduijkers@gmail.com");
            Workshop workshop = new BuildingWorkshop("test", "bla, bla, bla...", "INBUILDING", 100, new DateTime(2022, 1, 1), person, "lavendelheide 10", "1");
            workshopManager.Add(workshop);
            workshopManager.Remove(workshop);

            Assert.AreEqual(0, workshopManager.GetAll().Count);
        }

        [TestMethod]
        public void TestReservation()
        {
            WorkshopManager workshopManager = new WorkshopManager();

            Person person = new Person("psn", "Teacher", "daan", "duijkers", "CB03", "daanduijkers@gmail.com");
            Workshop workshop = new BuildingWorkshop("test", "bla, bla, bla...", "INBUILDING", 1, new DateTime(2022, 1, 1), person, "lavendelheide 10", "1");
            workshopManager.Add(workshop);
            Person student = new Person("psn", "Teacher", "test", "test", "CB02", "test@gmail.com");
            Response reservation = workshopManager.Reserve(workshop, student);
            Assert.AreEqual(Response.Success, reservation);

            Response failedReservation = workshopManager.Reserve(workshop, student);
            Assert.AreEqual(Response.AlreadyRegistered, failedReservation);

            Person newStudent = new Person("psn3", "Student", "test3", "test4", "CB05", "test3@gmail.com");
            Response full = workshopManager.Reserve(workshop, newStudent);
            Assert.AreEqual(Response.NoEmptySlots, full);
        }

        [TestMethod]
        public void TestCancelReservation ()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Person person = new Person("psn", "Teacher", "daan", "duijkers", "CB03", "daanduijkers@gmail.com");
            Workshop workshop = new BuildingWorkshop("test", "bla, bla, bla...", "INBUILDING", 100, new DateTime(2022, 1, 1), person, "lavendelheide 10", "1");
            workshopManager.Add(workshop);
            Person student = new Person("psn", "teacher", "test", "test", "CB02", "test@gmail.com");
            bool failedCancelation = workshopManager.CancelReservation(workshop, student);
            Assert.IsFalse(failedCancelation);

            workshopManager.Reserve(workshop, student);
            bool cancelation = workshopManager.CancelReservation(workshop, student);
            Assert.IsTrue(cancelation);
        }

        [TestMethod]
        public void TestEdit()
        {
            WorkshopManager workshopManager = new WorkshopManager();

            Person person = new Person("psn", "Teacher", "daan", "duijkers", "CB03", "daanduijkers@gmail.com");
            Workshop workshop = new BuildingWorkshop("test", "bla, bla, bla...", "INBUILDING", 100, new DateTime(2022, 1, 1), person, "lavendelheide 10", "1");
            Response add = workshopManager.Add(workshop);
            Workshop GetAdd = workshopManager.Get(workshop);

            Assert.AreEqual(Response.Success, add);
            Assert.AreEqual("test", GetAdd.Name);
            Assert.AreEqual("bla, bla, bla...", GetAdd.Description);
            Assert.AreEqual("INBUILDING", GetAdd.Type);
            Assert.AreEqual(100, GetAdd.Seats.Count);
            Assert.AreEqual(new DateTime(2022, 1, 1), GetAdd.Date);
            Assert.AreEqual(person, GetAdd.Teacher);
            Assert.AreEqual("lavendelheide 10", ((BuildingWorkshop)GetAdd).Address);
            Assert.AreEqual("1", ((BuildingWorkshop)GetAdd).Room);

            Workshop newWorkshop = new BuildingWorkshop("test2", "description", "INBUILDING", 50, new DateTime(2023, 1, 1), person, "testweg 10", "3");
            Response edit = workshopManager.Edit(workshop, newWorkshop);

            Workshop getEdit = workshopManager.Get(workshop);
            Assert.AreEqual(Response.Success, edit);
            Assert.AreEqual("test2", getEdit.Name);
            Assert.AreEqual("description", getEdit.Description);
            Assert.AreEqual("INBUILDING", getEdit.Type);
            Assert.AreEqual(50, getEdit.Seats.Count);
            Assert.AreEqual(new DateTime(2023, 1, 1), getEdit.Date);
            Assert.AreEqual(person, getEdit.Teacher);
            Assert.AreEqual("testweg 10", ((BuildingWorkshop)getEdit).Address);
            Assert.AreEqual("3", ((BuildingWorkshop)getEdit).Room);
        }
    }
}