using ExpressTaste.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace ExpressTaste.Domain.Entities
{
    public class Customer : BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Lastname { get; set; }

        [StringLength(25)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(15)]
        [Phone]
        public string Phone { get; set; }

        public bool IsActive { get; set; }

        public char Gender { get; set; }

        public List<Order> Orders { get; set; }
    }
}
