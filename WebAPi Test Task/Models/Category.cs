using System.ComponentModel.DataAnnotations;

namespace WebAPi_Test_Task.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public ICollection<Product>Products { get; set; }
    }
}
