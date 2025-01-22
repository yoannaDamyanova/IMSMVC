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

        public IEnumerable<CommercialSiteViewModel> AllCommercialSites()
        {
            return repository.AllReadOnly<CommercialSite>()
                .Select(cs => new CommercialSiteViewModel()
                {
                    Name = cs.Name,
                    AvailableProducts = commercialsiteproductservice.GetAllAvailableProducts(cs.Id)
                }).ToList();
        }
    }
}
