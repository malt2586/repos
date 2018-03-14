using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Entities.Tests
{
    [TestClass]
    public class CorpsTest
    {
        [TestMethod]
        public void Corps()
        {
            // arrange
            Scout captain = new Scout(new DateTime(), "John", "Doe", 2);
            List<Group> groups = new List<Group>();
            int expectedMarks = 2;

            // act
            Corps corps = new Corps(captain, groups);
            Scout actualCaptain = corps.Captain;
            List<Group> actualGroups = corps.Groups;
            int actualMarks = corps.TotalMarks;

            // assert
            Assert.IsNotNull(corps, "Corps is null");
            Assert.AreEqual(captain, actualCaptain, "Captain not equal");
            Assert.AreEqual(groups, actualGroups, "Groups not equal");
            Assert.AreEqual(expectedMarks, actualMarks, "Marks not equal");
        }

        [TestMethod]
        public void AddGroup()
        {
            // arrange
            Scout captain = new Scout(new DateTime(), "John", "Doe", 2);
            List<Group> groups = new List<Group>();
            Corps corps = new Corps(captain, groups);
            Scout leader = new Scout(new DateTime(), "Jane", "Doe", 1);
            List<Scout> members = new List<Scout>();
            Group groupToAdd = new Group(null, leader, members);
            int expectedGroupCount = 1;

            // act
            corps.AddGroup(groupToAdd);
            int actualGroupCount = corps.Groups.Count;

            // assert
            Assert.AreEqual(expectedGroupCount, actualGroupCount);
        }

        [TestMethod]
        public void RemoveGroup()
        {
            Scout leader = new Scout(new DateTime(), "Jane", "Doe", 1);
            List<Scout> members = new List<Scout>();
            Group groupToRemove = new Group(null, leader, members);
            Scout captain = new Scout(new DateTime(), "John", "Doe", 2);
            List<Group> groups = new List<Group>() { groupToRemove };
            int expectedGroupCount = 0;
            Corps corps = new Corps(captain, groups);

            // act
            corps.RemoveGroup(groupToRemove);
            int actualGroupCount = corps.Groups.Count;

            // assert
            Assert.AreEqual(expectedGroupCount, actualGroupCount);
        }

        [TestMethod]
        public void FindScoutsWith()
        {
            // arrange
            Scout scout1 = new Scout(new DateTime(), "John", "Doe", 1);
            Scout scout2 = new Scout(new DateTime(), "Jane", "Doe", 5);
            List<Scout> members = new List<Scout>() { scout1, scout2 };
            Scout leader = new Scout(new DateTime(), "Jane", "Doe", 1);
            Group group1 = new Group(null, leader, members);
            Group group2 = new Group(null, leader, members);

            Scout captain = new Scout(new DateTime(), "John", "Doe", 2);
            List<Group> groups = new List<Group>() { group1, group2 };
            Corps corps = new Corps(captain, groups);

            byte marksToFind = 1;
            Scout[] expected = new Scout[2] { scout1, scout1 };

            // act
            Scout[] actual = corps.FindScoutsWith(marksToFind);

            // assert
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void ToStringTest()
        {
            // arrange
            Scout scout1 = new Scout(new DateTime(), "John", "Doe", 1);
            Scout scout2 = new Scout(new DateTime(), "Jane", "Doe", 5);
            List<Scout> members = new List<Scout>() { scout1, scout2 };
            Scout leader = new Scout(new DateTime(), "Jane", "Doe", 1);
            Group group1 = new Group(null, leader, members);
            Group group2 = new Group(null, leader, members);

            Scout captain = new Scout(new DateTime(), "John", "Doe", 2);
            List<Group> groups = new List<Group>() { group1, group2 };
            Corps corps = new Corps(captain, groups);

            string expected = $"Captain: {corps.Captain.FirstName} {corps.Captain.LastName}, Groups: {groups.Count}, Marks: {corps.TotalMarks}";

            // act
            string actual = corps.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
