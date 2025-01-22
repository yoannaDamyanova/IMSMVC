using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Web.ViewModels.Product
{
    public class ProductDeleteViewModel
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string SupplierName { get; set; } = null!;

        public string CategoryName { get; set; } = null!;
    }
}
