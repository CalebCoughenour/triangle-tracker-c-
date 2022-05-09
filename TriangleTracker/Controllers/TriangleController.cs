using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TriangleTracker.Models;

namespace Triangle.Controllers
{
  public class TriangleController : Controller
  {
    [HttpGet("/triangle")]
    public ActionResult TriangleForm()
    {
      return View();
    }

    [HttpPost("/triangle/new")]
    public ActionResult Index(int side1, int side2, int side3)
    {
      NewTriangle userTriangle = new NewTriangle(side1, side2, side3);
      return View(userTriangle);
    }
  }
}