using ExpressTaste.Domain.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpressTaste.Domain.Entities
{
   // [Table("CUSTOMERS")]
    public class Customer: BaseEntity
    {
        //[Key]
        //public int Id { get; set; }

        [StringLength(50)] 
        public string Name { get; set; }

        [StringLength(50)]
       // [Column("LAST_NAME")] 
        public string Lastname { get; set; }

        [StringLength(25)]
        [EmailAddress]
       // [Column ("EMAIL")]
        public string Email { get; set; }

        [StringLength(15)]
        [Phone]
        public string Phone { get; set; }

        public bool IsActive { get; set; }

        public char Gender { get; set; }

        public List<Order> Orders { get; set; }
    }
}
