using ExpressTaste.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace ExpressTaste.Domain.Entities
{
    public class PaymentMethod : BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
