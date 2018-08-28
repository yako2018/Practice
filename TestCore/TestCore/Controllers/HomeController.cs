using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestCore.Models;
using TestCore.Service.CustomMiddleware;

namespace TestCore.Controllers
{
    public class HomeController : Controller
    {
        //[MiddlewareFilter(typeof(FirstMiddleware))]
        public IActionResult Index()
        {
            return Content("hello");
            //return View();
        }
        
        [HttpGet]
        public IActionResult GetList()
        {
            TestModel test = new TestModel();
            test.str1 = "string1";
            test.str2 = "string2";
            return Content(JsonConvert.SerializeObject(test));
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
