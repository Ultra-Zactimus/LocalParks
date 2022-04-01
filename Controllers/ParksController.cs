using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LocalPark.Models;

namespace LocalPark.Controllers
{
  public class ParksController : Controller
  {
    public IActionResult Index()
    {
      var allParks = Park.GetParks();

      return View(allParks);
    }

    [HttpPost]
    public IActionResult Index(Park park)
    {
      Park.Post(park);
      
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var park = Park.GetDetails(id);

      return View("Index");
    }

    public IActionResult Edit(int id)
    {
      var park = Park.GetDetails(id);

      return View(park);
    }

    [HttpPost]
    public IActionResult Details(int id, Park park)
    {
      park.ParkId = id;

      Park.Put(park);

      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Park.Delete(id);

      return RedirectToAction("Index");
    }
  }
}