using DropDownHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownHelp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test() 
        {
            var countries = new List<Country>
            {
                new Country { Id = 1, Name = "India" },
                new Country { Id = 2, Name = "China" },
                new Country { Id = 3, Name = "America" },
                new Country { Id = 4, Name = "Japan" }
            };

            ViewBag.list = countries;

            Employee employee = new Employee()
            {
                Country = 1
            };

            return View(employee);
        }

        [HttpPost]
        public ActionResult Test(Employee emp)
        {
            if (ModelState.IsValid)
            {
               return RedirectToAction("Test");
            }

            var countries = new List<Country>
            {
                new Country { Id = 1, Name = "India" },
                new Country { Id = 2, Name = "China" },
                new Country { Id = 3, Name = "America" },
                new Country { Id = 4, Name = "Japan" }
            };

            ViewBag.list = countries;

            return View();
        }
    }

    public class Country
    {
        public int Id { get; set; }
        public  string Name { get; set; }
    }
}