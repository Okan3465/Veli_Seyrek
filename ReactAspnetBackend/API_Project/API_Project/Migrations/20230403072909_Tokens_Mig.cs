using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Project.Migrations
{
    public partial class Tokens_Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 10, 29, 8, 758, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 4, 10, 29, 8, 759, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 10, 29, 8, 759, DateTimeKind.Local).AddTicks(1530));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 31, 10, 25, 4, 449, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 4, 10, 25, 4, 450, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 10, 25, 4, 450, DateTimeKind.Local).AddTicks(3082));
        }
    }
}
