namespace Resturant.Models
{
    using Resturant.Enums;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Order
    {
       
            public int Id { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public double TotalPrice { get; set; }
            public OrderStatus orderStatus { get; set; }
            public DateTime CreatedAt { get; set; } = DateTime.Now;


        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public Customer?  Customer { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("Table")]
        public int TableId { get; set; }
        public Table Table { get; set; }
        public ICollection<OrderItem>OrderItems { get; set; }
        [ForeignKey("Delivery")]
        public int DeliveryId { get; set; }
        public Delivery Delivery { get; set; }


    }
}
