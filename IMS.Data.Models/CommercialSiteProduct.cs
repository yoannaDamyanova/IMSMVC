using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace IMS.Data.Models
{
    public class CommercialSiteProduct
    {
        [Required]
        public int CommercialSiteId { get; set; }

        [Required]
        [ForeignKey(nameof(CommercialSiteId))]
        public CommercialSite CommercialSite { get; set; } = null!;

        [Required]
        public Guid ProductId { get; set; }

        [Required]
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        [Required]
        public int ProductCount { get; set; }
    }
}
