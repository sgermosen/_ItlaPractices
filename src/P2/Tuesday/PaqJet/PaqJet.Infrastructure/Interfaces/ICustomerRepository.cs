using PaqJet.API.Requests;
using PaqJet.API.Responses;
using PaqJet.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqJet.Infrastructure.Interfaces
{
    public interface ICustomerRepository
    {
        Task<List<CustomerModel>> GetCustomers();
        Task<CustomerModel> GetCustomerById(int id);
        Task<AddCustomerResponse> AddCustomer(AddCustomerRequest request);
        Task<bool> UpdateCustomer(EditCustomerRequest request);
        //Task<int> SaveChanges();
    }
}
