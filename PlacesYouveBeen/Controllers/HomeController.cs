using Microsoft.AspNetCore.Mvc;
using PlacesYouveBeen.Models;

namespace PlacesYouveBeen.Models
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