using Microsoft.EntityFrameworkCore;
using PaqJet.Domain.Core;
using PaqJet.Infrastructure.Interfaces;
using PaqJet.Persistence;

namespace EmployeeJet.Infrastructure.Interfaces
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {

        private readonly PaqJetDbContext _context;

        public GenericRepository(PaqJetDbContext context)
        {
            _context = context;
        }

        async Task<List<T>> IRepository<T>.Get()
        {
            return await _context.Set<T>().ToListAsync();
        }

        async Task<T> IRepository<T>.GetById(int id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(p => p.Id == id);
        }

        public Task<T> Add(T request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCustomer(T request)
        {
            throw new NotImplementedException();
        }
    }
}
