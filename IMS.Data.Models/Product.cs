using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static IMS.Common.EntityValidationConstants.Product;

namespace IMS.Data.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(MaxTitleLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(MinCount, MaxCount)]
        public int Count { get; set; }

        [Required]
        [Range(MinPrice, MaxPrice)]
        public double Price { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string ImgPath { get; set; } = null!;

        [Required]
        public int SupplierId { get; set; }

        [Required]
        [ForeignKey(nameof(SupplierId))]
        public Supplier Supplier { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; } = null!;

        public bool IsAvailbale { get; set; } = true;
    }
}
