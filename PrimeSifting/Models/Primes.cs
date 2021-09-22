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
      
      for (int j = 2; j <= input; j++)
      {
        for(int k = j + 1; k <= input; k++)
        {
          if (k % j == 0 )
          {
            primes.Remove(k);
          }
        }
      }
      return primes;
    }
  }
}