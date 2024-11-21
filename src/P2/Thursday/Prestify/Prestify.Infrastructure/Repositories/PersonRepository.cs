using Microsoft.EntityFrameworkCore;
using Prestify.Common.Dtos;
using Prestify.Common.Requests;
using Prestify.Common.Responses;
using Prestify.Domain.Entities;
using Prestify.Persistence;

namespace Prestify.Infrastructure.Exceptions
{
    public class PersonRepository: IPersonRepository
    {
        private readonly PrestifyDbContext _context;
        public PersonRepository(PrestifyDbContext context)
        {
            _context = context;
        }

        public async Task<List<PersonDto>> GetPeople()
        {
            var people = await _context.People.ToListAsync();
            var peopleToReturn = new List<PersonDto>();
            foreach (var personDb in people)
            {
                peopleToReturn.Add(FromPersonToPersonDto(personDb));
            }
            return peopleToReturn;
        }

        public async Task<PersonDto> GetPerson(int id)
        {
            //var person = await _context.People.FirstOrDefaultAsync(p=> p.Id == id);
            var personDb = await _context.People.FindAsync(id);
            if (personDb == null)
            {
                throw new Exception("No person found");
            }

            return FromPersonToPersonDto(personDb);
        }

        public async Task<NewPersonResponse> AddPerson(NewPersonRequest request)
        {
            var personDb = FromPersonDtoToPerson(request);

            _context.People.Add(personDb);
            await _context.SaveChangesAsync();

            return new NewPersonResponse { Id = personDb.Id };
        }

        private PersonDto FromPersonToPersonDto(Person personDb)
        {
            return new PersonDto
            {
                Address = personDb.Address,
                Dni = personDb.Dni,
                Email = personDb.Email,
                Id = personDb.Id,
                LastNames = personDb.LastNames,
                Name = personDb.Name,
                Phone = personDb.Phone,
            };
        }

        private Person FromPersonDtoToPerson(NewPersonRequest dto)
        {
            return new Person
            {
                Address = dto.Address,
                Dni = dto.Dni,
                Email = dto.Email, 
                LastNames = dto.LastNames,
                Name = dto.Name,
                Phone = dto.Phone,
            };
        }

        private Person FromPersonDtoToPerson(PersonDto dto)
        {
            return new Person
            {
                Address = dto.Address,
                Dni = dto.Dni,
                Email = dto.Email,
                LastNames = dto.LastNames,
                Name = dto.Name,
                Phone = dto.Phone,
            };
        }
 
    }
}
