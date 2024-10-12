using Microsoft.AspNetCore.Mvc;
using Prestify.Web.Data;
using Prestify.Web.Models;
using Prestify.Web.Models.Entities;
using Prestify.Web.Models.ViewModels;
using System;

namespace Prestify.Web.Controllers
{
    public class PeopleController : Controller
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
        //Get
        // [HttpGet]
        public IActionResult Create()
        {
            //var person = new Person();
            // return View(person);
            return View();
        }

        [HttpPost]
      //  public IActionResult Create(Person vm)
        public IActionResult Create(CreatePersonViewModel vm)
        {
            //if (ModelState.IsValid)
            //{
            //    _context.People.Add(vm);
            //    _context.SaveChanges();
            //    // return RedirectToAction("Index");
            //    return RedirectToAction(nameof(Index));
            //}
            ////else
            ////{
            //return View(vm);
            ////  }

            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            var personDb = new Person();
            personDb.Name = vm.Name;
            personDb.Email = vm.Email;
            personDb.Phone = vm.Phone;
            personDb.Address   = vm.Address;
            personDb.LastNames = vm.LastNames;
            personDb.Dni = vm.Dni;

            //_context.People.Add(vm);
            _context.People.Add(personDb);
            // _context.Add(vm);
            _context.SaveChanges();
            // return RedirectToAction("Index");
            return RedirectToAction(nameof(Index));
        }

        //Get
        // [HttpGet]
        public IActionResult Edit(int id)
        {
            var person = _context.People.FirstOrDefault(p => p.Id == id);

            //Person personDb;
            //var people = _context.People.ToList();
            //foreach (var item in people)
            //{
            //    if (item.Id == loqueseaId)
            //    { 
            //        personDb = item; 
            //        break;
            //    }
            //}
            if (person == null)
            {
               return NotFound();
            }

            var vm = new EditPersonViewModel();
            vm.Name = person.Name;
            vm.Email = person.Email;
            vm.Phone = person.Phone;
            vm.Address = person.Address;
            vm.LastNames = person.LastNames;
            vm.Dni = person.Dni;

            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(int id, EditPersonViewModel vm)
        {
            if (vm.Id != id)
            {
                return BadRequest("Incorrect id");
            }
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            var personDb = _context.People.FirstOrDefault(p => p.Id == id);

            if (personDb == null)
            {
               return  NotFound();
            }

            personDb.Name = vm.Name;
            personDb.Email = vm.Email;
            personDb.Phone = vm.Phone;
            personDb.Address = vm.Address;
            personDb.LastNames = vm.LastNames;
            personDb.Dni = vm.Dni;
             
            _context.People.Update(personDb);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost] 
        public IActionResult Delete(int peopleId)
        {
            var person = _context.People.FirstOrDefault(p => p.Id == peopleId);
 
            if (person == null)
            {
                return NotFound();
            }

            //var vm = new EditPersonViewModel();
            //vm.Name = person.Name;
            //vm.Email = person.Email;
            //vm.Phone = person.Phone;
            //vm.Address = person.Address;
            //vm.LastNames = person.LastNames;
            //vm.Dni = person.Dni;

            _context.People.Remove(person);
            _context.SaveChanges();
            //return View(vm);
            return RedirectToAction(nameof(Index)); 
        }

        //[HttpPost]
        //public IActionResult Delete(EditPersonViewModel vm)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(vm);
        //    }

        //    var personDb = _context.People.FirstOrDefault(p => p.Id == vm.Id);

        //    if (personDb == null)
        //    {
        //        return NotFound();
        //    }
             
        //    _context.People.Remove(personDb);
        //    _context.SaveChanges();
        //    return RedirectToAction(nameof(Index));
        //}
    }
}
