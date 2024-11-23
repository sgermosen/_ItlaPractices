using ExpressTaste.Domain.Core;
using ExpressTaste.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace ExpressTaste.Domain.Entities
{
    public class Customer : BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(15)]
        [Phone]
        public string Phone { get; set; }

        public char Gender { get; set; }

        [Required]
        [StringLength(20)]
        public string TaxId { get; set; }

        public CustomerType CustomerType { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
