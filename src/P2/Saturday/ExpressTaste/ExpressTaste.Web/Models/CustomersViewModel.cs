using ExpressTaste.Web.Models.Entities;

namespace ExpressTaste.Web.Models
{
    public class CustomersViewModel
    {
        public List<Customer> ActiveCustomers { get; set; }
        public List<Customer> AllCustomers { get; set; }
    }
}
