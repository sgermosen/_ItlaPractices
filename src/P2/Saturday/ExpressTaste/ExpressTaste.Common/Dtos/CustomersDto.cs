using ExpressTaste.Domain.Entities;

namespace ExpressTaste.API.Dtos
{
    public class CustomersDto
    {
        public List<Customer> ActiveCustomers { get; set; }
        public List<Customer> AllCustomers { get; set; }
    }
}
