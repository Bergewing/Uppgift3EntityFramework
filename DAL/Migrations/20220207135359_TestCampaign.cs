using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class TestCampaign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Campaigns",
                columns: new[] { "ID", "Name", "PriceReduction" },
                values: new object[] { 2, "Test", 1.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductsID",
                keyValue: 6,
                column: "CampaignsID",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Campaigns",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductsID",
                keyValue: 6,
                column: "CampaignsID",
                value: 1);
        }
    }
}
