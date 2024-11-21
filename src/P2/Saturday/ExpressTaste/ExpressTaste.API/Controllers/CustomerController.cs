using ExpressTaste.API.Dtos;
using ExpressTaste.Infraestructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExpressTaste.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _repo;
        

        public CustomerController(ICustomerRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("GetCustomer/{id}")]
        public async Task<ActionResult<CustomerDto>> GetCustomer(int id)
        {

            var customer = await _repo.Get(id);
            if (customer == null)
            {
                return NotFound();
            }
            //var response = new CustomerDto();
            //response.Email = customerDb.Email;
            //response.Gender = customerDb.Gender;

            //var response = new CustomerDto
            //{
            //    Id = customerDb.Id,
            //    Gender = customerDb.Gender,
            //    Email = customerDb.Email,
            //    IsActive = customerDb.IsActive,
            //    Lastname = customerDb.Lastname,
            //    Name = customerDb.Name,
            //    Phone = customerDb.Phone
            //};

            return customer;
        }

        [HttpGet(nameof(GetCustomers))]
        public async Task<ActionResult<List<CustomerDto>>> GetCustomers()
        {
            //  var customers = await _repo.GetAll(); 
            return await _repo.GetAll(); ;
        }

        [HttpPost(nameof(AddCustomer))]
        public async Task<ActionResult<CreateCustomerResponse>> AddCustomer(CreateCustomerRequest request)
        {
            return await _repo.Add(request);
        }

        //[HttpPut("UpdateCustomer/{id}")]
        //public async Task<IActionResult> UpdateCustomer(int id, CreateCustomerRequest request)
        //{
        //    var customerDb = await _context.Customers.FindAsync(id);
        //    if (customerDb == null)
        //    {
        //        return NotFound();
        //    }

        //    customerDb.Name = request.Name;
        //    customerDb.Email = request.Email;
        //    customerDb.Phone = request.Phone;
        //    customerDb.Gender = request.Gender;
        //    customerDb.IsActive = request.IsActive;
        //    customerDb.Lastname = request.Lastname;

        //    _context.Customers.Update(customerDb);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}


        //[HttpDelete("DeleteCustomer/{id}")]
        //public async Task<IActionResult> DeleteCustomer(int id)
        //{
        //    var customerDb = await _context.Customers.FindAsync(id);
        //    if (customerDb == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Customers.Remove(customerDb);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

    }
}
