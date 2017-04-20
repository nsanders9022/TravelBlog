using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using TravelBlog.Models;


namespace TravelBlog.Controllers
{
    public class ExperiencesPeoplesController : Controller
    {
        private TravelDbContext db = new TravelDbContext();

        public IActionResult Index()
        {
            return View(db.ExperiencesPeoples.ToList());
        }

        public IActionResult Create()
        {
            ViewBag.PeopleId = new SelectList(db.Peoples, "PeopleId", "Name");
            ViewBag.ExperienceId = new SelectList(db.Experiences, "ExperienceId", "Description");
            return View();
        }

        [HttpPost]
        public IActionResult Create(ExperiencePeople experiencePeople)
        {
            db.ExperiencesPeoples.Add(experiencePeople);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
