using PaqJet.Domain.Core;

namespace PaqJet.Infrastructure.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> Get();
        Task<T> GetById(int id);
        Task<T> Add(T request);
        Task<bool> UpdateCustomer(T request);
    }
}
