using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return Content("Welcome to my c# page");
        }
        public IActionResult JsonReturn()
        {
            return Json(new { name = "Sandeep devineni", nickname = "sandy" });
        }
        public IActionResult HtmlReturn()
        {
            var indx = "<html><head><title>Sandeep Devineni</title></head><body>Hi this is sandeep</body></html";
            return Content(indx, "text/html");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
