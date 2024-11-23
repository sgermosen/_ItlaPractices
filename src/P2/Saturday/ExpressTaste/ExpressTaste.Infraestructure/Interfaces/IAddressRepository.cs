using ExpressTaste.Common.Dtos;
using ExpressTaste.Common.Requests;
using ExpressTaste.Common.Responses;

namespace ExpressTaste.Infraestructure.Interfaces
{
    public interface IAddressRepository
    {
        Task<List<AddressDto>> GetAllAsync();
        Task<AddressDto> GetByIdAsync(int id);
        Task<CreateAddressResponse> AddAsync(CreateAddressRequest request);
        Task<UpdateAddressResponse> UpdateAsync(int id, UpdateAddressRequest request);
        Task<DeleteAddressResponse> DeleteAsync(int id);

        Task<List<AddressDto>> GetByCustomerIdAsync(int customerId);
        Task<AddressDto> GetPrimaryAddressAsync(int customerId);
        Task<bool> SetPrimaryAddressAsync(int addressId, int customerId);
        Task<bool> ExistsAsync(int id);
        Task<List<AddressDto>> GetByPostalCodeAsync(string postalCode);
        Task<List<AddressDto>> GetByCityAsync(string city);
    }
}
