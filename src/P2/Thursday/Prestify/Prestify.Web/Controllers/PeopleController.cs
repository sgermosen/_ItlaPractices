using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Prestify.Web.Data;
using Prestify.Web.Models;

namespace Prestify.Web.Controllers
{
    public class PeopleController:Controller
    {
        private readonly PrestifyDbContext _context;

        public PeopleController(PrestifyDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            var query = _context.People.Where(p => !p.Deleted);

            //query = query.Where(p => p.Name.Contains("Juan x"));

            var people = query.ToList();
            var general = new General();

             general.People = people;
            ViewBag.Header = "This is a Header";
            ViewBag.PeopleFromViewBag = people;
            return View(general);
        }
    }
}
