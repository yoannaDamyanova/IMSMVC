using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using IMS.Services.Data.Contracts;
using static IMS.Web.Extensions.ClaimsPrincipalExtensions;
using IMS.Web.Controllers;

namespace IMS.Web.Attributes
{
    public class MustBeEmployeeAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            IEmployeeService? employeeService = context.HttpContext.RequestServices.GetService<IEmployeeService>();

            if (employeeService == null)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }

            //if (employeeService != null
            //    && employeeService.ExistsByUserIdAsync(context.HttpContext.User.Id()).Result == false)
            //{
            //    context.Result = new RedirectToActionResult(nameof(EmployeeController.Become), "Instructor", null);
            //}
        }
    }
}
