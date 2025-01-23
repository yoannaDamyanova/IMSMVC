using IMS.Services.Data.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace IMS.Web.Controllers
{
    public class CommercialSiteController : BaseController
    {
        private readonly ICommercialSiteService commercialSiteService;

        public CommercialSiteController(ICommercialSiteService commercialSiteService)
        {
            this.commercialSiteService = commercialSiteService;
        }

        [HttpGet]
        public IActionResult All()
        {
            var model = commercialSiteService.AllCommercialSitesAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int siteId)
        {
            if (await commercialSiteService.ExistsAsync(siteId) == false)
            {
                return BadRequest();
            }

            var sites = commercialSiteService.AllCommercialSitesAsync();

            var model = sites.FirstOrDefault(s => s.Id == siteId);

            return View(model);
        }
    }
}
