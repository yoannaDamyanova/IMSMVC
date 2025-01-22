using IMS.Web.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Web.ViewModels
{
    public class CommercialSiteViewModel
    {
        public string Name { get; set; } = null!;

        public IEnumerable<ProductIndexServiceModel>? AvailableProducts { get; set; }
    }
}
