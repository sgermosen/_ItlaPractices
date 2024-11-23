using Prestify.Common.Dtos;
using Prestify.Common.Requests;
using Prestify.Common.Responses;

namespace Prestify.Infrastructure.Exceptions
{
    public interface IPersonRepository
    {
        Task<List<PersonDto>> GetPeople();
        Task<PersonDto> GetPerson(int id);
        Task<bool> AddPerson(NewPersonRequest request);
        //Task<int> SaveChanges();
    }
}
