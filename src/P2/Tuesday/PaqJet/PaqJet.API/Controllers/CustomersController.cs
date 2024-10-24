using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaqJet.API.Requests;
using PaqJet.API.Responses;
using PaqJet.Domain;
using PaqJet.Domain.Entities;
using PaqJet.Web.Models;

namespace PaqJet.API.Controllers
{
    [ApiController]
    //[Route("Customers")]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly PaqJetDbContext _context;

        public CustomersController(PaqJetDbContext context)
        {
            _context = context;
        }

        [HttpGet(nameof(GetAllCustomers))]
        public async Task<IActionResult> GetAllCustomers()
        {

            var customers = await _context.Customers.ToListAsync();
            return Ok(customers);
        }

        //[HttpGet]
        //public async Task<ActionResult<List<Customer>>> GetAllCustomers2()
        //{

        //    var customers = await _context.Customers.ToListAsync();
        //    return customers;
        //}

        //[HttpPost(nameof(AddCustomer))]
        //public async Task<IActionResult> AddCustomer(AddCustomerRequest request)
        //{
        //    var dbCustomer = new Customer();

        //    dbCustomer.IsActive = request.IsActive;
        //    dbCustomer.Name = request.Name;
        //    dbCustomer.LastName = request.LastName;
        //    dbCustomer.Age = request.Age;
        //    dbCustomer.Sex = request.Sex;
               
        //    _context.Customers.Add(dbCustomer);
        //    await _context.SaveChangesAsync();

        //   // var response = new AddCustomerResponse { Id = dbCustomer.Id };
        //    return Ok(response);
          // return Ok(new AddCustomerResponse { Id = dbCustomer.Id)
   // };

    //}


    [HttpPost(nameof(AddCustomer))]
        public async Task<ActionResult<AddCustomerResponse>> AddCustomer(AddCustomerRequest request)
        {
            var dbCustomer = new Customer();

            dbCustomer.IsActive = request.IsActive;
            dbCustomer.Name = request.Name;
            dbCustomer.LastName = request.LastName;
            dbCustomer.Age = request.Age;
            dbCustomer.Sex = request.Sex;

            _context.Customers.Add(dbCustomer);
            await _context.SaveChangesAsync();

           return new AddCustomerResponse { Id = dbCustomer.Id };
          
        }

    }
}
