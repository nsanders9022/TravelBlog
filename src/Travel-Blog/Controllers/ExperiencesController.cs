using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelBlog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace TravelBlog.Controllers
{
    public class ExperiencesController : Controller
    {
        private TravelDbContext db = new TravelDbContext();
        public IActionResult Index()
        {
            return View(db.Experiences.ToList());
        }

        public IActionResult Details (int id)
        {
            var thisExperience = db.Experiences.Include(experiences => experiences.Place).FirstOrDefault(experiences => experiences.ExperienceId == id);
            return View(thisExperience);
        }
    }
}
