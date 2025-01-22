using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using IMS.Services.Data.Contracts;
using IMS.Web.Extensions;

namespace IMS.Web.Attributes
{
    public class NotAnEmployeeAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            IEmployeeService? employeeService = context.HttpContext.RequestServices.GetService<IEmployeeService>();

            if (employeeService == null)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }

            if (employeeService != null
                && employeeService.ExistsByUserIdAsync(context.HttpContext.User.Id()).Result)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status400BadRequest);
            }
        }
    }
}
