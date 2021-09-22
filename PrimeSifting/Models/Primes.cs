using System;
using System.Collections.Generic;

namespace PrimeSifting.Models
{
  
  public class Primes
  {
    public static List<int> FindPrimes(int input)
    {
      List<int> primes = new List<int> {};
      for (int i = 2; i <= input; i++)
      {
        primes.Add(i);
      }
      return primes;
    }

  }


}