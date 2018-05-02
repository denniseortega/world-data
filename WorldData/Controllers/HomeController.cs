using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WorldData.Models;

namespace WorldData.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
        return View();
    }
    [HttpGet("/Cities")]
    public ActionResult CitiesList()
    {
      List<City> listOfAllCitites = City.GetAll();
      return View ("Cities", listOfAllCitites);
    }
  }
}
