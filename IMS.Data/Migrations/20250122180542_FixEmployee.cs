using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommercialSiteId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommercialSiteId", "IsApproved" },
                values: new object[] { 1, true });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommercialSiteId", "IsApproved" },
                values: new object[] { null, false });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CommercialSiteId",
                table: "Employees",
                column: "CommercialSiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_CommercialSites_CommercialSiteId",
                table: "Employees",
                column: "CommercialSiteId",
                principalTable: "CommercialSites",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_CommercialSites_CommercialSiteId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_CommercialSiteId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CommercialSiteId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06e4a52b-0ee1-426f-b7a2-6b009a0c1f65",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12421763-df51-49d7-bb7a-d514cbf510f9", "AQAAAAIAAYagAAAAEFIUjfhrGi6KR7cyr0WJBnGK8d8cB1PCAoAV2yzgDk+o3gMkguR3iQvUCUyEICzDOA==", "7a46b5df-278a-4f16-b951-5bfcbceb461d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69b38fdd-0aba-47f5-9f2b-6c7bb549d7ab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5e22e02-deaf-4b6c-a212-3a2800854b18", "AQAAAAIAAYagAAAAEAAsLyoRFIaC8vC7AC1NRiLGMgtnGmx/tiT2lLmk81Jv01jfq34VYr2bB4a+c18Klg==", "c1398525-a9b9-4aa4-8a13-ae7fdeb3b52f" });
        }
    }
}
