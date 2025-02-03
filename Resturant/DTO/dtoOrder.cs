namespace Resturant.DTO
{
    using Resturant.Enums;
    public class dtoOrder
    {
        public string Name { get; set; }
        public double TotalPrice { get; set; }
        public OrderStatus orderStatus { get; set; }
        public int UserId { get; set; }
        public int CustomerId { get; set; }
    }
}
