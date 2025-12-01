using System.ComponentModel.DataAnnotations;

namespace WarehouseMaster.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Name { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
