using Microsoft.EntityFrameworkCore;
using Prestify.Infrastructure.Interfaces;
using Prestify.Persistence;

namespace Prestify.Infrastructure.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly PrestifyDbContext _context;

        public GenericRepository(PrestifyDbContext context)
        {
            this._context = context;
        }
        public async Task<bool> Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return true;
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();

        }
        public Task<T> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
