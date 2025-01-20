using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using IMS.Services.Data.Contracts;
using IMS.Web.Extensions;

namespace IMS.Web.Attributes
{
    public class NotAnInstructorAttribute : ActionFilterAttribute
    {
        //public override void OnActionExecuting(ActionExecutingContext context)
        //{
        //    base.OnActionExecuting(context);

        //    IInstructorService? instructorService = context.HttpContext.RequestServices.GetService<IInstructorService>();

        //    if (instructorService == null)
        //    {
        //        context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
        //    }

        //    if (instructorService != null
        //        && instructorService.ExistsByUserIdAsync(context.HttpContext.User.Id()).Result)
        //    {
        //        context.Result = new StatusCodeResult(StatusCodes.Status400BadRequest);
        //    }
        //}
    }
}
