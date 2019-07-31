using Microsoft.AspNetCore.Mvc;
using PlacesYouveBeen.Models;
using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
    public class PlacesController : Controller
    {

        [HttpGet("/places")]
        public ActionResult Index()
        {
            List<Place> allPlaces = Place.GetAll();
            return View(allPlaces);
        }

        [HttpGet("/places/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/places")]
        public ActionResult Create(string cityName)
        {
            Place myPlace = new Place(cityName);
            return RedirectToAction("Index");
        }

        [HttpPost("/places/delete")]
        public ActionResult DeleteAll()
        {
            Place.ClearAll();
            return View();
        }
    }
}