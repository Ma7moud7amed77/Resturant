using System.ComponentModel.DataAnnotations.Schema;

namespace Resturant.Models
{
    public class Table
    {
        public int Id { get; set; }
        public string status { get; set; }
        public int Capacity { get; set; }
        public ICollection <Order>Orders{ get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
