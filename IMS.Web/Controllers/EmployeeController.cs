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
        //private ICommercialSiteService commercialSiteService;

        public EmployeeController(IEmployeeService employeeService, ICommercialSiteService commercialSiteService)
        {
            this.employeeService = employeeService;
            //this.commercialSiteService = commercialSiteService;
        }

        //[HttpGet]
        //[NotAnEmployee]
        //public async IActionResult Become()
        //{
        //    var model = new BecomeEmployeeFormModel()
        //    {
        //        CommercialSites = await commercialSiteService.AllCommercialSitesAsync()
        //    };

        //    return View(model);
        //}

        //[HttpPost]
        //[NotAnEmployee]
        //public async Task<IActionResult> Become(BecomeEmployeeFormModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }
        //    if (await commercialSiteService.ExistsAsync(model.CommercialSiteId))
        //    {
        //        model.CommercialSites = await commercialSiteService.AllCommercialSitesAsync();
        //    }

        //    await employeeService.CreateAsync(model, User.Id());

        //    return RedirectToAction("All", "Product");
        //}

        [HttpGet]
        [MustBeEmployee]
        public async Task<IActionResult> Office(string employeeId)
        {
            var model = await employeeService.GetEmployeeOfficeByUserIdAsync(employeeId);

            return View(model);
        }
    }
}
