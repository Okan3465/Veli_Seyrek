using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Project.Migrations
{
    public partial class Updated_Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 19, 15, 55, 474, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 19, 15, 55, 475, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 17, 19, 15, 55, 475, DateTimeKind.Local).AddTicks(3187));
        }
    }
}
