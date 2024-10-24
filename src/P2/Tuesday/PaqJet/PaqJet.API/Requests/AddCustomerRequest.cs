namespace PaqJet.API.Requests
{
    public class AddCustomerRequest
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public char Sex { get; set; }
        public bool IsActive { get; set; }
    }
}
