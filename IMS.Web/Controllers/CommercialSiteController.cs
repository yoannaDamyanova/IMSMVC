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

        public IActionResult All()
        {
            var model = commercialSiteService.AllCommercialSites();

            return View(model);
        }
    }
}
