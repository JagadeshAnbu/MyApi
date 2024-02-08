using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApi.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Category { get; set; }

        public string Image { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal NewPrice { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal OldPrice { get; set; }
    }
}
