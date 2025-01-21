using IMS.Services.Data.Contracts;
using IMS.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IMS.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;

        public HomeController(
            ILogger<HomeController> logger,
            IProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var model = await productService.LastSevenProductsAsync();

            return View(model);
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {

            if (statusCode == 400)
            {
                return View("Error400");
            }

            if (statusCode == 401)
            {
                return View("Error401");
            }

            if (statusCode == 404)
            {
                return View("Error404");
            }

            if (statusCode == 500)
            {
                return View("Error500");
            }
            return View();
        }
    }
}
