using Microsoft.AspNetCore.Mvc;
using TriangleTracker.Models;

namespace TriangleTracker.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}