using System.ComponentModel.DataAnnotations;
using static IMS.Common.EntityValidationConstants.Category;

namespace IMS.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;
    }
}
