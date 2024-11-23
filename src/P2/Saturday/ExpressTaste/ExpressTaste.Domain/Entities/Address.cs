using ExpressTaste.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace ExpressTaste.Domain.Entities
{
    public class Address : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Street { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string State { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        [Required]
        [StringLength(10)]
        public string PostalCode { get; set; }

        public bool IsPrimary { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
