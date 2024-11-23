using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressTaste.Common.Dtos
{
    public class CustomerOrdersDto
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public List<OrderDto> Orders { get; set; }
        public decimal TotalSpent { get; set; }
        public int TotalOrders { get; set; }
    }
}
