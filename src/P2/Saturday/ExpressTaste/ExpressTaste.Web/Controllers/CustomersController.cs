using ExpressTaste.Web.Data;
using ExpressTaste.Web.Models.Entities;
using ExpressTaste.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExpressTaste.Web.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ExpressTasteDbContext _context;

        public CustomersController(ExpressTasteDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var vm = new CustomersViewModel();
            var allCustomers = _context.Customers.ToList();
            var activeCustomers = _context.Customers
                .Where(c => c.IsActive && !c.IsActive).ToList();
            // ViewBag.CustomerInformation = info2;

            //vm.ActiveCustomers = activeCustomers;
            vm.AllCustomers = allCustomers;
            return View(vm);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateCustomerViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var dbCustomer = new Customer();

                dbCustomer.Name = vm.Name;
                dbCustomer.Email = vm.Email;
                dbCustomer.Phone = vm.Phone;
                dbCustomer.Lastname = vm.Lastname;
                dbCustomer.Gender = vm.Gender;
                dbCustomer.IsActive = vm.IsActive;

                _context.Customers.Add(dbCustomer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        { 

            var customerDb = await _context.Customers.FindAsync(id);
            // var customer = await _context.Customers.FirstOrDefaultAsync(c => c.Id == id);
            if (customerDb == null)
            {
                return NotFound();
            }
            var vm = new EditCustomerViewModel();
            vm.Id = customerDb.Id;
            vm.Name = customerDb.Name;
            vm.Email = customerDb.Email;
            vm.Phone = customerDb.Phone;
            vm.Lastname = customerDb.Lastname;
            vm.Gender = customerDb.Gender;
            vm.IsActive = customerDb.IsActive;

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditCustomerViewModel vm)
        {
            //    if (identification != vm.Id)
            //    {
            //        return NotFound();
            //    }

            if (ModelState.IsValid)
            {
                var dbCustomer = await _context.Customers.FindAsync(id);

                dbCustomer.Name = vm.Name;
                dbCustomer.Email = vm.Email;
                dbCustomer.Phone = vm.Phone;
                dbCustomer.Lastname = vm.Lastname;
                dbCustomer.Gender = vm.Gender;
                dbCustomer.IsActive = vm.IsActive;
                _context.Customers.Update(dbCustomer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vm);
        }

        // GET: Customers1/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }


        [HttpPost, ActionName(nameof(Delete))]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
