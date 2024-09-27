using Microsoft.AspNetCore.Mvc;
using Prestify.Web.Models;
using System.Diagnostics;

namespace Prestify.Web.Controllers
{
    public class HomesController : Controller
    {
        public HomesController()
        {
        }

        public IActionResult AnAction()
        {
            var emp = new Employee();
            emp.Address = "here comes an address";

            return View("SomethingDifferent");
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
