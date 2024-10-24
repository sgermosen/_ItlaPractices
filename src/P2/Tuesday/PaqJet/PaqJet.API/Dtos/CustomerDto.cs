using System.ComponentModel.DataAnnotations;

namespace PaqJet.Web.Models
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public char Sex { get; set; }
        public bool IsActive { get; set; }
    }
}
