using System.ComponentModel.DataAnnotations;
using DAY5.Models;
namespace Day5.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string? CategoryName { get; set; }
        // Navigation property - thuoc tinh dieu huong
        public ICollection<Product>? Products { get; set; } // hoac cos the su dung List<Product> thay vi ICollection<Product>
    }
}