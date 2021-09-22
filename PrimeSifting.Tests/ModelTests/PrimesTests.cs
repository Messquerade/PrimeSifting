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
      Console.WriteLine(result);
      Assert.AreEqual("2, 3, 5, 7", result);
      // Assert.AreEqual(3, Primes.FindPrimes(10)[0]);
      // Assert.AreEqual(5, Primes.FindPrimes(10)[0]);
      // Assert.AreEqual(7, Primes.FindPrimes(10)[0]);
      // Assert.IsTrue(expectedResult.SequenceEqual(Primes.FindPrimes(10)));
      // Enumerable.SequenceEqual(list1, list2);
    }
  }
}