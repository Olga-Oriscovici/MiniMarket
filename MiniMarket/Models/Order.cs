using System.ComponentModel.DataAnnotations;

namespace MiniMarket.Models
{
    public class Order
    {
        public int Id { get; set; }
       
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
       
        public DateTime? CreatedDate { get; set; }
    }
}
