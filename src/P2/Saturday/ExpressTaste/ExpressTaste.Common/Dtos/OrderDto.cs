using ExpressTaste.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressTaste.Common.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public OrderStatus Status { get; set; }
        public string Notes { get; set; }
        public CustomerDto Customer { get; set; }
        public AddressDto ShippingAddress { get; set; }
        public PaymentMethodDto PaymentMethod { get; set; }
        public List<OrderDetailDto> OrderDetails { get; set; }
    }
}
