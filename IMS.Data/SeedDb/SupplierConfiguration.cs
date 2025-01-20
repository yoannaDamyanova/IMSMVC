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
    internal class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            var data = new SeedData();

            builder.HasData(new Supplier[]
            {
                data.BoschTools,
                data.LeviStraussCo,
                data.FritoLayInc,
                data.IKEA,
                data.WilsonSportingGoods,
                data.SamsungElectronics,
                data.Unilever
            });
        }
    }
}
