using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class UpdateInfo3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentID", "Manager", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Dairy" },
                    { 2, 1, "Fruit&Vegetable" },
                    { 3, 2, "Pantry" },
                    { 4, 2, "Drink" },
                    { 5, 3, "Bread" },
                    { 6, 4, "Meat" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeID", "EndDate", "Mentor", "Name", "PhoneNr", "SSN", "Title" },
                values: new object[,]
                {
                    { 1, 10, 1, "Soja Karlsson", 700000001, 1, "Manager" },
                    { 2, 10, 1, "Simon Bergewing", 700000002, 2, "Manager" },
                    { 3, 10, 1, "Anders Andersson", 700000003, 3, "Employee" },
                    { 4, 10, 1, "Tobias Persson", 700000004, 4, "Employee" },
                    { 5, 10, 1, "Erika Andersson", 700000005, 5, "Trainee" },
                    { 6, 10, 1, "Thomas Karlsson", 700000001, 1, "Trainee" }
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
                    { "sojakarlsson123@msn.se", 6 },
                    { "thomaserik@gmail.se", 5 },
                    { "tobias567@hotmail.com", 3 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductsID", "Amount", "Barcode", "CampaignsID", "ExpirationDate", "InventoryByID", "InventoryDate", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, 10, 1, 0, 123, 1, 123, 15.0, "6 pack Eggs" },
                    { 2, 5, 2, 0, 321, 2, 321, 10.0, "Onion in Net" },
                    { 3, 9, 3, 0, 555, 3, 777, 25.0, "Cornflakes" },
                    { 4, 25, 4, 0, 456, 4, 345, 20.0, "Coca-cola" },
                    { 5, 3, 5, 0, 345, 5, 234, 17.0, "Toast" },
                    { 6, 5, 6, 0, 999, 6, 888, 80.0, "Riby Eye" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumns: new[] { "Emails", "EmployeeID" },
                keyValues: new object[] { "ander321@msn.se", 3 });

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumns: new[] { "Emails", "EmployeeID" },
                keyValues: new object[] { "e.andersson@gmail.com", 4 });

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumns: new[] { "Emails", "EmployeeID" },
                keyValues: new object[] { "simon@Sojashandel.se", 2 });

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumns: new[] { "Emails", "EmployeeID" },
                keyValues: new object[] { "simon123@hotmail.com", 2 });

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumns: new[] { "Emails", "EmployeeID" },
                keyValues: new object[] { "soja@sojashandel.se", 1 });

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumns: new[] { "Emails", "EmployeeID" },
                keyValues: new object[] { "sojakarlsson123@msn.se", 6 });

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumns: new[] { "Emails", "EmployeeID" },
                keyValues: new object[] { "thomaserik@gmail.se", 5 });

            migrationBuilder.DeleteData(
                table: "Email",
                keyColumns: new[] { "Emails", "EmployeeID" },
                keyValues: new object[] { "tobias567@hotmail.com", 3 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductsID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductsID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductsID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductsID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductsID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductsID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 6);
        }
    }
}
