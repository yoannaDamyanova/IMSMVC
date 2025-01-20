using IMS.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Data.SeedDb
{
    internal class CommercialSitesProductsConfiguration : IEntityTypeConfiguration<CommercialSiteProduct>
    {
        public void Configure(EntityTypeBuilder<CommercialSiteProduct> builder)
        {
            var data = new SeedData();

            builder.HasData(new CommercialSiteProduct[]
            {
                data.BalkanTradeHubSamsungGalaxyS23,
                data.BlackSeaLogisticsCenterWilsonEvolutionIndoorBasketball,
                data.DanubeCommerceParkBoschCordlessDrill
            });
        }
    }
}
