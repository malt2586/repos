using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void AccountTest()
        {
            // arrange
            string id = "112233";
            string name = "TestAccount";
            int expectedBalance = 0;
            
            // act
            Account acc = new Account(id, name);
            string actualID = acc.Id;
            string actualName = acc.Name;
            int actualBalance = acc.Balance;
            
            // assert
            Assert.AreEqual(id, actualID, "ID not equal.");
            Assert.AreEqual(name, actualName, "Name not equal.");
            Assert.AreEqual(expectedBalance, actualBalance, "Balance not equal.");
        }

        [TestMethod()]
        public void AccountTest1()
        {
            // arrange
            string id = "112233";
            string name = "TestAccount";
            int balance = 100;
            
            // act
            Account acc = new Account(id, name, balance);
            string actualID = acc.Id;
            string actualName = acc.Name;
            int actualBalance = acc.Balance;

            // assert
            Assert.AreEqual(id, actualID, "ID not equal.");
            Assert.AreEqual(name, actualName, "Name not equal.");
            Assert.AreEqual(balance, actualBalance, "Balance not equal.");
        }

        [TestMethod()]
        public void CreditTest()
        {
            // arrange
            int currentBalance = 100;
            int deposit = 30;
            int expected = 130;
            Account acc = new Account("112233", "TestAccount", currentBalance);
            
            // act
            acc.Credit(deposit);
            double actual = acc.Balance;
            
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DebitTest()
        {
            // arrange
            int currentBalance = 100;
            int withdrawal = 30;
            int expected = 70;
            Account acc = new Account("112233", "TestAccount", currentBalance);

            // act
            acc.Debit(withdrawal);
            int actual = acc.Balance;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DebitTest1()
        {
            // arrange
            int currentBalance = 100;
            int withdrawal = 120;
            int expected = currentBalance;
            Account acc = new Account("112233", "TestAccount", currentBalance);

            // act
            acc.Debit(withdrawal);
            int actual = acc.Balance;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TransferToTest()
        {
            // arrange
            int currentBalance = 100;
            int transfer = 30;
            int expected1 = 70;
            int expected2 = 130;
            Account acc1 = new Account("112233", "TestAccount", currentBalance);
            Account acc2 = new Account("112233", "TestAccount", currentBalance);

            // act
            acc1.TransferTo(acc2, transfer);
            double actual1 = acc1.Balance;
            double actual2 = acc2.Balance;

            // assert
            Assert.AreEqual(expected1, actual1, "acc1 failed");
            Assert.AreEqual(expected2, actual2, "acc2 failed");
        }

        [TestMethod()]
        public void ToStringTest()
        {
            // arrange
            string id = "112233";
            string name = "TestAccount";
            int balance = 100;
            string expected = $"Account[Name: {name}, Balance: {balance}]";
            Account acc = new Account(id, name, balance);

            // act
            string actual = acc.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}