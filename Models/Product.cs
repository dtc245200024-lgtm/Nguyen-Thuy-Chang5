using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Day5.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Phai nhap ten san pham")]
        [StringLength(100)]// gioi han do dai cua ten san pham la 100 ky tu
        public string? ProductName { get; set; }
        [Range(0.01, 1000000000, ErrorMessage = "Gia san pham phai lon hon 0 va nho hon 1000000000")]
        public decimal ProductPrice { get; set; }
        // Foreign key to Category - khoa ngoai
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        // Navigation property - thuoc tinh dieu huong
        public Category? Category { get; set; }
    }
}