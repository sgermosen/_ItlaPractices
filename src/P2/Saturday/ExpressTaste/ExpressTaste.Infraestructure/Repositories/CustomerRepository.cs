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
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ExpressTasteDbContext _context;

        public CustomerRepository(ExpressTasteDbContext context)
        {
            _context = context;
        }

        public async Task<List<CustomerDto>> GetAllAsync()
        {
            var customers = await _context.Customers
                .Include(c => c.Addresses.Where(a => a.IsPrimary))
                .AsNoTracking()
                .Select(c => new CustomerDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Lastname = c.Lastname,
                    Email = c.Email,
                    Phone = c.Phone,
                    Gender = c.Gender,
                    TaxId = c.TaxId,
                    CustomerType = c.CustomerType,
                    IsActive = c.IsActive,
                    CreatedDate = c.CreatedDate,
                    ModifiedDate = c.ModifiedDate,
                    PrimaryAddress = c.Addresses
                        .Where(a => a.IsPrimary)
                        .Select(a => new AddressDto
                        {
                            Id = a.Id,
                            Street = a.Street,
                            City = a.City,
                            State = a.State,
                            Country = a.Country,
                            PostalCode = a.PostalCode,
                            IsPrimary = a.IsPrimary
                        })
                        .FirstOrDefault()
                })
                .ToListAsync();

            return customers;
        }

        public async Task<CustomerDto> GetByIdAsync(int id)
        {
            var customer = await _context.Customers
                .Include(c => c.Addresses.Where(a => a.IsPrimary))
                .AsNoTracking()
                .Select(c => new CustomerDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Lastname = c.Lastname,
                    Email = c.Email,
                    Phone = c.Phone,
                    Gender = c.Gender,
                    TaxId = c.TaxId,
                    CustomerType = c.CustomerType,
                    IsActive = c.IsActive,
                    CreatedDate = c.CreatedDate,
                    ModifiedDate = c.ModifiedDate,
                    PrimaryAddress = c.Addresses
                        .Where(a => a.IsPrimary)
                        .Select(a => new AddressDto
                        {
                            Id = a.Id,
                            Street = a.Street,
                            City = a.City,
                            State = a.State,
                            Country = a.Country,
                            PostalCode = a.PostalCode,
                            IsPrimary = a.IsPrimary
                        })
                        .FirstOrDefault()
                })
                .FirstOrDefaultAsync(c => c.Id == id);

            if (customer == null)
                throw new KeyNotFoundException($"Customer with ID {id} not found");

            return customer;
        }

        public async Task<CreateCustomerResponse> AddAsync(CreateCustomerRequest request)
        {
            if (await _context.Customers.AnyAsync(c => c.Email == request.Email))
                throw new InvalidOperationException("Email already exists");

            if (await _context.Customers.AnyAsync(c => c.TaxId == request.TaxId))
                throw new InvalidOperationException("TaxId already exists");

            var customer = new Customer
            {
                Name = request.Name,
                Lastname = request.Lastname,
                Email = request.Email,
                Phone = request.Phone,
                Gender = request.Gender,
                TaxId = request.TaxId,
                CustomerType = request.CustomerType,
                IsActive = true,
                CreatedDate = DateTime.UtcNow
            };

            if (request.PrimaryAddress != null)
            {
                customer.Addresses = new List<Address>
            {
                new Address
                {
                    Street = request.PrimaryAddress.Street,
                    City = request.PrimaryAddress.City,
                    State = request.PrimaryAddress.State,
                    Country = request.PrimaryAddress.Country,
                    PostalCode = request.PrimaryAddress.PostalCode,
                    IsPrimary = true,
                    CreatedDate = DateTime.UtcNow
                }
            };
            }

            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return new CreateCustomerResponse
            {
                Id = customer.Id,
                FullName = $"{customer.Name} {customer.Lastname}",
                CreatedDate = customer.CreatedDate
            };
        }

        public async Task<UpdateCustomerResponse> UpdateAsync(int id, UpdateCustomerRequest request)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
                throw new KeyNotFoundException($"Customer with ID {id} not found");

            if (request.Email != null && request.Email != customer.Email)
            {
                if (await _context.Customers.AnyAsync(c => c.Email == request.Email))
                    throw new InvalidOperationException("Email already exists");
                customer.Email = request.Email;
            }

            if (request.TaxId != null && request.TaxId != customer.TaxId)
            {
                if (await _context.Customers.AnyAsync(c => c.TaxId == request.TaxId))
                    throw new InvalidOperationException("TaxId already exists");
                customer.TaxId = request.TaxId;
            }

            if (request.Name != null) customer.Name = request.Name;
            if (request.Lastname != null) customer.Lastname = request.Lastname;
            if (request.Phone != null) customer.Phone = request.Phone;
            if (request.Gender.HasValue) customer.Gender = request.Gender.Value;
            if (request.CustomerType.HasValue) customer.CustomerType = request.CustomerType.Value;
            if (request.IsActive.HasValue) customer.IsActive = request.IsActive.Value;

            customer.ModifiedDate = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return new UpdateCustomerResponse
            {
                Success = true,
                ModifiedDate = customer.ModifiedDate,
                Message = "Customer updated successfully"
            };
        }

        public async Task<DeleteCustomerResponse> DeleteAsync(int id)
        {
            var customer = await _context.Customers
                .Include(c => c.Orders)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (customer == null)
                throw new KeyNotFoundException($"Customer with ID {id} not found");

            if (customer.Orders.Any())
            {
                customer.IsActive = false;
                customer.ModifiedDate = DateTime.UtcNow;
                await _context.SaveChangesAsync();

                return new DeleteCustomerResponse
                {
                    Success = true,
                    Message = "Customer has been deactivated due to existing orders"
                };
            }

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return new DeleteCustomerResponse
            {
                Success = true,
                Message = "Customer has been deleted successfully"
            };
        }

        // Implementación de métodos específicos
        public async Task<List<CustomerDto>> GetActiveCustomersAsync()
        {
            return await _context.Customers
                .Where(c => c.IsActive)
                .Select(c => new CustomerDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Lastname = c.Lastname,
                    Email = c.Email,
                    Phone = c.Phone,
                    Gender = c.Gender,
                    TaxId = c.TaxId,
                    CustomerType = c.CustomerType,
                    IsActive = c.IsActive,
                    CreatedDate = c.CreatedDate,
                    ModifiedDate = c.ModifiedDate
                })
                .ToListAsync();
        }

        public async Task<CustomerOrdersDto> GetCustomerOrdersAsync(int customerId)
        {
            var customer = await _context.Customers
                .Include(c => c.Orders)
                    .ThenInclude(o => o.OrderDetails)
                        .ThenInclude(od => od.Product)
                .FirstOrDefaultAsync(c => c.Id == customerId);

            if (customer == null)
                throw new KeyNotFoundException($"Customer with ID {customerId} not found");

            return new CustomerOrdersDto
            {
                CustomerId = customer.Id,
                CustomerName = $"{customer.Name} {customer.Lastname}",
                Orders = customer.Orders.Select(o => new OrderDto
                {
                    Id = o.Id,
                    OrderDate = o.OrderDate,
                    Status = o.Status,
                    Total = o.Total,
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
                }).ToList()
            };
        }

        public async Task<CustomerStatisticsDto> GetCustomerStatisticsAsync(int customerId)
        {
            var customer = await _context.Customers
                .Include(c => c.Orders)
                .FirstOrDefaultAsync(c => c.Id == customerId);

            if (customer == null)
                throw new KeyNotFoundException($"Customer with ID {customerId} not found");

            return new CustomerStatisticsDto
            {
                TotalOrders = customer.Orders.Count,
                TotalSpent = customer.Orders.Sum(o => o.Total),
                LastOrderDate = customer.Orders.Max(o => o.OrderDate),
                AverageOrderValue = customer.Orders.Any()
                    ? customer.Orders.Average(o => o.Total)
                    : 0
            };
        }

        public Task<List<CustomerDto>> GetCustomersByTypeAsync(CustomerType type)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerAddressesDto> GetCustomerAddressesAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDto> GetCustomerByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDto> GetCustomerByTaxIdAsync(string taxId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsByTaxIdAsync(string taxId)
        {
            throw new NotImplementedException();
        }

        public Task<List<CustomerDto>> SearchCustomersAsync(CustomerSearchRequest searchRequest)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCustomerStatusAsync(int id, bool isActive)
        {
            throw new NotImplementedException();
        }

        public Task<AddCustomerAddressResponse> AddCustomerAddressAsync(int customerId, AddCustomerAddressRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SetPrimaryAddressAsync(int customerId, int addressId)
        {
            throw new NotImplementedException();
        }
    }
}
