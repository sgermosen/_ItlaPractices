namespace PaqJet.Infrastructure.Models
{
    public class EmployeeModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public int Id { get; internal set; }
    }
}
