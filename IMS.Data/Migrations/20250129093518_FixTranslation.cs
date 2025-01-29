using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixTranslation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("62f797e8-e161-4d59-a29a-b1a806b45edb"),
                column: "Name",
                value: "Dove Deep Moisture Хидратиращ душгел 1L");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06e4a52b-0ee1-426f-b7a2-6b009a0c1f65",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb4f0e39-4f66-46fa-85e0-ed2d577d51f2", "AQAAAAIAAYagAAAAEPICCJBPerYOS/Eh7LqRgdRjYrvsC7v6NuXZWLVU1jMO+9CqTnKn8L4ex6/QH1zu0w==", "333b37b0-84e1-4d21-8bed-05055466bd36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69b38fdd-0aba-47f5-9f2b-6c7bb549d7ab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccecb44f-f648-44cf-a5ae-4f8efc1c8ec4", "AQAAAAIAAYagAAAAECpZw34BWrDSQh9arBCG7wk+/bDNQXAa2ECTnMNrDKE+coSMn0WkbeW4XjSNNRcHTw==", "982d72d4-2290-4bc4-82db-621bafe7ee33" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62f797e8-e161-4d59-a29a-b1a806b45edb"),
                column: "Name",
                value: "Dove Deep Moisture Nourishing Body Wash 1L");
        }
    }
}
