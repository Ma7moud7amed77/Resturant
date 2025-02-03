using System.Text.Json.Serialization;

namespace Resturant.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        [JsonIgnore]
        public ICollection<Order>? orders { get; set; }
        [JsonIgnore]
        public ICollection<Table> Tables { get; set; }
    }
}
