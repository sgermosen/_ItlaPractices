using ExpressTaste.Domain.Core;
using ExpressTaste.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpressTaste.Domain.Entities
{

    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Subtotal { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Tax { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        public OrderStatus Status { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        public int CustomerId { get; set; }
        public int? ShippingAddressId { get; set; }
        public int PaymentMethodId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Address ShippingAddress { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
