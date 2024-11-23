using ExpressTaste.Common.Dtos;
using ExpressTaste.Common.Requests;
using ExpressTaste.Common.Responses;
using ExpressTaste.Domain.Enums;

namespace ExpressTaste.Infraestructure.Interfaces
{
    public interface IOrderRepository
    {
        Task<List<OrderDto>> GetAllAsync();
        Task<OrderDto> GetByIdAsync(int id);
        Task<CreateOrderResponse> AddAsync(CreateOrderRequest request);
        Task<UpdateOrderResponse> UpdateAsync(int id, UpdateOrderRequest request);
        Task<DeleteOrderResponse> DeleteAsync(int id);

        Task<List<OrderDto>> GetOrdersByCustomerAsync(int customerId);
        Task<List<OrderDto>> GetOrdersByStatusAsync(OrderStatus status);
        Task<List<OrderDto>> GetOrdersByDateRangeAsync(DateTime startDate, DateTime endDate);
        Task<OrderDetailsDto> GetOrderDetailsAsync(int orderId);
        Task<bool> UpdateOrderStatusAsync(int id, OrderStatus status);
        Task<OrderSummaryDto> GetOrderSummaryAsync(int orderId);
        Task<List<OrderDto>> GetPendingOrdersAsync();
        Task<bool> ExistsAsync(int id);
        Task<decimal> GetOrderTotalAsync(int orderId);
        Task<List<OrderDto>> SearchOrdersAsync(OrderSearchRequest searchRequest);
        Task<bool> CancelOrderAsync(int id, string reason);
        Task<bool> AddOrderItemAsync(int orderId, AddOrderItemRequest request);
        Task<bool> UpdateOrderItemAsync(int orderId, int productId, UpdateOrderItemRequest request);
        Task<bool> RemoveOrderItemAsync(int orderId, int productId);
    }
}
