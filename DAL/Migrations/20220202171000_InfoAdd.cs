using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class InfoAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "Product",
                table: "Ingredients");

            migrationBuilder.RenameColumn(
                name: "InventoryBy",
                table: "Products",
                newName: "InventoryByID");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Ingredients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Manager",
                table: "Department",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients",
                columns: new[] { "Ingredient", "ProductID" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_InventoryByID",
                table: "Products",
                column: "InventoryByID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Employee_InventoryByID",
                table: "Products",
                column: "InventoryByID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Employee_InventoryByID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_InventoryByID",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Ingredients");

            migrationBuilder.RenameColumn(
                name: "InventoryByID",
                table: "Products",
                newName: "InventoryBy");

            migrationBuilder.AddColumn<string>(
                name: "Product",
                table: "Ingredients",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Manager",
                table: "Department",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients",
                columns: new[] { "Ingredient", "Product" });
        }
    }
}
