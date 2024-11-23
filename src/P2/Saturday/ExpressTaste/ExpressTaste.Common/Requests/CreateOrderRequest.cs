using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressTaste.Common.Requests
{
    public class CreateOrderRequest
    {
        [Required]
        public int CustomerId { get; set; }

        public int? ShippingAddressId { get; set; }

        [Required]
        public int PaymentMethodId { get; set; }

        public string Notes { get; set; }

        [Required]
        public List<OrderItemRequest> Items { get; set; }
    }
}
