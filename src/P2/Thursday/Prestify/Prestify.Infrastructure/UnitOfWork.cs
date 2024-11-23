using Prestify.Domain.Entities;
using Prestify.Infrastructure.Exceptions;
using Prestify.Infrastructure.Interfaces;
using Prestify.Infrastructure.Repositories;
using Prestify.Persistence;

namespace Prestify.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PrestifyDbContext _context;
        //private IPersonRepository _personRepository;
        //private ILoanRepository _loanRepository;
        private IRepository<Person> _personRepository;
        private IRepository<Loan> _loanRepository;
        public UnitOfWork(PrestifyDbContext context)
        {
            _context = context;
        }

        //public IPersonRepository PersonRepository => _personRepository ??= new PersonRepository(_context);
        //public ILoanRepository LoanRepository => _loanRepository ??= new LoanRepository(_context);
        public IRepository<Person> PersonRepository => _personRepository ??= new GenericRepository<Person>(_context);
        public IRepository<Loan> LoanRepository => _loanRepository ??= new GenericRepository<Loan>(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
