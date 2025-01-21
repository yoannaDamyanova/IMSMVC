﻿using IMS.Services.Data.Contracts;
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
    }
}