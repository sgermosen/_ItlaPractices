using ExpressTaste.Domain.Enums;

namespace ExpressTaste.Common.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public char Gender { get; set; }
        public string TaxId { get; set; }
        public CustomerType CustomerType { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public AddressDto PrimaryAddress { get; set; }
    }
}
