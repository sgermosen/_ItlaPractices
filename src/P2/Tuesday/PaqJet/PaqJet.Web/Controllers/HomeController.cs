using Microsoft.AspNetCore.Mvc;
using PaqJet.Web.Models;
using System.Diagnostics;

namespace PaqJet.Web.Controllers
{
    public class HomeController : Controller
    { 
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MyActionNameIsOneThing()
        {
           // return View();

            return View("ButMyViewNameIsOther");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
