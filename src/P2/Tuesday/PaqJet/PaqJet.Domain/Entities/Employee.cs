using PaqJet.Domain.Core;

namespace PaqJet.Domain.Entities
{
    public class Employee: BaseEntity
    { 
        public string Name { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
    }
}
