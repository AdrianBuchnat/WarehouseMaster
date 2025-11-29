using System.ComponentModel.DataAnnotations;

namespace WarehouseMaster.models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
