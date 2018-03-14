using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Entities.Tests
{
    [TestClass]
    public class GroupTest
    {
        [TestMethod]
        public void Group()
        {
            // arrange
            string name = null;
            ushort expectedMarks = 2;
            Scout leader = new Scout(new DateTime(), "John", "Doe", 2);
            List<Scout> members = new List<Scout>();

            // act
            Group group = new Group(name, leader, members);
            string actualName = group.Name;
            ushort actualMarks = group.TotalMarks;
            Scout actualLeader = group.Leader;
            List<Scout> actualMembers = group.Members;

            // assert
            Assert.IsNotNull(group, "Group is null");
            Assert.AreEqual(name, actualName, "Name not equal");
            Assert.AreEqual(expectedMarks, actualMarks, "Marks not equal");
            Assert.AreEqual(leader, actualLeader, "Leader not equal");
            Assert.AreEqual(members, actualMembers, "Members not equal");
        }

        [TestMethod]
        public void AddScout()
        {
            // arrange
            string name = null;
            Scout leader = new Scout(new DateTime(), "John", "Doe", 0);
            Scout scoutToAdd = new Scout(new DateTime(), "John", "Doe", 0);
            List<Scout> members = new List<Scout>();
            int expectedMembersCount = 1;
            Group group = new Group(name, leader, members);

            // act
            group.AddScout(scoutToAdd);
            int actualMembersCount = group.Members.Count;

            // assert
            Assert.AreEqual(expectedMembersCount, actualMembersCount);
        }

        [TestMethod]
        public void RemoveScout()
        {
            // arrange
            string name = null;
            Scout leader = new Scout(new DateTime(), "John", "Doe", 0);
            Scout scoutToRemove = new Scout(new DateTime(), "John", "Doe", 0);
            List<Scout> members = new List<Scout>() { scoutToRemove };
            int expectedMembersCount = 0;
            Group group = new Group(name, leader, members);

            // act
            group.RemoveScout(scoutToRemove);
            int actualMembersCount = group.Members.Count;

            // assert
            Assert.AreEqual(expectedMembersCount, actualMembersCount);
        }

        [TestMethod]
        public void FindScoutsWith()
        {
            // arrange
            string name = null;
            Scout leader = new Scout(new DateTime(), "John", "Doe", 0);
            List<Scout> members = new List<Scout>();
            Scout scout1 = new Scout(new DateTime(), "John", "Doe", 1);
            Scout scout2 = new Scout(new DateTime(), "Jane", "Doe", 5);
            members.Add(scout1);
            members.Add(scout2);
            byte marksToFind = 5;
            Scout[] expected = new Scout[1] { scout2 };
            Group group = new Group(name, leader, members);

            // act
            Scout[] actual = group.FindScoutsWith(marksToFind);

            // assert
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void ToStringTest()
        {
            // arrange
            string name = null;
            Scout leader = new Scout(new DateTime(), "John", "Doe", 0);
            List<Scout> members = new List<Scout>();
            Group group = new Group(name, leader, members);
            string expected = $"Name: {name}, Leader: {leader.FirstName} {leader.LastName}, Members: {members.Count}";

            // act
            string actual = group.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
