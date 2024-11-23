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
            return customer;
        }

        [HttpGet(nameof(GetCustomers))]
        public async Task<ActionResult<List<CustomerDto>>> GetCustomers()
        {
            return await _repo.GetAll(); ;
        }

        [HttpPost(nameof(AddCustomer))]
        public async Task<ActionResult<CreateCustomerResponse>> AddCustomer(CreateCustomerRequest request)
        {
            return await _repo.Add(request);
        }
    }
}
