using ExpressTaste.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressTaste.Common.Requests
{
    public class UpdateOrderRequest
    {
        public OrderStatus? Status { get; set; }
        public string Notes { get; set; }
        public int? ShippingAddressId { get; set; }
        public List<OrderItemRequest> Items { get; set; }
    }
}
