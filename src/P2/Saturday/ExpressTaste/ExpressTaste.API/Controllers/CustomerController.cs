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

        [HttpGet("GetCustomer/{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            var customerDb = await _context.Customers.FindAsync(id);
            if (customerDb == null)
            {
                return NotFound();
            }
            return customerDb;
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

        [HttpPut("UpdateCustomer/{id}")]
        public async Task<IActionResult> UpdateCustomer(int id, CreateCustomerRequest request)
        {
            var customerDb = await _context.Customers.FindAsync(id);
            if (customerDb == null)
            {
                return NotFound();
            }

            customerDb.Name = request.Name;
            customerDb.Email = request.Email;
            customerDb.Phone = request.Phone;
            customerDb.Gender = request.Gender;
            customerDb.IsActive = request.IsActive;
            customerDb.Lastname = request.Lastname;

            _context.Customers.Update(customerDb);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        [HttpDelete("DeleteCustomer/{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customerDb = await _context.Customers.FindAsync(id);
            if (customerDb == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customerDb);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
