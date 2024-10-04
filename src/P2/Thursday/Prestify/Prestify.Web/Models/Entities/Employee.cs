using System.ComponentModel.DataAnnotations;

namespace Prestify.Web.Models.Entities
{
    public class Employee
    {
        //public string Dni { get; set; } 
        //public string Name { get; set; }
        //public string LastName { get; set; }
        //public string Address { get; set; }
        //public string Phone { get; set; }
        //public string Email { get; set; }
        [StringLength(100)]
        public string Position { get; set; }
        public int Id { get; set; }
        public List<Loan> Loans { get; set; }

    }
}
