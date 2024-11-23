using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressTaste.Common.Responses
{
    public class UpdateCustomerResponse
    {
        public bool Success { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Message { get; set; }
    }
}
