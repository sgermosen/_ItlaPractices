using ExpressTaste.Common.Dtos;
using ExpressTaste.Common.Requests;
using ExpressTaste.Common.Responses;
using ExpressTaste.Infraestructure.Interfaces;
using ExpressTaste.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ExpressTaste.Infraestructure.Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly ExpressTasteDbContext _context;

        public OrderDetailRepository(ExpressTasteDbContext context)
        {
            _context = context;
        }

        public async Task<List<OrderDetailDto>> GetByOrderIdAsync(int orderId)
        {
            return await _context.OrderDetails
                .Include(od => od.Product)
                .Where(od => od.OrderId == orderId)
                .Select(od => new OrderDetailDto
                {
                    Id = od.Id,
                    Quantity = od.Quantity,
                    UnitPrice = od.UnitPrice,
                    Discount = od.Discount,
                    Subtotal = od.Subtotal,
                    Product = new ProductDto
                    {
                        Id = od.Product.Id,
                        Name = od.Product.Name
                    }
                })
                .ToListAsync();
        }

        public async Task<bool> UpdateQuantityAsync(int id, int quantity)
        {
            var orderDetail = await _context.OrderDetails.FindAsync(id);
            if (orderDetail == null)
                throw new KeyNotFoundException($"Order detail with ID {id} not found");

            orderDetail.Quantity = quantity;
            orderDetail.Subtotal = (orderDetail.UnitPrice * quantity) * (1 - orderDetail.Discount / 100);
            orderDetail.ModifiedDate = DateTime.UtcNow;

            // Actualizar totales de la orden
            var order = await _context.Orders
                .Include(o => o.OrderDetails)
                .FirstOrDefaultAsync(o => o.Id == orderDetail.OrderId);

            if (order != null)
            {
                order.Subtotal = order.OrderDetails.Sum(od => od.Subtotal);
                order.Tax = order.Subtotal * 0.16m; // Ejemplo: 16% de impuesto
                order.Total = order.Subtotal + order.Tax;
                order.ModifiedDate = DateTime.UtcNow;
            }

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<OrderDetailSummaryDto> GetSummaryAsync(int id)
        {
            return await _context.OrderDetails
                .Include(od => od.Order)
                .Include(od => od.Product)
                .Where(od => od.Id == id)
                .Select(od => new OrderDetailSummaryDto
                {
                    OrderId = od.OrderId,
                    ProductName = od.Product.Name,
                    Quantity = od.Quantity,
                    Total = od.Subtotal
                })
                .FirstOrDefaultAsync();
        }

        public Task<List<OrderDetailDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetailDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CreateOrderDetailResponse> AddAsync(CreateOrderDetailRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<UpdateOrderDetailResponse> UpdateAsync(int id, UpdateOrderDetailRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteOrderDetailResponse> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDetailDto>> GetByProductIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> GetTotalByOrderIdAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateDiscountAsync(int id, decimal discount)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }



        Task<DeleteOrderDetailResponse> IOrderDetailRepository.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}