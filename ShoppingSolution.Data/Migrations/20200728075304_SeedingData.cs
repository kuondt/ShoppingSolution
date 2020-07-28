using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingSolution.Data.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfig",
                keyColumn: "Key",
                keyValue: "HomeTiltle");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 28, 14, 53, 3, 387, DateTimeKind.Local).AddTicks(2410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 28, 13, 3, 11, 976, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "AppConfig",
                keyColumn: "Key",
                keyValue: "HomeDescription",
                column: "Value",
                value: "This is description of eShopSolution");

            migrationBuilder.UpdateData(
                table: "AppConfig",
                keyColumn: "Key",
                keyValue: "HomeKeyword",
                column: "Value",
                value: "This is keyword of eShopSolution");

            migrationBuilder.InsertData(
                table: "AppConfig",
                columns: new[] { "Key", "Value" },
                values: new object[] { "HomeTitle", "This is home page of eShopSolution" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 7, 28, 14, 53, 3, 415, DateTimeKind.Local).AddTicks(4956));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfig",
                keyColumn: "Key",
                keyValue: "HomeTitle");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 28, 13, 3, 11, 976, DateTimeKind.Local).AddTicks(2640),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 28, 14, 53, 3, 387, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "AppConfig",
                keyColumn: "Key",
                keyValue: "HomeDescription",
                column: "Value",
                value: "Description of ShoppingSolution");

            migrationBuilder.UpdateData(
                table: "AppConfig",
                keyColumn: "Key",
                keyValue: "HomeKeyword",
                column: "Value",
                value: "Keyword of ShoppingSolution");

            migrationBuilder.InsertData(
                table: "AppConfig",
                columns: new[] { "Key", "Value" },
                values: new object[] { "HomeTiltle", "Homepage of ShoppingSolution" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 7, 28, 13, 3, 12, 2, DateTimeKind.Local).AddTicks(742));
        }
    }
}
