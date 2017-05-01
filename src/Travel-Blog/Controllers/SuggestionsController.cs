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
    public class SuggestionsController : Controller
    {
        private TravelDbContext db = new TravelDbContext();
        public IActionResult Index()
        {
            return View(db.Suggestions.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisSuggestion = db.Suggestions.FirstOrDefault(suggestions => suggestions.SuggestionId == id);
            return View(thisSuggestion);
        }
        public IActionResult Create()
        {         
            return View();
        }
        [HttpPost]
        public IActionResult Create(Suggestion suggestion)
        {
            db.Suggestions.Add(suggestion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //public IActionResult Edit(int id)
        //{
        //    var thisExperience = db.Experiences.FirstOrDefault(experiences => experiences.ExperienceId == id);
        //    ViewBag.PlaceId = new SelectList(db.Places, "PlaceId", "City");
        //    return View(thisExperience);
        //}
        //[HttpPost]
        //public IActionResult Edit(Experience experience)
        //{
        //    db.Entry(experience).State = EntityState.Modified;
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        //public ActionResult Delete(int id)
        //{
        //    var thisExperience = db.Experiences.FirstOrDefault(experiences => experiences.ExperienceId == id);
        //    return View(thisExperience);
        //}
        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeleteConfirmed(int id)
        //{
        //    var thisExperience = db.Experiences.FirstOrDefault(experiences => experiences.ExperienceId == id);
        //    db.Experiences.Remove(thisExperience);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

    }
}
