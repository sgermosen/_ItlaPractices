using Prestify.Domain.Entities;

namespace Prestify.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        //ILoanRepository LoanRepository { get; }
        //IPersonRepository PersonRepository { get; }
        IRepository<Person> PersonRepository { get; }
        IRepository<Loan> LoanRepository { get; }

        Task<int> CommitAsync();
        void Dispose();
    }
}