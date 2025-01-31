using IMS.Data.Models;
using IMS.Data.Repository.Contracts;
using IMS.Services.Data.Contracts;
using IMS.Web.ViewModels.Product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Services.Data
{
    public class CommercialSiteProductService : BaseService, ICommercialsiteProductService
    {
        private readonly IRepository repository;

        public CommercialSiteProductService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<bool> ExistsById(string productId)
        {
            Guid id = Guid.Empty;
            if (!IsGuidValid(productId, ref id))
            {
                return false;
            }

            return await repository.AllReadOnly<CommercialSiteProduct>()
                .AnyAsync(csp => csp.ProductId == id);
        }

        public IEnumerable<ProductServiceModel> GetAllAvailableProducts(int commercialSiteId)
        {
            return repository.AllReadOnly<CommercialSiteProduct>()
                .Where(csp => csp.CommercialSiteId == commercialSiteId)
                .Include(csp => csp.Product)
                .Select(csp => new ProductServiceModel()
                {
                    Name = csp.Product.Name,
                    Price = csp.Product.Price,
                    Id = csp.Product.Id,
                    Count = csp.ProductCount,
                    PhotoFileName = csp.Product.ImgPath,
                }).ToList();
        }

        public async Task<CommercialSiteProduct> GetById(string productId)
        {
            Guid id = Guid.Empty;
            if (!IsGuidValid(productId, ref id))
            {
                return null;
            }

            return await repository.All<CommercialSiteProduct>()
                .FirstOrDefaultAsync(csp => csp.ProductId == id);
        }
    }
}
