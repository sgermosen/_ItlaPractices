using Microsoft.AspNetCore.Mvc;
using PaqJet.Domain;
using PaqJet.Persistence;

namespace PaqJet.Web.Controllers
{
    public class CustomersController : Controller
    {
        private readonly PaqJetDbContext _context;

        public CustomersController(PaqJetDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            return View();

        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }


        public async Task<IActionResult> Edit(int? id)
        {
            return View();
        }

        private bool CustumerExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
