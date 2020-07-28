using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingSolution.Data.Migrations
{
    public partial class Seeding_Identity_USer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 28, 16, 10, 8, 82, DateTimeKind.Local).AddTicks(2754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 28, 15, 49, 15, 144, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("7e2de1ee-b97b-4698-abe4-c22a0332b2c9"), "dc3ff4af-cab8-4e5e-98c7-cd12aaf4c2d9", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("8dd4e4e7-cbb1-4db8-8cd8-3024401afc74"), new Guid("7e2de1ee-b97b-4698-abe4-c22a0332b2c9") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("8dd4e4e7-cbb1-4db8-8cd8-3024401afc74"), 0, "e5dccf20-b933-4393-8058-d3491d3c942a", new DateTime(1998, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "cuong.263@gmail.com", true, "Dao", "Cuong", false, null, "cuong.263@gmail.com", "admin", "AQAAAAEAACcQAAAAEO5zcdKYkTp+J0wfz0ImQu/UzVs4/F+6j6xR/m5CprAFm283gL2bYGmLch0wGQiTfg==", null, false, "", false, "admin" });

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
                value: new DateTime(2020, 7, 28, 16, 10, 8, 119, DateTimeKind.Local).AddTicks(7738));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7e2de1ee-b97b-4698-abe4-c22a0332b2c9"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("8dd4e4e7-cbb1-4db8-8cd8-3024401afc74"), new Guid("7e2de1ee-b97b-4698-abe4-c22a0332b2c9") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8dd4e4e7-cbb1-4db8-8cd8-3024401afc74"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 28, 15, 49, 15, 144, DateTimeKind.Local).AddTicks(2134),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 28, 16, 10, 8, 82, DateTimeKind.Local).AddTicks(2754));

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
                value: new DateTime(2020, 7, 28, 15, 49, 15, 179, DateTimeKind.Local).AddTicks(6979));
        }
    }
}
