using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using TravelBlog.Models;


namespace Travel_Blog.Controllers
{
    public class Solutions : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
