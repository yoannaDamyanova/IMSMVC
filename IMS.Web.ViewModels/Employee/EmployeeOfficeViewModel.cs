using IMS.Data.Models;
using IMS.Web.ViewModels.Product;

namespace IMS.Web.ViewModels.Employee
{
    public class EmployeeOfficeViewModel
    {
        public string Name { get; set; } = string.Empty;

        public int YearsOfExperience { get; set; }

        public int CommercialSiteId { get; set; }

        public string CommercialSiteName { get; set; } = string.Empty;

        public IEnumerable<ProductServiceModel>? Products { get; set; }     
    }
}
