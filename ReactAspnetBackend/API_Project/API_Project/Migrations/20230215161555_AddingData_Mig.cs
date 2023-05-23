using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Project.Migrations
{
    public partial class AddingData_Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2023, 2, 12, 19, 15, 55, 474, DateTimeKind.Local).AddTicks(5687), null, "Bilgisayar", 10000m, 300 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2023, 1, 16, 19, 15, 55, 475, DateTimeKind.Local).AddTicks(3170), null, "Telefon", 15000m, 300 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2022, 12, 17, 19, 15, 55, 475, DateTimeKind.Local).AddTicks(3187), null, "Klavye", 150m, 300 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
