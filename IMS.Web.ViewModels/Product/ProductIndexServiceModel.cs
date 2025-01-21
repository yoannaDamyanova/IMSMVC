using IMS.Web.ViewModels.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Web.ViewModels.Product
{
    public class ProductIndexServiceModel : IProductModel
    {
        public string Id { get; set; }
        public string Name { get; set; } = null!;
        public double Price { get; set; }
    }
}
