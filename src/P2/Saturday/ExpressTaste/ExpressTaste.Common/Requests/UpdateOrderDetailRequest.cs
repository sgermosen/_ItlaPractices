using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressTaste.Common.Requests
{
    public class UpdateOrderDetailRequest
    {
        [Range(1, int.MaxValue)]
        public int? Quantity { get; set; }

        [Range(0, double.MaxValue)]
        public decimal? UnitPrice { get; set; }

        [Range(0, 100)]
        public decimal? Discount { get; set; }
    }
}
