using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Test23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriceReduction = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNr = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MentorID = table.Column<int>(type: "int", nullable: true),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employee_Employee_MentorID",
                        column: x => x.MentorID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID");
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ManagerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Department_Employee_ManagerID",
                        column: x => x.ManagerID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    Emails = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => new { x.Emails, x.EmployeeID });
                    table.ForeignKey(
                        name: "FK_Email_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "date", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Barcode = table.Column<int>(type: "int", nullable: false),
                    CampaignsID = table.Column<int>(type: "int", nullable: false),
                    InventoryByID = table.Column<int>(type: "int", nullable: false),
                    InventoryDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductsID);
                    table.ForeignKey(
                        name: "FK_Products_Campaigns_CampaignsID",
                        column: x => x.CampaignsID,
                        principalTable: "Campaigns",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Employee_InventoryByID",
                        column: x => x.InventoryByID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentProducts",
                columns: table => new
                {
                    ProductsID = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentProducts", x => new { x.ProductsID, x.DepartmentID });
                    table.ForeignKey(
                        name: "FK_DepartmentProducts_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepartmentProducts_Products_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "Products",
                        principalColumn: "ProductsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Ingredient = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => new { x.Ingredient, x.ProductsID });
                    table.ForeignKey(
                        name: "FK_Ingredients_Products_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "Products",
                        principalColumn: "ProductsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Campaigns",
                columns: new[] { "ID", "Name", "PriceReduction" },
                values: new object[] { 1, "RegularPrice", 0.0 });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeID", "EndDate", "MentorID", "Name", "PhoneNr", "SSN", "Title" },
                values: new object[,]
                {
                    { 1, null, null, "Soja Karlsson", "0700000001", "0000000001", "Manager" },
                    { 2, null, null, "Simon Bergewing", "0700000002", "0000000002", "Manager" },
                    { 3, null, null, "Anders Andersson", "0700000003", "0000000003", "Employee" },
                    { 4, null, null, "Tobias Persson", "0700000004", "0000000004", "Employee" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Name", "ManagerID" },
                values: new object[,]
                {
                    { "Bread", 3 },
                    { "Dairy", 1 },
                    { "Drink", 2 },
                    { "Fruit&Vegetable", 1 },
                    { "Meat", 4 },
                    { "Pantry", 2 }
                });

            migrationBuilder.InsertData(
                table: "Email",
                columns: new[] { "Emails", "EmployeeID" },
                values: new object[,]
                {
                    { "ander321@msn.se", 3 },
                    { "e.andersson@gmail.com", 4 },
                    { "simon@Sojashandel.se", 2 },
                    { "simon123@hotmail.com", 2 },
                    { "soja@sojashandel.se", 1 },
                    { "tobias567@hotmail.com", 3 }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeID", "EndDate", "MentorID", "Name", "PhoneNr", "SSN", "Title" },
                values: new object[,]
                {
                    { 5, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Erika Andersson", "0700000005", "0000000005", "Trainee" },
                    { 6, new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Thomas Karlsson", "0700000006", "0000000006", "Trainee" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductsID", "Amount", "Barcode", "CampaignsID", "ExpirationDate", "InventoryByID", "InventoryDate", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, 10, 1, 1, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15m, "6 pack Eggs" },
                    { 2, 5, 2, 1, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Onion in Net" },
                    { 3, 9, 3, 1, new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, "Cornflakes" },
                    { 4, 25, 4, 1, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, "Coca-cola" }
                });

            migrationBuilder.InsertData(
                table: "DepartmentProducts",
                columns: new[] { "DepartmentID", "ProductsID" },
                values: new object[,]
                {
                    { "Dairy", 1 },
                    { "Fruit&Vegetable", 2 },
                    { "Pantry", 3 },
                    { "Drink", 4 }
                });

            migrationBuilder.InsertData(
                table: "Email",
                columns: new[] { "Emails", "EmployeeID" },
                values: new object[,]
                {
                    { "sojakarlsson123@msn.se", 6 },
                    { "thomaserik@gmail.se", 5 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductsID", "Amount", "Barcode", "CampaignsID", "ExpirationDate", "InventoryByID", "InventoryDate", "Price", "ProductName" },
                values: new object[,]
                {
                    { 5, 3, 5, 1, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17m, "Toast" },
                    { 6, 5, 6, 1, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 80m, "Rib Eye" }
                });

            migrationBuilder.InsertData(
                table: "DepartmentProducts",
                columns: new[] { "DepartmentID", "ProductsID" },
                values: new object[] { "Bread", 5 });

            migrationBuilder.InsertData(
                table: "DepartmentProducts",
                columns: new[] { "DepartmentID", "ProductsID" },
                values: new object[] { "Meat", 5 });

            migrationBuilder.InsertData(
                table: "DepartmentProducts",
                columns: new[] { "DepartmentID", "ProductsID" },
                values: new object[] { "Meat", 6 });

            migrationBuilder.CreateIndex(
                name: "IX_Department_ManagerID",
                table: "Department",
                column: "ManagerID");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentProducts_DepartmentID",
                table: "DepartmentProducts",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Email_EmployeeID",
                table: "Email",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_MentorID",
                table: "Employee",
                column: "MentorID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_SSN",
                table: "Employee",
                column: "SSN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_ProductsID",
                table: "Ingredients",
                column: "ProductsID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CampaignsID",
                table: "Products",
                column: "CampaignsID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_InventoryByID",
                table: "Products",
                column: "InventoryByID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentProducts");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
