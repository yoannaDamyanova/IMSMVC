using IMS.Web.ViewModels.Contracts;
using System.ComponentModel.DataAnnotations;
using static IMS.Common.ErrorMessageConstants;
using static IMS.Common.EntityValidationConstants.Product;
using IMS.Web.ViewModels.Category;
using IMS.Web.ViewModels.Supplier;
using Microsoft.AspNetCore.Http;
using System.Resources;
using IMS.Common;

namespace IMS.Web.ViewModels.Product
{
    public class ProductFormModel : IProductModel
    {
        public string? Id { get; set; }
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(MaxTitleLength,
            MinimumLength = MinTitleLength,
            ErrorMessage = LengthMessage)]
        public string Name { get; set ; } = null!;
        [Required(ErrorMessage = RequiredMessage)]
        [Range(MinPrice, MaxPrice, ErrorMessage = PriceErrorMessage)]
        public double Price { get; set; }
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(MaxDescriptionLength,
            MinimumLength = MinDescriptionLength,
            ErrorMessage = LengthMessage)]
        public string Description { get; set; } = null!;
        [Required(ErrorMessage = RequiredMessage)]
        [Range(MinCount, MaxCount)]
        public int Count { get; set; }
        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Катеогория")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Производител")]
        public int SupplierId { get; set; }
        [Required(ErrorMessage = RequiredMessage)]
        [DataType(DataType.Upload)]
        public IFormFile PhotoFileName { get; set; } = null!;
        public IEnumerable<CategoryServiceModel> Categories { get; set; } = new HashSet<CategoryServiceModel>();
        public IEnumerable<SupplierServiceModel> Suppliers { get; set; } = new HashSet<SupplierServiceModel>();
    }
}
