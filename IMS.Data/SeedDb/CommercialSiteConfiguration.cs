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
    internal class CommercialSiteConfiguration : IEntityTypeConfiguration<CommercialSite>
    {
        public void Configure(EntityTypeBuilder<CommercialSite> builder)
        {
            var data = new SeedData();

            builder.HasData(new CommercialSite[]
            {
                data.BalkanTradeHub,
                data.BlackSeaLogisticsCenter,
                data.DanubeCommercePark,
            });
        }
    }
}
