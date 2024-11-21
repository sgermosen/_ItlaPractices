using PaqJet.API.Responses;
using PaqJet.Infrastructure.Models;

namespace PaqJet.Infrastructure.Interfaces
{
    public interface IPaqRepository
    {
        Task<List<PaqModel>> Get();
        Task<PaqModel> GetById(int id);
        Task<PaqModel> Add(PaqModel request);
        Task<bool> Update(PaqModel request);
    }
}
