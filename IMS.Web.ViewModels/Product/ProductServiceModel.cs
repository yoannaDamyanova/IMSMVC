using IMS.Web.ViewModels.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Web.ViewModels.Product
{
    public class ProductServiceModel : IProductModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public double Price { get; set; }

        public int Count { get; set; }

        public string PhotoFileName { get; set; } = string.Empty;
    }
}
