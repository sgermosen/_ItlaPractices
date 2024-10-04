using Prestify.Web.Controllers;
using Prestify.Web.Models.Entities;

namespace Prestify.Web.Models
{
    public class General
    {
        public string Header { get; set; }
        public List<Person> People { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
