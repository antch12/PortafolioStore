using System.Collections.ObjectModel;

namespace Core.Models
{
    public class Product
    {
        public int? ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Price { get; set; }
        public int? Fk_CategoryId { get; set; }
    }
}
