using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressTaste.Common.Responses
{
    public class AddCustomerAddressResponse
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string FullAddress { get; set; }
        public bool IsPrimary { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
