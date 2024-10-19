using System.ComponentModel.DataAnnotations;

namespace Prestify.Domain.Entities
{
    public class Loan
    {
        public int Id { get; set; }
        [StringLength(25)]
        public string LoanNumber { get; set; }
        public decimal Amount { get; set; }
        public int Rate { get; set; }
        public int Term { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndtDate { get; set; }
        //public bool Active { get; set; }
        public bool Inactive { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
