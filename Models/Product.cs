
using System.Collections.Generic;

namespace bluemodas.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int? Quantity { get; set; }
        public decimal Price { get; set; }
        public int Rating  { get; set; }       
        public string Image { get; set; }              
       
    }
}
