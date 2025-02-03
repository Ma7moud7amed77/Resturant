using System.ComponentModel.DataAnnotations.Schema;

namespace Resturant.Models
{
    public class Delivery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ExperienceYears { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<Order>Orders  { get; set; }
        
    }
}
