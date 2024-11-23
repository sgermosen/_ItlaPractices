using Prestify.Infrastructure.Models;

namespace Prestify.Infrastructure.Interfaces
{
    public interface ILoanRepository
    {
        Task<bool> Add(LoanModel request);
    }
}