using ExpressTaste.Common.Dtos;
using ExpressTaste.Common.Requests;
using ExpressTaste.Common.Responses;

namespace ExpressTaste.Infraestructure.Interfaces
{
    public interface ICustomerRepository
    {
        Task<List<CustomerDto>> GetAll();
        Task<CustomerDto> Get(int id);
        Task<CreateCustomerResponse> Add(CreateCustomerRequest request);
    }
}
