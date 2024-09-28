using System.ComponentModel.DataAnnotations;

namespace ExpressTaste.Web.Models.Entities
{

    public class Customer
    {
        [Key]
        public int Id { get; set; }

        
        public string Name { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public char Gender { get; set; }
    }
}
