using IMS.Web.ViewModels.Product;
using IMS.Web.ViewModels.Category;
using IMS.Data.Models;
using IMS.Web.ViewModels.Supplier;
using IMS.Web.Infrastructure.Enumerations;

namespace IMS.Services.Data.Contracts
{
    public interface IProductService
    {
        Task AddProductAsync(ProductFormModel model);

        Task<IEnumerable<CategoryServiceModel>> AllCategoriesAsync();
        Task<IEnumerable<SupplierServiceModel>> AllSuppliersAsync();

        Task<IEnumerable<string>> AllCategoriesNamesAsync();

        Task<bool> CategoryExistsAsync(int categoryId);

        Task DeleteAsync(Guid productId);

        Task EditAsync(ProductFormModel model, string productId);

        Task<bool> ExistsAsync(Guid id);

        Task<ProductDetailsServiceModel> ProductDetailsByIdAsync(Guid id);

        Task<Product> GetByIdAsync(Guid productId);

        Task<ProductFormModel?> GetProductFormModelByIdAsync(string id);

        Task<IEnumerable<ProductIndexServiceModel>> LastSevenProductsAsync();

        Task<IEnumerable<string>> AllSuppliersNamesAsync();

        Task<ProductQueryServiceModel> AllAsync(string? category = null,
            string? supplier = null,
            string? searchTerm = null,
            ProductSorting sorting = ProductSorting.PriceAscending,
            int currentPage = 1,
            int classesPerPage = 1);

        Task RequestProductAsync(ProductRequestViewModel model);

        Task<int> AllProductsCountAsync();

        Task<double> SumProductPricesAsync();
    }
}
