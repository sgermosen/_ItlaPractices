using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prestify.API.Requests;
using Prestify.API.Responses;
using Prestify.Domain;
using Prestify.Domain.Entities;

namespace Prestify.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly PrestifyDbContext _context;

        public PeopleController(PrestifyDbContext context)
        {
            _context = context;
        }


        [HttpGet("GetPeople")]
        public async Task<ActionResult<List<Person>>> GetPeople()
        {
            return await _context.People.ToListAsync();
        }

        [HttpPost("AddPerson")]
        public async Task<ActionResult<NewPersonResponse>> AddPerson(NewPersonRequest request)
        {
            var personDb = new Person();

            personDb.Name = request.Name;
            personDb.Email = request.Email;
            personDb.Phone = request.Phone;
            personDb.Address = request.Address;
            personDb.LastNames = request.LastNames;
            personDb.Dni = request.Dni;
            //var customer = new Customer();
            //customer.Job = "Something";
            //var customer2 = new Customer();
            //customer2.Job = "Something";
            //var customer3 = new Customer();
            //customer3.Job = "Something";
            //var customer4 = new Customer();
            //customer4.Job = "Something";
            //personDb.Customers = new List<Customer> { customer, customer2, customer3, customer4 };

            _context.People.Add(personDb);
            await _context.SaveChangesAsync();

            return new NewPersonResponse { Id = personDb.Id };
            //var response = new NewPersonResponse{Id = personDb.Id};

            //return response;
            //  return personDb.Id;
        }


    }
}
