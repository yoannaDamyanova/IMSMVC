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
    internal class CommercialSiteProductService : BaseService, ICommercialsiteProductService
    {
        private readonly IRepository repository;

        public CommercialSiteProductService(IRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<ProductIndexServiceModel> GetAllAvailableProducts(int commercialSiteId)
        {
            return repository.AllReadOnly<CommercialSiteProduct>()
                .Where(csp => csp.CommercialSiteId == commercialSiteId)
                .Include(csp => csp.Product)
                .Select(csp => new ProductIndexServiceModel()
                {
                    Name = csp.Product.Name,
                    Price = csp.Product.Price,
                    Id = csp.Product.Id.ToString(),
                }).ToList();
        }
    }
}
