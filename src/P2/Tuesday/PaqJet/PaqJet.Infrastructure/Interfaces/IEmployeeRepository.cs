using PaqJet.API.Responses;
using PaqJet.Infrastructure.Models;

namespace PaqJet.Infrastructure.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<EmployeeModel>> Get();
        Task<EmployeeModel> GetById(int id);
        Task<EmployeeModel> Add(EmployeeModel request);
        Task<bool> Update(EmployeeModel request);
    }
}
