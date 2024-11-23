using ExpressTaste.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressTaste.Common.Dtos
{
    public class OrderSummaryDto
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public int ItemCount { get; set; }
        public decimal Total { get; set; }
        public OrderStatus Status { get; set; }
    }
}
