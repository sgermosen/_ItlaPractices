using ExpressTaste.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressTaste.Common.Responses
{
    public class UpdateOrderResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public OrderStatus CurrentStatus { get; set; }
    }
}
