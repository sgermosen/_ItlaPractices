using PaqJet.Domain.Entities;

namespace PaqJet.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        ICustomerRepository CustomerRepository { get; }
        IRepository<Employee> CustomerRepositorYGen { get; }
        IEmployeeRepository EmployeeRepository { get; }
        Task<int> CommitAsync();
    }
}
