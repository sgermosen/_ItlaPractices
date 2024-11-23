using ExpressTaste.Common.Dtos;
using ExpressTaste.Common.Requests;
using ExpressTaste.Common.Responses;
using ExpressTaste.Domain.Entities;
using ExpressTaste.Infraestructure.Interfaces;
using ExpressTaste.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressTaste.Infraestructure.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ExpressTasteDbContext _context;

        public AddressRepository(ExpressTasteDbContext context)
        {
            _context = context;
        }

        public async Task<List<AddressDto>> GetByCustomerIdAsync(int customerId)
        {
            return await _context.Customers
                .Where(c => c.Id == customerId)
                .SelectMany(c => c.Addresses)
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
                .ToListAsync();
        }

        public async Task<bool> SetPrimaryAddressAsync(int addressId, int customerId)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                var customerAddresses = await _context.Customers
                    .Include(c => c.Addresses)
                    .Where(c => c.Id == customerId)
                    .SelectMany(c => c.Addresses)
                    .ToListAsync();

                foreach (var address in customerAddresses)
                {
                    address.IsPrimary = address.Id == addressId;
                    address.ModifiedDate = DateTime.UtcNow;
                }

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
                return true;
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task<CreateAddressResponse> AddAsync(CreateAddressRequest request)
        {
            var customer = await _context.Customers.FindAsync(request.CustomerId);
            if (customer == null)
                throw new KeyNotFoundException($"Customer with ID {request.CustomerId} not found");

            var address = new Address
            {
                Street = request.Street,
                City = request.City,
                State = request.State,
                Country = request.Country,
                PostalCode = request.PostalCode,
                CustomerId = request.CustomerId,
                IsPrimary = request.IsPrimary,
                CreatedDate = DateTime.UtcNow
            };

            if (request.IsPrimary)
            {
                var existingAddresses = await _context.Addresses
                    .Where(a => a.CustomerId == request.CustomerId)
                    .ToListAsync();

                foreach (var existingAddress in existingAddresses)
                {
                    existingAddress.IsPrimary = false;
                    existingAddress.ModifiedDate = DateTime.UtcNow;
                }
            }

            _context.Addresses.Add(address);
            await _context.SaveChangesAsync();

            return new CreateAddressResponse { Id = address.Id };
        }

        public Task<List<AddressDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AddressDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UpdateAddressResponse> UpdateAsync(int id, UpdateAddressRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteAddressResponse> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AddressDto> GetPrimaryAddressAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AddressDto>> GetByPostalCodeAsync(string postalCode)
        {
            throw new NotImplementedException();
        }

        public Task<List<AddressDto>> GetByCityAsync(string city)
        {
            throw new NotImplementedException();
        }
    }
}
