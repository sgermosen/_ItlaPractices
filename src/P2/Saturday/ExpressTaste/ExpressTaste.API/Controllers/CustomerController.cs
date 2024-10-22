using ExpressTaste.API.Dtos;
using ExpressTaste.Domain;
using ExpressTaste.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExpressTaste.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ExpressTasteDbContext _context;

        public CustomerController(ExpressTasteDbContext context)
        {
            _context = context;
        }

        [HttpGet(nameof(GetCustomers))]
        public async Task<ActionResult<List<Customer>>> GetCustomers()
        {
            var customers = await _context.Customers.ToListAsync();

            return customers;
        }

        [HttpPost(nameof(AddCustomer))]
        public async Task<ActionResult<CreateCustomerResponse>> AddCustomer(CreateCustomerRequest request)
        {

            var dbCustomer = new Customer();

            dbCustomer.Name = request.Name;
            dbCustomer.Email = request.Email;
            dbCustomer.Phone = request.Phone;
            dbCustomer.Lastname = request.Lastname;
            dbCustomer.Gender = request.Gender;
            dbCustomer.IsActive = request.IsActive;
            _context.Customers.Add(dbCustomer);
            await _context.SaveChangesAsync();

            return new CreateCustomerResponse { Id = dbCustomer.Id };
        }

    }
}
