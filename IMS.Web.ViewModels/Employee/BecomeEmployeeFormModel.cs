using static IMS.Common.ErrorMessageConstants;
using static IMS.Common.EntityValidationConstants;
using System.ComponentModel.DataAnnotations;

namespace IMS.Web.ViewModels.Employee
{
    public class BecomeEmployeeFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        public int YearsOfExperience { get; set; }
    }
}
