using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaqJet.Domain;
using PaqJet.Domain.Entities;
using PaqJet.Web.Models;

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
            return View(await _context.Customers.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var custumer = await _context.Customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (custumer == null)
            {
                return NotFound();
            }

            return View(custumer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            var customers = _context.Customers.ToList();
            //ViewBag.Customers = customers;
            //ViewBag.Header = "Esta es la cabecera del back";
            var vm = new CreateCustomerViewModel();
            vm.Header = "Esta es la cabecera del back";
            // vm.Customers = customers;
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateCustomerViewModel custumer)
        {
            if (ModelState.IsValid)
            {
                var dbCustomer = new Customer();

                dbCustomer.IsActive = custumer.IsActive;
                dbCustomer.Name = custumer.Name;
                dbCustomer.LastName = custumer.LastName;

                _context.Customers.Add(dbCustomer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(custumer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var custumer = await _context.Customers.FindAsync(id);
            if (custumer == null)
            {
                return NotFound();
            }
            var vm = new EditCustomerViewModel();
            vm.Id = custumer.Id;
            vm.Name = custumer.Name;
            vm.LastName = custumer.LastName;

            return View(vm);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditCustomerRequest custumer)
        {
            if (id != custumer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var dbCustomer = new Customer();

                    dbCustomer.IsActive = custumer.IsActive;
                    dbCustomer.Name = custumer.Name;
                    dbCustomer.LastName = custumer.LastName;

                    _context.Customers.Update(dbCustomer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustumerExists(custumer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(custumer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var custumer = await _context.Customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (custumer == null)
            {
                return NotFound();
            }

            return View(custumer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var custumer = await _context.Customers.FindAsync(id);
            if (custumer != null)
            {
                _context.Customers.Remove(custumer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustumerExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
