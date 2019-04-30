using Microsoft.AspNetCore.Mvc;
using Delivery.Models;
using System.Collections.Generic;

namespace Delivery.Controllers
{
  public class ParcelsController : Controller
  {

    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(string description, int height, int width, int depth, int weight)
    {
      Parcel theParcel = new Parcel(description, height, width, depth, weight);
      return RedirectToAction("Index");
    }

  }
}
