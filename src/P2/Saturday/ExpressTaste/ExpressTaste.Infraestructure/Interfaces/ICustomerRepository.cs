using ExpressTaste.Common.Dtos;
using ExpressTaste.Common.Requests;
using ExpressTaste.Common.Responses;
using ExpressTaste.Domain.Enums;

namespace ExpressTaste.Infraestructure.Interfaces
{
    public interface ICustomerRepository
    {
        Task<List<CustomerDto>> GetAllAsync();
        Task<CustomerDto> GetByIdAsync(int id);
        Task<CreateCustomerResponse> AddAsync(CreateCustomerRequest request);
        Task<UpdateCustomerResponse> UpdateAsync(int id, UpdateCustomerRequest request);
        Task<DeleteCustomerResponse> DeleteAsync(int id);

        Task<List<CustomerDto>> GetActiveCustomersAsync();
        Task<List<CustomerDto>> GetCustomersByTypeAsync(CustomerType type);
        Task<CustomerOrdersDto> GetCustomerOrdersAsync(int customerId);
        Task<CustomerAddressesDto> GetCustomerAddressesAsync(int customerId);
        Task<CustomerDto> GetCustomerByEmailAsync(string email);
        Task<CustomerDto> GetCustomerByTaxIdAsync(string taxId);
        Task<bool> ExistsAsync(int id);
        Task<bool> ExistsByEmailAsync(string email);
        Task<bool> ExistsByTaxIdAsync(string taxId);
        Task<List<CustomerDto>> SearchCustomersAsync(CustomerSearchRequest searchRequest);
        Task<CustomerStatisticsDto> GetCustomerStatisticsAsync(int customerId);
        Task<bool> UpdateCustomerStatusAsync(int id, bool isActive);
        Task<AddCustomerAddressResponse> AddCustomerAddressAsync(int customerId, AddCustomerAddressRequest request);
        Task<bool> SetPrimaryAddressAsync(int customerId, int addressId);
    }
}
