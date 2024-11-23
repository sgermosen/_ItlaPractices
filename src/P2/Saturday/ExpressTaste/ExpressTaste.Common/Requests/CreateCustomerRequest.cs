using ExpressTaste.Common.Dtos;
using ExpressTaste.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ExpressTaste.Common.Requests
{
    public class CreateCustomerRequest
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        public char Gender { get; set; }

        [Required]
        public string TaxId { get; set; }

        public CustomerType CustomerType { get; set; }

        public AddressDto PrimaryAddress { get; set; }
    }
}
