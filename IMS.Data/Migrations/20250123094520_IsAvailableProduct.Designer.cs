﻿// <auto-generated />
using System;
using IMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IMS.Data.Migrations
{
    [DbContext(typeof(IMSDbContext))]
    [Migration("20250123094520_IsAvailableProduct")]
    partial class IsAvailableProduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IMS.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "06e4a52b-0ee1-426f-b7a2-6b009a0c1f65",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6cf1da1a-d6c9-4dd0-92de-07856c0144af",
                            Email = "employee@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Emilia",
                            LastName = "Ivanova",
                            LockoutEnabled = false,
                            NormalizedEmail = "employee@gmail.com",
                            NormalizedUserName = "employee@gmail.com",
                            PasswordHash = "AQAAAAIAAYagAAAAEJDFFbywrD7T1vZCN5D1E0UGP3d6HtM3ZtNXRBsEKjT60NnHnqHOI9g3SRp8whD3gQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f103530a-b4d9-4b5b-ba7c-fb6b9833f204",
                            TwoFactorEnabled = false,
                            UserName = "employee@gmail.com"
                        },
                        new
                        {
                            Id = "69b38fdd-0aba-47f5-9f2b-6c7bb549d7ab",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "295a8b36-d975-462d-8f4e-112196b86259",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Great",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEOGJwHaeFRIIZGrHTFg0uXty+Bu28UnSCO9GWYh8odgsIkMbZpvnVj2o+xql31KaeQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "57cf6e5e-8c0a-4080-ab3f-92ff96462ae7",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("IMS.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Name = "Electronics and Appliances"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Food and Beverages"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Automotive and Tools"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Clothing and Accessories"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Furniture and Home Goods"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Sports and Outdoor Equipment"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Health and Personal Care"
                        });
                });

            modelBuilder.Entity("IMS.Data.Models.CommercialSite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CommercialSites");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Balkan Trade Hub"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Black Sea Logistics Center"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Danube Commerce Park"
                        });
                });

            modelBuilder.Entity("IMS.Data.Models.CommercialSiteProduct", b =>
                {
                    b.Property<int>("CommercialSiteId")
                        .HasColumnType("int");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ProductCount")
                        .HasColumnType("int");

                    b.HasKey("CommercialSiteId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CommercialSitesProducts");

                    b.HasData(
                        new
                        {
                            CommercialSiteId = 1,
                            ProductId = new Guid("13cc5dae-f692-4e93-9b7d-3b1e520d4e89"),
                            ProductCount = 20
                        },
                        new
                        {
                            CommercialSiteId = 2,
                            ProductId = new Guid("aef8b15d-c498-4ee4-a31f-ef67e1c970c7"),
                            ProductCount = 50
                        },
                        new
                        {
                            CommercialSiteId = 3,
                            ProductId = new Guid("7508feee-3168-401e-84d7-9e126b394196"),
                            ProductCount = 10
                        });
                });

            modelBuilder.Entity("IMS.Data.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CommercialSiteId")
                        .HasColumnType("int");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("YearsOfExperience")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommercialSiteId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CommercialSiteId = 1,
                            IsApproved = true,
                            UserId = "06e4a52b-0ee1-426f-b7a2-6b009a0c1f65",
                            YearsOfExperience = 10
                        },
                        new
                        {
                            Id = 2,
                            IsApproved = false,
                            UserId = "69b38fdd-0aba-47f5-9f2b-6c7bb549d7ab",
                            YearsOfExperience = 30
                        });
                });

            modelBuilder.Entity("IMS.Data.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailbale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2b966829-79b6-4eff-8e6d-51e147f966ea"),
                            CategoryId = 2,
                            Count = 75,
                            Description = "A modern queen-sized wooden bed frame with a minimalist design and storage drawers underneath.",
                            IsAvailbale = true,
                            Name = "IKEA MALM Bed Frame",
                            Price = 249.99000000000001,
                            SupplierId = 2
                        },
                        new
                        {
                            Id = new Guid("13cc5dae-f692-4e93-9b7d-3b1e520d4e89"),
                            CategoryId = 3,
                            Count = 150,
                            Description = "A flagship smartphone with a 6.1-inch AMOLED display, 256GB storage, and a powerful triple-camera system",
                            IsAvailbale = true,
                            Name = "Samsung Galaxy S23",
                            Price = 999.99000000000001,
                            SupplierId = 1
                        },
                        new
                        {
                            Id = new Guid("35970b4c-ac84-4e23-bf98-ac1785d736da"),
                            CategoryId = 1,
                            Count = 500,
                            Description = "Crispy and lightly salted potato chips in a large family-size bag. Perfect for sharing",
                            IsAvailbale = true,
                            Name = "Lay's Classic Potato Chips (Party Size)",
                            Price = 4.9900000000000002,
                            SupplierId = 3
                        },
                        new
                        {
                            Id = new Guid("4e861aa5-5553-456e-bd6f-4312ffc05563"),
                            CategoryId = 4,
                            Count = 200,
                            Description = "Classic straight-leg denim jeans made from durable cotton, available in various sizes and washes.",
                            IsAvailbale = true,
                            Name = "Levi's 501 Original Jeans",
                            Price = 69.989999999999995,
                            SupplierId = 1
                        },
                        new
                        {
                            Id = new Guid("aef8b15d-c498-4ee4-a31f-ef67e1c970c7"),
                            CategoryId = 7,
                            Count = 120,
                            Description = "High-quality indoor basketball with a soft feel, designed for competitive play and superior grip.",
                            IsAvailbale = true,
                            Name = "Wilson Evolution Indoor Basketball",
                            Price = 59.990000000000002,
                            SupplierId = 1
                        },
                        new
                        {
                            Id = new Guid("7508feee-3168-401e-84d7-9e126b394196"),
                            CategoryId = 6,
                            Count = 80,
                            Description = "Compact and lightweight cordless drill with two-speed settings, a rechargeable battery, and a carrying case.",
                            IsAvailbale = true,
                            Name = "Bosch Cordless Drill/Driver Kit (12V)",
                            Price = 119.98999999999999,
                            SupplierId = 3
                        },
                        new
                        {
                            Id = new Guid("62f797e8-e161-4d59-a29a-b1a806b45edb"),
                            CategoryId = 5,
                            Count = 300,
                            Description = "Gentle body wash with a rich lather that nourishes and moisturizes the skin.",
                            IsAvailbale = true,
                            Name = "Dove Deep Moisture Body Wash (16 oz)",
                            Price = 6.4900000000000002,
                            SupplierId = 2
                        });
                });

            modelBuilder.Entity("IMS.Data.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            Id = 6,
                            Name = "Bosch Tools"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Levi Strauss & Co."
                        },
                        new
                        {
                            Id = 3,
                            Name = "Frito-Lay, Inc."
                        },
                        new
                        {
                            Id = 2,
                            Name = "IKEA"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Wilson Sporting Goods"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Samsung Electronics"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Unilever"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "user:fullname",
                            ClaimValue = "Emilia Ivanova",
                            UserId = "06e4a52b-0ee1-426f-b7a2-6b009a0c1f65"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "user:fullname",
                            ClaimValue = "Great Admin",
                            UserId = "69b38fdd-0aba-47f5-9f2b-6c7bb549d7ab"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("IMS.Data.Models.CommercialSiteProduct", b =>
                {
                    b.HasOne("IMS.Data.Models.CommercialSite", "CommercialSite")
                        .WithMany()
                        .HasForeignKey("CommercialSiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CommercialSite");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("IMS.Data.Models.Employee", b =>
                {
                    b.HasOne("IMS.Data.Models.CommercialSite", "CommercialSite")
                        .WithMany()
                        .HasForeignKey("CommercialSiteId");

                    b.HasOne("IMS.Data.Models.ApplicationUser", "User")
                        .WithOne("Employee")
                        .HasForeignKey("IMS.Data.Models.Employee", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CommercialSite");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IMS.Data.Models.Product", b =>
                {
                    b.HasOne("IMS.Data.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.Data.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("IMS.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("IMS.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("IMS.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IMS.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
