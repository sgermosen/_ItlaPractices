using System.ComponentModel.DataAnnotations;

namespace ExpressTaste.Web.Models.Entities
{

    public class Order
    {
        [Key]
        public int Id { get; set; } 
        
        public DateTime Date { get; set; }

        public decimal Amount { get; set; } 
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
         
    }
}
