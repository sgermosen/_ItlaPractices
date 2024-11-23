using ExpressTaste.Common.Dtos;
using ExpressTaste.Common.Requests;
using ExpressTaste.Common.Responses;

namespace ExpressTaste.Infraestructure.Interfaces
{
    public interface IPaymentMethodRepository
    {
        Task<List<PaymentMethodDto>> GetAllAsync();
        Task<PaymentMethodDto> GetByIdAsync(int id);
        Task<CreatePaymentMethodResponse> AddAsync(CreatePaymentMethodRequest request);
        Task<UpdatePaymentMethodResponse> UpdateAsync(int id, UpdatePaymentMethodRequest request);
        Task<DeletePaymentMethodResponse> DeleteAsync(int id);

        Task<List<PaymentMethodDto>> GetActivePaymentMethodsAsync();
        Task<bool> ExistsAsync(int id);
        Task<bool> UpdateStatusAsync(int id, bool isActive);
        Task<List<PaymentMethodDto>> GetByNameAsync(string name);
    }
}
