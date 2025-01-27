using static IMS.Common.ErrorMessageConstants;
using System.ComponentModel.DataAnnotations;
using IMS.Data.Models;

namespace IMS.Web.ViewModels.Employee
{
    public class BecomeEmployeeFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        public int YearsOfExperience { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Търговски обект")]
        public int CommercialSiteId { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        public IEnumerable<CommercialSiteViewModel> CommercialSites { get; set; } = new HashSet<CommercialSiteViewModel>();
    }
}
