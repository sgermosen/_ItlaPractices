using Microsoft.AspNetCore.Mvc;

namespace ExpressTaste.Web.Controllers
{
    public class CustomersController : Controller
    {
        public CustomersController()
        {
        }

        [HttpGet]
        public ActionResult Index()
        {
            //var vm = new CustomersViewModel();
            //var allCustomers = _context.Customers.ToList();
            //var activeCustomers = _context.Customers
            //    .Where(c => c.IsActive && !c.IsActive).ToList();
            //// ViewBag.CustomerInformation = info2;

            ////vm.ActiveCustomers = activeCustomers;
            //vm.AllCustomers = allCustomers;
            //return View(vm);
            return View();
        }


        public async Task<IActionResult> Details(int? id)
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }


        // [HttpPost]
        //// [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Create(CreateCustomerViewModel vm)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         var dbCustomer = new Customer();

        //         dbCustomer.Name = vm.Name;
        //         dbCustomer.Email = vm.Email;
        //         dbCustomer.Phone = vm.Phone;
        //         dbCustomer.Lastname = vm.Lastname;
        //         dbCustomer.Gender = vm.Gender;
        //         dbCustomer.IsActive = vm.IsActive;

        //         _context.Customers.Add(dbCustomer);
        //         await _context.SaveChangesAsync();
        //         return RedirectToAction(nameof(Index));
        //     }
        //     return View();
        // }

        public async Task<IActionResult> Edit(int id)
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, EditCustomerViewModel vm)
        //{
        //    //    if (identification != vm.Id)
        //    //    {
        //    //        return NotFound();
        //    //    }


        //    if (ModelState.IsValid)
        //    {
        //        var dbCustomer = await _context.Customers.FindAsync(id);

        //        dbCustomer.Name = vm.Name;
        //        dbCustomer.Email = vm.Email;
        //        dbCustomer.Phone = vm.Phone;
        //        dbCustomer.Lastname = vm.Lastname;
        //        dbCustomer.Gender = vm.Gender;
        //        dbCustomer.IsActive = vm.IsActive;
        //        _context.Customers.Update(dbCustomer);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(vm);
        //}

        ////// GET: Customers1/Delete/5
        ////public async Task<IActionResult> Delete(int id)
        ////{
        ////    var customer = await _context.Customers
        ////        .FirstOrDefaultAsync(m => m.Id == id);
        ////    if (customer == null)
        ////    {
        ////        return NotFound();
        ////    }

        ////    return View(customer);
        ////}


        //[HttpPost, ActionName(nameof(Delete))]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirm(int id)
        //{
        //    var customer = await _context.Customers.FindAsync(id);
        //    if (customer != null)
        //    {
        //        _context.Customers.Remove(customer);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

    }
}
