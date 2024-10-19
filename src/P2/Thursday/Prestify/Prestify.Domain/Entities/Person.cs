using System.ComponentModel.DataAnnotations;

namespace Prestify.Domain.Entities
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [StringLength(15)]
        public string? Dni { get; set; }
        [Required(ErrorMessage = "You need to put a value here")]
        [StringLength(50)]
        public string? Name { get; set; }
        [StringLength(50)]
        public string LastNames { get; set; }

        [StringLength(500)]
        public string? Address { get; set; }
        [Phone]
        [StringLength(15)]
        public string? Phone { get; set; }
        [EmailAddress]
        [StringLength(25)] 
        public string? Email { get; set; }
        public bool Deleted { get; set; }
        public List<Customer> Customers { get; set; }
        // public List<Customer> Customers = new List<Customer>();
        //public Person()
        //{
        //    Customers = new List<Customer> { };
        //}

    }
}
