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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(People people)
        {
            db.Peoples.Add(people);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var thisPeople = db.Peoples.FirstOrDefault(peoples => peoples.PeopleId == id);
            return View(thisPeople);
        }

        [HttpPost]
        public IActionResult Edit(People people)
        {
            db.Entry(people).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var thisPeople = db.Peoples.FirstOrDefault(peoples => peoples.PeopleId == id);
            return View(thisPeople);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisPeople = db.Peoples.FirstOrDefault(peoples => peoples.PeopleId == id);
            db.Peoples.Remove(thisPeople);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
