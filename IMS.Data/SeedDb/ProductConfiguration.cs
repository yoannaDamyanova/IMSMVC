using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using IMS.Data.Models;
namespace IMS.Data.SeedDb
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            var data = new SeedData();

            builder.HasData(new Product[]
            {
                data.BedFrame,
                data.SamsungGalaxyS23,
                data.LaysClassicPotatoChips,
                data.Levis501OriginalJeans,
                data.WilsonEvolutionIndoorBasketball,
                data.BoschCordlessDrill,
                data.DoveDeepMoistureBodyWash,
            });
        }
    }
}
