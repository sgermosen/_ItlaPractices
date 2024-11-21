using Microsoft.AspNetCore.Mvc;
using PaqJet.API.Requests;
using PaqJet.API.Responses;
using PaqJet.Infrastructure.Interfaces;
using PaqJet.Infrastructure.Models;

namespace PaqJet.API.Controllers
{
    [ApiController]
    //[Route("Customers")]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet(nameof(GetAllCustomers))]
        public async Task<IActionResult> GetAllCustomers()
        {

            var customers = await _customerService.GetCustomers();
            return Ok(customers);
        }


        [HttpGet("GetCustomer/{id}")]
        public async Task<ActionResult<CustomerModel>> GetCustomer(int id)
        {
            var customer = await _customerService.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return customer;
        }
        //[HttpGet]
        //public async Task<ActionResult<List<Customer>>> GetAllCustomers2()
        //{

        //    var customers = await _repository.Customers.ToListAsync();
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

        //    _repository.Customers.Add(dbCustomer);
        //    await _repository.SaveChangesAsync();

        //   // var response = new AddCustomerResponse { Id = dbCustomer.Id };
        //    return Ok(response);
        // return Ok(new AddCustomerResponse { Id = dbCustomer.Id)
        // };

        //}


        [HttpPost(nameof(AddCustomer))]
        public async Task<ActionResult<AddCustomerResponse>> AddCustomer(AddCustomerRequest request)
        {
            return await _customerService.AddCustomer(request);
        }


        [HttpPut("EditCustomer/{id}")]
        public async Task<IActionResult> EditCustomer(int id, EditCustomerRequest request)
        {
            if (request.Id != id)
            {
                return BadRequest();
            }

            var success = await _customerService.UpdateCustomer(request);

            if (success)
            {
                return NoContent();
            }
            //else
            //{ 
            return BadRequest("Something gor wrong");
            // }
        }


        //[HttpDelete("DeleteCustomer/{id}")]
        //public async Task<IActionResult> DeleteCustomer(int id)
        //{
        //    var personDb = await _repository.Customers.FindAsync(id);
        //    if (personDb == null)
        //    {
        //        return NotFound();
        //    }

        //    _repository.Customers.Remove(personDb);
        //    await _repository.SaveChangesAsync();

        //    return NoContent();
        //}
    }
}