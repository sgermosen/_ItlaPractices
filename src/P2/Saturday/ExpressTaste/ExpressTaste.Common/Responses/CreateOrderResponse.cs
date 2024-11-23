using ExpressTaste.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressTaste.Common.Responses
{
    public class CreateOrderResponse
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public OrderStatus Status { get; set; }
    }
}
