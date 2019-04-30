using Microsoft.AspNetCore.Mvc;
using Delivery.Models;
using System.Collections.Generic;

namespace Delivery.Controllers
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
