using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PrimeSifting.Models;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class RangeTests
  {
    [TestMethod]
    public void FindPrimes_ReturnsListOfNumbers_List()
    {
      Assert.AreEqual(typeof(List<int>), Primes.FindPrimes(10).GetType());
    }

    [TestMethod]
    public void FindPrimes_ReturnsPrimes_ListOfPrimeNumbers()
    {
      string result = string.Join( ", ", Primes.FindPrimes(10));
      Assert.AreEqual("2, 3, 5, 7", result);
    }
  }
}