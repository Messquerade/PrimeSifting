using Microsoft.AspNetCore.Mvc;
using PrimeSifting.Models;
using System;
using System.Collections.Generic;

namespace PrimeSifting.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index() {return View(); }

    [Route("/primes")]
    public ActionResult Primes(int number)
    {

      List<int> displayList = Models.Primes.FindPrimes(number);
      return View(displayList);
    }
  }
}

