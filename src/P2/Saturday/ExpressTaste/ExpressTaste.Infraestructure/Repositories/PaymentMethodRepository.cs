using ExpressTaste.Common.Dtos;
using ExpressTaste.Common.Requests;
using ExpressTaste.Common.Responses;
using ExpressTaste.Domain.Entities;
using ExpressTaste.Infraestructure.Interfaces;
using ExpressTaste.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ExpressTaste.Infraestructure.Repositories
{
    public class PaymentMethodRepository : IPaymentMethodRepository
    {
        private readonly ExpressTasteDbContext _context;

        public PaymentMethodRepository(ExpressTasteDbContext context)
        {
            _context = context;
        }

        public async Task<List<PaymentMethodDto>> GetAllAsync()
        {
            return await _context.PaymentMethods
                .Select(p => new PaymentMethodDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    IsActive = p.IsActive
                })
                .ToListAsync();
        }

        public async Task<List<PaymentMethodDto>> GetActivePaymentMethodsAsync()
        {
            return await _context.PaymentMethods
                .Where(p => p.IsActive)
                .Select(p => new PaymentMethodDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    IsActive = p.IsActive
                })
                .ToListAsync();
        }

        public async Task<CreatePaymentMethodResponse> AddAsync(CreatePaymentMethodRequest request)
        {
            var paymentMethod = new PaymentMethod
            {
                Name = request.Name,
                Description = request.Description,
                IsActive = true,
                CreatedDate = DateTime.UtcNow
            };

            _context.PaymentMethods.Add(paymentMethod);
            await _context.SaveChangesAsync();

            return new CreatePaymentMethodResponse { Id = paymentMethod.Id };
        }

        public async Task<bool> UpdateStatusAsync(int id, bool isActive)
        {
            var paymentMethod = await _context.PaymentMethods.FindAsync(id);
            if (paymentMethod == null)
                throw new KeyNotFoundException($"Payment method with ID {id} not found");

            paymentMethod.IsActive = isActive;
            paymentMethod.ModifiedDate = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return true;
        }

        public Task<PaymentMethodDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }



        public Task<UpdatePaymentMethodResponse> UpdateAsync(int id, UpdatePaymentMethodRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeletePaymentMethodResponse> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PaymentMethodDto>> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }




    }
}
