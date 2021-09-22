using System;
using System.Collections.Generic;
using PrimeSifting.Models;


namespace PrimeSifting
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter an integer greater than 2 to find the primes! [q to quit]");
      string stringResponse = Console.ReadLine();
      int response;
      if (stringResponse.ToLower() == "q")
      {
        Console.WriteLine("Goodbye");
      }
      else if (int.TryParse(stringResponse, out response))
      {
        if (response <= 2)
        {
          Console.WriteLine("Input must be greater than 2.");
          Main();
        }
        else
        {
          Console.WriteLine(string.Join(", ", Primes.FindPrimes(response)));
          Main();
        }
      }
      else
      {
        Console.WriteLine("Please enter a number greater than 2.");
        Main();
      }
    }
  }
}
