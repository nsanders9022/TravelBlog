using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelBlog.Models;


namespace TravelBlog.Controllers
{
    public class PlacesController : Controller
    {

        private TravelDbContext db = new TravelDbContext();
        public IActionResult Index()
        {
            return View(db.Places.ToList());
        }
        public IActionResult Details(int id)
        {
            var thisPlace = db.Places.FirstOrDefault(places => places.PlaceId == id);
            return View(thisPlace);
        }
    }
}
