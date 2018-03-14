using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Entities.Tests
{
    [TestClass]
    public class ScoutTest
    {
        [TestMethod]
        public void Scout()
        {
            // arrange
            DateTime birthday = new DateTime();
            string firstName = null;
            string lastName = null;
            byte marks = 0;

            // act
            Scout scout = new Scout(birthday, firstName, lastName, marks);
            DateTime actualBirthday = scout.Birthday;
            string actualFirstName = scout.FirstName;
            string actualLastName = scout.LastName;
            byte actualMarks = scout.Marks;

            // assert
            Assert.IsNotNull(scout, "Scout is null");
            Assert.AreEqual(birthday, actualBirthday, "Birthday not equal");
            Assert.AreEqual(firstName, actualFirstName, "Firstname not equal");
            Assert.AreEqual(lastName, actualLastName, "Lastname not equal");
            Assert.AreEqual(marks, actualMarks, "Marks not equal");
        }

        [TestMethod]
        public void ToStringTest()
        {
            // arrange
            DateTime birthday = new DateTime();
            Scout scout = new Scout(birthday, "Jon", "Doe", 0);
            string expected = $"Name: {scout.FirstName} {scout.LastName}, Birthday: {scout.Birthday}, Marks: {scout.Marks}";

            // act
            string actual = scout.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
