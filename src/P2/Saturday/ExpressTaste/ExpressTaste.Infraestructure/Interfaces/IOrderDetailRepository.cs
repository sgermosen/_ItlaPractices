using ExpressTaste.Common.Dtos;
using ExpressTaste.Common.Requests;
using ExpressTaste.Common.Responses;

namespace ExpressTaste.Infraestructure.Interfaces
{
    public interface IOrderDetailRepository
    {
        Task<List<OrderDetailDto>> GetAllAsync();
        Task<OrderDetailDto> GetByIdAsync(int id);
        Task<CreateOrderDetailResponse> AddAsync(CreateOrderDetailRequest request);
        Task<UpdateOrderDetailResponse> UpdateAsync(int id, UpdateOrderDetailRequest request);
        Task<DeleteOrderDetailResponse> DeleteAsync(int id);

        Task<List<OrderDetailDto>> GetByOrderIdAsync(int orderId);
        Task<List<OrderDetailDto>> GetByProductIdAsync(int productId);
        Task<decimal> GetTotalByOrderIdAsync(int orderId);
        Task<bool> UpdateQuantityAsync(int id, int quantity);
        Task<bool> UpdateDiscountAsync(int id, decimal discount);
        Task<bool> ExistsAsync(int id);
        Task<OrderDetailSummaryDto> GetSummaryAsync(int id);
    }
}
