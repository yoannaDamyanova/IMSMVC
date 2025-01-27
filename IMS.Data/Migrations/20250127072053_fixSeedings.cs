using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixSeedings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06e4a52b-0ee1-426f-b7a2-6b009a0c1f65",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "255ff357-e938-4fd4-b3eb-5f7a95e7bb1d", "AQAAAAIAAYagAAAAEHA65Jn9cMXfxBKUDlmGeCi8BLGXbWThFKjjmM4RQD8kG4AQDdZK7cA5EoTF7gntrw==", "d60af456-c039-4c32-9941-6208ad889dd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69b38fdd-0aba-47f5-9f2b-6c7bb549d7ab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca23dbc4-5959-4bf7-9279-2cef664068c8", "AQAAAAIAAYagAAAAEPYPxJsoWnhecTNrRgcRyPh7PS0myQUJTGvPIEYNRecE/hztG/7t7N0PAzjD7eirXQ==", "2b41df33-b09f-440e-94dd-3747705a0793" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e861aa5-5553-456e-bd6f-4312ffc05563"),
                column: "SupplierId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62f797e8-e161-4d59-a29a-b1a806b45edb"),
                column: "SupplierId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7508feee-3168-401e-84d7-9e126b394196"),
                column: "SupplierId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aef8b15d-c498-4ee4-a31f-ef67e1c970c7"),
                column: "SupplierId",
                value: 7);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: new Guid("4e861aa5-5553-456e-bd6f-4312ffc05563"),
                column: "SupplierId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62f797e8-e161-4d59-a29a-b1a806b45edb"),
                column: "SupplierId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7508feee-3168-401e-84d7-9e126b394196"),
                column: "SupplierId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aef8b15d-c498-4ee4-a31f-ef67e1c970c7"),
                column: "SupplierId",
                value: 1);
        }
    }
}
