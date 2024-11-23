using ExpressTaste.Common.Dtos;
using ExpressTaste.Common.Requests;
using ExpressTaste.Common.Responses;
using ExpressTaste.Domain.Entities;
using ExpressTaste.Domain.Enums;
using ExpressTaste.Infraestructure.Interfaces;
using ExpressTaste.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ExpressTaste.Infraestructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ExpressTasteDbContext _context;

        public OrderRepository(ExpressTasteDbContext context)
        {
            _context = context;
        }

        public async Task<List<OrderDto>> GetAllAsync()
        {
            return await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Product)
                .Select(o => new OrderDto
                {
                    Id = o.Id,
                    OrderDate = o.OrderDate,
                    Status = o.Status,
                    Subtotal = o.Subtotal,
                    Tax = o.Tax,
                    Total = o.Total,
                    Notes = o.Notes,
                    Customer = new CustomerDto
                    {
                        Id = o.Customer.Id,
                        Name = o.Customer.Name,
                        Lastname = o.Customer.Lastname
                    },
                    OrderDetails = o.OrderDetails.Select(od => new OrderDetailDto
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
                    }).ToList()
                })
                .ToListAsync();
        }

        public async Task<CreateOrderResponse> AddAsync(CreateOrderRequest request)
        {
            var customer = await _context.Customers.FindAsync(request.CustomerId);
            if (customer == null)
                throw new KeyNotFoundException($"Customer with ID {request.CustomerId} not found");

            var order = new Order
            {
                CustomerId = request.CustomerId,
                ShippingAddressId = request.ShippingAddressId,
                PaymentMethodId = request.PaymentMethodId,
                OrderDate = DateTime.UtcNow,
                Status = OrderStatus.Pending,
                Notes = request.Notes,
                CreatedDate = DateTime.UtcNow
            };

            var orderDetails = new List<OrderDetail>();
            decimal subtotal = 0;

            foreach (var item in request.Items)
            {
                var product = await _context.Products.FindAsync(item.ProductId);
                if (product == null)
                    throw new KeyNotFoundException($"Product with ID {item.ProductId} not found");

                var unitPrice = item.UnitPrice ?? product.UnitPrice;
                var discount = item.Discount ?? 0;
                var itemSubtotal = (unitPrice * item.Quantity) * (1 - discount / 100);

                orderDetails.Add(new OrderDetail
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    UnitPrice = unitPrice,
                    Discount = discount,
                    Subtotal = itemSubtotal,
                    CreatedDate = DateTime.UtcNow
                });

                subtotal += itemSubtotal;
            }

            order.OrderDetails = orderDetails;
            order.Subtotal = subtotal;
            order.Tax = subtotal * 0.16m; // Ejemplo: 16% de impuesto
            order.Total = subtotal + order.Tax;

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return new CreateOrderResponse
            {
                Id = order.Id,
                OrderDate = order.OrderDate,
                Total = order.Total,
                Status = order.Status
            };
        }

        public async Task<bool> UpdateOrderStatusAsync(int id, OrderStatus status)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
                throw new KeyNotFoundException($"Order with ID {id} not found");

            order.Status = status;
            order.ModifiedDate = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> CancelOrderAsync(int id, string reason)
        {
            var order = await _context.Orders
                .Include(o => o.OrderDetails)
                .FirstOrDefaultAsync(o => o.Id == id);

            if (order == null)
                throw new KeyNotFoundException($"Order with ID {id} not found");

            if (order.Status == OrderStatus.Completed)
                throw new InvalidOperationException("Cannot cancel a completed order");

            order.Status = OrderStatus.Cancelled;
            order.Notes = $"Cancelled: {reason}";
            order.ModifiedDate = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return true;
        }

        public Task<OrderDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UpdateOrderResponse> UpdateAsync(int id, UpdateOrderRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteOrderResponse> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDto>> GetOrdersByCustomerAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDto>> GetOrdersByStatusAsync(OrderStatus status)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDto>> GetOrdersByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetailsDto> GetOrderDetailsAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<OrderSummaryDto> GetOrderSummaryAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDto>> GetPendingOrdersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> GetOrderTotalAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDto>> SearchOrdersAsync(OrderSearchRequest searchRequest)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddOrderItemAsync(int orderId, AddOrderItemRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOrderItemAsync(int orderId, int productId, UpdateOrderItemRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveOrderItemAsync(int orderId, int productId)
        {
            throw new NotImplementedException();
        }
    }
}
