using System.ComponentModel.DataAnnotations.Schema;

namespace Resturant.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        [ForeignKey("Item")]
        public int ItemId { get; set; }
        public Item Item { get; set; }

        
        public int Quantity { get; set; }
        
        

    }
}
