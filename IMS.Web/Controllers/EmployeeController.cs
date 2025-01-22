using IMS.Services.Data.Contracts;
using IMS.Web.Attributes;
using IMS.Web.Extensions;
using IMS.Web.ViewModels.Employee;
using Microsoft.AspNetCore.Mvc;

namespace IMS.Web.Controllers
{
    public class EmployeeController : BaseController
    {
        private IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        [NotAnEmployee]
        public IActionResult Become()
        {
            var model = new BecomeEmployeeFormModel();

            return View(model);
        }

        [HttpPost]
        [NotAnEmployee]
        public async Task<IActionResult> Become(BecomeEmployeeFormModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            await employeeService.CreateAsync(model, User.Id());

            return RedirectToAction("All", "Product");
        }

        [HttpGet]
        [MustBeEmployee]
        public async Task<IActionResult> Office(string employeeId)
        {
            var model = await employeeService.GetEmployeeOfficeByUserId(employeeId);

            return View(model);
        }
    }
}
