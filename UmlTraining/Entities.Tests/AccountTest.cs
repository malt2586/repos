// <copyright file="AccountTest.cs">Copyright ©  2018</copyright>

using System;
using Entities;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Entities.Tests
{
    [TestClass]
    [PexClass(typeof(Account))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AccountTest
    {

        [PexMethod]
        public Account Constructor(string id, string name)
        {
            Account target = new Account(id, name);
            return target;
            // TODO: add assertions to method AccountTest.Constructor(String, String)
        }

        [PexMethod]
        public Account Constructor01(
            string id,
            string name,
            int balance
        )
        {
            Account target = new Account(id, name, balance);
            return target;
            // TODO: add assertions to method AccountTest.Constructor01(String, String, Int32)
        }

        [PexMethod]
        public int Credit([PexAssumeUnderTest]Account target, int amount)
        {
            int result = target.Credit(amount);
            return result;
            // TODO: add assertions to method AccountTest.Credit(Account, Int32)
        }

        [PexMethod]
        public int Debit([PexAssumeUnderTest]Account target, int amount)
        {
            int result = target.Debit(amount);
            return result;
            // TODO: add assertions to method AccountTest.Debit(Account, Int32)
        }

        [PexMethod]
        public int TransferTo(
            [PexAssumeUnderTest]Account target,
            Account another,
            int amount
        )
        {
            int result = target.TransferTo(another, amount);
            return result;
            // TODO: add assertions to method AccountTest.TransferTo(Account, Account, Int32)
        }

        [PexMethod]
        public string ToString01([PexAssumeUnderTest]Account target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method AccountTest.ToString01(Account)
        }

        [PexMethod]
        public string IdGet([PexAssumeUnderTest]Account target)
        {
            string result = target.Id;
            return result;
            // TODO: add assertions to method AccountTest.IdGet(Account)
        }

        [PexMethod]
        public string NameGet([PexAssumeUnderTest]Account target)
        {
            string result = target.Name;
            return result;
            // TODO: add assertions to method AccountTest.NameGet(Account)
        }

        [PexMethod]
        public int BalanceGet([PexAssumeUnderTest]Account target)
        {
            int result = target.Balance;
            return result;
            // TODO: add assertions to method AccountTest.BalanceGet(Account)
        }
    }
}
