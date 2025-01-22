using IMS.Web.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Services.Data.Contracts
{
    public interface ICommercialsiteProductService
    {
        IEnumerable<ProductIndexServiceModel> GetAllAvailableProducts(int commercialSiteId)
    }
}
