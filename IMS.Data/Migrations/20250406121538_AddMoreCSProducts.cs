using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreCSProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06e4a52b-0ee1-426f-b7a2-6b009a0c1f65",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31811420-5fb4-45d6-bfb9-0a9e6edb3456", "AQAAAAIAAYagAAAAEDaYbfsTRwyWQ88g+1cvlkDqxqWeali4qK6L/7rhybbfTeEvyty2/2B6P1HEUxaSBA==", "dd36b68c-26da-486b-910d-457e342b57ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69b38fdd-0aba-47f5-9f2b-6c7bb549d7ab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c33ea39c-20d6-464a-80e6-a9329184ed1e", "AQAAAAIAAYagAAAAEGvKrcUUouxY7aiqD23qLih5owF7PH7/hR9QaKUz+9D67Q15vTqY3Hsj2bBoiLb3GQ==", "4fde2b04-be22-41d0-a5c6-994a42db5511" });

            migrationBuilder.InsertData(
                table: "CommercialSitesProducts",
                columns: new[] { "CommercialSiteId", "ProductId", "ProductCount" },
                values: new object[,]
                {
                    { 1, new Guid("35970b4c-ac84-4e23-bf98-ac1785d736da"), 100 },
                    { 1, new Guid("4e861aa5-5553-456e-bd6f-4312ffc05563"), 15 },
                    { 1, new Guid("62f797e8-e161-4d59-a29a-b1a806b45edb"), 50 },
                    { 1, new Guid("aef8b15d-c498-4ee4-a31f-ef67e1c970c7"), 30 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CommercialSitesProducts",
                keyColumns: new[] { "CommercialSiteId", "ProductId" },
                keyValues: new object[] { 1, new Guid("35970b4c-ac84-4e23-bf98-ac1785d736da") });

            migrationBuilder.DeleteData(
                table: "CommercialSitesProducts",
                keyColumns: new[] { "CommercialSiteId", "ProductId" },
                keyValues: new object[] { 1, new Guid("4e861aa5-5553-456e-bd6f-4312ffc05563") });

            migrationBuilder.DeleteData(
                table: "CommercialSitesProducts",
                keyColumns: new[] { "CommercialSiteId", "ProductId" },
                keyValues: new object[] { 1, new Guid("62f797e8-e161-4d59-a29a-b1a806b45edb") });

            migrationBuilder.DeleteData(
                table: "CommercialSitesProducts",
                keyColumns: new[] { "CommercialSiteId", "ProductId" },
                keyValues: new object[] { 1, new Guid("aef8b15d-c498-4ee4-a31f-ef67e1c970c7") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06e4a52b-0ee1-426f-b7a2-6b009a0c1f65",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afc746a5-5d78-4725-acff-94857ee58f23", "AQAAAAIAAYagAAAAEA9ZSbIVRTZjZ69wCP4/C4ZWdMpuOPnbh6xRu3PjP5aq6+0hJUZl6TpQldy1matRFw==", "e0b9f047-3531-498b-b2dc-8f9464a9eda3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69b38fdd-0aba-47f5-9f2b-6c7bb549d7ab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2171e1d2-87d5-43f3-9c9c-91a81054df8c", "AQAAAAIAAYagAAAAEEGifPsg2lWas4pVuuXLPZOqW62tvIaGbFuOq5Gpk8dd0X4sGD1jBID/hAi0Gd2BHQ==", "fc09f64e-db01-46ae-bbb7-dc2721eaf4df" });
        }
    }
}
