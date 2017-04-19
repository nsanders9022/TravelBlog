using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelBlog.Models;


namespace TravelBlog.Controllers
{
    public class PeoplesController : Controller
    {
        private TravelDbContext db = new TravelDbContext();
        public IActionResult Index()
        {
            return View(db.Peoples.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisPeople = db.Peoples.FirstOrDefault(peoples => peoples.PeopleId == id);
            return View(thisPeople);
        }
    }
}
