using EmployeeJet.Infrastructure.Interfaces;
using PaqJet.Domain.Entities;
using PaqJet.Infrastructure.Interfaces;
using PaqJet.Persistence;

namespace PaqJet.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    //: IUnitOfWork
    {
        private readonly PaqJetDbContext _context;
        private ICustomerRepository _customerRepository;
        private IRepository<Customer> _customerRepositoryGen;
        // private IPaqRepository _paqRepository;
        private IEmployeeRepository _employeeRepository;

        public UnitOfWork(PaqJetDbContext context)
        {
            _context = context;
        }

        public IRepository<Customer> CustomerRepositoryGen =>   _customerRepositoryGen ??= new GenericRepository<Customer>(_context);
        public ICustomerRepository CustomerRepository =>   _customerRepository ??= new CustomerRepository(_context);
        //  public IPaqRepository PaqRepository =>   _paqRepository ??= new PaqRepository(_context);
        public IEmployeeRepository EmployeeRepository => _employeeRepository ??= new EmployeeRepository(_context);

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
