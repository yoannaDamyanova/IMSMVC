using IMS.Services.Data;
using IMS.Services.Data.Contracts;
using IMS.Web.Controllers;
using IMS.Web.Extensions;
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

            await productService.AddProductAsync(model);

            return RedirectToAction("DashBoard", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string productId)
        {
            Guid id = Guid.Empty;
            if (!IsGuidValid(productId, ref id))
            {
                return BadRequest();
            }

            var product = await productService.GetByIdAsync(id);
            var categories = await productService.AllCategoriesAsync();
            var category = categories.FirstOrDefault(c => c.Id == product.CategoryId);
            var suppliers = await productService.AllSuppliersAsync();
            var supplier = suppliers.FirstOrDefault(s => s.Id == product.CategoryId);

            var model = new ProductDeleteViewModel
            {
                Id = productId.ToString(),
                Name = product.Name,
                CategoryName = category.Name,
                SupplierName = supplier.Name
            };

            return View(model);
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Delete(ProductDeleteViewModel model)
        {
            Guid id = Guid.Empty;
            if (!IsGuidValid(model.Id, ref id))
            {
                return BadRequest();
            }

            await productService.DeleteAsync(id);
            return RedirectToAction("Dashboard", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string productId)
        {
            Guid id = Guid.Empty;
            if (!IsGuidValid(productId, ref id))
            {
                return BadRequest();
            }

            if (await productService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await productService.GetProductFormModelByIdAsync(productId);

            model.Categories = await productService.AllCategoriesAsync();
            model.Suppliers = await productService.AllSuppliersAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProductFormModel model)
        {
            Guid id = Guid.Empty;
            if (!IsGuidValid(model.Id, ref id))
            {
                return BadRequest();
            }

            if (await productService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (!User.IsAdmin())
            {
                return Unauthorized();
            }

            if (await productService.CategoryExistsAsync(model.CategoryId) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist");
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await productService.AllCategoriesAsync();

                return View(model);
            }

            await productService.EditAsync(model, model.Id);

            return RedirectToAction("DashBoard", "Home");
        }
    }
}
