using IMS.Data.Models;
using Microsoft.AspNetCore.Identity;
using static IMS.Web.Infrastructure.Constants.CustomClaims;
using static System.Net.Mime.MediaTypeNames;

namespace IMS.Data.SeedDb
{
    internal class SeedData
    {
        public ApplicationUser EmployeeUser { get; set; }
        public ApplicationUser AdminUser { get; set; }

        public IdentityUserClaim<string> EmployeeUserClaim { get; set; }
        public IdentityUserClaim<string> AdminUserClaim { get; set; }

        public Employee Employee { get; set; }
        public Employee AdminEmployee { get; set; }

        public Category FoodAndBeverages { get; set; }
        public Category FurnitureAndHomeGoods { get; set; }
        public Category ElectronicsAndAppliences { get; set; }
        public Category ClothingAndAccessories { get; set; }
        public Category HealthAndPersonalCare { get; set; }
        public Category AutomotiveAndTools { get; set; }
        public Category SportsAndOutdoorEquipment { get; set; }

        public Product BedFrame { get; set; }
        public Product LaysClassicPotatoChips { get; set; }
        public Product SamsungGalaxyS23 { get; set; }
        public Product Levis501OriginalJeans { get; set; }
        public Product DoveDeepMoistureBodyWash { get; set; }
        public Product BoschCordlessDrill { get; set; }
        public Product WilsonEvolutionIndoorBasketball { get; set; }

        public Supplier SamsungElectronics { get; set; }
        public Supplier IKEA { get; set; }
        public Supplier FritoLayInc { get; set; }
        public Supplier LeviStraussCo { get; set; }
        public Supplier Unilever { get; set; }
        public Supplier BoschTools { get; set; }
        public Supplier WilsonSportingGoods { get; set; }

        public CommercialSite BalkanTradeHub { get; set; }
        public CommercialSite BlackSeaLogisticsCenter { get; set; }
        public CommercialSite DanubeCommercePark { get; set; }

        public CommercialSiteProduct BalkanTradeHubSamsungGalaxyS23 { get; set; }
        public CommercialSiteProduct BlackSeaLogisticsCenterWilsonEvolutionIndoorBasketball { get; set; }
        public CommercialSiteProduct DanubeCommerceParkBoschCordlessDrill { get; set; }

        public SeedData()
        {
            SeedUsers();
            SeedCommercialSites();
            SeedEmployees();
            SeedCategories();
            SeedProdutcs();
            SeedSuppliers();
            SeedCommercialSitesProducts();
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            EmployeeUser = new ApplicationUser()
            {
                Id = "06e4a52b-0ee1-426f-b7a2-6b009a0c1f65",
                UserName = "employee@gmail.com",
                NormalizedUserName = "employee@gmail.com",
                Email = "employee@gmail.com",
                NormalizedEmail = "employee@gmail.com",
                FirstName = "Emilia",
                LastName = "Ivanova"
            };

            EmployeeUserClaim = new IdentityUserClaim<string>()
            {
                Id = 1,
                ClaimType = UserFullNameClaim,
                ClaimValue = "Emilia Ivanova",
                UserId = "06e4a52b-0ee1-426f-b7a2-6b009a0c1f65"
            };

            EmployeeUser.PasswordHash =
                hasher.HashPassword(EmployeeUser, "emiliaa123");

            AdminUser = new ApplicationUser()
            {
                Id = "69b38fdd-0aba-47f5-9f2b-6c7bb549d7ab",
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                FirstName = "Great",
                LastName = "Admin"
            };

            AdminUserClaim = new IdentityUserClaim<string>()
            {
                Id = 2,
                ClaimType = UserFullNameClaim,
                UserId = "69b38fdd-0aba-47f5-9f2b-6c7bb549d7ab",
                ClaimValue = "Great Admin"
            };

            AdminUser.PasswordHash =
                hasher.HashPassword(AdminUser, "admin123");
        }

        private void SeedEmployees()
        {
            Employee = new Employee()
            {
                Id = 1,
                UserId = EmployeeUser.Id,
                YearsOfExperience = 10,
                CommercialSiteId = 1,
                IsApproved = true
            };
            AdminEmployee = new Employee()
            {
                Id = 2,
                UserId = AdminUser.Id,
                YearsOfExperience = 30,
            };
        }

        private void SeedCategories()
        {
            FoodAndBeverages = new Category()
            {
                Id = 1,
                Name = "Food and Beverages"
            };

            FurnitureAndHomeGoods = new Category()
            {
                Id = 2,
                Name = "Furniture and Home Goods"
            };

            ElectronicsAndAppliences = new Category()
            {
                Id = 3,
                Name = "Electronics and Appliances"
            };

            ClothingAndAccessories = new Category()
            {
                Id = 4,
                Name = "Clothing and Accessories"
            };

            HealthAndPersonalCare = new Category()
            {
                Id = 5,
                Name = "Health and Personal Care"
            };

            AutomotiveAndTools = new Category()
            {
                Id = 6,
                Name = "Automotive and Tools"
            };

            SportsAndOutdoorEquipment = new Category()
            {
                Id = 7,
                Name = "Sports and Outdoor Equipment"
            };
        }

        private void SeedProdutcs()
        {
            SamsungGalaxyS23 = new Product()
            {
                Id = new Guid("13cc5dae-f692-4e93-9b7d-3b1e520d4e89"),
                Name = "Samsung Galaxy S23",
                Price = 999.99,
                Count = 150,
                SupplierId = 1,
                CategoryId = 3,
                Description = "A flagship smartphone with a 6.1-inch AMOLED display, 256GB storage, and a powerful triple-camera system",
                ImgPath = "samsung-galaxy-s23-5g-sm-s911-128gb-phantom-black.jpg"
            };

            BedFrame = new Product()
            {
                Id = new Guid("2b966829-79b6-4eff-8e6d-51e147f966ea"),
                Name = "IKEA MALM Bed Frame",
                Price = 249.99,
                Count = 75,
                Description = "A modern queen-sized wooden bed frame with a minimalist design and storage drawers underneath.",
                SupplierId = 2,
                CategoryId = 2,
                ImgPath = "malm-bed-frame-blue__1330503_pe9.jpg"
            };
            LaysClassicPotatoChips = new Product()
            {
                Id = new Guid("35970b4c-ac84-4e23-bf98-ac1785d736da"),
                Name = "Lay's Classic Potato Chips (Party Size)",
                Price = 4.99,
                Count = 500,
                Description = "Crispy and lightly salted potato chips in a large family-size bag. Perfect for sharing",
                SupplierId = 3,
                CategoryId = 1,
                ImgPath = "Lay-s-Classic-Potato-Chips-8-oz.jpg"
            };

            Levis501OriginalJeans = new Product()
            {
                Id = new Guid("4e861aa5-5553-456e-bd6f-4312ffc05563"),
                Name = "Levi's 501 Original Jeans",
                Price = 69.99,
                Count = 200,
                Description = "Classic straight-leg denim jeans made from durable cotton, available in various sizes and washes.",
                SupplierId = 4,
                CategoryId = 4,
                ImgPath = "mens_501_original.jpg"
            };

            DoveDeepMoistureBodyWash = new Product()
            {
                Id = new Guid("62f797e8-e161-4d59-a29a-b1a806b45edb"),
                Name = "Dove Deep Moisture Body Wash (16 oz)",
                Price = 6.49,
                Count = 300,
                Description = "Gentle body wash with a rich lather that nourishes and moisturizes the skin.",
                SupplierId = 5,
                CategoryId = 5,
                ImgPath = "dove-deep-moisture-body-wash.jpg"
            };

            BoschCordlessDrill = new Product()
            {
                Id = new Guid("7508feee-3168-401e-84d7-9e126b394196"),
                Name = "Bosch Cordless Drill/Driver Kit (12V)",
                Price = 119.99,
                Count = 80,
                Description = "Compact and lightweight cordless drill with two-speed settings, a rechargeable battery, and a carrying case.",
                SupplierId = 6,
                CategoryId = 6,
                ImgPath = "Bosch_GSR_120-Li_Cordless_Drill_Driver___22210.jpg"
            };

            WilsonEvolutionIndoorBasketball = new Product()
            {
                Id = new Guid("aef8b15d-c498-4ee4-a31f-ef67e1c970c7"),
                Name = "Wilson Evolution Indoor Basketball",
                Price = 59.99,
                Count = 120,
                Description = "High-quality indoor basketball with a soft feel, designed for competitive play and superior grip.",
                SupplierId = 7,
                CategoryId = 7,
                ImgPath = "wilson-evolution-indoor-basketball.jpg"
            };
        }

        private void SeedSuppliers()
        {
            SamsungElectronics = new Supplier()
            {
                Id = 1,
                Name = "Samsung Electronics"
            };

            IKEA = new Supplier()
            {
                Id = 2,
                Name = "IKEA"
            };

            FritoLayInc = new Supplier()
            {
                Id = 3,
                Name = "Frito-Lay, Inc."
            };

            LeviStraussCo = new Supplier()
            {
                Id = 4,
                Name = "Levi Strauss & Co."
            };

            Unilever = new Supplier()
            {
                Id = 5,
                Name = "Unilever"
            };

            BoschTools = new Supplier()
            {
                Id = 6,
                Name = "Bosch Tools"
            };

            WilsonSportingGoods = new Supplier()
            {
                Id = 7,
                Name = "Wilson Sporting Goods"
            };
        }

        private void SeedCommercialSites()
        {
            BalkanTradeHub = new CommercialSite()
            {
                Id = 1,
                Name = "Balkan Trade Hub"
            };

            BlackSeaLogisticsCenter = new CommercialSite()
            {
                Id = 2,
                Name = "Black Sea Logistics Center"
            };

            DanubeCommercePark = new CommercialSite()
            {
                Id = 3,
                Name = "Danube Commerce Park"
            };
        }

        private void SeedCommercialSitesProducts()
        {
            BalkanTradeHubSamsungGalaxyS23 = new CommercialSiteProduct()
            {
                ProductId = SamsungGalaxyS23.Id,
                CommercialSiteId = BalkanTradeHub.Id,
                ProductCount = 20
            };

            BlackSeaLogisticsCenterWilsonEvolutionIndoorBasketball = new CommercialSiteProduct()
            {
                ProductId = WilsonEvolutionIndoorBasketball.Id,
                CommercialSiteId = BlackSeaLogisticsCenter.Id,
                ProductCount = 50
            };

            DanubeCommerceParkBoschCordlessDrill = new CommercialSiteProduct()
            {
                ProductId = BoschCordlessDrill.Id,
                CommercialSiteId = DanubeCommercePark.Id,
                ProductCount = 10
            };
        }
    }
}
