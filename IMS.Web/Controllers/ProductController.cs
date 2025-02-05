﻿using IMS.Services.Data.Contracts;
using IMS.Web.Attributes;
using IMS.Web.ViewModels.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IMS.Web.Controllers
{
    public class ProductController : BaseController
    {
        private IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllProductsQueryModel model)
        {
            var classes = await productService.AllAsync(
                model.Category,
                model.Supplier,
                model.SearchTerm,
                model.Sorting,
                model.CurrentPage,
                model.ProductsPerPage);

            model.TotalProductsCount = classes.TotalProductsCount;

            model.Products = classes.Products;

            model.Categories = await productService.AllCategoriesNamesAsync();

            model.Suppliers = await productService.AllSuppliersNamesAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string productId)
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

            var model = await productService.ProductDetailsByIdAsync(id);

            return View(model);
        }

        [HttpGet]
        [MustBeEmployee]
        public async Task<IActionResult> RequestProduct(Guid productId)
        {

            if (await productService.ExistsAsync(productId) == false)
            {
                return BadRequest();
            }

            var product = await productService.GetByIdAsync(productId);
            var suppliers = await productService.AllSuppliersAsync();
            var supplier = suppliers.FirstOrDefault(s => s.Id == product.SupplierId);

            var model = new ProductRequestViewModel()
            {
                Id = productId.ToString(),
                Name = product.Name,
                Price = product.Price,
                SupplierName = supplier.Name,
                Description = product.Description,
                Count = product.Count,
                PhotoName = product.ImgPath
            };

            return View(model);
        }

        [HttpPost]
        [MustBeEmployee]
        public async Task<IActionResult> RequestProduct(ProductRequestViewModel model)
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
            if (model.EmployeeSiteId == 0)
            {
                return BadRequest();
            }
            await productService.RequestProductAsync(model);
            return RedirectToAction(nameof(All));
        }
    }
}
