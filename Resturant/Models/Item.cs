﻿namespace Resturant.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public ICollection<OrderItem>OrderItems{ get; set; }

    }
}
