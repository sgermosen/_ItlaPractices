using ExpressTaste.Web.Data;
using ExpressTaste.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExpressTaste.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ExpressTasteDbContext _db;
         
        public HomeController(ExpressTasteDbContext db)
        { 
            _db = db;
        }

        public IActionResult ShowMeSomething()
        { 
            
            return View("ShoMeAnotherThing");
        }
         
        public IActionResult Index()
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
