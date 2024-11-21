using ExpressTaste.API.Dtos;

namespace ExpressTaste.Infraestructure.Repositories
{
    public interface ICustomerRepository
    {
        Task<List<CustomerDto>> GetAll();
        Task<CustomerDto> Get(int id);
        Task<CreateCustomerResponse> Add(CreateCustomerRequest request);
    }
}
