using ExpressTaste.Domain.Core;

namespace ExpressTaste.Domain.Entities
{
    public class OrderDetail: BaseEntity
    {
        //public int Id { get; set; }
        public string itemDescription { get; set; }
    }
}
