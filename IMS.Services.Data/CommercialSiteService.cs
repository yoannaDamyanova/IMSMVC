using IMS.Data.Models;
using IMS.Data.Repository.Contracts;
using IMS.Services.Data.Contracts;
using IMS.Web.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Services.Data
{
    public class CommercialSiteService : BaseService, ICommercialSiteService
    {
        private readonly IRepository repository;
        private readonly ICommercialsiteProductService commercialsiteproductservice;

        public CommercialSiteService(IRepository repository, ICommercialsiteProductService commercialsiteproductservice)
        {
            this.repository = repository;
            this.commercialsiteproductservice = commercialsiteproductservice;
        }

        public IEnumerable<CommercialSiteViewModel> AllCommercialSitesAsync()
        {
            return repository.AllReadOnly<CommercialSite>()
                .Select(cs => new CommercialSiteViewModel()
                {
                    Id = cs.Id,
                    Name = cs.Name,
                    AvailableProducts = commercialsiteproductservice.GetAllAvailableProducts(cs.Id),
                }).ToList();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await repository.AllReadOnly<CommercialSite>()
                .AnyAsync(cs => cs.Id == id);
        }

        public async Task<CommercialSite> GetByIdAsync(int id)
        {
            return await repository.AllReadOnly<CommercialSite>()
                .FirstOrDefaultAsync(cs => cs.Id == id);
        }
    }
}
