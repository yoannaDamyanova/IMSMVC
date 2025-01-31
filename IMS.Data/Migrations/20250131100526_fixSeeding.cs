using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e861aa5-5553-456e-bd6f-4312ffc05563"),
                column: "ImgPath",
                value: "mens_501_original.webp");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06e4a52b-0ee1-426f-b7a2-6b009a0c1f65",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc47fb2e-4d56-44cd-a4ea-7f690826aa6d", "AQAAAAIAAYagAAAAEHp6SOEGCHHylueiOPasG66ezqJBe8Oqc4JZ1MNtL6+F83KoDyOU68HmdxUvzqtuGw==", "8ac0167f-8428-45b5-9c4e-efc3a6da0abb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69b38fdd-0aba-47f5-9f2b-6c7bb549d7ab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e2f6984-0e0c-4864-9d65-e5f148a9bfbb", "AQAAAAIAAYagAAAAEHXMGhwhiPkTS9gX7GoUQjQr4xEVhDNmJnBw53iWzbDbzzunWhtbHugxPvvRdcuOkA==", "ac13939c-ae30-42d1-8080-87e8cb1f2b3a" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e861aa5-5553-456e-bd6f-4312ffc05563"),
                column: "ImgPath",
                value: "mens_501_original.jpg");
        }
    }
}
