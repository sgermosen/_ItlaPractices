using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressTaste.Common.Dtos
{
    public class CustomerAddressesDto
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public AddressDto PrimaryAddress { get; set; }
        public List<AddressDto> OtherAddresses { get; set; }
    }
}
