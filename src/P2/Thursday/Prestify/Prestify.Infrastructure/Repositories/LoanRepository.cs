using Prestify.Domain.Entities;
using Prestify.Infrastructure.Interfaces;
using Prestify.Infrastructure.Models;
using Prestify.Infrastructure.Repositories;
using Prestify.Persistence;

namespace Prestify.Infrastructure.Exceptions
{
    public class LoanRepository : GenericRepository<Loan> // IRepository<Loan> //ILoanRepository
    {
        private readonly PrestifyDbContext _context;

        public LoanRepository(PrestifyDbContext context) : base(context)
        {
        }


        public async Task<bool> Add(LoanModel request)
        {
            var loanDb = new Loan();
            loanDb.LoanNumber = request.LoanNumber;
            //rest of fields 

            _context.Loans.Add(loanDb);
            return true;
        }

        //public async Task<bool> Add(Loan entity)
        //{
        //    var loanDb = new Loan();
        //    loanDb.LoanNumber = entity.LoanNumber;
        //    //rest of fields 

        //    _context.Loans.Add(loanDb);
        //    return true;
        //}

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Loan> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Loan entity)
        {
            throw new NotImplementedException();
        }
    }
}
