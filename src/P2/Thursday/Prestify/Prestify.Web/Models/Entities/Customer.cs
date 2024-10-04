using System.ComponentModel.DataAnnotations;

namespace Prestify.Web.Models.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Job { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public List<Loan> Loans { get; set; }

    }
}
