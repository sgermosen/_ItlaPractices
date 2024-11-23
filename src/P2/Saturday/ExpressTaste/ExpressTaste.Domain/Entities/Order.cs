using ExpressTaste.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace ExpressTaste.Domain.Entities
{

    public class Order : BaseEntity
    {

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [StringLength(500)]
        public string Description { get; set; }

    }
}
