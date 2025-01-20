using IMS.Data.Models;
using IMS.Data.SeedDb;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IMS.Data
{
    public class IMSDbContext : IdentityDbContext<ApplicationUser>
    {
        public IMSDbContext()
        {

        }

        public IMSDbContext(DbContextOptions<IMSDbContext> options)
        : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CommercialSiteProduct>()
                .HasKey(csp => new { csp.CommercialSiteId, csp.ProductId });

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new UserClaimsConfiguration());
            modelBuilder.ApplyConfiguration(new CommercialSiteConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());
            modelBuilder.ApplyConfiguration(new CommercialSitesProductsConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Product> Products { get; set; } = null!;

        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;

        public virtual DbSet<Category> Categories { get; set; } = null!;

        public virtual DbSet<CommercialSite> CommercialSites { get; set; } = null!;

        public virtual DbSet<Employee> Employees { get; set; } = null!;

        public virtual DbSet<CommercialSiteProduct> CommercialSitesProducts { get; set; } = null!;
    }
}
