using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;
// <copyright file="AccountTest.Credit.g.cs">Copyright ©  2018</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace Entities.Tests
{
    public partial class AccountTest
    {

[TestMethod]
[PexGeneratedBy(typeof(AccountTest))]
public void Credit554()
{
    int i;
    Account s0 = new Account((string)null, (string)null, 0);
    i = this.Credit(s0, 0);
    Assert.AreEqual<int>(0, i);
    Assert.IsNotNull((object)s0);
    Assert.AreEqual<string>((string)null, s0.Id);
    Assert.AreEqual<string>((string)null, s0.Name);
    Assert.AreEqual<int>(0, s0.Balance);
}
    }
}
