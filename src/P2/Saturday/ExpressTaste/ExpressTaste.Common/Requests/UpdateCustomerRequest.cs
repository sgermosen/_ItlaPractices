using ExpressTaste.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressTaste.Common.Requests
{
    public class UpdateCustomerRequest
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Lastname { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        public char? Gender { get; set; }
        public string TaxId { get; set; }
        public CustomerType? CustomerType { get; set; }
        public bool? IsActive { get; set; }
    }
}
