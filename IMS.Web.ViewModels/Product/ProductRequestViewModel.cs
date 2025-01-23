using IMS.Web.ViewModels.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static IMS.Common.ErrorMessageConstants;

namespace IMS.Web.ViewModels.Product
{
    public class ProductRequestViewModel : IProductModel
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = string.Empty;

        public double Price { get; set; }

        public int Count { get; set; }

        public string Description { get; set; } = string.Empty;

        public string SupplierName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Заявена бройка")]
        [Range(1, int.MaxValue, ErrorMessage = "Заявената бройка трябва да бъде поне 1.")]
        public int RequestedCount { get; set; }

        public int EmployeeSiteId { get; set; }
    }
}
