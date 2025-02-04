using IMS.Services.Data.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace IMS.Web.Areas.Admin.Controllers
{
    public class UserController : AdminBaseController
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<IActionResult> All()
        {
            var model = await userService.AllAsync();

            return View(model);
        }
    }
}
