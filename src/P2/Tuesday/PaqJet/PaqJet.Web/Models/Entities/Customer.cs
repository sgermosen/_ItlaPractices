using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaqJet.Web.Models.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        public int Age { get; set; }
        public char Sex { get; set; }
        public bool IsActive { get; set; }

        public List<Paq> Paqs { get; set; }

    }
}
