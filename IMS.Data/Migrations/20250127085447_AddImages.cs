using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImgPath",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06e4a52b-0ee1-426f-b7a2-6b009a0c1f65",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34a6a3a6-393c-455f-91b4-e9035f08d386", "AQAAAAIAAYagAAAAEEyIsd0zOw9C5KNdnN6i3KqLInOPcWMJMjIgQMpYkvIXKi7PE6sJUu0xqtsIMsHQbg==", "c2f22489-ee9d-4fcf-9f6e-3e0e1b1bd302" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69b38fdd-0aba-47f5-9f2b-6c7bb549d7ab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8bb1122-c89c-4ae5-ace9-9d4745483efe", "AQAAAAIAAYagAAAAEJZKFOnyKOMUwe4afZ718LU8J9rtzPnRvT6dxD43IdX+BH4EkOpo8nUyht9H6shdOA==", "95f90eba-cb04-4dfc-8c00-896d6a4b4460" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13cc5dae-f692-4e93-9b7d-3b1e520d4e89"),
                column: "ImgPath",
                value: "samsung-galaxy-s23-5g-sm-s911-128gb-phantom-black.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b966829-79b6-4eff-8e6d-51e147f966ea"),
                column: "ImgPath",
                value: "malm-bed-frame-blue__1330503_pe9.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35970b4c-ac84-4e23-bf98-ac1785d736da"),
                column: "ImgPath",
                value: "Lay-s-Classic-Potato-Chips-8-oz.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e861aa5-5553-456e-bd6f-4312ffc05563"),
                column: "ImgPath",
                value: "mens_501_original.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62f797e8-e161-4d59-a29a-b1a806b45edb"),
                column: "ImgPath",
                value: "dove-deep-moisture-body-wash.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7508feee-3168-401e-84d7-9e126b394196"),
                column: "ImgPath",
                value: "Bosch_GSR_120-Li_Cordless_Drill_Driver___22210.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aef8b15d-c498-4ee4-a31f-ef67e1c970c7"),
                column: "ImgPath",
                value: "wilson-evolution-indoor-basketball.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImgPath",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                keyValue: new Guid("13cc5dae-f692-4e93-9b7d-3b1e520d4e89"),
                column: "ImgPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b966829-79b6-4eff-8e6d-51e147f966ea"),
                column: "ImgPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35970b4c-ac84-4e23-bf98-ac1785d736da"),
                column: "ImgPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e861aa5-5553-456e-bd6f-4312ffc05563"),
                column: "ImgPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62f797e8-e161-4d59-a29a-b1a806b45edb"),
                column: "ImgPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7508feee-3168-401e-84d7-9e126b394196"),
                column: "ImgPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aef8b15d-c498-4ee4-a31f-ef67e1c970c7"),
                column: "ImgPath",
                value: null);
        }
    }
}
