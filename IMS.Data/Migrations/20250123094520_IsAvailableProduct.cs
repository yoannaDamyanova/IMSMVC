using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class IsAvailableProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAvailbale",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06e4a52b-0ee1-426f-b7a2-6b009a0c1f65",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cf1da1a-d6c9-4dd0-92de-07856c0144af", "AQAAAAIAAYagAAAAEJDFFbywrD7T1vZCN5D1E0UGP3d6HtM3ZtNXRBsEKjT60NnHnqHOI9g3SRp8whD3gQ==", "f103530a-b4d9-4b5b-ba7c-fb6b9833f204" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69b38fdd-0aba-47f5-9f2b-6c7bb549d7ab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "295a8b36-d975-462d-8f4e-112196b86259", "AQAAAAIAAYagAAAAEOGJwHaeFRIIZGrHTFg0uXty+Bu28UnSCO9GWYh8odgsIkMbZpvnVj2o+xql31KaeQ==", "57cf6e5e-8c0a-4080-ab3f-92ff96462ae7" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13cc5dae-f692-4e93-9b7d-3b1e520d4e89"),
                column: "IsAvailbale",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b966829-79b6-4eff-8e6d-51e147f966ea"),
                column: "IsAvailbale",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35970b4c-ac84-4e23-bf98-ac1785d736da"),
                column: "IsAvailbale",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e861aa5-5553-456e-bd6f-4312ffc05563"),
                column: "IsAvailbale",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62f797e8-e161-4d59-a29a-b1a806b45edb"),
                column: "IsAvailbale",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7508feee-3168-401e-84d7-9e126b394196"),
                column: "IsAvailbale",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aef8b15d-c498-4ee4-a31f-ef67e1c970c7"),
                column: "IsAvailbale",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAvailbale",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06e4a52b-0ee1-426f-b7a2-6b009a0c1f65",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6a7c913-a5a3-4682-8846-3ac9043f3d33", "AQAAAAIAAYagAAAAEOD8QFtwRwnyqinUVEwehrCBP16O65doJnGSd3a0Iz/5zBeYKn5/fGbnuxMFV3zVTw==", "e8dc6193-fb76-4708-b92c-d675a8b41e17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69b38fdd-0aba-47f5-9f2b-6c7bb549d7ab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eae45edc-85b3-4cb7-bab8-b5eff00bc031", "AQAAAAIAAYagAAAAEMe7kxYHfeCDfEcDyLSkkX2EdB9KfFxvZagelrPlubTsmBbyWcAetBNISTf5GBfbHA==", "8c5aab98-8547-46ae-bb0e-970578435399" });
        }
    }
}
