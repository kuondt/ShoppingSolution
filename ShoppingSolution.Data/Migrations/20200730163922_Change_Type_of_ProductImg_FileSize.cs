using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingSolution.Data.Migrations
{
    public partial class Change_Type_of_ProductImg_FileSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7e2de1ee-b97b-4698-abe4-c22a0332b2c9"),
                column: "ConcurrencyStamp",
                value: "8f5232f3-dda6-4973-b8d8-5d3aabbff259");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8dd4e4e7-cbb1-4db8-8cd8-3024401afc74"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e2b18491-e5fb-4c82-ac5c-37f230c5e866", "AQAAAAEAACcQAAAAEFb6jNuv5FRarMu7vm9hP2rOGNx8bQ9eDppXBwDdC6/+VJtqXvg+cUgO/QU27IY/Gw==" });

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
                value: new DateTime(2020, 7, 30, 23, 39, 20, 618, DateTimeKind.Local).AddTicks(2711));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7e2de1ee-b97b-4698-abe4-c22a0332b2c9"),
                column: "ConcurrencyStamp",
                value: "2a8bb666-5693-401a-8354-a5c1791c8c4c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8dd4e4e7-cbb1-4db8-8cd8-3024401afc74"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "234961eb-17d6-4c00-88c7-e30374acc973", "AQAAAAEAACcQAAAAEFdqv3lPO/nLZ3gq/vf7N5s+imchMS/hfGf6ddzwx20IQhMyNR1JDh6771RahNUIoA==" });

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
                value: new DateTime(2020, 7, 30, 22, 23, 32, 685, DateTimeKind.Local).AddTicks(7198));
        }
    }
}
