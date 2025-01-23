using IMS.Data.Models;
using IMS.Data.Repository.Contracts;
using IMS.Services.Data.Contracts;
using IMS.Web.ViewModels.Product;
using IMS.Web.ViewModels.Category;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Text.RegularExpressions;
using IMS.Web.ViewModels.Supplier;
using IMS.Web.Infrastructure.Enumerations;

namespace IMS.Services.Data
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IRepository repository;
        private readonly ICommercialsiteProductService commercialsiteProductService;

        public ProductService(IRepository _repository, ICommercialsiteProductService commercialsiteProductService)
        {
            repository = _repository;
            this.commercialsiteProductService = commercialsiteProductService;
        }

        public async Task<Guid> AddProductAsync(ProductFormModel model)
        {
            Product product = new Product()
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                Count = model.Count,
                CategoryId = model.CategoryId,
                SupplierId = model.SupplierId,
            };

            await repository.AddAsync(product);
            await repository.SaveChangesAsync();
            return product.Id;
        }

        public async Task<IEnumerable<CategoryServiceModel>> AllCategoriesAsync()
        {
            return await repository.AllReadOnly<Category>()
                .Select(c => new CategoryServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<string>> AllCategoriesNamesAsync()
        {
            return await repository.AllReadOnly<Category>()
                .Select(c => c.Name)
                .Distinct()
                .ToListAsync();
        }

        public async Task<bool> CategoryExistsAsync(int categoryId)
        {
            return await repository.AllReadOnly<Category>()
                .AnyAsync(c => c.Id == categoryId);
        }

        public async Task DeleteAsync(Guid productId)
        {
            await repository.DeleteAsync<Product>(productId);
            await repository.SaveChangesAsync();
        }

        public async Task EditAsync(ProductFormModel model, string productId)
        {
            Guid id = Guid.Empty;
            IsGuidValid(productId, ref id);
            var product = await repository.GetByIdAsync<Product>(id);

            if (product != null)
            {
                product.Name = model.Name;
                product.Description = model.Description;
                product.CategoryId = model.CategoryId;
                product.Price = model.Price;
                product.Count = model.Count;
                product.SupplierId = model.SupplierId;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            bool reuslt = await repository.AllReadOnly<Product>()
                .AnyAsync(p => p.Id == id);

            return reuslt;
        }

        public async Task<ProductDetailsServiceModel> ProductDetailsByIdAsync(Guid id)
        {
            var product = await repository.AllReadOnly<Product>()
                .Include(p => p.Supplier)
                .FirstOrDefaultAsync(fc => fc.Id == id);

            return product == null
                ? throw new InvalidOperationException("This product doesn't exist!")
                : await repository.AllReadOnly<Product>()
                .Where(p => p.Id == id)
                .Select(p => new ProductDetailsServiceModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    SupplierName = p.Supplier.Name,
                    Price = p.Price,
                    Count = p.Count
                })
                .FirstAsync();
        }

        public async Task<Product> GetByIdAsync(Guid productId)
        {
            return await repository.GetByIdAsync<Product>(productId);
        }

        public async Task<ProductFormModel?> GetProductFormModelByIdAsync(string id)
        {
            return await repository.AllReadOnly<Product>()
                .Where(p => p.Id.ToString() == id)
                .Select(p => new ProductFormModel()
                {
                    Id = p.Id.ToString(),
                    Name = p.Name,
                    Description = p.Description,
                    CategoryId = p.CategoryId,
                    Count = p.Count,
                    Price = p.Price,
                    SupplierId = p.SupplierId
                })
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<ProductIndexServiceModel>> LastSevenProductsAsync()
        {
            var products = await repository.AllReadOnly<Product>()
                .Where(p => p.Count > 0)
                .Take(5)
                .Select(p => new ProductIndexServiceModel()
                {
                    Id = p.Id.ToString(),
                    Name = p.Name,
                    Price = p.Price,
                })
                .ToListAsync();

            return products;
        }

        public async Task<IEnumerable<string>> AllSuppliersNamesAsync()
        {
            return await repository.AllReadOnly<Supplier>()
                .Select(s => s.Name)
                .ToListAsync();
        }

        public async Task<IEnumerable<SupplierServiceModel>> AllSuppliersAsync()
        {
            return await repository.AllReadOnly<Supplier>()
                .Select(s => new SupplierServiceModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                })
                .ToListAsync();
        }

        public async Task<ProductQueryServiceModel> AllAsync(string? category = null,
            string? status = null,
            string? searchTerm = null,
            ProductSorting sorting = ProductSorting.PriceAscending,
            int currentPage = 1,
            int classesPerPage = 1)
        {
            var classesToShow = await repository.AllReadOnly<Product>()
                .Where(p => p.IsAvailbale == true)
                .Include(p => p.Supplier)
                .Include(p => p.Category)
                .ToListAsync();

            if (category != null)
            {
                classesToShow = classesToShow.Where(c => c.Category.Name == category).ToList();
            }

            if (searchTerm != null)
            {
                string normalizedSearchTerm = searchTerm.ToLower();
                classesToShow = classesToShow
                    .Where(c => (c.Name.ToLower().Contains(normalizedSearchTerm)) ||
                                c.Supplier.Name.ToString().Contains(normalizedSearchTerm) ||
                                c.Category.Name.ToString().Contains(normalizedSearchTerm)).ToList();
            }

            classesToShow = sorting switch
            {
                ProductSorting.PriceAscending => classesToShow.OrderBy(c => c.Price).ToList(),
                ProductSorting.PriceDescending => classesToShow.OrderByDescending(c => c.Price).ToList(),
                ProductSorting.CountAscening => classesToShow.OrderBy(c => c.Count).ToList(),
                ProductSorting.CountDescening => classesToShow.OrderByDescending(c => c.Count).ToList(),
                _ => classesToShow.OrderByDescending(c => c.Id).ToList(),
            };

            var products = classesToShow
                .Skip((currentPage - 1) * classesPerPage)
                .Take(classesPerPage)
                .Select(c => new ProductServiceModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Count = c.Count,
                    Price = c.Price,
                }).ToList();

            int totalProducts = classesToShow.Count;

            return new ProductQueryServiceModel()
            {
                Products = products,
                TotalProductsCount = totalProducts,
            };
        }

        public async Task RequestProductAsync(ProductRequestViewModel model)
        {
            Guid id = Guid.Empty;
            IsGuidValid(model.Id, ref id);
            var product = await repository.All<Product>()
                .FirstOrDefaultAsync(p => p.Id == id);

            if (model.Count - model.RequestedCount == 0)
            {
                product.IsAvailbale = false;
            }

            product.Count -= model.RequestedCount;

            if (await commercialsiteProductService.ExistsById(model.Id))
            {
                var siteProduct = await commercialsiteProductService.GetById(model.Id);

                siteProduct.ProductCount += model.RequestedCount;
            }
            else 
            {
                CommercialSiteProduct csp = new()
                {
                    CommercialSiteId = model.EmployeeSiteId,
                    ProductId = product.Id,
                    ProductCount = model.RequestedCount,
                };
                await repository.AddAsync(csp);
            }
            await repository.SaveChangesAsync();
        }
    }
}
