using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using IMS.Data.Models;

namespace IMS.Data.SeedDb
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var data = new SeedData();

            builder.HasData(new Category[]
            {
                data.ElectronicsAndAppliences,
                data.FoodAndBeverages,
                data.AutomotiveAndTools,
                data.ClothingAndAccessories,
                data.FurnitureAndHomeGoods,
                data.SportsAndOutdoorEquipment,
                data.HealthAndPersonalCare
            });
        }
    }
}
