using IMS.Services.Data;
using IMS.Services.Data.Contracts;
using IMS.Web.Controllers;
using IMS.Web.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;

namespace IMS.Web.Areas.Admin.Controllers
{
    public class ProductController : AdminBaseController
    {
        private IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ProductFormModel()
            {
                Categories = await productService.AllCategoriesAsync(),
                Suppliers = await productService.AllSuppliersAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductFormModel model)
        {
            if (await productService.CategoryExistsAsync(model.CategoryId) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist!");
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await productService.AllCategoriesAsync();
                model.Suppliers = await productService.AllSuppliersAsync();

                return View(model);
            }

            Guid productId = await productService.AddProductAsync(model);

            return RedirectToAction("DashBoard", "Home");
        }
    }
}
