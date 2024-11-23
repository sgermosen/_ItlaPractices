using ExpressTaste.Common.Dtos;
using ExpressTaste.Common.Requests;
using ExpressTaste.Common.Responses;
using ExpressTaste.Infraestructure.Interfaces;
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

            var customer = await _repo.GetByIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return customer;
        }

        [HttpGet(nameof(GetCustomers))]
        public async Task<ActionResult<List<CustomerDto>>> GetCustomers()
        {
            return await _repo.GetAllAsync(); ;
        }

        [HttpPost(nameof(AddCustomer))]
        public async Task<ActionResult<CreateCustomerResponse>> AddCustomer(CreateCustomerRequest request)
        {
            return await _repo.AddAsync(request);
        }
    }
}
