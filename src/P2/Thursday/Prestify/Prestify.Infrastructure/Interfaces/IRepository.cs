namespace Prestify.Infrastructure.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<bool> Delete(int id);
        Task<bool> Update(T entity);
        Task<bool> Add(T entity);
    }
}
