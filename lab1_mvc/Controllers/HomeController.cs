using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab1_mvc.Models;

namespace lab1_mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model= new Person();
            model.name="Megna Agarwal";
            model.address= "Dhalku, Chettrapati";
            
            // ViewBag.name=model.name;
            // ViewBag.address=model.address;
            
            return View(model);
        }

        [HttpPost]
        public IActionResult Check(int a)
        {
            var r="even";
            if(a%2==0)
                r="even";
            else
                r="odd";
            ViewBag.Result=r;
            return View();
        }

        [HttpGet]
        public IActionResult Check()
        {
            return View();      
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
