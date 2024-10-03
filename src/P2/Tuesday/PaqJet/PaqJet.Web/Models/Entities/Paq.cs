namespace PaqJet.Web.Models.Entities
{
    public class Paq
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public decimal Pounds { get; set; }
        public decimal Price { get; set; }
        public decimal DeclaredValue { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int CustumerId { get; set; }
        public Customer Customer { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
