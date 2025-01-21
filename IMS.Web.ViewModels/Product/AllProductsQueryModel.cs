using IMS.Web.Infrastructure.Enumerations;
using IMS.Web.ViewModels.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Web.ViewModels.Product
{
    public class AllProductsQueryModel
    {
        public int ProductsPerPage { get; set; } = 5;

        public string Category { get; init; } = null!;

        public string SearchTerm { get; set; } = null!;

        public ProductSorting Sorting { get; init; }

        public int CurrentPage { get; init; } = 1;

        public int TotalProductsCount { get; set; }

        public IEnumerable<string> Categories { get; set; } = null!;

        public IEnumerable<ProductServiceModel> Products { get; set; } = new List<ProductServiceModel>();

        public IEnumerable<string> Suppliers { get; set; } = null!;

        public string Supplier { get; init; } = null!;
    }
}
