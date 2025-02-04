using IMS.Services.Data.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace IMS.Web.Areas.Admin.Controllers
{
    public class EmployeeController : AdminBaseController
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public async Task<IActionResult> All()
        {
            var model = await employeeService.AllAsync();

            return View(model);
        }
    }
}
