using PaqJet.Domain.Entities;

namespace PaqJet.Infrastructure.Models
{
    public class PaqModel
    {
        public string Address { get; set; }
        public decimal Pounds { get; set; }
        public decimal Price { get; set; }
        public decimal DeclaredValue { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public StatusModel Status { get; set; }
        public int CustumerId { get; set; }
        public CustomerModel Customer { get; set; }
        public int EmployeeId { get; set; }
        public EmployeeModel Employee { get; set; }
    }
}
