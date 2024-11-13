using PaqJet.API.Requests;
using PaqJet.API.Responses;
using PaqJet.Infrastructure.Models;

namespace PaqJet.Infrastructure.Interfaces
{
    public interface ICustomerService
    {
        Task<AddCustomerResponse> AddCustomer(AddCustomerRequest request);
        Task<List<CustomerModel>> GetCustomers();
        Task<CustomerModel> GetCustomerById(int id);
        Task<bool> UpdateCustomer(EditCustomerRequest request);
    }
}
