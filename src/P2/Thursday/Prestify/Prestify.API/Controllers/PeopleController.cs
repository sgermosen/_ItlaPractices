using Microsoft.AspNetCore.Mvc;
using Prestify.Common.Dtos;
using Prestify.Common.Requests;
using Prestify.Domain.Entities;
using Prestify.Infrastructure;
using Prestify.Infrastructure.Interfaces;
using Prestify.Infrastructure.Models;

namespace Prestify.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        //private readonly IPersonRepository _repo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Person> personRepo;

        //private readonly LoanRepository loanRepository;

        public PeopleController(//IPersonRepository repo, 
            UnitOfWork unitOfWork,//, LoanRepository loanRepository
            IRepository<Person> personRepo 
                                 )
        {
            //_repo = repo;
            this._unitOfWork = unitOfWork;
            this.personRepo = personRepo;
            //this.loanRepository = loanRepository;
        }


        [HttpGet(nameof(GetPeople))]
        public async Task<ActionResult<List<PersonDto>>> GetPeople()
        {
            var people = await _repo.GetPeople();
            if (!people.Any())
                return BadRequest("No data faound");
            return people;
        }

        [HttpGet("GetPerson/{id}")]
        public async Task<ActionResult<PersonDto>> GetPerson(int id)
        {
            if (id == 0)
                return BadRequest("You need to give me an Valid Id");

            var personDto = await _repo.GetPerson(id);
            if (personDto == null)
            {
                return NotFound();
            }

            return personDto;
        }


        [HttpPost("AddPerson")]
        public async Task<IActionResult> AddPerson(NewPersonRequest request)
        {

            if (string.IsNullOrEmpty(request.Name))
                return BadRequest("You need to set a name");
            if (string.IsNullOrEmpty(request.Dni))
                return BadRequest("You need to set a dni");
            if (string.IsNullOrEmpty(request.LastNames))
                return BadRequest("You need to set a last names");
            if (string.IsNullOrEmpty(request.Email))
                return BadRequest("You need to set a email");
            if (!request.Email.Contains("@"))
                return BadRequest("you need to provide a valid email");

            //var list = new List<NewPersonRequest>();
            //list.Add(request);
            //list.Add(request);
            //list.Add(request);
            //list.Add(request);
            //list.Add(request);
            //list.Add(request);
            //list.Add(request);
            //list.Add(request);
            //list.Add(request);
            //list.Add(request);

            //foreach (var item in list)
            //{
            var loadnDto = new LoanModel();
            loadnDto.LoanNumber = "ASDASDASDA";

            await _unitOfWork.PersonRepository.Add(request);
            await _unitOfWork.LoanRepository.Add(loadnDto);
            //await _repo.AddPerson(request);
            //await personRepo.Add(
            //await loanRepository.Add(loadnDto);



            // await _repo.AddPerson(item);
            //}
            //await _repo.SaveChanges();
            await _unitOfWork.CommitAsync();
            return Ok();
        }

        [HttpPut("UpdatePerson/{id}")]
        public async Task<IActionResult> UpdatePerson(int id, NewPersonRequest request)
        {
            //var personDb = await _repo.People.FindAsync(id);
            //if (personDb == null)
            //{
            //    return NotFound();
            //}

            //personDb.Name = request.Name;
            //personDb.Email = request.Email;
            //personDb.Phone = request.Phone;
            //personDb.Address = request.Address;
            //personDb.LastNames = request.LastNames;
            //personDb.Dni = request.Dni;

            //_repo.People.Update(personDb);
            //await _repo.SaveChangesAsync();

            return NoContent();
        }


        [HttpDelete("DeletePerson/{id}")]
        public async Task<IActionResult> DeletePerson(int id)
        {
            //var personDb = await _repo.People.FindAsync(id);
            //if (personDb == null)
            //{
            //    return NotFound();
            //}

            //_repo.People.Remove(personDb);
            //await _repo.SaveChangesAsync();

            return NoContent();
        }

    }
}
